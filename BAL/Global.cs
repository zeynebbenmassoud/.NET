using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BAL
{
    public class Global
    {
        static public string cs = @"Data Source=localhost;Initial Catalog=mini_project_3tiers_final;Integrated Security=True";

        static public SqlConnection seConnecter(string strCN)
        {
            //on va créer un objet de connexon objCN
            SqlConnection objCN = new SqlConnection();
            try
            {
                //Définir la chaine de connection
                objCN.ConnectionString = strCN;
                //si la coonection est fermée, on l'ouvre avec open()
                if (objCN.State == System.Data.ConnectionState.Closed)
                    objCN.Open();
            }
            catch (Exception)
            {
                throw;
            }
            return objCN;
        }

        static public void seDeconnecter(SqlConnection objCN)
        {
            try
            {
                if (objCN.State == System.Data.ConnectionState.Open)
                    objCN.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        static public Object ExecuterOleDBScalaire(String strSQL, SqlConnection objCN)
        {
            Object obj = new object();
            SqlCommand objComm = new SqlCommand(strSQL, objCN);
            try
            {
                obj = objComm.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            return obj;
        }

        static public SqlDataReader ExecuterOleDBSelect(string strSQL, SqlConnection objCN)
        {
            SqlDataReader objDR = null;
            SqlCommand objComm = new SqlCommand(strSQL, objCN); ;
            try
            {
                objDR = objComm.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
            return objDR;
        }

        static public int ExecuterOleDBAction(string strSQL, SqlConnection objCN, params object[] objPM)
        {
            int nb = -1;
            SqlCommand objComm = new SqlCommand(strSQL, objCN);
            try
            {
                foreach (object obj in objPM)
                {
                    SqlParameter param = new SqlParameter();
                    param.Value = obj;
                    objComm.Parameters.Add(param);
                }
                nb = objComm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return nb;
        }

        static public string CleanString(string str)
        {
            if (str.Contains("'"))
            {
                str = str.Replace("'", "''");
                return str;
            }
            return str;
        }

        static public int ExecuterOleDBActionNomsParams(string strSQL, SqlConnection objCN, object[,] objPM)
        {
            int nb = -1;
            SqlCommand objComm = new SqlCommand(strSQL, objCN);
            try
            {
                for (int i = 0; i < objPM.GetLength(0); i++)
                {
                    objComm.Parameters.AddWithValue((string)objPM[i, 0], objPM[i, 1]);
                }
                nb = objComm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            return nb;
        }

        //Mise à jour des donnée d'un client (Transaction):

        static public bool ExecuterTransaction(string strCN, params string[] tabSQL)
        {
            bool ok;
            SqlCommand objComm = new SqlCommand();
            SqlTransaction transact;
            try
            {
                SqlConnection objCN = seConnecter(strCN);
                objComm.Connection = objCN;
                transact = objCN.BeginTransaction();
                objComm.Transaction = transact;
                try
                {
                    foreach (string strSQL in tabSQL)
                    {
                        objComm.CommandText = strSQL;
                        int i = objComm.ExecuteNonQuery();
                    }
                    transact.Commit();
                    ok = true;
                }
                catch (Exception)
                {
                    transact.Rollback();
                    ok = false;
                }
                finally
                {
                    seDeconnecter(objCN);
                }
            }
            catch (Exception)
            {
                ok = false;
            }
            return ok;


        }
    }
}
