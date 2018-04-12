using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace SchoolDBP
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(GVars.connectionString());
        SqlDataAdapter da1, da2;
        DataTable dt1, dt2;
        SqlCommandBuilder builder1, builder2;

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            da1 = new SqlDataAdapter("SELECT * FROM data", conn);
            dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            da2 = new SqlDataAdapter("SELECT * FROM disciplines", conn);
            dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            conn.Close();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoResizeColumns();
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoResizeColumns();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                builder1 = new SqlCommandBuilder(da1);
                da1.UpdateCommand = builder1.GetUpdateCommand();
                da1.Update(dt1);
                builder2 = new SqlCommandBuilder(da2);
                da2.UpdateCommand = builder2.GetUpdateCommand();
                da2.Update(dt2);
                MessageBox.Show("Success");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

