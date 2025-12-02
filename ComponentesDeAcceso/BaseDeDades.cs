using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace ComponentesDeAcceso
{
    public class BaseDeDades
    {
        #region Variables Globales

        //Connexión
        ConnectionStringSettings conf;
        private string cnx;
        private SqlConnection cnn;
        private SqlDataAdapter adapter;

        #endregion

        public BaseDeDades()
        {
            Connectar();
            EncryptConnection();
        }

        private void EncryptConnection()
        {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration("JobHuntersSystem.exe");
                ConnectionStringsSection section = configuration.GetSection("connectionStrings") as ConnectionStringsSection;

                if (!section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }

                configuration.Save();

        }

        private void Connectar()
        {
            conf = ConfigurationManager.ConnectionStrings["SecureCoreG2Connection"];
            if (conf != null)
            {
                cnx = conf.ConnectionString;
                cnn = new SqlConnection(cnx);
            }
        }

        public DataSet PortarTaula(string NomTaula)
        {
            string query = "select * from " + NomTaula;
            adapter = new SqlDataAdapter(query, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            cnn.Close();

            return dataSet;
        }

        public DataSet PortarPerConsulta(string consultaSql)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            cnn.Close();

            return dataSet;
        }

        public DataSet PortarPerConsulta(string consultaSql, string nomTabla)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, nomTabla);
            cnn.Close();

            return dataSet;
        }

        public void Actualitzar(string consultaSqlOG ,DataSet dataSet)
        {
            adapter = new SqlDataAdapter(consultaSqlOG, cnn);
            SqlCommandBuilder commandBuilder;
            commandBuilder = new SqlCommandBuilder(adapter);

            cnn.Open();
            if (dataSet.HasChanges())
            {
                adapter.Update(dataSet.Tables[0]);
            }
            cnn.Close();
        }

        public DataTable PortarDataTable(string consultaSql)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            cnn.Close();

            return dataSet.Tables[0];
        }

        public DataSet AfegirDataTable(string consultaSql, DataSet dataSet)
        {
            adapter = new SqlDataAdapter(consultaSql, cnn);

            cnn.Open();
            DataTable newTable = new DataTable();
            adapter.Fill(newTable);  
            cnn.Close();

            dataSet.Tables.Add(newTable); 

            return dataSet;

        }

        public void Executa(string querySQL)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(querySQL, cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cnn.Close();
        }

        public DataSet GeneraConsultaCerca(string nomTaula, Dictionary<string, string> keyValuePairs)
        {
            SqlCommand cmd = cnn.CreateCommand();
            DataSet data = new DataSet();


            cmd.CommandType = CommandType.Text;
            string query = "SELECT * FROM " + nomTaula +
                                    " WHERE";

            foreach (var item in keyValuePairs)
            {
                string paramName = "@" + item.Key;
                query += $" {item.Key} = {paramName} AND";
                cmd.Parameters.Add(new SqlParameter(paramName, item.Value));
            }
            query = query.Substring(0, query.Length - 3);


            cmd.CommandText = query;
            cnn.Open();            
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            cnn.Close();

            return data;
        }
    }
}
