using CodeGeneration.dao;
using CodeGeneration.model;
using CodeGeneration.Properties;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace CodeGeneration.Utils
{
    internal class Utilitaire
    {

        public static string addCodeFile(string code)
        {

           
            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "codegenEncryption.txt")))
            {

                outputFile.WriteLine(code);
            }
            return code;
        }

        public static string readCodeFile() {
            string line;
            string key = "";
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            docPath = docPath + "\\codegenEncryption.txt";
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(docPath);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    key += line;
                    //Read the next line
                    line = sr.ReadLine();
                    
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            
            return key;


        }
        //Generate a random number between 0 and 9
        public static string NumberBetweenZeroAndNine(Random random)
        {
            //Get a random number between 0 to 9.
            random = new Random();
            int randomNumber = random.Next(10);
            return randomNumber.ToString();
        }

        //Generate a random letter  or  a random number or a random punctuation (Az09!@)
        public static string randomLetter_Number_Punction(Random random, ASCIIEncoding aSCIIEncoding)
        {
            //Get a random Number, Letter, Punctuation
            random = new Random();
            int randomNumberByte = random.Next(33, 128);
            Byte[] data = new byte[1];
            data[0] = (byte)randomNumberByte;

            //Convert number to ASCII VALUE
            aSCIIEncoding = new ASCIIEncoding();
            return aSCIIEncoding.GetString(data);
        }

        public static string randomCapitalLetter(Random random, ASCIIEncoding aSCIIEncoding)
        {
            //Get random Capital Letter
            random = new Random();
            int randomNumberByte = random.Next(65, 91);
            Byte[] data = new byte[1];
            data[0] = (byte)randomNumberByte;

            //Convert number to ASCII VALUE
            aSCIIEncoding = new ASCIIEncoding();
            return aSCIIEncoding.GetString(data);
        }

        public static string randomTinyLetter(Random random, ASCIIEncoding aSCIIEncoding)
        {
            //Get random Capital Letter
            random = new Random();
            int randomNumberByte = random.Next(97, 123);
            Byte[] data = new byte[1];
            data[0] = (byte)randomNumberByte;

            //Convert number to ASCII VALUE
            aSCIIEncoding = new ASCIIEncoding();
            return aSCIIEncoding.GetString(data);
        }

        public static string randomPunctuation(Random random, ASCIIEncoding aSCIIEncoding)
        {
            //Get random Capital Letter
            random = new Random();
            int randomNumberByte = random.Next(33, 48);
            Byte[] data = new byte[1];
            data[0] = (byte)randomNumberByte;

            //Convert number to ASCII VALUE
            aSCIIEncoding = new ASCIIEncoding();
            return aSCIIEncoding.GetString(data);
        }
        //Generate a space (" ")
        public static string addSpaceBar(Random random, ASCIIEncoding aSCIIEncoding)
        {
            Byte[] data2 = new Byte[1];
            data2[0] = 32;
            aSCIIEncoding = new ASCIIEncoding();
            //Convert number to ASCII VALUE
            return aSCIIEncoding.GetString(data2);
        }

        //Generate a random number between 1 and 3
        public static int numberBetweenOneAndThree(Random random)
        {
            random = new Random();
            return random.Next(1, 4);
        }

        //Generate a random number between 1 and 2
        public static int numberBetweenOneAndTwo(Random random)
        {
            random = new Random();
            return random.Next(1, 3);
        }

        // Show or Hide loading labels
        public static void showloadingLabels() {
            var txtLoad = Application.OpenForms["Form1"].Controls["txtLoad"] as Label;
            var txtWait = Application.OpenForms["Form1"].Controls["txtWait"] as Label;
            var txtComplete = Application.OpenForms["Form1"].Controls["txtComplete"] as Label;

            var progressBar = Application.OpenForms["Form1"].Controls["progressBar1"] as ProgressBar;
            if (progressBar.Visible == true) {
                if (txtComplete.Visible == true) {
                    txtComplete.Visible = false;
                }
                txtLoad.Visible = true;
                txtWait.Visible = true;

            }
            else if (progressBar.Visible == false) {
                txtLoad.Visible = false;
                txtWait.Visible = false;
                txtComplete.Visible = true;
            }
        }

        // Show or Hide progressBar
        public static void showProgressBar() {
            var progressBar = Application.OpenForms["Form1"].Controls["progressBar1"] as ProgressBar;
            if (progressBar != null) {
                progressBar.Visible = true;
            }
            if (progressBar.Value.Equals(progressBar.Maximum)) {
                progressBar.Visible = false;
                progressBar.Value = 0;
            }
        }

        //Increment progress bar according to progress
        public static ProgressBar loadProgressBar(int value)
        {
            var progressBar = Application.OpenForms["Form1"].Controls["progressBar1"] as ProgressBar;
            progressBar.Maximum = 13 - 1;
            progressBar.Value = value;
            return progressBar;
        }

        //Change cursor depending on the state of progressbar
        public static void changeCursor() {
            var form1 = Application.OpenForms["Form1"];
            var progressBar = Application.OpenForms["Form1"].Controls["progressBar1"] as ProgressBar;
            if (progressBar != null) {
                form1.Cursor = Cursors.WaitCursor;
            }
            if (progressBar.Value.Equals(progressBar.Maximum)) {
                form1.Cursor = Cursors.Default;
            }
        }

        // Empty password field if a code is already generated   
        public static void emptyPasswordField()
        {
            var txtGenerate = Application.OpenForms["Form1"].Controls["txtGenerate"] as TextBox;
            if (txtGenerate.TextLength > 0) {
                txtGenerate.Clear();
            }
        }
        //This method was main algorithm to generate a password whose length is 12
        //We use random to choose between which method it will call.
        //As the loop goes on and chooses between different methods, it generate the pwd.
        public static string generatePasswordSize12(Random random, ASCIIEncoding encoding, string randomPassword12)
        {
            emptyPasswordField();
            changeCursor();
            showProgressBar();
            setCustomLabelBgColor();
            showloadingLabels();
            refreshForm();

            for (int i = 0; i < 12; i++)
            {
                loadProgressBar(i);
                Thread.Sleep(500);
                int choice = numberBetweenOneAndThree(random);


                if (randomPassword12.Contains(' '))
                {
                    choice = numberBetweenOneAndTwo(random);
                }

                if (choice.Equals(1))
                {
                    string randomNumberText = NumberBetweenZeroAndNine(random);
                    randomPassword12 = randomPassword12 + randomNumberText;
                }

                else if (choice.Equals(2))
                {
                    string randomNumber_Letter_Punctuation = randomLetter_Number_Punction(random, encoding);
                    randomPassword12 = randomPassword12 + randomNumber_Letter_Punctuation;
                }

                else if (choice.Equals(3))
                {
                    string spaceButtonText = addSpaceBar(random, encoding);
                    randomPassword12 = randomPassword12 + spaceButtonText;
                }
            }
            changeCursor();
            MessageBox.Show(" Thank you for using CodeGen.");
            showProgressBar();
            showloadingLabels();
            return randomPassword12;
        }

        // This method is the main algorith to generate a password whose lenght is 12.
        // The generated password follows the following sequence 
        // First letter is a capital following with tiny letters
        // until the 11th letter which is a number and the 12th is a punctuation
        public static string generatePasswordLength12(Random random, ASCIIEncoding encoding, string randomPassword12) {
        
            for (int i = 0; i < 13; i++)
            {
                loadProgressBar(i);
                Thread.Sleep(500);
                int choice = numberBetweenOneAndThree(random);



                if (i.Equals(1))
                {
                    choice = 3;
                }

                else if (i.Equals(11))
                {
                    choice = 1;
                }

                else if (i.Equals(12))
                {
                    choice = 2;
                }
                else {
                    choice = 0;
                }

                if (choice.Equals(0))
                {
                    string randomSmallLetter = randomTinyLetter(random, encoding);
                    randomPassword12 = randomPassword12 + randomSmallLetter;
                }

                if (choice.Equals(1))
                {
                    string randomNumberText = NumberBetweenZeroAndNine(random);
                    randomPassword12 = randomPassword12 + randomNumberText;
                }

                else if (choice.Equals(2))
                {
                    string randomPunctation = randomPunctuation(random, encoding);
                    randomPassword12 = randomPassword12 + randomPunctation;
                }

                else if (choice.Equals(3))
                {
                    string randomCapLetter = randomCapitalLetter(random, encoding);
                    randomPassword12 = randomCapLetter;
                }
            }

            return randomPassword12;
        }

        //Generate password for file security
        public static string generatePasswordLength40(Random random, ASCIIEncoding encoding, string randomPassword40)
        {
            for (int i = 0; i < 40; i++)
            {
                
                Thread.Sleep(100);
                int choice = numberBetweenOneAndThree(random);


                if (randomPassword40.Contains(' '))
                {
                    choice = numberBetweenOneAndTwo(random);
                }

                if (choice.Equals(1))
                {
                    string randomNumberText = NumberBetweenZeroAndNine(random);
                    randomPassword40 = randomPassword40 + randomNumberText;
                }

                else if (choice.Equals(2))
                {
                    string randomNumber_Letter_Punctuation = randomLetter_Number_Punction(random, encoding);
                    randomPassword40 = randomPassword40 + randomNumber_Letter_Punctuation;
                }

                else if (choice.Equals(3))
                {
                    string spaceButtonText = addSpaceBar(random, encoding);
                    randomPassword40 = randomPassword40 + spaceButtonText;
                }
            }
            return randomPassword40;
        }

        // Refresh form 
        public static void refreshForm()
        {
            Application.OpenForms["Form1"].Refresh();
        }

        //Set label colors to same red as background
        public static void setCustomLabelBgColor() {
            List<Label> labelLists = new List<Label>();
            Label l1 = Application.OpenForms["Form1"].Controls["txtLoad"] as Label;
            Label l2 = Application.OpenForms["Form1"].Controls["txtWait"] as Label;
            // Label l3 = Application.OpenForms["Form1"].Controls["txtComplete"] as Label;
            labelLists.Add(l1);
            labelLists.Add(l2);
            // labelLists.Add(l3);
            foreach (Label tmp in labelLists) {
                tmp.BackColor = Color.FromArgb(237, 28, 28);
            }

        }
        
        public static int saveAccess(string platform, string password, string key) {

            string cs = "server=codegeneration.mysql.database.azure.com;" +
                       "user=zeko450; password=Jetaime1!;" +
                   "database=codegeneration;port=3306;SslMode=Required;SslCa=Resources.DigiCertGlobalRootCA.crt.pem";
           
            DaoAccess dao = new DaoAccess(cs);
            Access access = new Access(platform, password, key);

            //requete parametré
            string cde = "insert into Access (platform,password,userkey) values (@platform, @generatedpw, @key)";
            
            int lignes = dao.persistPassword(cde, access);

            return lignes;
        }

        public static List<Access> getAccess() {

            string cs = "server=codegeneration.mysql.database.azure.com;" +
                       "user=zeko450; password=Jetaime1!;" +
                   "database=codegeneration;port=3306;SslMode=Required;SslCa=Resources.DigiCertGlobalRootCA.crt.pem";

            DaoAccess dao = new DaoAccess(cs);

            string key = readCodeFile();
            string requete = "select platform, password from Access where userkey = @key";

            List<Access> access = dao.getAccesses(requete, key);
            return access;
        }

        public static void verifyFirstTimeUser(Random random, ASCIIEncoding encoding)
        {
            
            string code = "";
            string keycheck = readCodeFile();

            if (keycheck.Equals(""))
            {
                string key = generatePasswordLength40(random, encoding, code);
                Utilitaire.addCodeFile(key);
            }
        }

        public static void beforePasswordGenerated()
        {
            emptyPasswordField();
            changeCursor();
            showProgressBar();
            setCustomLabelBgColor();
            showloadingLabels();
            refreshForm();
        }

        public static void afterPasswordGenerated()
        {
            changeCursor();
            MessageBox.Show(" Thank you for using CodeGen.");
            showProgressBar();
            showloadingLabels();
        }
    }
    }
  
