using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SchoolDBP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is LogRegistForm)
                {
                    this.Hide();
                    openForm.Show();
                    break;
                }
            }
        }
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = userBox.Text;
            string pass = customFuncs.SHA512Hash(passBox.Text);

            SqlConnection conn = new SqlConnection(GVars.connectionString());
            string SQLlogin = "SELECT * FROM users WHERE username LIKE @username AND password = @password;";
            string SQLuserID = "SELECT userList_ID FROM users WHERE username LIKE @username;";
            string SQLType = "SELECT type FROM users WHERE username LIKE @username;";
            SqlCommand cmdLog = new SqlCommand(SQLlogin, conn);
            SqlCommand cmdID = new SqlCommand(SQLuserID, conn);
            SqlCommand cmdType = new SqlCommand(SQLType, conn);

            cmdLog.Parameters.AddWithValue("@username", user);
            cmdLog.Parameters.AddWithValue("@password", pass);
            cmdLog.Connection = conn;
            cmdID.Parameters.AddWithValue("@username", user);
            cmdID.Connection = conn;
            cmdType.Parameters.AddWithValue("@username", user);
            cmdType.Connection = conn;

            conn.Open();
            int temp = Convert.ToInt32(cmdID.ExecuteScalar());
            GVars.setUserID(temp);
            DataSet ds = new DataSet();
            SqlDataAdapter SQLDa = new SqlDataAdapter(cmdLog);

            SQLDa.Fill(ds);
            var typeCheck = cmdType.ExecuteScalar();
            conn.Close();

            bool loginSucc = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));
            
            if (loginSucc)
            {
                if(typeCheck.ToString() == "Student")
                {
                    Form StudentForm = new StudentForm();
                    StudentForm.Show();
                    this.Hide();
                }
                else
                {
                    Form TeacherForm = new TeacherForm();
                    TeacherForm.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Check Credentials");
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            userBox.Text = null;
            passBox.Text = null;
        }
    }
}
