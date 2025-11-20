using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

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
            XifrarConexio();
        }

        private void XifrarConexio()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration("JobHuntersSystem.exe");
            ConnectionStringsSection section = configuration.GetSection("connectionStrings")
            as ConnectionStringsSection;
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
            DataSet newdataset = new DataSet();
            adapter.Fill(dataSet);
            cnn.Close();

            dataSet.Tables[0].Rows.Add(newdataset.Tables[0]);

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
    }
}
