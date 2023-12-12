using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TugasPraktik
{
    public partial class FormComponent : Form
    {
        Akun akun1 = new Akun(20000, "hiyahiyahiya");
        public FormComponent()
        {
            InitializeComponent();
            
        }
        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=ListofName1";
           
        public DataTable dt;
        public static NpgsqlCommand cmd;
        public string sql = null;
        public DataGridViewRow r;




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormComponent_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLoaddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "SELECT * FROM st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                txtName.Text = r.Cells["_name"].Value.ToString();
                txtAlamat.Text = r.Cells["_alamat"].Value.ToString();
                txtNo_handphone.Text = r.Cells["_no_Handphone"].Value.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT FROM st_insert(:_name, :_alamat,:_no_handphone)";
        
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_name", txtName.Text);
                cmd.Parameters.AddWithValue("_alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("_no_handphone", txtNo_handphone.Text);
                if((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    btnLoaddata.PerformClick();
                    txtName.Text = txtNo_handphone.Text = txtAlamat.Text = null;
                }

            }
            catch (Exception ex )
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {   
            if(r==null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            try
            {
                conn.Open();
                sql = @"SELECT FROM st_update(:_name, :_alamat,:_no_handphone)";

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_name", txtName.Text);
                cmd.Parameters.AddWithValue("_alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("_no_handphone", txtNo_handphone.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users berhasil diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    btnLoaddata.PerformClick();
                    txtName.Text = txtNo_handphone.Text = txtAlamat.Text = null;
                    r = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r==null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Apakah benar anda ingin menghapus data " + r.Cells["_id"].Value.ToString()+ " ?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)


                try
                {
                    sql = @"SELECT FROM st_delete(:_name, :_alamat,:_no_handphone)";

                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
            
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data Users berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        btnLoaddata.PerformClick();
                        txtName.Text = txtNo_handphone.Text = txtAlamat.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            Modul9Form frm = new Modul9Form(this);
            frm.Show();
        }
    }
}
