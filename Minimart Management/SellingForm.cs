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
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace Minimart_Management
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        DBConnect dbConnect = DBConnect.getInstance();
        DGVPrinter printer = new DGVPrinter();
        private void getCategory()
        {
            string selectQuery = "SELECT * FROM category";
            SqlCommand command = new SqlCommand(selectQuery, dbConnect.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Selling_combobox.DataSource = dt;
            Selling_combobox.ValueMember = "CatName";
           
        }
        private void getTable()
        {
            string selectQuery = "SELECT ProdName, ProdPrice FROM product";
            SqlCommand command = new SqlCommand(selectQuery, dbConnect.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }
        private void getSellTable()
        {
            string selectQuery = "SELECT * FROM Bill";
            SqlCommand command = new SqlCommand(selectQuery, dbConnect.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView2.DataSource = dt;
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_Date.Text = DateTime.Today.ToShortDateString();
            label_Seller.Text = LoginForm.sellerName;
            getCategory();
            getTable();
            getSellTable();
             
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            SellingName_Textbox.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SellingPrice_Textbox.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();

        }
        int grandTotal = 0, n = 0;

        private void Add_label_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Bill VALUES (" + TextBox_Id.Text + ",'" + label_Seller.Text + "','" + label_Date.Text + "'," + grandTotal.ToString()+") ";
                SqlCommand command = new SqlCommand(insertQuery, dbConnect.Getcon());
                dbConnect.Opencon();
                command.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Order Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConnect.Closecon();
                getSellTable();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Print_label_Click(object sender, EventArgs e)
        {
            printer.Title = "Cyclop Minimart Sell Lists";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Cyclop";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape=true;
            printer.PrintDataGridView(guna2DataGridView2);
        }

        private void labe_logout_MouseEnter(object sender, EventArgs e)
        {
            labe_logout.ForeColor = Color.Orange;
        }

        private void labe_logout_MouseLeave(object sender, EventArgs e)
        {
            labe_logout.ForeColor = Color.Black;
        }

        private void labe_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Black;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Add_Order_MouseEnter(object sender, EventArgs e)
        {
            Add_Order.ForeColor = Color.Orange;
        }

        private void Add_Order_MouseLeave(object sender, EventArgs e)
        {
            Add_Order.ForeColor = Color.Black;
        }

        private void Add_label_MouseEnter(object sender, EventArgs e)
        {
            Add_label.ForeColor = Color.Orange;
        }

        private void Add_label_MouseLeave(object sender, EventArgs e)
        {
            Add_label.ForeColor = Color.Black;
        }

        private void Print_label_MouseEnter(object sender, EventArgs e)
        {
            Print_label.ForeColor = Color.Orange;
        }

        private void Print_label_MouseLeave(object sender, EventArgs e)
        {
            Print_label.ForeColor = Color.Black;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void Selling_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT ProdName, ProdPrice FROM product WHERE ProdCat='" + Selling_combobox.SelectedValue.ToString() + "'";
            SqlCommand command = new SqlCommand(selectQuery, dbConnect.Getcon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void Add_Order_Click(object sender, EventArgs e)
        {
            if (SellingName_Textbox.Text == "" || SellingQty_Textbox.Text == "")
            {
                MessageBox.Show("Please fill in the Box","Information Missing",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Total = Convert.ToInt32(SellingPrice_Textbox.Text) * Convert.ToInt32(SellingQty_Textbox.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(guna2DataGridView_Seller);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = SellingName_Textbox.Text;
                addRow.Cells[2].Value = SellingPrice_Textbox.Text;
                addRow.Cells[3].Value = SellingQty_Textbox.Text;
                addRow.Cells[4].Value = Total;
                guna2DataGridView_Seller.Rows.Add(addRow);
                grandTotal += Total;
                currency_label.Text = grandTotal + "$";
            }
        }
    }
}
