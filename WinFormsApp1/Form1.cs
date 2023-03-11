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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string strcon = @"Data Source=FULIN114\SQLEXPRESS;Initial Catalog=dulieu;User ID=sa;Password=Ba0quynh";
        SqlConnection sqlcon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_ketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon == null)
                {
                    sqlcon = new SqlConnection(strcon);
                }
                if(sqlcon.State==ConnectionState.Closed)
                {
                    sqlcon.Open();
                    MessageBox.Show("Ket noi thanh cong");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlcon != null && sqlcon.State == ConnectionState.Open)
                    MessageBox.Show("Dong ket noi");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnt_timten_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandType = CommandType.Text;

            sqlcom.CommandText = "select * from donvi";
            sqlcom.Connection = sqlcon;
            int sdt = (int)sqlcom.ExecuteScalar();
            MessageBox.Show("sdt" + sdt);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
