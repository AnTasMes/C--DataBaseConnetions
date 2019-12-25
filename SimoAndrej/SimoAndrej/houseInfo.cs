using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SimoAndrej
{
    class houseInfo : accountInfo
    {
        public static MySqlConnection mySqlConnection = new MySqlConnection(connection); //Nasledjivanje
        public static string[] winStatus1 = new string[10];

        public static void windowCheck(int sprat)
        {
            int index = 0;
            string countWin = "SELECT status FROM prozorinfo WHERE sprat='"+sprat+"'";
            MySqlCommand countCommand = new MySqlCommand(countWin, mySqlConnection);
            try
            {
                mySqlConnection.Open();
                using (MySqlDataReader countReader = countCommand.ExecuteReader())
                {
                    while (countReader.Read())
                    {
                        houseInfo.winStatus1[index] = countReader.GetString(countReader.GetOrdinal("status")).ToString();
                        index++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            mySqlConnection.Close();
        }

        //koristiti ovu mogucnost za promenu statusa prozora
        //uporedjivati boje
        //public static string promena_statusa = "UPDATE prozorinfo SET status ='Otvoren' WHERE IDprozor='"+button.TabIndex+"'";

        //Koristiti switch opciju i button za dodelu statusa switch(boja) crvena: promena; zelena: promena; zuta: promena;
    }
}
