using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using System.Text.RegularExpressions;

namespace TeNDA_Inventory_Management_System
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\antwi\Documents\TeNDAInventory.mdf;Integrated Security=True;Connect Timeout=30");

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    void populate()
        {
            Con.Open();
            String Userselect = "Select * From Users";
            SqlDataAdapter da = new SqlDataAdapter(Userselect, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            Display.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /** try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into User values ('" + fname.Text + "', '" + username.Text + "', '" + pass.Text + "', '" + email.Text + "', '" + contacts.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                Con.Close();
            }

            catch
            {
                
            } **/

        }

        //User data delation
        private void edit_Click(object sender, EventArgs e)
        {
            if(contacts.Text == "")
            {
                MessageBox.Show("Please The Users Contact Number");
            }
            else
            {
                Con.Open();
                String myquery = "Delete from Users where Contact= '"+contacts.Text+"';";
                SqlCommand sqlCommand= new SqlCommand(myquery, Con);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("User Successfully Delated");
                Con.Close();
                populate();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (contacts.Text != "" && email.Text != "" && pass.Text != "" && username.Text != "" && fname.Text != "")
            {
                try { 
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Users (Fullname, Username, Password, Email, Contact) values ('" + contacts.Text + "', '" + email.Text + "', '" + pass.Text + "', '" + username.Text + "', '" + fname.Text + "')", Con);
                        fname.Text = "Fullname";
                        username.Text = "Username";
                        pass.Text = "Password";
                        email.Text = "Email";
                        contacts.Text = "Contact";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Added Successfully");
                        Con.Close();
                        populate();

                        contacts.Text = "";
                        email.Text = "";
                        pass.Text = "";
                        username.Text = "";
                        fname.Text = "";
                    }

                catch
                {
                    
                }


            }


            else
            {
                MessageBox.Show("Some fields empty");
            }


        }

        private void deleteedit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update Users set Contact='" + contacts.Text + "', Email= '" + email.Text + "', Password= '" + pass.Text + "', Fullname= '" + fname.Text + "' Where Username= '" + username.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                populate();

            }
            catch 
            {
               
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teNDAInventoryDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.teNDAInventoryDataSet.Users);
            populate();
        }

        private void Display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fname.Text = Display.SelectedRows[0].Cells[0].Value.ToString();
            username.Text = Display.SelectedRows[0].Cells[1].Value.ToString();
            pass.Text = Display.SelectedRows[0].Cells[2].Value.ToString();
            email.Text = Display.SelectedRows[0].Cells[3].Value.ToString();
            contacts.Text = Display.SelectedRows[0].Cells[4].Value.ToString();

        }
    }
}
