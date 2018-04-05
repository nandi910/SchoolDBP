using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net.Mail;

namespace SchoolDBP
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        int temp = 0;
        Random rand = new Random((int)DateTime.Now.Ticks);
        string user, pass, firstN, lastN;
        int year, spec;
        bool semester;
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Data.mdf;Integrated Security=True";

        public bool checkExistingUser(string input)
        {
            DataTable dt = new DataTable();
            
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select username from users where username= @Username", conn);
                cmd.Parameters.AddWithValue("@Username", usernameBox.Text);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    MessageBox.Show(string.Format("Username {0} already exist", usernameBox.Text));
                    return true;
                }
                else
                    return false;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                return true;
            }
        }

        private static string bytesToString(byte[] hash)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                str.Append(hash[i].ToString("X2"));
            return str.ToString();
        }

        public static string SHA512Hash(string input)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = sha512.ComputeHash(bytes);
            return bytesToString(hash);
        }
    
        private void year1rad_CheckedChanged(object sender, EventArgs e)
        {
            year = 1;
        }

        private void year2rad_CheckedChanged(object sender, EventArgs e)
        {
            year = 2;
        }

        private void year3rad_CheckedChanged(object sender, EventArgs e)
        {
            year = 3;
        }

        private void year4rad_CheckedChanged(object sender, EventArgs e)
        {
            year = 4;
        }

        private void semester1rad_CheckedChanged(object sender, EventArgs e)
        {
            semester = false;
        }

        private void semester2rad_CheckedChanged(object sender, EventArgs e)
        {
            semester = true;
        }

        private void spec1rad_CheckedChanged(object sender, EventArgs e)
        {
            spec = 1;
        }

        private void spec2rad_CheckedChanged(object sender, EventArgs e)
        {
            spec = 2;
        }

        private void spec3rad_CheckedChanged(object sender, EventArgs e)
        {
            spec = 3;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            DataTable dt_users = new DataTable();
            dt_users = DatabaseHelper.load_users();
            int dr = dt_users.Rows.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            string SQL = "INSERT into users (username, password) values(@username,@password)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = SQL;
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@username", usernameBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordBox.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Row inserted");
            conn.Close();
            //string UpdateSQL = "UPDATE users SET username=@username, password=@password";
        }

        private void spec4rad_CheckedChanged(object sender, EventArgs e)
        {
            spec = 4;
        }
    
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void sendEmail_Click(object sender, EventArgs e)
        {
            if(checkExistingUser(usernameBox.Text))
            {
                
            }
            else
            {
                if(usernameBox.Text != "")
                {
                    string app_mail = "szivacsnandi@gmail.com";
                    string app_password = "NandiSetH";
                    temp = rand.Next(100000, 999999);
                    SmtpClient client = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Credentials = new System.Net.NetworkCredential(app_mail, app_password),
                    };

                    try
                    {
                        MailMessage mail = new MailMessage(app_mail, emailBox.Text, "Verification Code", Convert.ToString(temp));
                        client.Send(mail);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Username box cannot be empty");
                }
            }
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            if (checkExistingUser(usernameBox.Text))
            {
                if (Convert.ToInt32(verifyBox.Text) == temp)
                {
                    MessageBox.Show("User already exists");
                }
                else
                {
                    user = usernameBox.Text;
                    pass = SHA512Hash(passwordBox.Text);
                    firstN = firstNameBox.Text;
                    lastN = lastNameBox.Text;
                    MessageBox.Show("Registration Successful");
                }
            }
        }
    }
}
