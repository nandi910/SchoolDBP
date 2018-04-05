using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolDBP
{
    public partial class LogRegistForm : Form
    {
        public LogRegistForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form LoginForm = new LoginForm();
                LoginForm.Show();
                this.Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form RegisterForm = new RegisterForm();
                RegisterForm.Show();
                this.Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogRegistForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("[PH] MEANS PLACEHOLDER. IF STILL THERE, CHANGE WHEN DONE.");
        }
    }
}
