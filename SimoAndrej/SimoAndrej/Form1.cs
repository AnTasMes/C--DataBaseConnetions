using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimoAndrej
{
    public partial class Login : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection(accountInfo.connection);
        public Login()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '•';
            ifremembered();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbSee_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSee.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            accountInfo.Username = tbUsername.Text;
            accountInfo.Password = tbPassword.Text;
            rememberCheck();
            userLogin();          
        }

        public void userLogin()
        {            
            string checkUser = "SELECT * FROM userinformation WHERE username='" + accountInfo.Username + "' and password='" + accountInfo.Password + "'";
            MySqlCommand checkCommand = new MySqlCommand(checkUser, mySqlConnection);
            try
            {
                mySqlConnection.Open();
                checkCommand.Parameters.AddWithValue("@username", accountInfo.Username);
                checkCommand.Parameters.AddWithValue("@password", accountInfo.Password);
                MySqlDataReader checReader = checkCommand.ExecuteReader();
                if (checReader.HasRows)
                {
                    houseLayout f1 = new houseLayout();
                    f1.Visible = true;
                    if (f1.Visible == true)
                    {
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Uneti podaci nisu validni", "Greska");
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                mySqlConnection.Close();
                MessageBox.Show("Doslo je do greske pri povezivanju, pokusajte ponovo. \n("+e.Message+")", "Greska");              
            }
            
        }

        public void rememberCheck()
        {
            try
            {
                mySqlConnection.Open();
                if (cbRemember.Checked)
                {
                    string remember = "UPDATE userinformation SET remember='remember' WHERE username='" + accountInfo.Username + "' and password='" + accountInfo.Password + "'";
                    MySqlCommand rememberCommand = new MySqlCommand(remember, mySqlConnection);
                    rememberCommand.ExecuteNonQuery();
                    MySqlDataReader rememberReader = rememberCommand.ExecuteReader();
                    rememberReader.Close();
                }
                else
                {
                    string dontRemember = "UPDATE userinformation SET remember='dont' WHERE username='" + accountInfo.Username + "' and password='" + accountInfo.Password + "'";
                    MySqlCommand dontRememberCommand = new MySqlCommand(dontRemember, mySqlConnection);
                    dontRememberCommand.ExecuteNonQuery();
                    MySqlDataReader rememberReader = dontRememberCommand.ExecuteReader();
                    rememberReader.Close();
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                mySqlConnection.Close();
                MessageBox.Show("Doslo je do greske pri povezivanju, pokusajte ponovo. \n(" + e.Message + ")", "Greska");
            }
        }

        public void ifremembered()
        {
            string isremembered = "SELECT * FROM userinformation WHERE remember='remember'";
            MySqlCommand rmbCommand = new MySqlCommand(isremembered, mySqlConnection);
            try
            {
                mySqlConnection.Open();
                MySqlDataReader rmbReader = rmbCommand.ExecuteReader();
                if(rmbReader.HasRows)
                {
                    rmbReader.Close();
                    string fillTB = "SELECT username, password FROM userinformation WHERE 1";
                    MySqlCommand fillCommand = new MySqlCommand(fillTB, mySqlConnection);
                    using(MySqlDataReader fillAdapter = fillCommand.ExecuteReader())
                    {
                        while(fillAdapter.Read())
                        {
                            string user = fillAdapter.GetString(fillAdapter.GetOrdinal("username")).ToString();
                            string password = fillAdapter.GetString(fillAdapter.GetOrdinal("password")).ToString();
                            tbUsername.Text = String.Format(user);
                            tbPassword.Text = String.Format(password);                            
                        }
                        fillAdapter.Close();
                    }
                    cbRemember.Checked = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Doslo je do greske pri povezivanju, pokusajte ponovo. \n(" + e.Message + ")", "Greska");
            }
            mySqlConnection.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
