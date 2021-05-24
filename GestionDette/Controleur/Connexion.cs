using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Controleur.Properties;

namespace Controller
{
    public class Connexion
    {

        public SqlConnection conn;


        public Boolean connecter(String nom,String password)
        {
            try
            {
                string strConnexion = "Server=DESKTOP-KPH67FP;Database=GestionDette;Uid={0};Pwd={1};";
                conn = new SqlConnection(String.Format(strConnexion,
                         nom, password));
                conn.Open();
                Console.WriteLine("Etat de la connexion : " + conn.State);
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }

        }
        public Boolean connecter()
        {
            try
            {
                string strConnexion = "Server=DESKTOP-KPH67FP;Database=GestionDette;Uid={0};Pwd={1};";
                String nom =Settings.Default.Nom;
                String password = Settings.Default.Password;
                if (nom == null || password == null || nom.Length == 0 || password.Length == 0)
                {
                    return false;
                }
                else { 
                conn = new SqlConnection(String.Format(strConnexion,
                         nom, password));
                conn.Open();
                Console.WriteLine("Etat de la connexion : " + conn.State);
                return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("L'erreur suivante a été rencontrée :" + e.Message);
                return false;
            }

        }
        public Boolean executeCommand(SqlCommand cmd)
        {
            cmd.Connection = conn;
            if (cmd.ExecuteNonQuery() >= 1)
            {

                return true;
            }
            else
            {
                return false;
            }

        }
        public SqlDataReader Rdd(String query)
        {

            SqlCommand cmd2 = new SqlCommand(query, conn);
            SqlDataReader reader = cmd2.ExecuteReader();
            return reader;

        }

    }
}
