using CodeGeneration.dao;
using CodeGeneration.model;
using CodeGeneration.thread;
using CodeGeneration.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace CodeGeneration

{
    public partial class Form1 : Form
    {
        Random random;
        ASCIIEncoding encoding;        

        public Form1()
        {
            InitializeComponent();
        }

     
        private async void button1_Click(object sender, EventArgs e)
        {
            //Store password 
            string password = "";
            string platform = textPlatform.Text;
            string key = Utilitaire.readCodeFile();
           
            if (String.IsNullOrEmpty(platform) || platform.Equals("Ex: Google"))
            {
                MessageBox.Show("Type a platform related to password");
            }
            else
            {
                Utilitaire.beforePasswordGenerated();
                //Generate password
                password = Utilitaire.generatePasswordLength12(random, encoding, password);
                Utilitaire.afterPasswordGenerated();
                //Display password
                txtGenerate.Text = password;

                //Persist password
                int lignes = Utilitaire.saveAccess(platform, password, key);
                Console.WriteLine(lignes + "ont été insérée");
            }
        }
            


        private void button2_Click(object sender, EventArgs e)
        {
            //Saved passwords
            this.Hide();
            Form2 form2 = new Form2();
            form2.Visible = true;
        }

        

        private void textPlatform_Click(object sender, EventArgs e)
        {
            if (textPlatform.Text.Equals("Ex: Google")) {
                textPlatform.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utilitaire.verifyFirstTimeUser(random,encoding);

            textPlatform.Text = "Ex: Google";
            txtGenerate.Text = "Press generate";
        }
    }
}
