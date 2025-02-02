using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace MDI
{
    public partial class ApiForm : Form
    {
        private string connectionString =
            "Server=cipg01;Username=postgres;Password=123456;Database=CP_TR122";
        private List<Post> posts = new List<Post>();
        private readonly ApiService _apiService = new ApiService();

        public class Post
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }

        public ApiForm()
        {
            InitializeComponent();
            LoadData();
            LoadApiData();
        }

        private async void LoadApiData()
        {
            try
            {
                posts = await _apiService.GetAllPostsAsync<Post>("posts");

                if (posts != null && posts.Count > 0)
                {
                    dataGridView1.DataSource = null; // Clear any previous data
                    dataGridView1.DataSource = posts; // Bind API data to dataGridView1
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No data found from the API.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching API data: {ex.Message}");
            }
        }

        private void LoadData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM t_users", conn);
                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "INSERT INTO t_users (pk_id, c_userid, c_title, c_body) VALUES (@id, @userId, @title, @body)",
                    conn
                );
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@userId", int.Parse(txtUserId.Text));
                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@body", txtBody.Text);
                cmd.ExecuteNonQuery();

                LoadData();
                MessageBox.Show("Data inserted successfully.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new NpgsqlCommand(
                        "UPDATE t_users SET pk_id = @id, c_userid = @userid, c_title = @title, c_body = @body WHERE pk_id = @id",
                        conn
                    );
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                    cmd.Parameters.AddWithValue("@userid", int.Parse(txtUserId.Text));
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@body", txtBody.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully");
                    LoadData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new NpgsqlCommand("DELETE FROM t_users WHERE pk_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfully");
                    LoadData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) { }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var row = dataGridView2.SelectedRows[0];
                txtId.Text = row.Cells["pk_id"].Value.ToString();
                txtUserId.Text = row.Cells["c_userid"].Value.ToString();
                txtTitle.Text = row.Cells["c_title"].Value.ToString();
                txtBody.Text = row.Cells["c_body"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtId.Clear();
            txtUserId.Clear();
            txtTitle.Clear();
            txtBody.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtUserId.Clear();
            txtTitle.Clear();
            txtBody.Clear();
        }

        private void btnAddToDatabase_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Wait for 20-30 Seconds Because data is too large");
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                foreach (var post in posts)
                {
                    var cmd = new NpgsqlCommand(
                        "INSERT INTO t_users (pk_id, c_userid, c_title, c_body) VALUES (@id, @userId, @title, @body)",
                        conn
                    );
                    cmd.Parameters.AddWithValue("@id", post.Id);
                    cmd.Parameters.AddWithValue("@userId", post.UserId);
                    cmd.Parameters.AddWithValue("@title", post.Title);
                    cmd.Parameters.AddWithValue("@body", post.Body);
                    cmd.ExecuteNonQuery();
                }
                LoadData();
                MessageBox.Show("All API data added to database successfully.");
            }
        }
    }
}
