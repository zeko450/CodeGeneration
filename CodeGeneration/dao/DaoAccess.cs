using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGeneration.model;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Crypto.Digests.SkeinEngine;


namespace CodeGeneration.dao
{
    internal class DaoAccess
    {

        //Attribut
        public MySqlConnection mySqlConnection { get; set; }

        public MySqlCommand mySqlCommand { get; set; }

        //Constructeur
        public DaoAccess(string cs)
        {
            this.mySqlConnection = new MySqlConnection(cs);
        }

        public int persistPassword(string cde, Access access) {

            int lignes;

            GetCommande(cde);

            //Mettre en relation

            MySqlParameter parametre1 = new MySqlParameter();
            parametre1.ParameterName = "@platform";
            parametre1.Value = access.platform;

            MySqlParameter parametre2 = new MySqlParameter();
            parametre2.ParameterName = "@generatedpw";
            parametre2.Value = access.password;

            MySqlParameter parametre3 = new MySqlParameter();
            parametre3.ParameterName = "@key";
            parametre3.Value = access.key;

            mySqlCommand.Parameters.Add(parametre1);
            mySqlCommand.Parameters.Add(parametre2);
            mySqlCommand.Parameters.Add(parametre3);


            //Executer commande
            lignes = mySqlCommand.ExecuteNonQuery();
            FermerConnexion();

            return lignes;
        }

        public List<Access> getAccesses(string requete, string key) { 
            GetCommande(requete);
            
            List<Access> listAccess = new List<Access>();

            MySqlParameter parametre1 = new MySqlParameter();
            parametre1.ParameterName = "@key";
            parametre1.Value = key;

            mySqlCommand.Parameters.Add(parametre1);

            //DataReader 
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            
            //Transformer le contenu du reader dans une liste
            string password, platform;
            while (reader.Read())
            {
                platform = (string)reader[0];
                password = (string)reader[1];

                listAccess.Add(new Access(platform, password));
            }
            FermerConnexion();
            return listAccess;
        }
       
        //Ouvrir la connexion
        private void GetCommande(string cde)
        {
           //Prepare l'objet command
            mySqlConnection.Open();
            mySqlCommand = new MySqlCommand(cde, mySqlConnection);
        }
        
        //Fermer la connexion
        private void FermerConnexion()
        {
            mySqlConnection.Close();
        }

    }
}
