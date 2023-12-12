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

namespace Responsi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=nathan_responsi";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public void RefreshData()
        {
            try
            {
                conn.Open();

                dgv.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            //RefreshData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from st_insert(:_nama, :_nama_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", tbNamaKaryawan.Text);
                cmd.Parameters.AddWithValue("_nama_dep", cbDepKaryawan.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Insert Berhasil");
                    conn.Close();
                    RefreshData();
                    tbNamaKaryawan.Text = cbDepKaryawan.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAIL");
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgv.Rows[e.RowIndex];
                tbNamaKaryawan.Text = r.Cells["_nama"].Value.ToString();
                cbDepKaryawan.Text = r.Cells["_nama_dep"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data untuk diedit");
                return;
            }

            try
            {
                conn.Open();
                sql = @"select * from st_update(:_id_dep, :_nama_dep, :_id_karyawan, :_nama)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue(r.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue(r.Cells["_nama"].Value.ToString());
                cmd.Parameters.AddWithValue(r.Cells["_id_dep"].Value.ToString());
                
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diedit");
                    conn.Close();
                    RefreshData();
                    tbNamaKaryawan.Text = cbDepKaryawan.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "EDIT FAIL");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(r == null)
            {
                MessageBox.Show("Mohon pilih baris data untuk dihapus");
                return;
            }

            if(MessageBox.Show("Apakah benar ingin menghapus data" + r.Cells["_nama"].Value.ToString() + "?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"select * from st_delete(:_id_karyawan)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue(r.Cells["_id_karyawan"].Value.ToString());
                    
                    if((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data berhasil dihapus");
                        conn.Close();
                        RefreshData();
                        tbNamaKaryawan.Text = cbDepKaryawan.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "DELETE FAIL");
                }
            }
        }
    }
}
