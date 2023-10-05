using System;
using MySqlConnector;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using contactManagementApplication.Class;

namespace contactManagementApplication.Database
{
    class dbconn_personalContact
    {
        MySqlConnection conn;

        public dbconn_personalContact()
        {
            string connString = "Server=database-1.cpksygbc0jha.us-east-1.rds.amazonaws.com; UID=yadava17;password=yadava17;Database=db_yadava17;";
            conn = new MySqlConnection(connString);
        }
        public DataSet getAllPersonalContact()
        {
            try
            {
                conn.Open();
                string sql = "CALL getALLPersonalContact()";
                MySqlDataAdapter mySQLdata = new MySqlDataAdapter(sql, conn);
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
        public void addNewPersonalContact(dbconn_personalContact personalContact)
        {
            try
            {
                conn.Open();
                string sql = "CALL insertPersonalContact(@id, @name, @postCode, @dob, @homeAddress, @email, @phoneNum)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", personalContact.getAllPersonalContact());
                ; cmd.Parameters.AddWithValue("name", personalContact.getAllPersonalContact());
                cmd.Parameters.AddWithValue("postCode", personalContact.getAllPersonalContact());
                cmd.Parameters.AddWithValue("homeAddress", personalContact.getAllPersonalContact());
                cmd.Parameters.AddWithValue("email", personalContact.getAllPersonalContact());
                cmd.Parameters.AddWithValue("phoneNum", personalContact.getAllPersonalContact());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updatePersonalContact(personalContact PersonalContact)
        {
            try
            {
                conn.Open();
                string sql = "CALL updatePersonalContact(@name, @postCode, @dob, @homeAddress,@email,@phoneNum)";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("name", getAllPersonalContact());
                cmd.Parameters.AddWithValue("postCode", getAllPersonalContact());
                cmd.Parameters.AddWithValue("dob", getAllPersonalContact());
                cmd.Parameters.AddWithValue("homeAddress", getAllPersonalContact());
                cmd.Parameters.AddWithValue("email", getAllPersonalContact());
                cmd.Parameters.AddWithValue("phoneNum", getAllPersonalContact());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void deletePersonalContact(personalContact PersonalContact)
        {
            try
            {
                conn.Open();
                string sql = "deletePersonalContact";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("id", PersonalContact.getID());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
