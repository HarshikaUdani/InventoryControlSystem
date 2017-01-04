using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryControlSystem
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(tb_userName.Text == string.Empty))
                {
                    if (!(tb_password.Text == string.Empty))
                    {
                        String str = "server=UDANI-PC;database=InventoryControlSystem;UID=sa;password=1qaz2wsx@";
                        String query = "select * from USERS where username = '" + tb_userName.Text + "'and password = '" + this.tb_password.Text + "'";
                        SqlConnection con = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader dbr;
                        con.Open();
                        dbr = cmd.ExecuteReader();
                        int count = 0;
                        string type = null;
                        while (dbr.Read())
                        {
                            count = count + 1;
                            type = dbr.GetString(3);//4th column in USERS table is Type
                        }
                        if (count == 1)
                        {
                            //MessageBox.Show("username and password is correct");
                            if (type == "admin")
                            {
                                this.Hide();
                                Form_MainMenu FMM = new Form_MainMenu();
                                FMM.Closed += (s, args) => this.Close();
                                FMM.Show();
                            }
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show(" username and password incorrect", "login page");
                        }
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show(" password empty", "login page");
                    }
                }

                else
                {
                    MessageBox.Show(" username empty", "login page");
                }
                //con.Close();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);

            }

        }
    }
}
