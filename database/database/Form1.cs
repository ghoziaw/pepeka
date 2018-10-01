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

namespace E_warehouse
{
    public partial class Form1 : Form
    {
        String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=1q2w3e4r5t;database=ppk;Ssl mode = none";
        public Form1(String username)
        {
            InitializeComponent();
            show();
            pTambah.Visible = false;
            pUpdate.Visible = false;
            phapus.Visible = false;
            this.Text = username;
        }

        private void show()
        {
            try
            {
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                dbconn.Open();
                String sql = "SELECT id_barang as 'ID BARANG', nama_barang as 'NAMA BARANG', harga_barang as 'HARGA BARANG', jumlah_barang as 'JUMLAH' FROM Barang";
                MySqlCommand cmd = new MySqlCommand(sql, dbconn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                this.dgBarang.DataSource = dt;
                dbconn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAll.Visible = true;
            pTambah.Visible = false;
            pUpdate.Visible = false;
            phapus.Visible = false;
            try
            {
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                dbconn.Open();
                String sql = "SELECT id_barang as 'ID BARANG', nama_barang as 'NAMA BARANG', harga_barang as 'HARGA BARANG', jumlah_barang as 'JUMLAH' FROM Barang";
                MySqlCommand cmd = new MySqlCommand(sql, dbconn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                this.dgBarang.DataSource = dt;
                dbconn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            showAll.Visible = false;
            pUpdate.Visible = false;
            phapus.Visible = false;
            pTambah.Visible = true;
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection dbconn = new MySqlConnection(connectionString);                
                MySqlCommand cmd = new MySqlCommand("insert into Barang(nama_barang,jumlah_barang,harga_barang,kategori) values (@nama_barang,@jumlah_barang,@harga_barang,@kategori)", dbconn);
                dbconn.Open();
                cmd.Parameters.AddWithValue("@nama_barang", tbNmBrg.Text);
                cmd.Parameters.AddWithValue("@harga_barang", tbHgBrg.Text);
                cmd.Parameters.AddWithValue("@jumlah_barang", tbJmBrg.Text);
                cmd.Parameters.AddWithValue("@kategori", tbKtBrg.Text);
                cmd.ExecuteNonQuery();
                dbconn.Close();
                MessageBox.Show("Data Berhasil Ditambahkan");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }  
            showAll.Visible = true;
            pTambah.Visible = false;
        }

        private void btnBtlAdd_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah anda yakin?","Konfirmasi batal tambah", MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            {
                tbNmBrg.Text = "";
                tbHgBrg.Text = "";
                tbJmBrg.Text = "";
            }            
        }

        private void update_Click(object sender, EventArgs e)
        {
            showAll.Visible = false;
            pTambah.Visible = false;
            phapus.Visible = false;
            pUpdate.Visible = true;
        }

        private void btnCariupdt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection dbconn = new MySqlConnection(connectionString);
                dbconn.Open();
                String sql = "SELECT count(id_barang) FROM Barang where id_barang = @id";           
                MySqlCommand cmd = new MySqlCommand(sql, dbconn);
                cmd.Parameters.AddWithValue("@id", tbSrchid.Text);
                String angka = cmd.ExecuteScalar().ToString();
                if (angka == "1")
                {
                    showList(tbSrchid.Text);
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                    tbUidBrg.Text = "";
                    tbUnmBrg.Text = "";
                    tbUhgBrg.Text = "";
                    tbUjmBrg.Text = "";
                }
                dbconn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showList(String id)
        {
            MySqlConnection dbconn = new MySqlConnection(connectionString);
            dbconn.Open();
            String sql = "SELECT * FROM Barang where id_barang = @id";
            MySqlCommand cmd = new MySqlCommand(sql, dbconn);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();
            tbUidBrg.Text = read[0].ToString();
            tbUnmBrg.Text = read[1].ToString();
            tbUhgBrg.Text = read[2].ToString();
            tbUjmBrg.Text = read[3].ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            showAll.Visible = false;
            pTambah.Visible = false;
            pUpdate.Visible = false;
            phapus.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}