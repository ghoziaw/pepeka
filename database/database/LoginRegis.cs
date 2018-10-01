using E_warehouse;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database
{
    public partial class LoginRegis : Form
    {
        
        MySqlConnection DBConnect;
        MySqlCommand cmd;
        MySqlDataReader read;
        String admin;
        public LoginRegis()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        private void connect() { 
            string connection = "server=localhost; port=3306; uid=root; pwd=1q2w3e4r5t; database=ppk; SslMode=none;";
            DBConnect = new MySqlConnection(connection);
            try
            {
                DBConnect.Open();
                //MessageBox.Show("connected");
            }catch(Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                cmd = new MySqlCommand("select count(username) from admin where username=@uname and password=@pass",DBConnect);
                cmd.Parameters.AddWithValue("@uname", username.Text);
                cmd.Parameters.AddWithValue("@pass", passwrd.Text);
                String cek = cmd.ExecuteScalar().ToString();
                setAdmin(username.Text);
                if (cek=="1")
                {
                    MessageBox.Show("Login berhasil");
                    this.Visible = false;
                    Form1 form1 = new Form1(getAdmin());
                    form1.Show();
                }else if (cek == "0")
                {
                    MessageBox.Show("Login gagal");
                }
            }catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }
            DBConnect.Close();
        }

        private void setAdmin(String admin)
        {
            this.admin = admin;
        }

        public String getAdmin()
        {
            return this.admin;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void regisBtn_MouseClick(object sender, MouseEventArgs e)
        {
            
            panel2.Visible =!panel2.Visible;
            this.Text = "Register";
        }

        private void regRegBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(regUsername.Text)|| String.IsNullOrEmpty(regPasswrd.Text)|| String.IsNullOrEmpty(regName.Text))
                {
                    MessageBox.Show("Lengkapi semua form");
                }
                else
                {
                    connect();
                    cmd = new MySqlCommand("insert into admin(username,nama_admin,password) values(@username,@name,@pass)",DBConnect);
                    cmd.Parameters.AddWithValue("@username", regUsername.Text);
                    cmd.Parameters.AddWithValue("@name", regName.Text);
                    cmd.Parameters.AddWithValue("@pass", regPasswrd.Text);
                    cmd.ExecuteNonQuery();
                    DBConnect.Close();
                    MessageBox.Show("Registrasi berhasil, silahkan login!");
                    panel2.Visible = !panel2.Visible;
                    this.Text = "Login";
                }
            }catch(MySqlException err)
            {
                if (err.Number == 1062)
                {
                    MessageBox.Show("Username sudah digunakan");
                }
            }
        }

        private void regCancelBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            this.Text = "Login";
        }
    }
}
    