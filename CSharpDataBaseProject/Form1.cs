using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpDataBaseProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        int selectedRowIndex;
        DataGridViewRow row;

        private void Form1_Load(object sender, EventArgs e)
        {
            gbCustomer.Visible = false;
            gbOrders.Visible = false;
            gbBook.Visible = true;

            string connStr = "server=localhost;port=3306;database=my_db;uid=root;pwd=youwjdghk0.;allow user variables=true;";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM book", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "book");
            dataGridView1.DataSource = dataSet.Tables["book"];

            SetSearchComboBox();
        }

        #region 콤보 박스 채우기
        private void SetSearchComboBox()
        {
            string sql = "SELECT distinct publisher FROM book";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // publisher 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbPublisher.Items.Add(reader.GetString("publisher"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region table 변경
        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            gbCustomer.Visible = false;
            gbOrders.Visible = false;
            gbBook.Visible = true;

            TableChangedDataset("book");
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            gbBook.Visible = false;
            gbOrders.Visible = false;
            gbCustomer.Visible = true;

            TableChangedDataset("customer");
        }

        private void rbOrders_CheckedChanged(object sender, EventArgs e)
        {
            gbBook.Visible = false;
            gbCustomer.Visible = false;
            gbOrders.Visible = true;

            TableChangedDataset("orders");
        }

        private void TableChangedDataset(string table)
        {
            dataAdapter = new MySqlDataAdapter("SELECT * FROM " + table, conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, table);
            dataGridView1.DataSource = dataSet.Tables[table];
        }
        #endregion


        #region select
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gbBook.Visible)
            {
                #region select book
                
                string queryStr;
                
                string[] conditions = new string[5];
                conditions[0] = (tbBookid.Text != "") ? "bookid=@bookid" : null;
                conditions[1] = (tbBookName.Text != "") ? "bookname=@bookname" : null;
                conditions[2] = (cbPublisher.Text != "") ? "publisher=@publisher" : null;
                conditions[3] = (tbPrice.Text != "") ? "price=@price" : null;

                queryStr = SelectQueryString("book", conditions);

                dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@bookid", tbBookid.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@bookname", tbBookName.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@publisher", cbPublisher.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@price", tbPrice.Text);

                SelectDataset("book");
                #endregion
            }
            else if (gbCustomer.Visible)
            {
                #region select customer
                string queryStr;
                
                string[] conditions = new string[5];
                conditions[0] = (tbCustid.Text != "") ? "custid=@custid" : null;
                conditions[1] = (tbCustname.Text != "") ? "name=@name" : null;
                conditions[2] = (tbAddress.Text != "") ? "address=@address" : null;
                conditions[3] = (mtbPhone.Text != "") ? "phone=@phone" : null;

                queryStr = SelectQueryString("customer", conditions);
                
                dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@custid", tbCustid.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@name", tbCustname.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@address", tbAddress.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@phone", mtbPhone.Text);

                SelectDataset("customer");
                #endregion
            }
            else
            {
                #region select orders
                string queryStr;
                
                string[] conditions = new string[5];
                conditions[0] = (tbCustid.Text != "") ? "orderid=@orderid" : null;
                conditions[1] = (tbCustname.Text != "") ? "custid=@custid" : null;
                conditions[2] = (tbAddress.Text != "") ? "bookid=@bookid" : null;
                conditions[3] = (mtbPhone.Text != "") ? "saleprice=@saleprice" : null;
                conditions[4] = (mtbPhone.Text != "") ? "orderdate=@orderdate" : null;

                queryStr = SelectQueryString("orders", conditions);
                
                dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@orderid", tbOrderId.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@custid", tbCustid.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@bookid", tbOBookid.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@saleprice", tbSaleprice.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@orderdate", mtbOrderdate.Text);

                SelectDataset("orders");
                #endregion
            }
        }

        private string SelectQueryString(string table, string[] conditions)
        {
            string queryStr;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)
            {
                queryStr = $"SELECT * FROM " + table + " WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM " + table;
            }

            return queryStr;
        }

        private void SelectDataset(string table)
        {
            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, table) > 0)
                    dataGridView1.DataSource = dataSet.Tables[table];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion

        #region insert
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (gbBook.Visible)
            {
                #region insert book

                int id = SelectLastId("book", "bookid");

                string queryStr = "INSERT INTO book (bookid, bookname, publisher, price) " +
                "VALUES(@bookid, @bookname, @publisher, @price)";
                dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.InsertCommand.Parameters.Add("@bookid", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@bookname", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@publisher", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@price", MySqlDbType.Int32);

                dataAdapter.InsertCommand.Parameters["@bookid"].Value = id;
                dataAdapter.InsertCommand.Parameters["@bookname"].Value = tbBookName.Text;
                dataAdapter.InsertCommand.Parameters["@publisher"].Value = cbPublisher.Text;
                dataAdapter.InsertCommand.Parameters["@price"].Value = tbPrice.Text;

                Dataset("book", "Insert");
                #endregion
            }
            else if (gbCustomer.Visible)
            {
                #region insert customer
                int id = SelectLastId("customer", "custid");

                string queryStr = "INSERT INTO customer (custid, name, address, phone) " +
                "VALUES(@custid, @name, @address, @phone)";
                dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.InsertCommand.Parameters.Add("@custid", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@name", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@address", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@phone", MySqlDbType.VarChar);

                dataAdapter.InsertCommand.Parameters["@custid"].Value = id;
                dataAdapter.InsertCommand.Parameters["@name"].Value = tbCustname.Text;
                dataAdapter.InsertCommand.Parameters["@address"].Value = tbAddress.Text;
                dataAdapter.InsertCommand.Parameters["@phone"].Value = mtbPhone.Text;

                Dataset("customer", "Insert");
                #endregion
            }
            else
            {
                #region insert orders
                int id = SelectLastId("orders", "orderid");

                string queryStr = "INSERT INTO orders (orderid, custid, bookid, saleprice, orderdate) " +
                "VALUES(@orderid, @custid, @bookid, @saleprice, @orderdate)";
                dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.InsertCommand.Parameters.Add("@orderid", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@custid", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@bookid", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@saleprice", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@orderdate", MySqlDbType.VarChar);

                dataAdapter.InsertCommand.Parameters["@orderid"].Value = id;
                dataAdapter.InsertCommand.Parameters["@custid"].Value = tbOCustid.Text;
                dataAdapter.InsertCommand.Parameters["@bookid"].Value = tbOBookid.Text;
                dataAdapter.InsertCommand.Parameters["@saleprice"].Value = tbSaleprice.Text;
                dataAdapter.InsertCommand.Parameters["@orderdate"].Value = mtbOrderdate.Text;

                Dataset("orders", "Insert");
                #endregion
            }
        }

        private int SelectLastId(string table, string idname)
        {
            string idSelectSql = "SELECT " + idname + " FROM " + table + " ORDER BY " + idname + " DESC LIMIT 1";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(idSelectSql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = (int)reader[idname];
            reader.Close();
            conn.Close();

            return ++id;
        }
        #endregion

        #region update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gbBook.Visible)
            {
                string sql = "UPDATE book SET bookname=@bookname, publisher=@publisher, price=@price WHERE bookid=@bookid";
                dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookid", tbBookid.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookname", tbBookName.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@publisher", cbPublisher.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@price", tbPrice.Text);

                Dataset("book", "Update");
            }
            else if (gbCustomer.Visible)
            {
                string sql = "UPDATE customer SET name=@name, address=@address, phone=@phone WHERE custid=@custid";
                dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@custid", tbCustid.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", tbCustname.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@address", tbAddress.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@phone", mtbPhone.Text);

                Dataset("customer", "Update");
            }
            else
            {
                string sql = "UPDATE orders SET custid=@custid, bookid=@bookid, saleprice=@saleprice, orderdate=@orderdate WHERE orderid=@orderid";
                dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@orderid", tbOrderId.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@custid", tbOCustid.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@bookid", tbOBookid.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@saleprice", tbSaleprice.Text);
                dataAdapter.UpdateCommand.Parameters.AddWithValue("@orderdate", mtbOrderdate.Text);

                Dataset("orders", "Update");
            }
            
        }
        
        #endregion

        #region delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gbBook.Visible)
            {
                string sql = "DELETE FROM book WHERE bookid=@bookid";
                dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapter.DeleteCommand.Parameters.AddWithValue("@bookid", row.Cells[0].Value.ToString());

                Dataset("book", "Delete");
            }
            else if (gbCustomer.Visible)
            {
                string sql = "DELETE FROM customer WHERE custid=@custid";
                dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapter.DeleteCommand.Parameters.AddWithValue("@custid", row.Cells[0].Value.ToString());

                Dataset("customer", "Delete");
            }
            else
            {
                string sql = "DELETE FROM orders WHERE orderid=@orderid";
                dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
                dataAdapter.DeleteCommand.Parameters.AddWithValue("@orderid", row.Cells[0].Value.ToString());

                Dataset("orders", "Delete");
            }
            TextboxClear();
        }


        #endregion

        private void Dataset(string table, string sql)
        {
            try
            {
                conn.Open();
                if (sql == "Insert")
                    dataAdapter.InsertCommand.ExecuteNonQuery();
                else if (sql == "Update")
                    dataAdapter.UpdateCommand.ExecuteNonQuery();
                else
                    dataAdapter.DeleteCommand.ExecuteNonQuery();
                dataSet.Clear();
                dataAdapter.Fill(dataSet, table);
                dataGridView1.DataSource = dataSet.Tables[table];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTextboxClear_Click(object sender, EventArgs e)
        {
            TextboxClear();
        }

        private void TextboxClear()
        {
            tbBookid.Clear();
            tbBookName.Clear();
            cbPublisher.Text = "";
            tbPrice.Clear();
            tbCustid.Clear();
            tbCustname.Clear();
            tbAddress.Clear();
            mtbPhone.Clear();
            tbOrderId.Clear();
            tbOCustid.Clear();
            tbOBookid.Clear();
            tbSaleprice.Clear();
            mtbOrderdate.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            row = dataGridView1.Rows[selectedRowIndex];

            if (gbBook.Visible)
            {
                if (!cbPublisher.Visible)
                {
                    cbPublisher.Visible = false;
                    cbPublisher.Visible = true;
                }
                tbBookid.Text = row.Cells[0].Value.ToString();
                tbBookName.Text = row.Cells[1].Value.ToString();
                cbPublisher.Text = row.Cells[2].Value.ToString();
                tbPrice.Text = row.Cells[3].Value.ToString();
            }
            else if (gbCustomer.Visible)
            {
                tbCustid.Text = row.Cells[0].Value.ToString();
                tbCustname.Text = row.Cells[1].Value.ToString();
                tbAddress.Text = row.Cells[2].Value.ToString();
                mtbPhone.Text = row.Cells[3].Value.ToString();
            }
            else
            {
                tbOrderId.Text = row.Cells[0].Value.ToString();
                tbOCustid.Text = row.Cells[1].Value.ToString();
                tbOBookid.Text = row.Cells[2].Value.ToString();
                tbSaleprice.Text = row.Cells[3].Value.ToString();
                mtbOrderdate.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
