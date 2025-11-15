using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OrderingFood_Orcullo_IT13
{
    public partial class Order : Form
    {
        string connectionString = @"Data Source=LAPTOP-ICOQ58RP\SQLEXPRESS;Initial Catalog=FoodOrderingDB;Integrated Security=True;";
        int selectedId = -1;

        public Order()
        {
            InitializeComponent();

            // Attach button events
            addButton.Click += addButton_Click;
            updateButton.Click += updateButton_Click;
            deleteButton.Click += deleteButton_Click;
            viewButton.Click += viewButton_Click;
            clearButton.Click += clearButton_Click;
            button6.Click += button6_Click; // search
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Load orders on startup
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Orders", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Orders (CustomerName, Food1, Food2, Food3) VALUES (@Customer, @Food1, @Food2, @Food3)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Customer", custextBox.Text);
                    cmd.Parameters.AddWithValue("@Food1", foodtextBox1.Text);
                    cmd.Parameters.AddWithValue("@Food2", foodtextBox2.Text);
                    cmd.Parameters.AddWithValue("@Food3", foodtextBox3.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadOrders();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding order: " + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Please select an order to update.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Orders SET CustomerName=@Customer, Food1=@Food1, Food2=@Food2, Food3=@Food3 WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Id", selectedId);
                    cmd.Parameters.AddWithValue("@Customer", custextBox.Text);
                    cmd.Parameters.AddWithValue("@Food1", foodtextBox1.Text);
                    cmd.Parameters.AddWithValue("@Food2", foodtextBox2.Text);
                    cmd.Parameters.AddWithValue("@Food3", foodtextBox3.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadOrders();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Please select an order to delete.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Orders WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Id", selectedId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadOrders();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting order: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e) // search
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Orders WHERE CustomerName LIKE @Search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + textBox5.Text + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching orders: " + ex.Message);
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            custextBox.Clear();
            foodtextBox1.Clear();
            foodtextBox2.Clear();
            foodtextBox3.Clear();
            textBox5.Clear();
            selectedId = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["Id"].Value);
                custextBox.Text = row.Cells["CustomerName"].Value.ToString();
                foodtextBox1.Text = row.Cells["Food1"].Value.ToString();
                foodtextBox2.Text = row.Cells["Food2"].Value.ToString();
                foodtextBox3.Text = row.Cells["Food3"].Value.ToString();
            }
        }
    }
}
