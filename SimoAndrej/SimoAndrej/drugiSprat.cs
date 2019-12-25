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
    public partial class drugiSprat : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection(accountInfo.connection);
        int index = 0;
        public drugiSprat()
        {
            InitializeComponent();
            houseInfo.windowCheck(2);
            statusSet();
        }

        private void drugiSprat_Load(object sender, EventArgs e)
        {

        }
        //public void windowCheck()
        //{
            
        //    string countWin = "SELECT status FROM prozorinfo WHERE sprat='2'";
        //    MySqlCommand countCommand = new MySqlCommand(countWin, mySqlConnection);
        //    try
        //    {
        //        mySqlConnection.Open();
        //        using (MySqlDataReader countReader = countCommand.ExecuteReader())
        //        {
        //            while (countReader.Read())
        //            {
        //                houseInfo.winStatus1[index] = countReader.GetString(countReader.GetOrdinal("status")).ToString();
        //                index++;                        
        //            }
        //            //MessageBox.Show(Convert.ToString(index));
        //            countReader.Close();
        //        }
        //        index = 0;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    mySqlConnection.Close();
        //}

        public void statusSet()
        {
            foreach(var button in panel1.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                if(button is Button)
                {                                        
                    if(houseInfo.winStatus1[index] == "Zatvoren")
                    {
                        button.BackColor = Color.Red;
                    }
                    else if(houseInfo.winStatus1[index] == "Otvoren")
                    {
                        button.BackColor = Color.Green;
                    }
                    else if(houseInfo.winStatus1[index] == "Kip")
                    {
                        button.BackColor = Color.Yellow;
                    }
                    index++;
                }
                
            }
        }
    }
}
