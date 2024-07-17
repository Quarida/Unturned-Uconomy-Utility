using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Collections.Generic;

namespace UnturnedShopPlugin
{
    public partial class MainForm : Form
    {
        private MySqlConnection connection;
        private Dictionary<string, string> itemsData;
        private Dictionary<string, string> vehiclesData;

        public MainForm()
        {
            InitializeComponent();
            itemsData = new Dictionary<string, string>();
            vehiclesData = new Dictionary<string, string>();
            FetchDataFromFiles();
        }

        private void FetchDataFromFiles()
        {
            foreach (var line in File.ReadAllLines("items.txt"))
            {
                var parts = line.Split(';');
                if (parts.Length == 2)
                {
                    itemsData[parts[0].Trim()] = parts[1].Trim();
                }
            }

            foreach (var line in File.ReadAllLines("vehicles.txt"))
            {
                var parts = line.Split(';');
                if (parts.Length == 2)
                {
                    vehiclesData[parts[0].Trim()] = parts[1].Trim();
                }
            }
        }

        private MySqlConnection ConnectToMySQL(string host, string user, string password, string database)
        {
            string connectionString = $"Server={host};Database={database};User ID={user};Password={password};SslMode=none;";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                return connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string host = hostTextBox.Text;
            string user = userTextBox.Text;
            string password = passwordTextBox.Text;
            string database = databaseTextBox.Text;

            connection = ConnectToMySQL(host, user, password, database);
            if (connection != null)
            {
                MessageBox.Show("Connected to MySQL successfully!", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataManagement();
            }
        }

        private void ShowDataManagement()
        {
            tabControl.TabPages.Clear();

            var vehicleTab = new TabPage("Araçlar");
            var itemTab = new TabPage("İtemler");

            tabControl.TabPages.Add(vehicleTab);
            tabControl.TabPages.Add(itemTab);

            var vehicleDataGrid = new DataGridView { Dock = DockStyle.Fill, AutoGenerateColumns = true };
            vehicleTab.Controls.Add(vehicleDataGrid);

            var itemDataGrid = new DataGridView { Dock = DockStyle.Fill, AutoGenerateColumns = true };
            itemTab.Controls.Add(itemDataGrid);

            FetchAndShowData(vehicleDataGrid, itemDataGrid);
        }

        private void FetchAndShowData(DataGridView vehicleDataGrid, DataGridView itemDataGrid)
        {
            var vehicleDataAdapter = new MySqlDataAdapter("SELECT * FROM uconomyvehicleshop", connection);
            var vehicleDataTable = new DataTable();
            vehicleDataAdapter.Fill(vehicleDataTable);
            vehicleDataGrid.DataSource = vehicleDataTable;

            var itemDataAdapter = new MySqlDataAdapter("SELECT * FROM uconomyitemshop", connection);
            var itemDataTable = new DataTable();
            itemDataAdapter.Fill(itemDataTable);
            itemDataGrid.DataSource = itemDataTable;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.ToLower();
            searchResultsListView.Items.Clear();

            if (tabControl.SelectedIndex == 1) 
            {
                foreach (var item in itemsData)
                {
                    if ((item.Key.ToLower().Contains(searchTerm) || item.Value.ToLower().Contains(searchTerm)) && !ExistingItemIds().Contains(item.Key))
                    {
                        var listViewItem = new ListViewItem(new[] { item.Key, item.Value });
                        searchResultsListView.Items.Add(listViewItem);
                    }
                }
            }
            else 
            {
                foreach (var vehicle in vehiclesData)
                {
                    if ((vehicle.Key.ToLower().Contains(searchTerm) || vehicle.Value.ToLower().Contains(searchTerm)) && !ExistingVehicleIds().Contains(vehicle.Key))
                    {
                        var listViewItem = new ListViewItem(new[] { vehicle.Key, vehicle.Value });
                        searchResultsListView.Items.Add(listViewItem);
                    }
                }
            }
        }

        private HashSet<string> ExistingItemIds()
        {
            var ids = new HashSet<string>();
            var command = new MySqlCommand("SELECT id FROM uconomyitemshop", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ids.Add(reader.GetString(0));
                }
            }
            return ids;
        }

        private HashSet<string> ExistingVehicleIds()
        {
            var ids = new HashSet<string>();
            var command = new MySqlCommand("SELECT id FROM uconomyvehicleshop", connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ids.Add(reader.GetString(0));
                }
            }
            return ids;
        }

        private void AddSelectedButton_Click(object sender, EventArgs e)
        {
            if (searchResultsListView.SelectedItems.Count > 0)
            {
                var selectedItem = searchResultsListView.SelectedItems[0];
                addIdTextBox.Text = selectedItem.SubItems[0].Text;
                addNameTextBox.Text = selectedItem.SubItems[1].Text;
            }
            else
            {
                MessageBox.Show("Lütfen eklemek istediğiniz bir veriyi seçin.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string addId = addIdTextBox.Text;
            string addName = addNameTextBox.Text;
            string addCost = addCostTextBox.Text;
            string addBuyback = addBuybackTextBox.Text;

            string query;
            if (!string.IsNullOrEmpty(addBuyback))
            {
                query = "INSERT INTO uconomyitemshop (id, itemname, cost, buyback) VALUES (@id, @name, @cost, @buyback)";
            }
            else 
            {
                query = "INSERT INTO uconomyvehicleshop (id, vehiclename, cost) VALUES (@id, @name, @cost)";
            }

            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", addId);
                command.Parameters.AddWithValue("@name", addName);
                command.Parameters.AddWithValue("@cost", addCost);
                if (!string.IsNullOrEmpty(addBuyback))
                {
                    command.Parameters.AddWithValue("@buyback", addBuyback);
                }

                command.ExecuteNonQuery();
            }

            MessageBox.Show("Veri başarıyla eklendi.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowDataManagement();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataGridView selectedGrid;
            if (tabControl.SelectedIndex == 1)
            {
                selectedGrid = (DataGridView)tabControl.TabPages[1].Controls[0];
            }
            else
            {
                selectedGrid = (DataGridView)tabControl.TabPages[0].Controls[0];
            }

            if (selectedGrid.SelectedRows.Count > 0)
            {
                var selectedRow = selectedGrid.SelectedRows[0];
                string id = selectedRow.Cells[0].Value.ToString();
                string query;
                if (tabControl.SelectedIndex == 1)
                {
                    query = "DELETE FROM uconomyitemshop WHERE id = @id";
                }
                else
                {
                    query = "DELETE FROM uconomyvehicleshop WHERE id = @id";
                }

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Veri başarıyla silindi.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataManagement();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir veriyi seçin.", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
