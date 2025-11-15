using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrderingFood_Orcullo_IT13
{
    public partial class Menu : Form
    {
        string connectionString = "Data Source=LAPTOP-ICOQ58RP\\SQLEXPRESS;Initial Catalog=FoodOrderingDB;Integrated Security=True;";
        int selectedId = -1;

        public Menu()
        {
            InitializeComponent();

            // Only subscribe events that are NOT already set in Designer
            viewButton.Click += (s, e) => LoadMenuItems();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM MenuItems", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO MenuItems (Name, Price, Quantity, Size) VALUES (@Name, @Price, @Quantity, @Size)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", foodtextBox.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(priceTextBox.Text));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(quantityTextBox.Text));
                cmd.Parameters.AddWithValue("@Size", sizeTextBox.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadMenuItems();
            ClearFields();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1 || !ValidateFields()) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE MenuItems SET Name=@Name, Price=@Price, Quantity=@Quantity, Size=@Size WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", selectedId);
                cmd.Parameters.AddWithValue("@Name", foodtextBox.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(priceTextBox.Text));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(quantityTextBox.Text));
                cmd.Parameters.AddWithValue("@Size", sizeTextBox.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadMenuItems();
            ClearFields();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM MenuItems WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", selectedId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadMenuItems();
            ClearFields();
        }

        private void button6_Click(object sender, EventArgs e) // search button
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MenuItems WHERE Name LIKE @Search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + textBox5.Text + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void button2_Click(object sender, EventArgs e) // clear button
        {
            ClearFields();
        }

        private void ClearFields()
        {
            foodtextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
            sizeTextBox.Clear();
            textBox5.Clear();
            selectedId = -1;
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(foodtextBox.Text) ||
                string.IsNullOrWhiteSpace(priceTextBox.Text) ||
                string.IsNullOrWhiteSpace(quantityTextBox.Text) ||
                string.IsNullOrWhiteSpace(sizeTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                foodtextBox.Text = row.Cells["Name"].Value.ToString();
                priceTextBox.Text = row.Cells["Price"].Value.ToString();
                quantityTextBox.Text = row.Cells["Quantity"].Value.ToString();
                sizeTextBox.Text = row.Cells["Size"].Value.ToString();
            }
        }
    }
}
