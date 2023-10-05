using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace contactManagementApplication.Database
{
    class dbconn_BusinessContact
    {
        MySqlConnection conn;

        public dbconn_BusinessContact()
        {
            string connString = "Server=database-1.cpksygbc0jha.us-east-1.rds.amazonaws.com; UID=yadava17;password=yadava17;Database=db_yadava17;";
            conn = new MySqlConnection(connString);
        }

        public DataSet getAllBusinessContact()
        {
            try 
            {
                conn.Open();
                string sql = "CALL getAllBusinessContact()";
                MySqlDataAdapter mySQLdata = new MySqlDataAdapter(sql,conn);
                DataSet ds = new DataSet();
                mySQLdata.Fill(ds);
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public void addNewBusinessContact(dbconn_BusinessContact businessContact)
        {
            try
            {
                conn.Open();
                string sql = "CALL insertBusinessContact(@id, @businessName, @employeeName, @businessEmail, @businessPhoneNum, @companyAddress, @PostCode)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", businessContact.getAllBusinessContact());
                cmd.Parameters.AddWithValue("employeeName", businessContact.getAllBusinessContact());
                cmd.Parameters.AddWithValue("businessName", businessContact.getAllBusinessContact());
                cmd.Parameters.AddWithValue("businessEmail", businessContact.getAllBusinessContact());
                cmd.Parameters.AddWithValue("businessPhoneNum", businessContact.getAllBusinessContact());
                cmd.Parameters.AddWithValue("companyAddress", businessContact.getAllBusinessContact());
                cmd.Parameters.AddWithValue("PostCode", businessContact.getAllBusinessContact());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
