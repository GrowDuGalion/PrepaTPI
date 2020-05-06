/**
 * Auteur : David
 * Projet : CRUD Préparation TPI
 * Date : 05.05.2020
 * Description : Programme qui permet de se connecter à la base de donnée et faire un CRUD
 * Version 1.0
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // A Ajouter
using System.Windows.Forms; // A Ajouter

namespace ProjCrudTpi
{
    /// <summary>
    /// Class MySQLConnect
    /// </summary>
    class MySQLConnect
    {
        //Innitialisation variables
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        /// <summary>
        /// Constructeur
        /// </summary>
        public MySQLConnect()
        {
            Initialize();
        }

        /// <summary>
        /// Innitialiser les valeurs
        /// </summary>
        private void Initialize()
        {
            server = "localhost";
            database = "crud_tpi";
            uid = "grow";
            password = "Super2020";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Ouvrir une connection à la base de donnée
        /// </summary>
        /// <returns></returns>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Fonction pour l'existence d'un utilisateur dans la base de donnée
        /// </summary>
        /// <param name="utilisateur"></param> email à vérifier
        /// <returns></returns>
        public bool utilisateurExist(string utilisateur)
        {
            string query = "SELECT COUNT(email) as nombre FROM utilisateurs WHERE email = @utilisateur";

            int nombreUti = 0;

            bool reponse = false;

            if(this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@utilisateur", utilisateur);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    nombreUti = Convert.ToInt32(dataReader["nombre"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                if (nombreUti > 0)
                {
                    reponse = true;
                }
            }

            return reponse;     
        }

        /// <summary>
        /// Fonction vérifier l'email et son mot de passe
        /// </summary>
        /// <param name="utilisateur"></param> email de l'utilisateur
        /// <param name="motDePasse"></param> mot de passe de l'utilisateur
        /// <returns></returns>
        public bool controleUtilisateurMotDePasse(string utilisateur, string motDePasse)
        {
            string query = "SELECT COUNT(email) as nombre FROM utilisateurs WHERE email = @utilisateur AND mdp = @motDePasse";

            int nombreConfirm = 0;

            bool reponse = false;

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@utilisateur", utilisateur);
                cmd.Parameters.AddWithValue("@motDePasse", motDePasse);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    nombreConfirm = Convert.ToInt32(dataReader["nombre"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                if (nombreConfirm == 1)
                {
                    reponse = true;
                }
            }

            return reponse;
        }

        /// <summary>
        /// Fonction pour sélectionner l'id de l'utilisateur connecté
        /// </summary>
        /// <param name="email"></param> email de l'utilisateur
        /// <returns></returns>
        public int SelectId(string email)
        {
            string query = "SELECT idUtilisateur FROM utilisateurs WHERE email = @email";

            //Create a list to store the result
            int result = 0;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@email", email);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    result = Convert.ToInt32(dataReader["idUtilisateur"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return result;
            }
            else
            {
                return result;
            }
        }

        /// <summary>
        /// Fonction pour sélectionner le mode de l'utilisateur
        /// </summary>
        /// <param name="email"></param> email de l'utilisateur
        /// <returns></returns>
        public bool SelectMode(string email)
        {
            string query = "SELECT admin FROM utilisateurs WHERE email = @email";

            //Create a list to store the result
            bool result = false;
            string reader = string.Empty;

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@email", email);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    reader = dataReader["admin"] + "";
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                if(reader == "False")
                {
                    result = false;
                }
                else if(reader == "True")
                {
                    result = true;
                }

                //return list to be displayed
                return result;
            }
            else
            {
                return result;
            }
        }

        /// <summary>
        /// Fonction pour ajouter un utilisateur dans la base de donnée
        /// </summary>
        /// <param name="nom"></param> nom de l'utilisateur à ajouter
        /// <param name="prenom"></param> prenom de l'utilisateur à ajouter
        /// <param name="email"></param> email de l'utilisateur à ajouter
        /// <param name="motDePasse"></param> mot de passe de l'utilisateur à ajouter
        public void ajouterUtilisateur(string nom, string prenom, string email, string motDePasse)
        {
            string query = "INSERT INTO utilisateurs (nom, prenom, email, mdp) VALUES (@nom, @prenom, @email, @motDePasse)";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nom", nom);
                cmd.Parameters.AddWithValue("@prenom", prenom);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@motDePasse", motDePasse);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();

            }
        }

        /// <summary>
        /// Fonction pour sélectionner le dernier id disponible dans la base de donnée
        /// </summary>
        /// <returns></returns>
        public int idUtilisateurMax()
        {
            string query = "SELECT MAX(idUtilisateur) as nombre FROM utilisateurs";

            int nombreMax = 0;

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    nombreMax = Convert.ToInt32(dataReader["nombre"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

            }

            return nombreMax;
        }

        /// <summary>
        /// Fonction pour sélectionner le premier id disponible dans la base de donnée
        /// </summary>
        /// <returns></returns>
        public int idUtilisateurMin()
        {
            string query = "SELECT MIN(idUtilisateur) as nombre FROM utilisateurs";

            int nombreMin = 0;

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    nombreMin = Convert.ToInt32(dataReader["nombre"]);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

            }

            return nombreMin;
        }

        /// <summary>
        /// Fonction pour sélectionner les données de 10 utilisateurs dans la base de donnée
        /// </summary>
        /// <param name="idDebut"></param> sélectionné à partir de cet id
        /// <returns></returns>
        public List<string>[] SelectAll(int idDebut)
        {
            string query = "SELECT * FROM utilisateurs WHERE idUtilisateur > @idDebut LIMIT 10";

            //Create a list to store the result
            List<string>[] list = new List<string>[7];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@idDebut", idDebut);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["idUtilisateur"] + "");
                    list[1].Add(dataReader["nom"] + "");
                    list[2].Add(dataReader["prenom"] + "");
                    list[3].Add(dataReader["email"] + "");
                    list[4].Add(dataReader["mdp"] + "");
                    list[5].Add(dataReader["admin"] + "");
                    list[6].Add(dataReader["date"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Fonction pour sélectionner les données d'un utilisateur dans la base de donnée
        /// </summary>
        /// <param name="ididUtilisateur"></param> id de l'utilisateur à sélectionner
        /// <returns></returns>
        public string[] SelectUnUtilisateur(int ididUtilisateur)
        {
            string query = "SELECT * FROM utilisateurs WHERE idUtilisateur = @idUtilisateur";

            //Create a list to store the result
            string[] table = new string[7];

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@idUtilisateur", ididUtilisateur);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    table[0] = dataReader["idUtilisateur"] + "";
                    table[1] = dataReader["nom"] + "";
                    table[2] = dataReader["prenom"] + "";
                    table[3] = dataReader["email"] + "";
                    table[4] = dataReader["mdp"] + "";
                    table[5] = dataReader["admin"] + "";
                    table[6] = dataReader["date"] + "";
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return table;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Fonction pour supprimer les données d'un utilisateur dans la base de donnée
        /// </summary>
        /// <param name="idUtilisateur"></param> id de l'utilisateur à supprimer
        public void SupprimmerUtilisateur(int idUtilisateur)
        {
            string query = "DELETE FROM utilisateurs WHERE idUtilisateur = @idUtilisateur";

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);

                //Execute command
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
        }

        /// <summary>
        /// Fonction pour modifier les données d'un utilisateur dans la base de donnée
        /// </summary>
        /// <param name="idUtilisateur"></param> id de l'utilisateur à modifier
        /// <param name="colonneAModif"></param> les colonnes à modifier
        /// <param name="nouvelleDonnee"></param> les nouvelles données à mettre dans les colonnes
        public void UpdateUnUtilisateur(int idUtilisateur, string[] colonneAModif, string[] nouvelleDonnee)
        {
            //Générer les colonnes et paramètres à SET dans query

            //Variable à insérer dans le query
            string lesSets = string.Empty;
            //Les paramètres à mettre dans la variables lesSets
            string unParametre = string.Empty;
            List<string> lesParametres = new List<string>();
            //Création de la string lesSets à insérer dans le query
            foreach (string colonne in colonneAModif)
            {
                lesSets += colonne;
                lesSets += " = ";
                unParametre = "@" + colonne;
                lesParametres.Add(unParametre);
                lesSets += unParametre;
                lesSets += ", ";
            }
            //Supprimmer les deux derniers caraactere (, ) du string lesSets
            lesSets = lesSets.Substring(0, lesSets.Length - 2);

            int nombreParametre = lesParametres.Count;

            string query = string.Format("UPDATE utilisateurs SET {0} WHERE idUtilisateur = @idUtilisateur",lesSets);         

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                for (int i = 0; i < nombreParametre; i++)
                {
                    cmd.Parameters.AddWithValue(lesParametres[i], nouvelleDonnee[i]);
                }

                cmd.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);

                //Execute command
                cmd.ExecuteNonQuery();

                //close Connection
                this.CloseConnection();

            }
        }
    }
}
