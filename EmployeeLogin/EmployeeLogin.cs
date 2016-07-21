using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DataEntryToDB
{
    public partial class EmployeeLogin : Form
    {
        //create connection object
        OleDbConnection connection = new OleDbConnection();

        public EmployeeLogin()
        {
            InitializeComponent();
            //connection string 
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Temp\Users.accdb;Persist Security Info=False";
        }

        private void btn_LoginEMP_Click(object sender, EventArgs e)
        {
            connection.Open();
            //command object
            OleDbCommand command = new OleDbCommand();
            //connection object
            command.Connection = connection;
            //confirm the user is in the database
            command.CommandText = "select * from tUserInfo where Username='" + txt_UserNameEMP.Text + "' and Password='" + txt_PassWordEMP.Text + "'";
            //execute the query, read the data
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
               
            }
            //check count value
            if (count == 1)
            {
                MessageBox.Show("UserName and Password are correct");
            }

            else if (count > 1)
            {
                MessageBox.Show("Duplicate UserName and Password");
            }
            else
            {
                MessageBox.Show("UserName and Password are not correct");
            }

            connection.Close();
        }

    }
    }
}
