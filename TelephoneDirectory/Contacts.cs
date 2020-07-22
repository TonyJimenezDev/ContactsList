using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;

/// <summary>
/// Contact List with search functions. 
/// Make a SQL Database and name it TelephoneContacts 
/// Make a table named ContactMobile - add 5 columns ID = int not null Primary Key, FirstName - varchar(50), LastName - varchar(50), Mobile - varchar(50), Email - varchar(50), Catagory - varchar(50). All except null but Primary Key
/// Open APPSettings - Add your serverconnectionstring.
/// Made By Tony Jimenez Free to use by anyone
/// </summary>
namespace TelephoneDirectory
{
    public partial class Contacts : Form
    {
        SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ServerConnectionString"]);
        public Contacts()
        {
            InitializeComponent();
        }

        private void QueryLookUp(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query,
            connection);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = item["ID"].ToString();
                dataGridView1.Rows[row].Cells[1].Value = item["FirstName"].ToString();
                dataGridView1.Rows[row].Cells[2].Value = item["LastName"].ToString();
                dataGridView1.Rows[row].Cells[3].Value = item["Mobile"].ToString();
                dataGridView1.Rows[row].Cells[4].Value = item["Email"].ToString();
                dataGridView1.Rows[row].Cells[5].Value = item["Catagory"].ToString();
            }
        }

        private void PortfolioLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(System.Configuration.ConfigurationManager.AppSettings["PortfolioWeb"]);
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            // Focus first textbox
            ActiveControl = firstName_TB;
            firstName_TB.Focus();
            QueryLookUp("Select * From ContactMobile");
            Delete_Btn.Enabled = false;
            Update_Btn.Enabled = false;
            dataGridView1.ClearSelection();
        }

        private void ClearFields()
        {
            firstName_TB.Clear();
            lastName_TB.Clear();
            mobile_TB.Clear();
            email_TB.Clear();
            catagory_CB.SelectedIndex = -1;
        }

        private void DisableFields()
        {
            firstName_TB.Enabled = false;
            lastName_TB.Enabled = false;
            mobile_TB.Enabled = false;
            email_TB.Enabled = false;
            catagory_CB.Enabled = false;
        }

        private void EnableFields()
        {
            firstName_TB.Enabled = true;
            lastName_TB.Enabled = true;
            mobile_TB.Enabled = true;
            email_TB.Enabled = true;
            catagory_CB.Enabled = true;
        }

        #region Button Events
        private void New_Btn_Click(object sender, EventArgs e)
        {
            ClearFields();
            EnableFields();
            firstName_TB.Focus();
            connection.Open();
            Insert_Btn.Enabled = true;
            Delete_Btn.Enabled = false;
            Update_Btn.Enabled = false;
            // Gets current ID from table
            SqlCommand command = new SqlCommand(@"Select IDENT_CURRENT('ContactMobile')", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) ID_ValueLabel.Text = (int.Parse(reader[0].ToString()) + 1).ToString();
            connection.Close();
            // Deselect
            if (dataGridView1.Rows.Count == 0) return;
            else dataGridView1.ClearSelection();
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstName_TB.Text) || string.IsNullOrWhiteSpace(firstName_TB.Text))
            {
                MessageBox.Show("First name cannot be empty!");
                return;
            }
            // Save New Contact
            int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 0)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"INSERT INTO ContactMobile 
                (FirstName, LastName, Mobile, Email, Catagory) VALUES ('" +
                    firstName_TB.Text + "','" +
                    lastName_TB.Text + "','" +
                    mobile_TB.Text + "','" +
                    email_TB.Text + "','" +
                    catagory_CB.Text + "')",
                    connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Contact Saved!");
                QueryLookUp("Select * From ContactMobile");
            }
            else // Save the Updated contact
            {
                connection.Open();
                SqlCommand updatecommand = new SqlCommand(@"UPDATE ContactMobile SET " +
                "FirstName = '" + firstName_TB.Text + "', " +
                "LastName = '" + lastName_TB.Text + "', " +
                "Mobile = '" + mobile_TB.Text + "'," +
                "Email = '" + email_TB.Text + "'," +
                "Catagory = '" + catagory_CB.Text + "'" +
                "Where (ID = '" + ID_ValueLabel.Text + "')",
                connection);

                updatecommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Contact Updated!");
                QueryLookUp("Select * From ContactMobile");
            }
            ClearFields();
            DisableFields();
            Insert_Btn.Enabled = false;
        }

        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0) return;
                ID_ValueLabel.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                firstName_TB.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lastName_TB.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                mobile_TB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                email_TB.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                catagory_CB.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                EnableFields();
                int index = dataGridView1.CurrentRow.Index;
                if (index != dataGridView1.CurrentRow.Index)
                {
                    Delete_Btn.Enabled = false;
                    Update_Btn.Enabled = false;

                }
                else
                {
                    index = dataGridView1.CurrentRow.Index;
                    Delete_Btn.Enabled = true;
                    Update_Btn.Enabled = true;
                    Insert_Btn.Enabled = false;
                }
            }
            catch
            {
                // Do nothing;
            }
            
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            // Primary key = Mobile
            connection.Open();
            SqlCommand command = new SqlCommand(@"DELETE FROM ContactMobile 
            WHERE (ID ='" + ID_ValueLabel.Text + "')",
            connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Contact Deleted!");
            QueryLookUp("Select * From ContactMobile");
            ClearFields();
            Delete_Btn.Enabled = false;
            Update_Btn.Enabled = false;
            DisableFields();
            if (dataGridView1.Rows.Count == 0) return;
        }


        private void Update_Btn_Click(object sender, EventArgs e)
        {
            Insert_Btn.Enabled = true;
            Delete_Btn.Enabled = false;
            Update_Btn.Enabled = false;
            EnableFields();
        }
        #endregion

        #region Text Change events
        private void SearchBox_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(SearchBox_TB.Text) || string.IsNullOrWhiteSpace(SearchBox_TB.Text))
                {
                    QueryLookUp("Select * From ContactMobile");
                    Search_Label.Text = "Search by all except id";
                    return;
                }
                else Search_Label.Text = "Searching...";

                QueryLookUp(@"Select * FROM ContactMobile WHERE" +
                "(FirstName LIKE '%" + SearchBox_TB.Text + "%') OR " +
                "(LastName LIKE '%" + SearchBox_TB.Text + "%') OR " +
                "(Mobile LIKE '%" + SearchBox_TB.Text + "%') OR " +
                "(Email LIKE '%" + SearchBox_TB.Text + "%') OR " +
                "(Catagory LIKE '%" + SearchBox_TB.Text + "%')");

                // Change search box label if exact match found
                if (SearchBox_TB.Text.ToLower() == dataGridView1.Rows[0].Cells[1].Value.ToString().ToLower()) Search_Label.Text = "First name FOUND";
                if (SearchBox_TB.Text.ToLower() == dataGridView1.Rows[0].Cells[2].Value.ToString().ToLower()) Search_Label.Text = "Last name FOUND";
                if (SearchBox_TB.Text.ToLower() == dataGridView1.Rows[0].Cells[3].Value.ToString().ToLower()) Search_Label.Text = "Mobile FOUND";
                if (SearchBox_TB.Text.ToLower() == dataGridView1.Rows[0].Cells[4].Value.ToString().ToLower()) Search_Label.Text = "Email FOUND";
                if (SearchBox_TB.Text.ToLower() == dataGridView1.Rows[0].Cells[5].Value.ToString().ToLower()) Search_Label.Text = "Catagory FOUND";
            }
            catch
            {
                // Do Nothing
            }
        }

        private void IDSearch_TB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(IDSearch_TB.Text) || string.IsNullOrWhiteSpace(IDSearch_TB.Text))
                {
                    QueryLookUp("Select * From ContactMobile");
                    IDNotFound_Label.Text = "Search by id";
                    return;
                }
                else IDNotFound_Label.Text = "Searching...";
                QueryLookUp("SELECT * FROM ContactMobile WHERE ID = " + IDSearch_TB.Text);
                // Change id search box label if exact match found
                if (IDSearch_TB.Text == dataGridView1.Rows[0].Cells[0].Value.ToString()) IDNotFound_Label.Text = "ID FOUND";
            }
            catch
            {
                // Do Nothing
            }
        }
        #endregion
    }
}
