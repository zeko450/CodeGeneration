using CodeGeneration.dao;
using CodeGeneration.model;
using CodeGeneration.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGeneration
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string key = Utilitaire.readCodeFile();
            List<Access> list = Utilitaire.getAccess(); //Store accesses in a list
            
            //Attach mouseup event
            listView1.MouseUp += listView1_MouseUp;

            //Add columns to listview
            listView1.View = View.Details;
            listView1.Columns.Add("Password");
            listView1.Columns.Add("Platform");
            listView1.Columns[0].Width = 100;
            listView1.Columns[1].Width = 80;

            foreach (Access tmp in list)
            {
                ListViewItem item = new ListViewItem(tmp.password);
                item.SubItems.Add(tmp.platform);

                listView1.Items.Add(item);
                item.ForeColor = Color.Red;
            }
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Check if right mouse button is clicked
            {
                if (listView1.FocusedItem != null && listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    // Create a context menu
                    ContextMenu contextMenu = new ContextMenu();

                    // Add a "Copy" menu item
                    MenuItem copyMenuItem = new MenuItem("Copy");
                    copyMenuItem.Click += CopyMenuItem_Click;
                    contextMenu.MenuItems.Add(copyMenuItem);

                    // Show the context menu at the mouse location
                    contextMenu.Show(listView1, e.Location);
                }
            }
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Concatenate the text of selected items and copy to clipboard
                string selectedText = string.Join(Environment.NewLine,
                    listView1.SelectedItems.Cast<ListViewItem>().Select(item => item.Text));
                Clipboard.SetText(selectedText);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["Form1"].Dispose();
        }
    }
}

