using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-P3GTBMC;Initial Catalog=AsmeniniuFinansuApskaita;Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
            InitializeEventHandlers();
            LoadCategories();
            LoadTransactions();

        }
        private void InitializeEventHandlers()
        {
            btnGenerateReport.Click += btnGenerateReport_Click;
            dgTransactions.CellContentClick += DgTransactions_CellContentClick;
            
        }

        
        private void DgTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Patikrinti, ar paspausta ląstelė yra tinkamoje diapazono vietoje
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Gaukite paspaustos ląstelės turinį
                object cellValue = dgTransactions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Rodyti pranešimo langą su ląstelės turiniu
                MessageBox.Show($"Paspausta ląstelė! Turinys: {cellValue}");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Metodai skirti pajamų ir išlaidų įrašų valdymui
        private void AddTransaction(decimal amount, int categoryID, DateTime date, string description)
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "INSERT INTO Transactions (UserID, CategoryID, Amount, Date, Description) " +
                               "VALUES (@UserID, @CategoryID, @Amount, @Date, @Description)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Priskiriame parametrus
                    command.Parameters.AddWithValue("@UserID", 1); // Pakeiskite į savo vartotojo ID
                    command.Parameters.AddWithValue("@CategoryID", categoryID);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Description", description);

                    // Įvykdome užklausą
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Įrašas pridėtas sėkmingai.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida pridedant įrašą: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void UpdateTransaction(int transactionID, decimal amount, int categoryID, DateTime date, string description)
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "UPDATE Transactions " +
                               "SET Amount = @Amount, " +
                               "    CategoryID = @CategoryID, " +
                               "    Date = @Date, " +
                               "    Description = @Description " +
                               "WHERE TransactionID = @TransactionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Priskiriame parametrus
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@CategoryID", categoryID);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@TransactionID", transactionID);

                    // Įvykdome užklausą
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Įrašas atnaujintas sėkmingai.");
                    }
                    else
                    {
                        MessageBox.Show("Įrašo atnaujinimas nepavyko. Įrašas su tokiu ID nerastas.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida atnaujinant įrašą: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            LoadTransactions();
        }


        private void DeleteTransaction(int transactionID)
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "DELETE FROM Transactions WHERE TransactionID = @TransactionID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Priskiriame parametrą
                    command.Parameters.AddWithValue("@TransactionID", transactionID);

                    // Įvykdome užklausą
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Įrašas pašalintas sėkmingai.");
                    }
                    else
                    {
                        MessageBox.Show("Įrašo pašalinimas nepavyko. Įrašas su tokiu ID nerastas.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida šalinant įrašą: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            LoadTransactions();
        }


        // Klasifikatorių valdymo metodai (pildymas, keitimas, trynimas)
        private void AddCategory(string type, string name)
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "INSERT INTO Categories (Type, Name) VALUES (@Type, @Name)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Priskiriame parametrus
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Name", name);

                    // Įvykdome užklausą
                    command.ExecuteNonQuery();

                    MessageBox.Show("Kategorija pridėta sėkmingai.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida pridedant kategoriją: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void UpdateCategory(int categoryID, string name)
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "UPDATE Categories SET Name = @Name WHERE CategoryID = @CategoryID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Priskiriame parametrus
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@CategoryID", categoryID);

                    // Įvykdome užklausą
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kategorija atnaujinta sėkmingai.");
                    }
                    else
                    {
                        MessageBox.Show("Kategorijos atnaujinimas nepavyko. Kategorija su tokiu ID nerasta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida atnaujinant kategoriją: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void DeleteCategory(int categoryID)
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Priskiriame parametrą
                    command.Parameters.AddWithValue("@CategoryID", categoryID);

                    // Įvykdome užklausą
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kategorija pašalinta sėkmingai.");
                    }
                    else
                    {
                        MessageBox.Show("Kategorijos pašalinimas nepavyko. Kategorija su tokiu ID nerasta.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida šalinant kategoriją: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        // Metodai skirti ataskaitų generavimui
        private void GeneratePeriodReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "SELECT TransactionID, Amount, CategoryID, Date, Description " +
               "FROM Transactions " +
               "WHERE Date BETWEEN @StartDate AND @EndDate " +
               "ORDER BY Date ASC";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Priskiriame parametrus
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@EndDate", endDate);

                    // Įvykdome užklausą
                    SqlDataReader reader = command.ExecuteReader();

                    // Ataskaitos generavimas pagal laikotarpį
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("TransactionID", typeof(int));
                    dataTable.Columns.Add("Amount", typeof(decimal));
                    dataTable.Columns.Add("CategoryID", typeof(int));
                    dataTable.Columns.Add("Date", typeof(DateTime));
                    dataTable.Columns.Add("Description", typeof(string));

                    while (reader.Read())
                    {
                        int transactionID = reader.GetInt32(0);
                        decimal amount = reader.GetDecimal(1);
                        int categoryID = reader.GetInt32(2);
                        DateTime date = reader.GetDateTime(3);
                        string description = reader.GetString(4);

                        // Pridedame naują eilutę į DataTable
                        dataTable.Rows.Add(transactionID, amount, categoryID, date, description);
                    }

                    // Atvaizduojame ataskaitą DataGridView komponente
                    dgReportGen.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klaida generuojant ataskaitą pagal laikotarpį: {ex.Message}\n{ex.StackTrace}");
            }
            finally
            {
                connection.Close();
            }
        }




        private void GenerateCategoryReport()
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "SELECT Categories.Name, SUM(Transactions.Amount) AS TotalAmount " +
                               "FROM Transactions " +
                               "INNER JOIN Categories ON Transactions.CategoryID = Categories.CategoryID " +
                               "GROUP BY Categories.Name";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Įvykdome užklausą
                    SqlDataReader reader = command.ExecuteReader();

                    // Ataskaitos generavimas pagal kategorijas
                    DataTable reportTable = new DataTable();
                    reportTable.Load(reader);

                    // Atvaizduojame ataskaitą DataGridView
                    dgCateRepGen.DataSource = reportTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida generuojant ataskaitą pagal kategorijas: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            GenerateCategoryReport();
        }


        private void GenerateSummaryReport()
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "SELECT 'Pajamos' AS Type, SUM(Amount) AS TotalAmount " +
                               "FROM Transactions WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE Type = 'Pajamos') " +
                               "UNION ALL " +
                               "SELECT 'Islaidos' AS Type, SUM(Amount) AS TotalAmount " +
                               "FROM Transactions WHERE CategoryID IN (SELECT CategoryID FROM Categories WHERE Type = 'Islaidos')";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Įvykdome užklausą
                    SqlDataReader reader = command.ExecuteReader();

                    // Sukurkite DataTable ir užkraukite duomenis iš reader
                    DataTable reportTable = new DataTable();
                    reportTable.Load(reader);

                    // Atvaizduojame ataskaitą DataGridView
                    dgLast.DataSource = reportTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida generuojant suminę ataskaitą: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpStartDate.Value.Date;  // Nustatykite tik datą, be laiko
                DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);  // Nustatykite dienos pabaigą, be laiko

                GeneratePeriodReport(startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida generuojant ataskaitą pagal laikotarpį: " + ex.Message);
            }
        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddTransaction_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(0, 0, DateTime.Now, "");
            if (transactionForm.ShowDialog() == DialogResult.OK)
            {
                // Gauti įvestus duomenis iš naujos formos ir įvykdyti transakciją
                decimal amount = transactionForm.Amount;
                int categoryID = transactionForm.CategoryID;
                DateTime date = transactionForm.Date;
                string description = transactionForm.Description;

                // Pridėkite transakciją
                AddTransaction(amount, categoryID, date, description);
            }
            LoadTransactions();
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm("Pradinis pavadinimas", "Pajamos");
            if (categoryForm.ShowDialog() == DialogResult.OK)
            {
                // Gauti įvestus duomenis iš naujos formos ir pridėti kategoriją
                string name = categoryForm.Name;
                string type = categoryForm.Type;

                // Pridėkite kategoriją
                AddCategory(type, name);
            }
            LoadCategories();
        }

        private void BtnEditCategory_Click(object sender, EventArgs e)
        {
            if (dgCategories.SelectedRows.Count > 0)
            {
                // Gaukite pasirinktos kategorijos ID
                int categoryID = Convert.ToInt32(dgCategories.SelectedRows[0].Cells["CategoryID"].Value);

                // Gaukite esamą pavadinimą ir tipą
                string currentName = dgCategories.SelectedRows[0].Cells["Name"].Value.ToString();
                string currentType = dgCategories.SelectedRows[0].Cells["Type"].Value.ToString(); // Galite pavadinti stulpelį pagal realią duomenų struktūrą

                // Rodyti formą su esamais duomenimis
                CategoryForm categoryForm = new CategoryForm(currentName, currentType);
                if (categoryForm.ShowDialog() == DialogResult.OK)
                {
                    // Gauti naują pavadinimą iš formos
                    string newName = categoryForm.Name;

                    // Atnaujinti kategoriją
                    UpdateCategory(categoryID, newName);
                }
            }
            else
            {
                MessageBox.Show("Pasirinkite kategoriją, kurią norite redaguoti.");
            }
            LoadCategories();
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dgCategories.SelectedRows.Count > 0)
            {
                // Gaukite pasirinktos kategorijos ID
                int categoryID = Convert.ToInt32(dgCategories.SelectedRows[0].Cells["CategoryID"].Value);

                // Patikrinkite, ar yra transakcijų su šia kategorija
                int transactionCount = GetTransactionCountByCategory(categoryID);

                if (transactionCount == 0)
                {
                    // Jei nėra transakcijų, galite ištrinti kategoriją
                    DeleteCategory(categoryID);
                }
                else
                {
                    MessageBox.Show("Negalima ištrinti kategorijos, su kuria susijusios transakcijos.");
                }
            }
            else
            {
                MessageBox.Show("Pasirinkite kategoriją, kurią norite ištrinti.");
            }
            LoadCategories();
        }
        private int GetTransactionCountByCategory(int categoryID)
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "SELECT COUNT(*) FROM Transactions WHERE CategoryID = @CategoryID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Priskiriame parametrą
                    command.Parameters.AddWithValue("@CategoryID", categoryID);

                    // Įvykdome užklausą ir grąžiname rezultatą
                    return (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida gaunant transakcijų skaičių pagal kategoriją: " + ex.Message);
                return -1; // Gražiname -1 kaip klaidos indikatorių
            }
            finally
            {
                connection.Close();
            }
        }

        private void dgCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadTransactions()
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "SELECT * FROM Transactions";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Nustatykite duomenų šaltinį DataGridView
                    dgTransactions.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida kraunant transakcijas: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void LoadCategories()
        {
            try
            {
                connection.Open();

                // Paruošiame SQL užklausą
                string query = "SELECT * FROM Categories";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Nustatykite duomenų šaltinį DataGridView
                    dgCategories.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida kraunant kategorijas: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTrans_Click(object sender, EventArgs e)
        {
            if (dgTransactions.SelectedRows.Count > 0)
            {
                // Gaukite pasirinktos transakcijos ID
                int transactionID = Convert.ToInt32(dgTransactions.SelectedRows[0].Cells["TransactionID"].Value);

                // Iškvieskite DeleteTransaction funkciją
                DeleteTransaction(transactionID);

                // Įkraukite atnaujintus transakcijų duomenis
                LoadTransactions();
            }
            else
            {
                MessageBox.Show("Pasirinkite transakciją, kurią norite ištrinti.");
            }
        }

        private void btnEditTrans_Click(object sender, EventArgs e)
        {
            if (dgTransactions.SelectedRows.Count > 0)
            {
                // Gaukite pasirinktos transakcijos ID
                int transactionID = Convert.ToInt32(dgTransactions.SelectedRows[0].Cells["TransactionID"].Value);

                // Gaukite esamus duomenis
                decimal currentAmount = Convert.ToDecimal(dgTransactions.SelectedRows[0].Cells["Amount"].Value);
                int currentCategoryID = Convert.ToInt32(dgTransactions.SelectedRows[0].Cells["CategoryID"].Value);
                DateTime currentDate = Convert.ToDateTime(dgTransactions.SelectedRows[0].Cells["Date"].Value);
                string currentDescription = dgTransactions.SelectedRows[0].Cells["Description"].Value.ToString();

                // Rodyti formą su esamais duomenimis
                TransactionForm transactionForm = new TransactionForm(currentAmount, currentCategoryID, currentDate, currentDescription);
                if (transactionForm.ShowDialog() == DialogResult.OK)
                {
                    // Gauti naujus duomenis iš formos
                    decimal newAmount = transactionForm.Amount;
                    int newCategoryID = transactionForm.CategoryID;
                    DateTime newDate = transactionForm.Date;
                    string newDescription = transactionForm.Description;

                    // Atnaujinti transakciją
                    UpdateTransaction(transactionID, newAmount, newCategoryID, newDate, newDescription);

                    // Įkraukite atnaujintus transakcijų duomenis
                    LoadTransactions();
                }
            }
            else
            {
                MessageBox.Show("Pasirinkite transakciją, kurią norite redaguoti.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateSummaryReport();
        }
    }
}
