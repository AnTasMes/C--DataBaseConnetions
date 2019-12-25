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
    public partial class houseLayout : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection(accountInfo.connection);
        public houseLayout()
        {
            InitializeComponent();            
        }

        prviSprat ps;
        private void spratPrvi_Click(object sender, EventArgs e)
        {
            if(ds!=null)
            {
                foreach (Form c in this.MdiChildren)
                {
                    c.Close();
                }
            }            
            if (ps == null)
            {
                ps = new prviSprat();
                ps.MdiParent = this;
                ps.FormClosed += Ps_FormClosed;
                ps.Show();
                ps.MinimizeBox = false;
                ps.MaximizeBox = false;
                ps.Dock = DockStyle.Fill;
                ps.WindowState = FormWindowState.Maximized;
            }
            else
            {
                ps.Activate();
            }
        }

        private void Ps_FormClosed(object sender, FormClosedEventArgs e)
        {
            ps = null;
        }
        drugiSprat ds;
        private void spratDrugi_Click(object sender, EventArgs e)
        {
            if (ps != null)
            {
                foreach (Form c in this.MdiChildren)
                {
                    c.Close();
                }
            }
            if (ds==null)
            {
                ds = new drugiSprat();
                ds.MdiParent = this;
                ds.FormClosed += Ds_FormClosed;
                ds.Show();
                ds.MinimizeBox = false;
                ds.MaximizeBox = false;
                ds.Dock = DockStyle.Fill;
                ds.WindowState = FormWindowState.Maximized;
            }            
            else
            {
                ds.Activate();
            }
        }

        private void Ds_FormClosed(object sender, FormClosedEventArgs e)
        {
            ds = null;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Visible = true;
            if (l1.Visible == true)
            {
                this.Close();
                if(ds != null)
                {
                    ds.Close();
                }
                if(ps != null)
                {
                    ps.Close();
                }
            }
        }
    }
}
