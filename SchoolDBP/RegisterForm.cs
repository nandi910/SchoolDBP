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
            string SQL = "SELECT * FROM users WHERE username is " + input + ";";

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                SqlDataAdapter DTAdapter = new SqlDataAdapter(cmd);
                try
                {
                    SqlCommand chckusr = new SqlCommand("SELECT COUNT * FROM users WHERE ([username] = @user;", conn);
                    chckusr.Parameters.AddWithValue("@user", input);

                    int userExist = (int)chckusr.ExecuteScalar();

                    if (userExist > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
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
            string app_mail = "szivacsnandi@gmail.com";
            string app_password = "NandiSetH";
            temp = rand.Next(10000,99999);
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
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
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
