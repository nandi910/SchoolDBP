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

        private int temp = Convert.ToInt32(null);
        Random rand = new Random((int)DateTime.Now.Ticks);
        private string user = null;
        private string pass = null;
        private string firstN = null;
        private string lastN = null;
        private int year = 0;
        private int spec = 0;
        private int semester = 0;
        private static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nandi\\Desktop\\SchoolDBP\\SchoolDBP\\Data.mdf;Integrated Security=True";
        

        private bool check_formula_empty()
        {
            bool tempEmpty = true;

            if (usernameBox.Text == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (passwordBox.Text == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (firstNameBox.Text == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (lastNameBox.Text == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (year == 0)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (semester == 0)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (spec == 0)
                tempEmpty = true;
            else
                tempEmpty = false;
            if (emailBox.Text == null)
                tempEmpty = true;
            else
                tempEmpty = false;
            return tempEmpty;
        }

        private bool checkExistingUser(string input)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("SELECT username FROM users WHERE username= @Username", conn);
                cmd.Parameters.AddWithValue("@Username", usernameBox.Text);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                    return true;
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

        private static string SHA512Hash(string input)
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
            semester = 1;
        }

        private void semester2rad_CheckedChanged(object sender, EventArgs e)
        {
            semester = 2;
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
            //DataTable dt_users = new DataTable();
            //dt_users = DatabaseHelper.load_users();
            //int dr = dt_users.Rows.Count;
            
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
                MessageBox.Show("User already exists.");
            }
            else
            {
                if(!check_formula_empty())
                {
                    string app_mail = "unidbproj@gmail.com";
                    string app_password = "iP1HcFr,ne";
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
                        MessageBox.Show("Check your mail");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Fill out the formula");
                }
            }
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(verifyBox.Text) != temp)
            {
                MessageBox.Show("Wrong verification code");
            }
            else
            {
                user = usernameBox.Text;
                pass = SHA512Hash(passwordBox.Text);
                firstN = firstNameBox.Text;
                lastN = lastNameBox.Text;

                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                //SQLUsers
                {
                    string SQLUsers = "INSERT INTO users VALUES(@username, @password)";
                    SqlCommand cmdUsers = new SqlCommand(SQLUsers, conn);
                    cmdUsers.Parameters.AddWithValue("@username", user);
                    cmdUsers.Parameters.AddWithValue("@password", pass);
                    cmdUsers.ExecuteScalar();
                }
                //SQLData
                try{
                    string SQLData = "INSERT INTO data (FirstName, LastName, Specialization, Year, Semester) VALUES(@FirstName,@LastName,@Specialization,@Year,@Semester)";
                    SqlCommand cmdData = new SqlCommand(SQLData, conn);
                    cmdData.Parameters.AddWithValue("@FirstName", firstN);
                    cmdData.Parameters.AddWithValue("@LastName", lastN);
                    cmdData.Parameters.AddWithValue("@Specialization", spec);
                    cmdData.Parameters.AddWithValue("@Year", year);
                    cmdData.Parameters.AddWithValue("@Semester", semester);
                    cmdData.ExecuteScalar();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                conn.Close();
                
                MessageBox.Show("Registration Successful, to log in, restart the app[PH].");
            }
        }
    }
}
