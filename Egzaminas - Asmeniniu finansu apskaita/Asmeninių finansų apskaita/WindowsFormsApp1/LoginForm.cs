using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-P3GTBMC;Initial Catalog=AsmeniniuFinansuApskaita;Integrated Security=True;");

        public string Username { get; private set; }
        public string Password { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        

        // Metodas skirtas autentifikacijai su duomenų baze
        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Priskiriame parametrus
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    // Įvykdome užklausą
                    int result = (int)command.ExecuteScalar();

                    // Tikriname ar rastas atitikimas
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida autentifikuojant naudotoją: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            Password = txtPassword.Text;

            // Patikrinkite duomenis su duomenų baze
            if (AuthenticateUser(Username, Password))
            {
                // Jei autentifikacija pavyko, parodykite pranešimą ir uždarykite langą
                MessageBox.Show("Prisijungimas sėkmingas!");
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide(); // Uždaryti dabartinį langą

            }
            else
            {
                // Jei autentifikacija nepavyko, parodykite klaidos pranešimą
                MessageBox.Show("Neteisingas vartotojo vardas arba slaptažodis!");
            }
        }
    }
}
