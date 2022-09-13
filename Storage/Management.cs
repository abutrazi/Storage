using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage.Classes;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Collections;





namespace Storage
{
    public partial class Management : Form
    {

        //variables
        private DBSQL dataB;
        private int Qty, Supid, Odid, Msgoc, Uoc, count, price, compid, Oc;


        public Management()
        {
            InitializeComponent();
        }
        
        //Main form Load
        private void Management_Load(object sender, EventArgs e)
        {
            string dbPath = Application.StartupPath + @"\..\..\Storage.accdb";
            if (File.Exists(dbPath))
            {
                DBSQL.ConnectionString = dbPath;
                dataB = DBSQL.Instance;
            }
            else
            {
                MessageBox.Show("Database" + dbPath + " not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            ucEmployeeManagement.Hide();
            ucProductManagement.Hide();
            register.Hide();
            login.Hide();
            products.Hide();
            actions.Hide();
            ucSupplierManagement.Hide();
            orderDetails.Hide();
            updateOrder.Hide();
            allOrders.Hide();
            settings.Hide();
            statics.Hide();
            Home_Load();
            Register_Load();
            Login_Load();
            UCEmployee_Load();
            UCProduct_Load();
            UCSupplier_Load();
            Message_Load();
            OrderDeatails_Load();
            Products_Load();
            UpdateOrder_Load();
            AllOrders_Load();
            Settings_Load();
            Statics_Load();
        }

        /*Register UC Events Start*/
        public void Register_Load()
        {
            register.OnclickRegister += Register_onclickInsetEmployee;
        }
        //Button that insert new Employee
        private void Register_onclickInsetEmployee(object sender, EventArgs e)
        {
            if (register.tbid.Text == "" || register.tbFName.Text == "" || register.tbLName.Text == "" || register.tbTel.Text == "" ||
                register.tbEMAIL.Text == "" || register.tbAdd.Text == "" || register.tbUserName.Text == "" || register.tbPass1.Text == "" ||
                register.tbPass2.Text == "" || register.tbCompName.Text == "" || register.tbCompEmail.Text == "" || register.tbCompPass.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(register.tbid.Text) == 1 || CheckNumber(register.tbTel.Text) == 1)
            {
                MessageBox.Show("Enter Just numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (register.tbid.Text.Length != 9)
            {
                MessageBox.Show("ID must be 9 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (register.tbTel.Text.Length != 10)
            {
                MessageBox.Show("Telphone must be 10 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IsValidEmail(register.tbEMAIL.Text) == 0)
            {
                MessageBox.Show("Email Format is incorrect!!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (register.tbPass1.Text != register.tbPass2.Text)
            {
                MessageBox.Show("The two password's that you entered does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IsValidEmail(register.tbCompEmail.Text) == 0)
            {
                MessageBox.Show("Comapny Email Format is incorrect!!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Employee emp = new Employee(int.Parse(register.tbid.Text), register.tbFName.Text, register.tbLName.Text, register.tbTel.Text, register.tbEMAIL.Text,
                register.tbAdd.Text, register.tbUserName.Text, (register.tbPass1.Text), "Admin",true);
                dataB.InsertEmployee(emp);
                Company comp = new Company(register.tbCompName.Text, register.tbCompEmail.Text, register.tbCompPass.Text);
                dataB.InsertCompany(comp);
                MessageBox.Show("Employee inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            ResetAlltb();
            register.Hide();
            login.Show();
            login.BringToFront();
        }
        //Function to rest all text boxes
        private void ResetAlltb()
        {
            register.tbid.Text = "";
            register.tbFName.Text = "";
            register.tbLName.Text = "";
            register.tbTel.Text = "";
            register.tbEMAIL.Text = "";
            register.tbAdd.Text = "";
            register.tbUserName.Text = "";
            register.tbPass1.Text = "";
            register.tbPass2.Text = "";
        }

        /*Register UC events Ends*/

        /*Login UC events start*/
        public void Login_Load()
        {
            login.OnclickLogin += Login_onclickLogin;
        }
        private void Login_onclickLogin(object sender, EventArgs e)
        {
            if (login.tbUserName.Text == "" || login.tbPassWord.Text == "")
            {
                MessageBox.Show("Please fill all fiels!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int res = dataB.LoginCheck(login.tbUserName.Text, (login.tbPassWord.Text));
                if (res == 1)
                {
                    string admin = dataB.CheckAdmin(login.tbUserName.Text, (login.tbPassWord.Text))[0].EmpRole.ToString();
                    if (admin == "Storekeeper")
                    {
                        employeeToolStripMenuItem.Visible = false;
                        addDelUpdateToolStripMenuItem.Visible = false;
                        orderToolStripMenuItem.Visible = false;
                        suppliersToolStripMenuItem.Visible = false;
                        messagesToolStripMenuItem.Visible = false;
                        reportsToolStripMenuItem.Visible = false;
                        settingsToolStripMenuItem.Visible = false;
                        staticsToolStripMenuItem.Visible = false;
                    }
                    else if (admin == "Secretary")
                    {
                        employeeToolStripMenuItem.Visible = false;
                        settingsToolStripMenuItem.Visible = false;
                    }
                    else 
                    {
                        RefreshMSG();
                        if (dataB.SelectAllProductToOrder().Length > 0)
                        {
                            AutoOrder();
                            FillMsgs(dataB.GetNewMsgs());
                            ucMessage.Show();
                            ucMessage.BringToFront();
                        }
                    }
                    actions.Show();
                    actions.BringToFront();
                }
                else
                {
                    MessageBox.Show("The UserName or Password is Wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     login.tbPassWord.Text = "";
                    return;
                }
               
                msActions.Visible = true;
            }
        }

        /*Login UC events Ends*/

        /*Home Events Start*/
        public void Home_Load()
        {
            msActions.Visible = false;
            try
            {
                if (dataB.SelectAllEmployees().Length == 0)
                {
                    register.Show();
                    register.BringToFront();
                    login.Hide();
                }
                else
                {
                    login.Show();
                    login.BringToFront();
                    register.Hide();
                }
            }
            catch
            {
                return;
            }
        }

        /*Home events Ends*/
        /**************************************/
        /*Employee  UC Events - Start */

        //Function that fill Employee data grid view
        private void FillEmployees()
        {
            Employee[] empArr = dataB.SelectAllEmployees();
            ucEmployeeManagement.DgvEmployees.RowCount = empArr.Length;
            ucEmployeeManagement.DgvEmployees.ColumnCount = 9;
            ucEmployeeManagement.DgvEmployees.Columns[0].HeaderText = "ID";
            ucEmployeeManagement.DgvEmployees.Columns[1].HeaderText = "First Name";
            ucEmployeeManagement.DgvEmployees.Columns[2].HeaderText = "Last Name";
            ucEmployeeManagement.DgvEmployees.Columns[3].HeaderText = "Telphone";
            ucEmployeeManagement.DgvEmployees.Columns[4].HeaderText = "Email";
            ucEmployeeManagement.DgvEmployees.Columns[5].HeaderText = "Address";
            ucEmployeeManagement.DgvEmployees.Columns[6].HeaderText = "UserName";
            ucEmployeeManagement.DgvEmployees.Columns[7].HeaderText = "Password";
            ucEmployeeManagement.DgvEmployees.Columns[8].HeaderText = "Role";
            ucEmployeeManagement.DgvEmployees.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucEmployeeManagement.DgvEmployees.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucEmployeeManagement.DgvEmployees.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucEmployeeManagement.DgvEmployees.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucEmployeeManagement.DgvEmployees.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucEmployeeManagement.DgvEmployees.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucEmployeeManagement.DgvEmployees.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucEmployeeManagement.DgvEmployees.Columns[7].Visible = false;
            ucEmployeeManagement.DgvEmployees.Columns[8].Visible = false;
            for (int i = 0; i < empArr.Length; i++)
            {
                ucEmployeeManagement.DgvEmployees[0, i].Value = empArr[i].EmpID;
                ucEmployeeManagement.DgvEmployees[1, i].Value = empArr[i].EmpFname;
                ucEmployeeManagement.DgvEmployees[2, i].Value = empArr[i].EmpLname;
                ucEmployeeManagement.DgvEmployees[3, i].Value = empArr[i].EmpTel;
                ucEmployeeManagement.DgvEmployees[4, i].Value = empArr[i].EmpEmail;
                ucEmployeeManagement.DgvEmployees[5, i].Value = empArr[i].EmpAddress;
                ucEmployeeManagement.DgvEmployees[6, i].Value = empArr[i].EmpUsername;
                ucEmployeeManagement.DgvEmployees[7, i].Value = empArr[i].EmpPassword;
                ucEmployeeManagement.DgvEmployees[8, i].Value = empArr[i].EmpRole;
            }
        }
        //Employee UC Load
        public void UCEmployee_Load()
        {
            FillEmployees();
            ucEmployeeManagement.OnclickInsertEmployee += UcEmployeeManagement_onclickInsetEmployee;
            ucEmployeeManagement.OnclickUpdateEmployee += UcEmployeeManagement_onclickUpdateEmployee;
            ucEmployeeManagement.OnClickDeleteEmployee += UcEmployeeManagement_onclickDeleteEmployee;
            ucEmployeeManagement.CellDoubleClick += UcEmployeeManagement_CellDoubleClick;
            ucEmployeeManagement.OnClickResetTbs += UcEmployeeManagemet_onclicResetTbs;
        }
        //button that insaert Employee(button)
        private void UcEmployeeManagement_onclickInsetEmployee(object sender, EventArgs e)
        {
            checktextbox1();
        }
        //Function to check data of text boxes 1
        private void checktextbox1()
        {
            if (ucEmployeeManagement.tbId.Text == "" || ucEmployeeManagement.tbFname.Text == "" || ucEmployeeManagement.tbLname.Text == "" ||
                 ucEmployeeManagement.tbTel.Text == "" || ucEmployeeManagement.tbEmail.Text == "" || ucEmployeeManagement.tbAddress.Text == "" ||
                 ucEmployeeManagement.tbUsername.Text == "" || ucEmployeeManagement.tbPassword.Text == "" || ucEmployeeManagement.cbRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(ucEmployeeManagement.tbId.Text) == 1 || int.Parse(ucEmployeeManagement.tbId.Text) < 0)
            {
                MessageBox.Show("ID Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucEmployeeManagement.tbId.Text = "";
                return;
            }
            else if (dataB.CheckID(int.Parse(ucEmployeeManagement.tbId.Text)) == 1)
            {
                MessageBox.Show("ID Already Exists!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucEmployeeManagement.tbId.Text = "";
                return;
            }
            else if (ucEmployeeManagement.tbId.Text.Length != 9)
            {
                MessageBox.Show("ID must be 9 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucEmployeeManagement.tbId.Text = "";
                return;
            }
            else
            {
                checktextbox2();
            }
        }
        //Function to check data of text boxes 2
        private void checktextbox2()
        {
             if (CheckNumber(ucEmployeeManagement.tbTel.Text) == 1)
            {
                MessageBox.Show("Enter Just numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucEmployeeManagement.tbTel.Text = "";
                return;
            }
            else if (ucEmployeeManagement.tbTel.Text.Length != 10)
            {
                MessageBox.Show("Telphone must be 10 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucEmployeeManagement.tbTel.Text = "";
                return;
            }
            else if (IsValidEmail(ucEmployeeManagement.tbEmail.Text) == 0)
            {
                MessageBox.Show("Email Format is incorrect!!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dataB.CheckUsername(ucEmployeeManagement.tbUsername.Text) == 1)
            {
                MessageBox.Show("Choose another UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucEmployeeManagement.tbUsername.Text = "";
                return;
            }
            else
            {
                addemployee();
            }
            ResetEmployeeTbs();
            FillEmployees();
        }
        //Function to add new employee(help)
        private void addemployee()
        {
            Employee emp = new Employee(int.Parse(ucEmployeeManagement.tbId.Text), ucEmployeeManagement.tbFname.Text, ucEmployeeManagement.tbLname.Text,
                                            ucEmployeeManagement.tbTel.Text, ucEmployeeManagement.tbEmail.Text, ucEmployeeManagement.tbAddress.Text,
                                            ucEmployeeManagement.tbUsername.Text, (ucEmployeeManagement.tbPassword.Text), ucEmployeeManagement.cbRole.Text,true);
            dataB.InsertEmployee(emp);
            MessageBox.Show("Employee inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //button that update an Employee info(button)
        private void UcEmployeeManagement_onclickUpdateEmployee(object sender, EventArgs e)
        {
            if (ucEmployeeManagement.tbId.Text == "" || ucEmployeeManagement.tbFname.Text == "" || ucEmployeeManagement.tbLname.Text == "" ||
                 ucEmployeeManagement.tbTel.Text == "" || ucEmployeeManagement.tbEmail.Text == "" || ucEmployeeManagement.tbAddress.Text == "" ||
                 ucEmployeeManagement.tbUsername.Text == "" || ucEmployeeManagement.tbPassword.Text == "" || ucEmployeeManagement.cbRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(ucEmployeeManagement.tbId.Text) == 1 || int.Parse(ucEmployeeManagement.tbId.Text) < 0)
            {
                MessageBox.Show("ID Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucEmployeeManagement.tbId.Text = "";
                return;
            }
            else if (ucEmployeeManagement.tbId.Text.Length != 9)
            {
                MessageBox.Show("ID must be 9 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(ucEmployeeManagement.tbTel.Text) == 1)
            {
                MessageBox.Show("Enter Just numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ucEmployeeManagement.tbTel.Text.Length != 10)
            {
                MessageBox.Show("Telphone must be 10 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IsValidEmail(ucEmployeeManagement.tbEmail.Text) == 0)
            {
                MessageBox.Show("Email Format is incorrect!!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                updateemployee();
            }
            ResetEmployeeTbs();
            FillEmployees();
        }
        //Function to update employee
        private void updateemployee()
        {
            Employee emp = new Employee(int.Parse(ucEmployeeManagement.tbId.Text), ucEmployeeManagement.tbFname.Text, ucEmployeeManagement.tbLname.Text,
                                            ucEmployeeManagement.tbTel.Text, ucEmployeeManagement.tbEmail.Text, ucEmployeeManagement.tbAddress.Text,
                                            ucEmployeeManagement.tbUsername.Text, (ucEmployeeManagement.tbPassword.Text), ucEmployeeManagement.cbRole.Text,true);
            dataB.UpdateEmployee(emp, int.Parse(ucEmployeeManagement.tbId.Text));
            MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //button that delete an Employee(button)
        private void UcEmployeeManagement_onclickDeleteEmployee(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ucEmployeeManagement.tbId.Text == "")
                {
                    MessageBox.Show("Couldn't delete Employee, ID is not defined!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(ucEmployeeManagement.cbRole.Text=="Admin")
                {
                    MessageBox.Show("Couldn't delete this Employee !!,this is the Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataB.DeleteEmployee(int.Parse(ucEmployeeManagement.tbId.Text));
                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetEmployeeTbs();
                FillEmployees();
            }
            else
            {
                return;
            }
            FillEmployees();
        }
        //button that reset text boxes  (button)
        private void UcEmployeeManagemet_onclicResetTbs(object sender, EventArgs e)
        {
            ResetEmployeeTbs();
        }
        //Function that reset all Employee text boxs
        private void ResetEmployeeTbs()
        {
            ucEmployeeManagement.tbId.Text = "";
            ucEmployeeManagement.tbFname.Text = "";
            ucEmployeeManagement.tbLname.Text = "";
            ucEmployeeManagement.tbTel.Text = "";
            ucEmployeeManagement.tbEmail.Text = "";
            ucEmployeeManagement.tbAddress.Text = "";
            ucEmployeeManagement.tbUsername.Text = "";
            ucEmployeeManagement.tbPassword.Text = "";
            ucEmployeeManagement.cbRole.Text = "Choose Role";
        }
        //Double Click on cell fill all text boxes (Employee test box's )
        private void UcEmployeeManagement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ucEmployeeManagement.DgvEmployees.CurrentRow.Selected = true;
            ucEmployeeManagement.tbId.Text = ucEmployeeManagement.DgvEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
            ucEmployeeManagement.tbFname.Text = ucEmployeeManagement.DgvEmployees.Rows[e.RowIndex].Cells[1].Value.ToString();
            ucEmployeeManagement.tbLname.Text = ucEmployeeManagement.DgvEmployees.Rows[e.RowIndex].Cells[2].Value.ToString();
            ucEmployeeManagement.tbTel.Text = ucEmployeeManagement.DgvEmployees.Rows[e.RowIndex].Cells[3].Value.ToString();
            ucEmployeeManagement.tbEmail.Text = ucEmployeeManagement.DgvEmployees.Rows[e.RowIndex].Cells[4].Value.ToString();
            ucEmployeeManagement.tbAddress.Text = ucEmployeeManagement.DgvEmployees.Rows[e.RowIndex].Cells[5].Value.ToString();
            ucEmployeeManagement.tbUsername.Text = ucEmployeeManagement.DgvEmployees.Rows[e.RowIndex].Cells[6].Value.ToString();
            ucEmployeeManagement.tbPassword.Text = ucEmployeeManagement.DgvEmployees.Rows[e.RowIndex].Cells[7].Value.ToString();
            ucEmployeeManagement.cbRole.Text = ucEmployeeManagement.DgvEmployees.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        /*Employee UC Events - End*/
        /***********************************/

        /*Product Managemnet UC Events Start*/
        public void UCProduct_Load()
        {
            FillProducts(dataB.SelectAllProducts());
            ucProductManagement.OnClickInsertProduct += UcProductManagement_onclickInsertProduct;
            ucProductManagement.OnClickDeleteProduct += UcProductManagement_onclickDeleteProduct;
            ucProductManagement.OnClickUpdateProduct += UcProductManagement_onclickUpdateeProduct;
            ucProductManagement.OnClickResetTbs += UcProductManagement_onclicRestTbs;
            ucProductManagement.CellDoubleClick += UcProductManagement_CellDoubleClick;
            ucProductManagement.OnClickSupp += UcProductManagement_OnlClickProdSuppl;
            ucProductManagement.SelectedIndexSupplier += UcProductManagement_SelectIndex;
            ucProductManagement.OnClickShowAll += UcProductMangement_OnClickShowAll;
        }
        //Function that fill products dta grid view
        private void FillProducts(Product[] prodArr) 
        {
            ucProductManagement.DgvProduct.RowCount = prodArr.Length;
            ucProductManagement.DgvProduct.ColumnCount = 7;
            ucProductManagement.DgvProduct.Columns[0].HeaderText = "Code";
            ucProductManagement.DgvProduct.Columns[1].HeaderText = "Name";
            ucProductManagement.DgvProduct.Columns[2].HeaderText = "Size";
            ucProductManagement.DgvProduct.Columns[3].HeaderText = "Price";
            ucProductManagement.DgvProduct.Columns[4].HeaderText = "Amount";
            ucProductManagement.DgvProduct.Columns[5].HeaderText = "MinQty";
            ucProductManagement.DgvProduct.Columns[6].HeaderText = "Supplier Name";
            ucProductManagement.DgvProduct.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucProductManagement.DgvProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucProductManagement.DgvProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucProductManagement.DgvProduct.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucProductManagement.DgvProduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucProductManagement.DgvProduct.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucProductManagement.DgvProduct.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 0; i < prodArr.Length; i++)
            {
                ucProductManagement.DgvProduct[0, i].Value = prodArr[i].ProdCode;
                ucProductManagement.DgvProduct[1, i].Value = prodArr[i].ProdName;
                ucProductManagement.DgvProduct[2, i].Value = prodArr[i].ProdSize;
                ucProductManagement.DgvProduct[3, i].Value = prodArr[i].ProdPrice;
                ucProductManagement.DgvProduct[4, i].Value = prodArr[i].ProdAmount;
                ucProductManagement.DgvProduct[5, i].Value = prodArr[i].MinQty;
                ucProductManagement.DgvProduct[6, i].Value = dataB.GetSupplierName(prodArr[i].SupplierCode);

            }
        } 
        //Button that insert product(button)
        private void UcProductManagement_onclickInsertProduct(object sender, EventArgs e)
        {
            if (ucProductManagement.tbCode.Text == "" || ucProductManagement.tbName.Text == "" ||
                ucProductManagement.tbSize.Text == "" || ucProductManagement.tbPrice.Text == "" || ucProductManagement.tbMinQty.Text == "" ||
                ucProductManagement.cbSupplierName.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(ucProductManagement.tbCode.Text) == 1 || CheckNumber(ucProductManagement.tbPrice.Text) == 1 ||
                CheckNumber(ucProductManagement.tbMinQty.Text) == 1)
            {
                MessageBox.Show("You Must Enter A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(dataB.CheckProd(int.Parse(ucProductManagement.tbCode.Text))==1)
            {
                MessageBox.Show("This Product's code exist you must to change it !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.Parse(ucProductManagement.tbCode.Text) < 0 || int.Parse(ucProductManagement.tbPrice.Text) < 0 ||
                      int.Parse(ucProductManagement.tbMinQty.Text) < 0)
            {
                MessageBox.Show("You Must Enter A Positive Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                addproduct();
            }
            FillProducts(dataB.SelectAllProducts());
            RestproductTbs();
        }
        //Function to add new product
        private void addproduct()
        {
            int x = dataB.SelectAllSupplier()[ucProductManagement.cbSupplierName.SelectedIndex].SupCode;
            Product prod = new Product(int.Parse(ucProductManagement.tbCode.Text), ucProductManagement.tbName.Text,
                                       ucProductManagement.tbSize.Text, int.Parse(ucProductManagement.tbPrice.Text), 0,
                                       int.Parse(ucProductManagement.tbMinQty.Text), x);
            dataB.InsertProd(prod);
            MessageBox.Show("Product inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Button that delete product(button)
        private void UcProductManagement_onclickDeleteProduct(object sender, EventArgs e)
        {
            if (ucProductManagement.tbCode.Text == "" || ucProductManagement.tbName.Text == "" ||
               ucProductManagement.tbSize.Text == "" || ucProductManagement.tbPrice.Text == "" ||
               ucProductManagement.tbMinQty.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (MessageBox.Show("Are you sure you want to delete this Product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                dataB.DeleteProduct(int.Parse(ucProductManagement.tbCode.Text));
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestproductTbs();
                FillProducts(dataB.SelectAllProducts());
            }
            else
            {
                return;
            }

        }
        //Button that Update product(button)
        private void UcProductManagement_onclickUpdateeProduct(object sender, EventArgs e)
        {
            if (ucProductManagement.tbCode.Text == "" || ucProductManagement.tbName.Text == "" ||
                ucProductManagement.tbSize.Text == "" || ucProductManagement.tbPrice.Text == "" || ucProductManagement.tbMinQty.Text == ""
                || ucProductManagement.cbSupplierName.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(ucProductManagement.tbCode.Text) == 1 || CheckNumber(ucProductManagement.tbPrice.Text) == 1 ||
                CheckNumber(ucProductManagement.tbMinQty.Text) == 1)
            {
                MessageBox.Show("You Must Enter A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.Parse(ucProductManagement.tbCode.Text) < 0 || int.Parse(ucProductManagement.tbPrice.Text) < 0 ||
                      int.Parse(ucProductManagement.tbMinQty.Text) < 0)
            {
                MessageBox.Show("The Number Must be non-negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                updateproduct();
            }
            FillProducts(dataB.SelectAllProducts());
            RestproductTbs();
        }
        //Function to update product
        private void updateproduct()
        {
            int x = dataB.SelectAllSupplier()[ucProductManagement.cbSupplierName.SelectedIndex].SupCode;
            Product prod = new Product(int.Parse(ucProductManagement.tbCode.Text), ucProductManagement.tbName.Text,
                                       ucProductManagement.tbSize.Text, int.Parse(ucProductManagement.tbPrice.Text), Qty,
                                       int.Parse(ucProductManagement.tbMinQty.Text), x);
            dataB.UpdateProduct(prod, int.Parse(ucProductManagement.tbCode.Text));
            MessageBox.Show("Product Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Function to reset text boxes(button)
        private void UcProductManagement_onclicRestTbs(object sender, EventArgs e)
        {
            RestproductTbs();
        }
        //Function that rest all product text boxes
        private void RestproductTbs()
        {
            ucProductManagement.tbCode.Text = "";
            ucProductManagement.tbName.Text = "";
            ucProductManagement.tbSize.Text = "";
            ucProductManagement.tbPrice.Text = "";
            ucProductManagement.tbMinQty.Text = "";
            ucProductManagement.cbSupplierName.Text = "Choose Supplier";
            ucProductManagement.cbSupplier.Text = "Choose Supplier";
            Qty = 0;

        }
        //Double Click on cell fill all text boxes(product text box's)//Double Click on cell fill all text boxes(product text box's)
        private void UcProductManagement_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ucProductManagement.DgvProduct.CurrentRow.Selected = true;
            ucProductManagement.tbCode.Text = ucProductManagement.DgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            ucProductManagement.tbName.Text = ucProductManagement.DgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            ucProductManagement.tbSize.Text = ucProductManagement.DgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            ucProductManagement.tbPrice.Text = ucProductManagement.DgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            Qty = int.Parse(ucProductManagement.DgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString());
            ucProductManagement.tbMinQty.Text = ucProductManagement.DgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            ucProductManagement.cbSupplierName.Text = ucProductManagement.DgvProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
        //function that prepares PDF doc (button)
        private void UcProductManagement_OnlClickProdSuppl(object sender, EventArgs e)
        {
            if (ucProductManagement.cbSupplier.SelectedItem == null)
            {
                MessageBox.Show("Choose Supplier!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PDF pdf = new PDF(@"C:\Users\Razi\Desktop\Storage\Storage\Storage\Reports\Supplier " + ucProductManagement.cbSupplier.SelectedItem.ToString());
                pdf.SetTitle("Supplier " + ucProductManagement.cbSupplier.SelectedItem.ToString());
                pdf.SetProductsTable(dataB.SelectOrderProduct(dataB.GetSupplierId(ucProductManagement.cbSupplier.SelectedItem.ToString())));
                pdf.CloseReport();
                MessageBox.Show("PDF file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ucProductManagement.cbSupplier.Text = "Choose Supplier";
            }
        }
       
       //function that fill products info by supplier
        private void UcProductManagement_SelectIndex(object sender, EventArgs e)
        {
            int sc = dataB.GetSupplierId(ucProductManagement.cbSupplier.SelectedItem.ToString());
            FillProducts(dataB.SelectAllProductsSup(sc));
        }
        //Function to show all products 
        private void UcProductMangement_OnClickShowAll(object sender,EventArgs e)
        {
            FillProducts(dataB.SelectAllProducts());
            ucProductManagement.cbSupplier.Text = "Choose Supplier";
        }
        /*Product Managment Uc Events End*/
        /**************************************/
        /*Product UC events start */

        //UC Products Load
        public void Products_Load()
        {
            FillProduct(dataB.SelectAllProducts());
            products.CellDoubleClickAmount += Products_CellDoubleClickAmount;
            products.OnClickSubmitAmount += Products_OnClickSubmitAmount;
            products.OnClickSearch += Poducts_OnClickSearch;
            products.OnClickShowAll += Poducts_OnClickShowAll;
        }
        //Button for import/export product by amount
        private void Products_OnClickSubmitAmount(object sender, EventArgs e)
        {
            if (products.tbCode.Text == "")
            {
                MessageBox.Show("Choose product to change amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!products.RbImport.Checked && !products.RbExport.Checked)
            {
                MessageBox.Show("Choose one actions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (products.tbAmount.Text == "")
            {
                MessageBox.Show("Enter the amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(products.tbAmount.Text) == 1 || int.Parse(products.tbAmount.Text) <= 0)
            {
                MessageBox.Show("The Amount Must Be A Positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                products.tbAmount.Text = "";
                return;
            }
            else
            {
                chechkaction();  
            }
            FillProduct(dataB.SelectAllProducts());
            RessetTb();
        }
        //function that check the action(help)
        private void chechkaction()
        {
            if (products.RbImport.Checked)
            {
                int x = dataB.GetSupplierId(products.DgvProduct.SelectedRows[0].Cells[6].Value.ToString());
                int res = int.Parse(products.tbAmount.Text) + (int)products.DgvProduct.SelectedRows[0].Cells[4].Value;
                Product p = new Product(int.Parse(products.tbCode.Text), products.tbName.Text, products.tbSize.Text,
                                int.Parse(products.DgvProduct.SelectedRows[0].Cells[3].Value.ToString()), res,
                                int.Parse(products.DgvProduct.SelectedRows[0].Cells[5].Value.ToString()),
                                x);
                dataB.UpdateProduct(p, int.Parse(products.tbCode.Text));
            }
            else
            {
                addtake();
            }
        }
        //Function add/take out (help)
        private void addtake()
        {
                if ((int)products.DgvProduct.SelectedRows[0].Cells[4].Value < int.Parse(products.tbAmount.Text))
                {
                    MessageBox.Show("There is not Enough quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    products.tbAmount.Text = "";
                    return;
                }
                else
                {
                    int x = dataB.GetSupplierId(products.DgvProduct.SelectedRows[0].Cells[6].Value.ToString());
                    int res = (int)products.DgvProduct.SelectedRows[0].Cells[4].Value - int.Parse(products.tbAmount.Text);
                    Product p = new Product(int.Parse(products.tbCode.Text), products.tbName.Text, products.tbSize.Text,
                                    int.Parse(products.DgvProduct.SelectedRows[0].Cells[3].Value.ToString()), res,
                                    int.Parse(products.DgvProduct.SelectedRows[0].Cells[5].Value.ToString()),
                                   x);
                    if (res <= int.Parse(products.DgvProduct.SelectedRows[0].Cells[5].Value.ToString()))
                    {
                        MessageBox.Show("Product's Amount is under min qty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataB.AddProdToOrder(p);
                    }
                    dataB.UpdateProduct(p, int.Parse(products.tbCode.Text));
                }
        }
        //Double Click on cell fill all text boxes(product text box's)
        private void Products_CellDoubleClickAmount(object sender, DataGridViewCellEventArgs e)
        {
            products.DgvProduct.CurrentRow.Selected = true;
            products.tbCode.Text = products.DgvProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            products.tbName.Text = products.DgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            products.tbSize.Text = products.DgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        //Function to search product(Button)
        private void Poducts_OnClickSearch(object sender, EventArgs e)
        {
            if (products.tbSearch.Text == "")
            {
                MessageBox.Show("Fill info to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (products.cbSearchBy.SelectedItem == null)
            {
                MessageBox.Show("Choose option to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (products.cbSearchBy.SelectedItem.ToString() == "Code")
                {
                    if (CheckNumber(products.tbSearch.Text) == 1 || int.Parse(products.tbSearch.Text) < 0)
                    {
                        MessageBox.Show("The Code Must be  Positive Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        FillProduct(dataB.SearchByCode(int.Parse(products.tbSearch.Text)));
                    }
                }
                else
                {
                    FillProduct(dataB.SearchByName(products.tbSearch.Text));
                }
            }
        }
        //Function to show all products (button)
        private void Poducts_OnClickShowAll(object sender, EventArgs e)
        {
            FillProduct(dataB.SelectAllProducts());
            products.tbSearch.Text = "";
            products.cbSearchBy.Text = "chosse option";
        }
        //Fubnction to fill products info in data grid view
        private void FillProduct(Product[] pArr)
        {
            products.DgvProduct.RowCount = pArr.Length;
            products.DgvProduct.ColumnCount = 7;
            products.DgvProduct.Columns[0].HeaderText = "Code";
            products.DgvProduct.Columns[1].HeaderText = "Name";
            products.DgvProduct.Columns[2].HeaderText = "Size";
            products.DgvProduct.Columns[3].HeaderText = "Price";
            products.DgvProduct.Columns[4].HeaderText = "Amount";
            products.DgvProduct.Columns[5].HeaderText = "MinQty";
            products.DgvProduct.Columns[6].HeaderText = "Supplier Name";
            products.DgvProduct.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            products.DgvProduct.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            products.DgvProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            products.DgvProduct.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            products.DgvProduct.Columns[3].Visible = false;
            products.DgvProduct.Columns[5].Visible = false;
            products.DgvProduct.Columns[6].Visible = false;
            for (int i = 0; i < pArr.Length; i++)
            {
                products.DgvProduct[0, i].Value = pArr[i].ProdCode;
                products.DgvProduct[1, i].Value = pArr[i].ProdName;
                products.DgvProduct[2, i].Value = pArr[i].ProdSize;
                products.DgvProduct[3, i].Value = pArr[i].ProdPrice;
                products.DgvProduct[4, i].Value = pArr[i].ProdAmount;
                products.DgvProduct[5, i].Value = pArr[i].MinQty;
                products.DgvProduct[6, i].Value = dataB.GetSupplierName(pArr[i].SupplierCode);
            }
        }
        //Function to reset all text boxes)
        private void RessetTb()
        {

            products.tbCode.Text = "";
            products.tbName.Text = "";
            products.tbSize.Text = "";
            products.tbAmount.Text = "";
            products.RbExport.Checked = false;
            products.RbImport.Checked = false;
        }
        /*Product UC events end*/
        /**************************/
        /*********************************/

        /*UC Supplier Management Start*/
        //UC Supplier management Load
        public void UCSupplier_Load()
        {
            FillSupplier(dataB.SelectAllSupplier());
            ucSupplierManagement.OnClickAddSupplier += UcSupplierManagemnet_InsertSupllier;
            ucSupplierManagement.OnClickUpdateSupplier += UcSupplierManagemnet_UpdateSupllier;
            ucSupplierManagement.OnClickDeleteSupplier += UcSupplierManagemnet_DeleteSupllier;
            ucSupplierManagement.CellDoubleClickSupplier += UcSupplierManagemnet_CellDoubleClick;
            ucSupplierManagement.OnClickRest += UcSupplierManagemnet_OnClickResetTbs;
            ucSupplierManagement.OnClickSearch += UcSupplierManagemnet_OnClickSeach;
            ucSupplierManagement.OnClickShowAll += UcSupplierManagemnet_OnClickShowAll;
        }
        //Function that fill supplier info in data grid view
        private void FillSupplier(Supplier[] supArr)
        {
            ucSupplierManagement.DgvSupplier.RowCount = supArr.Length;
            ucSupplierManagement.DgvSupplier.ColumnCount = 6;
            ucSupplierManagement.DgvSupplier.Columns[0].HeaderText = "SUPID";
            ucSupplierManagement.DgvSupplier.Columns[1].HeaderText = "Code";
            ucSupplierManagement.DgvSupplier.Columns[2].HeaderText = "Name";
            ucSupplierManagement.DgvSupplier.Columns[3].HeaderText = "Telphone";
            ucSupplierManagement.DgvSupplier.Columns[4].HeaderText = "Email";
            ucSupplierManagement.DgvSupplier.Columns[5].HeaderText = "Address";
            ucSupplierManagement.DgvSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucSupplierManagement.DgvSupplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucSupplierManagement.DgvSupplier.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucSupplierManagement.DgvSupplier.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucSupplierManagement.DgvSupplier.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucSupplierManagement.DgvSupplier.Columns[0].Visible = false;

            for (int i = 0; i < supArr.Length; i++)
            {
                ucSupplierManagement.DgvSupplier[0, i].Value = supArr[i].SUPID_AUTO;
                ucSupplierManagement.DgvSupplier[1, i].Value = supArr[i].SupCode;
                ucSupplierManagement.DgvSupplier[2, i].Value = supArr[i].SupName;
                ucSupplierManagement.DgvSupplier[3, i].Value = supArr[i].SupTel;
                ucSupplierManagement.DgvSupplier[4, i].Value = supArr[i].SupEmail;
                ucSupplierManagement.DgvSupplier[5, i].Value = supArr[i].SupAdd;
            }
        }
        //Function to add new supplier (button)
        private void UcSupplierManagemnet_InsertSupllier(object sender, EventArgs e)
        {
            if (ucSupplierManagement.tbCode.Text == "" || ucSupplierManagement.tbName.Text == "" || ucSupplierManagement.tbTel.Text == "" ||
               ucSupplierManagement.tbEmail.Text == "" || ucSupplierManagement.tbAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(ucSupplierManagement.tbCode.Text) == 1 || CheckNumber(ucSupplierManagement.tbTel.Text) == 1)
            {
                MessageBox.Show("The Code Must Enter A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dataB.CheckSupp(int.Parse(ucSupplierManagement.tbCode.Text))==1)
            {
                MessageBox.Show("This Supplier's code is exist!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            else if (ucSupplierManagement.tbTel.Text.Length != 10)
            {
                MessageBox.Show("Telphone must be 10 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IsValidEmail(ucSupplierManagement.tbEmail.Text) == 0)
            {
                MessageBox.Show("Email Format is incorrect!!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                addsupplier();
            }
            FillSupplier(dataB.SelectAllSupplier());
            ResetSuppliertbs();
        }
        //Function to add new supplier
        private void addsupplier()
        {
            Supplier s = new Supplier(int.Parse(ucSupplierManagement.tbCode.Text), ucSupplierManagement.tbName.Text, ucSupplierManagement.tbTel.Text,
               ucSupplierManagement.tbEmail.Text, ucSupplierManagement.tbAddress.Text,true);
            dataB.InsertSupplier(s);
            Supp s1 = new Supp(int.Parse(ucSupplierManagement.tbCode.Text), ucSupplierManagement.tbName.Text);
            dataB.CopySuplier(s1);
            MessageBox.Show("Supplier inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //function to update supplier info(button)
        private void UcSupplierManagemnet_UpdateSupllier(object sender, EventArgs e)
        {
            if (ucSupplierManagement.tbCode.Text == "" || ucSupplierManagement.tbName.Text == "" || ucSupplierManagement.tbTel.Text == "" ||
                ucSupplierManagement.tbEmail.Text == "" || ucSupplierManagement.tbAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(ucSupplierManagement.tbCode.Text) == 1)
            {
                MessageBox.Show("You Must Enter A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Supplier s = new Supplier(int.Parse(ucSupplierManagement.tbCode.Text), ucSupplierManagement.tbName.Text,
                    ucSupplierManagement.tbTel.Text, ucSupplierManagement.tbEmail.Text, ucSupplierManagement.tbAddress.Text,true);
                dataB.UpdateSupplier(s, Supid);
                MessageBox.Show("Supplier Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FillSupplier(dataB.SelectAllSupplier());
            ResetSuppliertbs();
        }
        //Function that delete supplier(button)
        private void UcSupplierManagemnet_DeleteSupllier(object sender, EventArgs e)
        {
            if (ucSupplierManagement.tbCode.Text == "" || ucSupplierManagement.tbName.Text == "" || ucSupplierManagement.tbTel.Text == "" ||
                ucSupplierManagement.tbEmail.Text == "" || ucSupplierManagement.tbAddress.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MessageBox.Show("Are you sure you want to delete this Supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Supid < 0)
                {
                    MessageBox.Show("Couldn't delete Supplier, ID is not defined!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(dataB.checksupplierproduct(int.Parse(ucSupplierManagement.tbCode.Text))>0)
                {
                    MessageBox.Show("Couldn't delete Supplier,there is prdoucts for him", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataB.DeleteSupplier(Supid);
                FillSupplier(dataB.SelectAllSupplier());
                ResetSuppliertbs();
            }
            else
            {
                return;
            }
        }
        //Function to choose supplier (Double click)
        private void UcSupplierManagemnet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ucSupplierManagement.DgvSupplier.CurrentRow.Selected = true;
            Supid = int.Parse(ucSupplierManagement.DgvSupplier.Rows[e.RowIndex].Cells[0].Value.ToString());
            ucSupplierManagement.tbCode.Text = ucSupplierManagement.DgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
            ucSupplierManagement.tbName.Text = ucSupplierManagement.DgvSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
            ucSupplierManagement.tbTel.Text = ucSupplierManagement.DgvSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
            ucSupplierManagement.tbEmail.Text = ucSupplierManagement.DgvSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
            ucSupplierManagement.tbAddress.Text = ucSupplierManagement.DgvSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        //Function  to reset all text boxes(button)
        private void UcSupplierManagemnet_OnClickResetTbs(object sender, EventArgs e)
        {
            ResetSuppliertbs();
        }
        //Function to search supplier(button)
        private void UcSupplierManagemnet_OnClickSeach(object sender, EventArgs e)
        {
            if (ucSupplierManagement.tbSearch.Text == "")
            {
                MessageBox.Show("Fill info to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (ucSupplierManagement.cbSearchBy.SelectedItem == null)
            {
                MessageBox.Show("Choose option to search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (ucSupplierManagement.cbSearchBy.SelectedItem.ToString() == "Code")
                {
                    if (CheckNumber(ucSupplierManagement.tbSearch.Text) == 1||int.Parse(ucSupplierManagement.tbSearch.Text)<0)
                    {
                        MessageBox.Show("You Must Enter A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        FillSupplier(dataB.SearchSupplierByCode(int.Parse((ucSupplierManagement.tbSearch.Text))));
                    }
                }
                else
                {
                    FillSupplier(dataB.SearchSupplierByName((ucSupplierManagement.tbSearch.Text)));
                }
            }
        }
        //Function to show all supplier (button)
        private void UcSupplierManagemnet_OnClickShowAll(object sender, EventArgs e)
        {
            FillSupplier(dataB.SelectAllSupplier());
            ucSupplierManagement.tbSearch.Text = "";
            ucSupplierManagement.cbSearchBy.Text = "Choose Option";
        }
        //Function to reset all text boxes
        private void ResetSuppliertbs()
        {
            Supid = 0;
            ucSupplierManagement.tbCode.Text = "";
            ucSupplierManagement.tbName.Text = "";
            ucSupplierManagement.tbTel.Text = "";
            ucSupplierManagement.tbEmail.Text = "";
            ucSupplierManagement.tbAddress.Text = "";
        }
        /*UC Supplier Management Ends*/

        /*****************************************/

        /*Order Details Events Start */
        //UC Order Details Load
        public void OrderDeatails_Load()
        {
            orderDetails.OnclickAddToOrder += OrderDeatails_OnClickAdd;
            orderDetails.OnclickUpdateOrder += OrderDetails_OnClickUpdate;
            orderDetails.OnclickDeletefromOrder += OrderDetails_OnClickDelete;
            orderDetails.OnClickSend += OrderDetails_OnClickSend;
            orderDetails.OnCellDoubleClickdgvProductList += OrderDeatails_CellDoubleClickProductList;
            orderDetails.OnCellDoubleClickdgvOrderList += OrderDeatails_CellDoubleClickOrderList;
            orderDetails.SelectedIndexSupplier += OrderDetails_SelectIndex;
        }
        //Choose supplier to fill his products in data grid view(combo box)
        private void OrderDetails_SelectIndex(object sender, EventArgs e)
        {
            int sc = dataB.GetSupplierId(orderDetails.cbSupplier.SelectedItem.ToString());
            FillProductsList(dataB.SelectOrderProduct(sc));
        }
        //Function to add product to order (button)
        private void OrderDeatails_OnClickAdd(object sender, EventArgs e)
        {
            if (orderDetails.tbProductCode.Text == "" || orderDetails.tbProductQty.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dataB.CheckProduct(int.Parse(orderDetails.tbProductCode.Text)) == 1)
            {
                MessageBox.Show("Product Already Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                OrderDetails od = new OrderDetails(0, int.Parse(orderDetails.tbProductCode.Text), orderDetails.tbProductName.Text, int.Parse(orderDetails.tbProductQty.Text));
                dataB.InsertOrderDetails(od);
                orderDetails.tbPayment.Text = (int.Parse(orderDetails.tbPayment.Text) + (price * int.Parse(orderDetails.tbProductQty.Text))).ToString();
            }
            RestTbOrderDetails();
            FillOrderDetails(dataB.SelectAllOrderDetails());
        }
        //Fuction to delete product from order(button)
        private void OrderDetails_OnClickDelete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Odid == 0)
                {
                    MessageBox.Show("Couldn't delete Producr, ID is not defined!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int price = dataB.GetPrice(int.Parse(orderDetails.tbProductCode.Text));
                orderDetails.tbPayment.Text = (int.Parse(orderDetails.tbPayment.Text) - ((int.Parse(orderDetails.tbProductQty.Text)) * price)).ToString();
                dataB.DeleteOrderdeatils(int.Parse(orderDetails.dgvOrderDetails.SelectedRows[0].Cells[0].Value.ToString()));
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RestTbOrderDetails();
                FillOrderDetails(dataB.SelectAllOrderDetails());
            }
            else
            {
                RestTbOrderDetails();
                return;
            }
            FillOrderDetails(dataB.SelectAllOrderDetails());
        }
        //Function to update info of product (button)
        private void OrderDetails_OnClickUpdate(object sender, EventArgs e)
        {
            if (orderDetails.tbProductCode.Text == "" || orderDetails.tbProductQty.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int oldQty = int.Parse(orderDetails.dgvOrderDetails.SelectedRows[0].Cells[4].Value.ToString());
                OrderDetails od = new OrderDetails(0, int.Parse(orderDetails.tbProductCode.Text), orderDetails.tbProductName.Text, int.Parse(orderDetails.tbProductQty.Text));
                dataB.UpdateOrderdetails(od, Odid);
                int price = dataB.GetPrice(int.Parse(orderDetails.tbProductCode.Text));
                if (oldQty > int.Parse(orderDetails.tbProductQty.Text))
                {
                    orderDetails.tbPayment.Text = (int.Parse(orderDetails.tbPayment.Text) - ((oldQty - int.Parse(orderDetails.tbProductQty.Text)) * price)).ToString();
                }
                else
                {
                    orderDetails.tbPayment.Text = (int.Parse(orderDetails.tbPayment.Text) + (int.Parse(orderDetails.tbProductQty.Text) - oldQty) * price).ToString();
                }
                MessageBox.Show("Order Details Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FillOrderDetails(dataB.SelectAllOrderDetails());
            RestTbOrderDetails();
        }
        //Function to fill all products in data grid view
        private void FillProductsList(Product[] prodArr)
        {
            orderDetails.dgvProdList.RowCount = prodArr.Length;
            orderDetails.dgvProdList.ColumnCount = 4;
            orderDetails.dgvProdList.Columns[0].HeaderText = "Code";
            orderDetails.dgvProdList.Columns[1].HeaderText = "Name";
            orderDetails.dgvProdList.Columns[2].HeaderText = "Size";
            orderDetails.dgvProdList.Columns[3].HeaderText = "Price";
            orderDetails.dgvProdList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderDetails.dgvProdList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderDetails.dgvProdList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderDetails.dgvProdList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < prodArr.Length; i++)
            {
                orderDetails.dgvProdList[0, i].Value = prodArr[i].ProdCode;
                orderDetails.dgvProdList[1, i].Value = prodArr[i].ProdName;
                orderDetails.dgvProdList[2, i].Value = prodArr[i].ProdSize;
                orderDetails.dgvProdList[3, i].Value = prodArr[i].ProdPrice;
            }
        }
        //Function to fill all order details (products)
        private void FillOrderDetails(OrderDetails[] od)
        {
            orderDetails.dgvOrderDetails.RowCount = od.Length;
            orderDetails.dgvOrderDetails.ColumnCount = 5;
            orderDetails.dgvOrderDetails.Columns[0].HeaderText = "Orderid";
            orderDetails.dgvOrderDetails.Columns[1].HeaderText = "OrderCode";
            orderDetails.dgvOrderDetails.Columns[2].HeaderText = "Code";
            orderDetails.dgvOrderDetails.Columns[3].HeaderText = "Name";
            orderDetails.dgvOrderDetails.Columns[4].HeaderText = "Quantity";
            orderDetails.dgvOrderDetails.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderDetails.dgvOrderDetails.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderDetails.dgvOrderDetails.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderDetails.dgvOrderDetails.Columns[0].Visible = false;
            orderDetails.dgvOrderDetails.Columns[1].Visible = false;
            for (int i = 0; i < od.Length; i++)
            {
                orderDetails.dgvOrderDetails[0, i].Value = od[i].Orderid;
                orderDetails.dgvOrderDetails[1, i].Value = od[i].OrderCode;
                orderDetails.dgvOrderDetails[2, i].Value = od[i].ProductCode;
                orderDetails.dgvOrderDetails[3, i].Value = od[i].ProductName;
                orderDetails.dgvOrderDetails[4, i].Value = od[i].Quantity;

            }
        }
        //Double click to choose product from products List
        private void OrderDeatails_CellDoubleClickProductList(object sednder, DataGridViewCellEventArgs e)
        {
            orderDetails.dgvProdList.CurrentRow.Selected = true;
            orderDetails.tbProductCode.Text = orderDetails.dgvProdList.Rows[e.RowIndex].Cells[0].Value.ToString();
            orderDetails.tbProductName.Text = orderDetails.dgvProdList.Rows[e.RowIndex].Cells[1].Value.ToString();
            price = int.Parse(orderDetails.dgvProdList.Rows[e.RowIndex].Cells[3].Value.ToString());
        }
        //Double click to choose product from order details
        private void OrderDeatails_CellDoubleClickOrderList(object sednder, DataGridViewCellEventArgs e)
        {
            orderDetails.dgvOrderDetails.CurrentRow.Selected = true;
            Odid = int.Parse(orderDetails.dgvOrderDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            orderDetails.tbProductCode.Text = orderDetails.dgvOrderDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            orderDetails.tbProductName.Text = orderDetails.dgvOrderDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            orderDetails.tbProductQty.Text = orderDetails.dgvOrderDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        //Function to send order to admin (button)
        private void OrderDetails_OnClickSend(object sender, EventArgs e)
        {
            if (dataB.SelectAllOrderDetails().Length == 0)
            {
                MessageBox.Show("Please fill Order details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (orderDetails.cbSupplier.SelectedItem == null)
            {
                MessageBox.Show("Choose Supplier", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int x = dataB.SelectAllSupplier()[orderDetails.cbSupplier.SelectedIndex].SupCode;
                MSG msg = new MSG("Submit the Order");
                dataB.NewMsg(msg);
                int z = dataB.GetLastMsg();
                Order ord = new Order(DateTime.Now.Date, x, false, z, int.Parse(orderDetails.tbPayment.Text));
                dataB.NewOrder(ord);
                for (int k = 0; k < dataB.SelectAllOrderDetails().Length; k++)
                {
                    dataB.ChangeOrdercode(dataB.GetLastOrder());
                }
                RestTbOrderDetails();
                actions.Show();
                actions.BringToFront();
                FillMsgs(dataB.GetNewMsgs());
                FillOrder_Update(dataB.GetAllOrderNotOK());
            }
            price = 0;
        }
        //Function to reset text boxes
        private void RestTbOrderDetails()
        {
            Odid = 0;
            orderDetails.tbProductCode.Text = "";
            orderDetails.tbProductName.Text = "";
            orderDetails.tbProductQty.Text = "";
            orderDetails.cbSupplier.Text = "Choose Supplier";

        }

        /*Order Details Events Ends */
        /****************************************/
        /*Update Order Events Start*/
        //UC update order Load
        public void UpdateOrder_Load()
        {
            FillOrder_Update(dataB.GetAllOrderNotOK());
            updateOrder.OnCellDoubleClickOrder += UpdateOrder_OnCellDoubleClickOreder;
            updateOrder.OnCellDoubleClickOrderDetails += UpdateOrder_OnCellDoubleClickOrederDetails;
            updateOrder.OnClickUpdate += UpdateOrder_OnClickUpdate;
            updateOrder.OnCellDoubleClickProducts += UpdateOrder_OnCellDoubleClickProducts;
            updateOrder.OnClickAddToOrder += UpdateOrder_OnClickAddToOrder;
            updateOrder.OnClickSend += UpdateOrder_OnClickSend;
            updateOrder.OnClickDelete += UpdateOrder_OnClickDelete;
        }
        //Function to fill all order in data grid view
        private void FillOrder_Update(Order[] order)
        {
            updateOrder.DgvOrder.RowCount = order.Length;
            updateOrder.DgvOrder.ColumnCount = 5;
            updateOrder.DgvOrder.Columns[0].HeaderText = "Order Code";
            updateOrder.DgvOrder.Columns[1].HeaderText = "Order Date";
            updateOrder.DgvOrder.Columns[2].HeaderText = "Supplier Name";
            updateOrder.DgvOrder.Columns[3].HeaderText = "MsgID";
            updateOrder.DgvOrder.Columns[4].HeaderText = "Payment";
            updateOrder.DgvOrder.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateOrder.DgvOrder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateOrder.DgvOrder.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateOrder.DgvOrder.Columns[3].Visible = false;
            updateOrder.DgvOrder.Columns[4].Visible = false;
            for (int i = 0; i < order.Length; i++)
            {
                updateOrder.DgvOrder[0, i].Value = order[i].OrderCode;
                updateOrder.DgvOrder[1, i].Value = order[i].OrderDate.ToString("dd/MM/yyyy");
                updateOrder.DgvOrder[2, i].Value = dataB.GetSupplierName(order[i].SupplierCode);
                updateOrder.DgvOrder[3, i].Value = order[i].MsgId;
                updateOrder.DgvOrder[4, i].Value = order[i].Payment;
            }
        }
        //Function to fill products in data grid view
        private void FillProducts_updateorderProducts(Product[] prodArr)
        {
            updateOrder.DgvProducts.RowCount = prodArr.Length;
            updateOrder.DgvProducts.ColumnCount = 4;
            updateOrder.DgvProducts.Columns[0].HeaderText = "Code";
            updateOrder.DgvProducts.Columns[1].HeaderText = "Name";
            updateOrder.DgvProducts.Columns[2].HeaderText = "Size";
            updateOrder.DgvProducts.Columns[3].HeaderText = "Price";
            updateOrder.DgvProducts.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateOrder.DgvProducts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateOrder.DgvProducts.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateOrder.DgvProducts.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < prodArr.Length; i++)
            {
                updateOrder.DgvProducts[0, i].Value = prodArr[i].ProdCode;
                updateOrder.DgvProducts[1, i].Value = prodArr[i].ProdName;
                updateOrder.DgvProducts[2, i].Value = prodArr[i].ProdSize;
                updateOrder.DgvProducts[3, i].Value = prodArr[i].ProdPrice;
            }
        }
        //Function to fill order details in data grid view
        private void FillUpdateOrderDetails(OrderDetails[] od)
        {
            updateOrder.DgvOrderDetails.RowCount = od.Length;
            updateOrder.DgvOrderDetails.ColumnCount = 5;
            updateOrder.DgvOrderDetails.Columns[0].HeaderText = "orderid";
            updateOrder.DgvOrderDetails.Columns[1].HeaderText = "OrderCode";
            updateOrder.DgvOrderDetails.Columns[2].HeaderText = "Code";
            updateOrder.DgvOrderDetails.Columns[3].HeaderText = "Name";
            updateOrder.DgvOrderDetails.Columns[4].HeaderText = "Qty";
            updateOrder.DgvOrderDetails.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateOrder.DgvOrderDetails.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateOrder.DgvOrderDetails.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            updateOrder.DgvOrderDetails.Columns[0].Visible = false;
            updateOrder.DgvOrderDetails.Columns[1].Visible = false;
            for (int i = 0; i < od.Length; i++)
            {
                updateOrder.DgvOrderDetails[0, i].Value = od[i].Orderid;
                updateOrder.DgvOrderDetails[1, i].Value = od[i].OrderCode;
                updateOrder.DgvOrderDetails[2, i].Value = od[i].ProductCode;
                updateOrder.DgvOrderDetails[3, i].Value = od[i].ProductName;
                updateOrder.DgvOrderDetails[4, i].Value = od[i].Quantity;
            }
        }
        //Double click to choose order
        private void UpdateOrder_OnCellDoubleClickOreder(object sender, DataGridViewCellEventArgs e)
        {
            count = 0;
            updateOrder.DgvOrder.CurrentRow.Selected = true;
            Uoc = int.Parse(updateOrder.DgvOrder.Rows[e.RowIndex].Cells[0].Value.ToString());
            updateOrder.tbSupplier.Text = updateOrder.DgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
            updateOrder.tbPayment.Text = updateOrder.DgvOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
            FillUpdateOrderDetails(dataB.SelectAllOrderDetail(Uoc));
            FillProducts_updateorderProducts(dataB.SelectOrderProduct(dataB.GetSupplierId(updateOrder.tbSupplier.Text)));
        }
        //Double click to choose product from order details list
        private void UpdateOrder_OnCellDoubleClickOrederDetails(object sender, DataGridViewCellEventArgs e)
        {
            updateOrder.DgvOrderDetails.CurrentRow.Selected = true;
            updateOrder.tbProductCode.Text = updateOrder.DgvOrderDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            updateOrder.tbProductName.Text = updateOrder.DgvOrderDetails.Rows[e.RowIndex].Cells[3].Value.ToString();
            updateOrder.tbQty.Text = updateOrder.DgvOrderDetails.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        //Double click to chose product from products List
        private void UpdateOrder_OnCellDoubleClickProducts(object sender, DataGridViewCellEventArgs e)
        {
            updateOrder.tbQty.Text = "";
            updateOrder.DgvProducts.CurrentRow.Selected = true;
            updateOrder.tbProductCode.Text = updateOrder.DgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            updateOrder.tbProductName.Text = updateOrder.DgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            price = int.Parse(updateOrder.DgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString());
        }
        //Function to update product info (button)
        private void UpdateOrder_OnClickUpdate(object sender, EventArgs e)
        {
            if (Uoc == 0)
            {
                MessageBox.Show("Choose An Order To Add Into", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (updateOrder.tbProductCode.Text == "" || updateOrder.tbQty.Text == "")
            {
                MessageBox.Show("Please fill all fields! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(updateOrder.tbQty.Text) == 1 || int.Parse(updateOrder.tbQty.Text) < 0)
            {
                MessageBox.Show("Quantity is Wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                updateorder();
            }
            Resetupdateorderfields();
        }
        //Function to update order
        private void updateorder()
        {
            int oldQty = int.Parse(updateOrder.DgvOrderDetails.SelectedRows[0].Cells[4].Value.ToString());
            OrderDetails orderDetails = new OrderDetails(Uoc, int.Parse(updateOrder.tbProductCode.Text), updateOrder.tbProductName.Text,
                                                          int.Parse(updateOrder.tbQty.Text));
            dataB.UpdateOrderdetails_Update(orderDetails, int.Parse(updateOrder.DgvOrderDetails.SelectedRows[0].Cells[0].Value.ToString()));
            int price = dataB.GetPrice(int.Parse(updateOrder.tbProductCode.Text));
            if (oldQty > int.Parse(updateOrder.tbQty.Text))
            {
                updateOrder.tbPayment.Text = (int.Parse(updateOrder.tbPayment.Text) - ((oldQty - int.Parse(updateOrder.tbQty.Text)) * price)).ToString();
            }
            else
            {
                updateOrder.tbPayment.Text = (int.Parse(updateOrder.tbPayment.Text) + (int.Parse(updateOrder.tbQty.Text) - oldQty) * price).ToString();
            }
            FillUpdateOrderDetails(dataB.SelectAllOrderDetail(Uoc));
            count++;
        }
        //Function to add product to order (button)
        private void UpdateOrder_OnClickAddToOrder(object sender, EventArgs e)
        {
            if (Uoc == 0)
            {
                MessageBox.Show("Choose An Order To Add Into", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (updateOrder.tbProductCode.Text == "" || updateOrder.tbQty.Text == "")
            {
                MessageBox.Show("Please Choose Product!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckNumber(updateOrder.tbQty.Text) == 1 || int.Parse(updateOrder.tbQty.Text) < 0)
            {
                MessageBox.Show("Please Enter Positive Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                updateOrder.tbQty.Text = "";
                return;
            }
            else if (dataB.SearchProductInOrderDetails(int.Parse(updateOrder.tbProductCode.Text), Uoc) == 1)
            {
                MessageBox.Show("The Product is Exist In Order !! Update It's Quantity", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                addtoorder();
            }
        }
        //Function to add product to order
        private void addtoorder()
        {
            OrderDetails od = new OrderDetails(Uoc, int.Parse(updateOrder.tbProductCode.Text), updateOrder.tbProductName.Text,
                                                    int.Parse(updateOrder.tbQty.Text));
            dataB.InsertOrderDetails(od);
            int price = dataB.GetPrice(int.Parse(updateOrder.tbProductCode.Text));
            updateOrder.tbPayment.Text = (int.Parse(updateOrder.tbPayment.Text) + (price * int.Parse(updateOrder.tbQty.Text))).ToString();
            FillUpdateOrderDetails(dataB.SelectAllOrderDetail(Uoc));
            Resetupdateorderfields();
            count++;
        }
        //Function to delete product from order (button)
        private void UpdateOrder_OnClickDelete(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (int.Parse(updateOrder.DgvOrderDetails.SelectedRows[0].Cells[0].Value.ToString()) == 0)
                {
                    MessageBox.Show("Couldn't delete Producr, ID is not defined!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int price = dataB.GetPrice(int.Parse(updateOrder.tbProductCode.Text));
                updateOrder.tbPayment.Text = (int.Parse(updateOrder.tbPayment.Text) - ((int.Parse(updateOrder.tbQty.Text)) * price)).ToString();
                dataB.DeleteOrderdeatils(int.Parse(updateOrder.DgvOrderDetails.SelectedRows[0].Cells[0].Value.ToString()));
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestTbOrderDetails();
                FillUpdateOrderDetails(dataB.SelectAllOrderDetail(Uoc));
            }
            else
            {
                Resetupdateorderfields();
                return;
            }
            FillUpdateOrderDetails(dataB.SelectAllOrderDetail(Uoc));
            count++;
        }
        //Function to sened order to admin (button)
        private void UpdateOrder_OnClickSend(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("Add OR Update Any Order You Want", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dataB.CheckSupp(dataB.GetSupplierId(updateOrder.tbSupplier.Text)) == 0)
            {
                MessageBox.Show("Supplier doesn't exist!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int id = dataB.GetSupplierId(updateOrder.DgvOrder.SelectedRows[0].Cells[2].Value.ToString());
                Order order = new Order(DateTime.Now, id, false, int.Parse(updateOrder.DgvOrder.SelectedRows[0].Cells[3].Value.ToString())
                    , int.Parse(updateOrder.tbPayment.Text));
                dataB.UpdateOrder_update(Uoc, int.Parse(updateOrder.tbPayment.Text));
                Uoc = 0;
                updateOrder.DgvOrderDetails.Rows.Clear();
                updateOrder.tbPayment.Text = "";
            }
            Resetupdateorderfields();
        }
        //Function to reset text boxes
        private void Resetupdateorderfields()
        {
            updateOrder.tbProductCode.Text = "";
            updateOrder.tbProductName.Text = "";
            updateOrder.tbQty.Text = "";
        }
        /*Update Order Events Ends*/
        /*******************************************/
        /*Allorder Events Start*/
        //UC All order Load
        public void AllOrders_Load()
        {
            allOrders.tbMonth.Text = DateTime.Parse(allOrders.dtOrderMonth.Text).Month + "/" + DateTime.Parse(allOrders.dtOrderMonth.Text).Year;
            FillAllOrder(dataB.GetOrderByMonth(DateTime.Parse(allOrders.dtOrderMonth.Text).Month, DateTime.Parse(allOrders.dtOrderMonth.Text).Year));
            allOrders.CellDoubleOrder += AllOrder_CellDoubleClick;
            allOrders.OnClickSavePdf += AllOrder_OnClickSavePdf;
            allOrders.ChangeM += AllOrder_Changemonth;
            allOrders.OnClickOrderReport += Report_OnClickOrderReport;
            allOrders.OnClickOrderY += AllOrder_OnClickOrderY;
        }
        //Function to fill all order in data grid view 
        private void FillAllOrder(Order[] order)
        {
            allOrders.DgvOrders.RowCount = order.Length;
            allOrders.DgvOrders.ColumnCount = 5;
            allOrders.DgvOrders.Columns[0].HeaderText = "Order Code";
            allOrders.DgvOrders.Columns[1].HeaderText = "Order Date";
            allOrders.DgvOrders.Columns[2].HeaderText = "Supplier Name";
            allOrders.DgvOrders.Columns[3].HeaderText = "MsgID";
            allOrders.DgvOrders.Columns[4].HeaderText = "Payment";
            allOrders.DgvOrders.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            allOrders.DgvOrders.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            allOrders.DgvOrders.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            allOrders.DgvOrders.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            allOrders.DgvOrders.Columns[3].Visible = false;
            for (int i = 0; i < order.Length; i++)
            {
                allOrders.DgvOrders[0, i].Value = order[i].OrderCode;
                allOrders.DgvOrders[1, i].Value = order[i].OrderDate.ToString("dd/MM/yyyy");
                allOrders.DgvOrders[2, i].Value = dataB.GetSupplierName(order[i].SupplierCode);
                allOrders.DgvOrders[3, i].Value = order[i].MsgId;
                allOrders.DgvOrders[4, i].Value = order[i].Payment;
            }
        }
        //Function to fill order details in data grid view
        private void FillOrderDetails_AllOrder(OrderDetails[] od)
        {
            allOrders.DgvOrderDetails.RowCount = od.Length;
            allOrders.DgvOrderDetails.ColumnCount = 5;
            allOrders.DgvOrderDetails.Columns[0].HeaderText = "orderid";
            allOrders.DgvOrderDetails.Columns[1].HeaderText = "OrderCode";
            allOrders.DgvOrderDetails.Columns[2].HeaderText = "Code";
            allOrders.DgvOrderDetails.Columns[3].HeaderText = "Name";
            allOrders.DgvOrderDetails.Columns[4].HeaderText = "Qty";
            allOrders.DgvOrderDetails.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            allOrders.DgvOrderDetails.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            allOrders.DgvOrderDetails.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            allOrders.DgvOrderDetails.Columns[0].Visible = false;
            allOrders.DgvOrderDetails.Columns[1].Visible = false;


            for (int i = 0; i < od.Length; i++)
            {
                allOrders.DgvOrderDetails[0, i].Value = od[i].Orderid;
                allOrders.DgvOrderDetails[1, i].Value = od[i].OrderCode;
                allOrders.DgvOrderDetails[2, i].Value = od[i].ProductCode;
                allOrders.DgvOrderDetails[3, i].Value = od[i].ProductName;
                allOrders.DgvOrderDetails[4, i].Value = od[i].Quantity;
            }
        }
        //Double click on order to fill order details in data grid view 
        private void AllOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Oc = int.Parse(allOrders.DgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
            FillOrderDetails_AllOrder(dataB.SelectAllOrderDetail(int.Parse(allOrders.DgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString())));
        }
        //Function that fill orders by month 
        private void AllOrder_Changemonth(object sender, EventArgs e)
        {
            FillAllOrder(dataB.GetOrderByMonth(DateTime.Parse(allOrders.dtOrderMonth.Text).Month, DateTime.Parse(allOrders.dtOrderMonth.Text).Year));
            allOrders.tbMonth.Text = DateTime.Parse(allOrders.dtOrderMonth.Text).Month + "/" + DateTime.Parse(allOrders.dtOrderMonth.Text).Year;
        }
        //Function that save PDF DOC for specific order (button)
        private void AllOrder_OnClickSavePdf(object sender, EventArgs e)
        {
            if (Oc > 0)
            {
                PDF pdf = new PDF(@"C:\Users\Razi\Desktop\Storage\Storage\Storage\Reports\Order " + dataB.GetOrderOK(Oc)[0].OrderDate.ToString("MM-yyyy"));
                pdf.SetTitle("Order Details");
                pdf.SetOrderDetailsTable(dataB.SelectAllOrderDetail(Oc));
                pdf.CloseReport();
                MessageBox.Show("PDF file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Choose Order!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //Function that save PDF DOC of orders for specific month (button)
        private void Report_OnClickOrderReport(object sender, EventArgs e)
        {

            PDF pdf = new PDF(@"C:\Users\Razi\Desktop\Storage\Storage\Storage\Reports\Orders " + DateTime.Parse(allOrders.dtOrderMonth.Text).Month + "-" + DateTime.Parse(allOrders.dtOrderMonth.Text).Year);
            pdf.SetTitle("Order Details " + allOrders.dtOrderMonth.Text);

            pdf.SetsumTable(dataB.SumProM(DateTime.Parse(allOrders.dtOrderMonth.Text).Month, DateTime.Parse(allOrders.dtOrderMonth.Text).Year));
            pdf.CloseReport();
            MessageBox.Show("PDF file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Function  taht save PDF DOC of orders for specific year(button)
        private void AllOrder_OnClickOrderY(object sender, EventArgs e)
        {
            PDF pdf = new PDF(@"C:\Users\Razi\Desktop\Storage\Storage\Storage\Reports\Orders " + allOrders.dtOrderdetailsY.Text);
            pdf.SetTitle("Order Details " + allOrders.dtOrderdetailsY.Text);
            pdf.SetsumTable(dataB.SumProYear(int.Parse(allOrders.dtOrderdetailsY.Text)));
            pdf.CloseReport();
            MessageBox.Show("PDF file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /*AllOrder Events Ends*/
        /********************************************/


        /*UcMessage Events Start*/
        //UC Message load
        public void Message_Load()
        {
            FillMsgs(dataB.GetNewMsgs());
            ucMessage.OnClickOk += Msg_OnClickOK;
            ucMessage.OnCellDoubleClickMsg += Msg_CellDoubleClickMsg;
            ucMessage.OnCellDoubleClickMOD += Msg_OnCellDoubleClickOrderDetails;
        }
        //Function to fill messages in data grid view
        private void FillMsgs(MSG[] msg)
        {
            ucMessage.DgvMsg.RowCount = msg.Length;
            ucMessage.DgvMsg.ColumnCount = 3;
            ucMessage.DgvMsg.Columns[0].HeaderText = "msgcode";
            ucMessage.DgvMsg.Columns[1].HeaderText = "Id";
            ucMessage.DgvMsg.Columns[2].HeaderText = "Subject";
            ucMessage.DgvMsg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucMessage.DgvMsg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucMessage.DgvMsg.Columns[0].Visible = false;

            for (int i =0; i <msg.Length; i++)
            {
                ucMessage.DgvMsg[0, i].Value = msg[i].MsgID;
                ucMessage.DgvMsg[1, i].Value = msg.Length-i ;
                ucMessage.DgvMsg[2, i].Value = msg[i].MsgSubject;
            }
        }
        // Function to fill order details in data grid view
        private void FillMsgOrderDetails(OrderDetails[] od)
        {
            ucMessage.DgvmsgOrderDetails.RowCount = od.Length;
            ucMessage.DgvmsgOrderDetails.ColumnCount = 4;
            ucMessage.DgvmsgOrderDetails.Columns[0].HeaderText = "Orderid";
            ucMessage.DgvmsgOrderDetails.Columns[1].HeaderText = "Code";
            ucMessage.DgvmsgOrderDetails.Columns[2].HeaderText = "Name";
            ucMessage.DgvmsgOrderDetails.Columns[3].HeaderText = "Qty";
            ucMessage.DgvmsgOrderDetails.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucMessage.DgvmsgOrderDetails.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucMessage.DgvmsgOrderDetails.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ucMessage.DgvmsgOrderDetails.Columns[0].Visible = false;
            for (int i = 0; i < od.Length; i++)
            {
                ucMessage.DgvmsgOrderDetails[0, i].Value = od[i].Orderid;
                ucMessage.DgvmsgOrderDetails[1, i].Value = od[i].ProductCode;
                ucMessage.DgvmsgOrderDetails[2, i].Value = od[i].ProductName;
                ucMessage.DgvmsgOrderDetails[3, i].Value = od[i].Quantity;
            }
        }
        //Double click on message ot fill order's details
        private void Msg_CellDoubleClickMsg(object sednder, DataGridViewCellEventArgs e)
        {
            ucMessage.DgvMsg.CurrentRow.Selected = true;
            Msgoc = int.Parse(ucMessage.DgvMsg.Rows[e.RowIndex].Cells[0].Value.ToString());
            Order[] orderemsg = dataB.GetOrder(Msgoc);
            ucMessage.tbOrdercode.Text = orderemsg[0].OrderCode.ToString();
            ucMessage.tbOrderDate.Text = orderemsg[0].OrderDate.ToString("dd/MM/yyyy");
            ucMessage.tbSupplierName.Text = dataB.GetSupplierName(orderemsg[0].SupplierCode);
            FillMsgOrderDetails(dataB.SelectAllOrderDetail(orderemsg[0].OrderCode));
            ucMessage.tbPayment.Text = orderemsg[0].Payment.ToString();

        }
        //Function to submit the order to send it to supplier(button)
        private void Msg_OnClickOK(object sender, EventArgs e)
        {
            if (ucMessage.tbOrdercode.Text == "")
            {
                MessageBox.Show("Choose Message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dataB.CheckSupp(dataB.GetSupplierId(ucMessage.tbSupplierName.Text))==0)
            {
                MessageBox.Show("Supplier doesn't exist!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string mail = dataB.EmailSupplier(dataB.GetSupplierId(ucMessage.tbSupplierName.Text));
                PDF pdf = new PDF(@"C:\Users\Razi\Desktop\Storage\Storage\Storage\Reports\Order");
                pdf.SetTitle("Order");
                pdf.SetOrderDetailsTable(dataB.SelectAllOrderDetail(int.Parse(ucMessage.tbOrdercode.Text)));
                pdf.CloseReport();
                int re = SendOrder(dataB.Getinfo()[0].CompEmail.ToString(), dataB.Getinfo()[0].CompPass.ToString(), mail);
                if (re == 1)
                {
                    dataB.OKOreder(int.Parse(ucMessage.tbOrdercode.Text));
                    MessageBox.Show("The order has been confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestMSG();
                }
                else
                {
                    showdia(mail);
                }
            }
        }
        //Function to reset all fields
        private void RestMSG()
        {
            Msgoc = 0;
            FillMsgs(dataB.GetNewMsgs());
            ucMessage.tbOrdercode.Text = "";
            ucMessage.tbOrderDate.Text = "";
            ucMessage.tbSupplierName.Text = "";
            ucMessage.DgvmsgOrderDetails.Rows.Clear();
            ucMessage.tbPayment.Text = "0";
        }
        //Dialig to correct Email ro password of company 
        private void showdia(string mail)
        {
            Dialog d = new Dialog();
            d.ShowDialog();
            if (d.DialogResult.Equals(DialogResult.OK))
            {
                if (d.tbEmail.Text == "" || d.tbPass.Text == "")
                {
                    MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (IsValidEmail(d.tbEmail.Text) == 0)
                {
                    MessageBox.Show("Email is wrog", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    int r = SendOrder(d.tbEmail.Text, d.tbPass.Text, mail);
                    if (r == 1)
                    {
                        dataB.OKOreder(int.Parse(ucMessage.tbOrdercode.Text));
                        MessageBox.Show("The order has been confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RestMSG();
                    }
                    else
                    {
                        showdia(mail);
                    }
                }
            }
        }
        //Function to send email to supplier 
        private int SendOrder(string fmail, string pass, string tomail)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(fmail);
                mail.To.Add(tomail);
                mail.Subject = "New Order";
                Attachment attachment;
                attachment = new Attachment(@"C:\Users\Razi\Desktop\Storage\Storage\Storage\Reports\Order.pdf");
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(fmail, pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
                return 1;
            }
            catch
            {
                MessageBox.Show("Email OR Password is Wrong");
                return 0;
            }
        }
        //Double click on amount of product to change it by dialog
        private void Msg_OnCellDoubleClickOrderDetails(object sender, DataGridViewCellEventArgs e)
        {
            ucMessage.DgvmsgOrderDetails.CurrentRow.Selected = true;
            int oldQty = int.Parse(ucMessage.DgvmsgOrderDetails.Rows[e.RowIndex].Cells[3].Value.ToString());
            UpdateQtyDialog newqty = new UpdateQtyDialog();
            newqty.ShowDialog();
            if(newqty.DialogResult.Equals(DialogResult.OK))
            {
                if(newqty.TbNewQty.Text=="")
                {
                    MessageBox.Show("Fill All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                else if(CheckNumber(newqty.TbNewQty.Text)==1|| int.Parse(newqty.TbNewQty.Text)<0)
                {
                    MessageBox.Show("Enter Postive Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    OrderDetails orderDetails = new OrderDetails(int.Parse(ucMessage.tbOrdercode.Text), int.Parse(ucMessage.DgvmsgOrderDetails.Rows[e.RowIndex].Cells[1].Value.ToString())
                        , ucMessage.DgvmsgOrderDetails.Rows[e.RowIndex].Cells[2].Value.ToString(), int.Parse(newqty.TbNewQty.Text));
                    dataB.UpdateOrderdetails_Update(orderDetails, int.Parse(ucMessage.DgvmsgOrderDetails.SelectedRows[0].Cells[0].Value.ToString()));
                    int price = dataB.GetPrice(int.Parse(ucMessage.DgvmsgOrderDetails.Rows[e.RowIndex].Cells[1].Value.ToString()));
                    if (oldQty > int.Parse(newqty.TbNewQty.Text))
                    {
                        ucMessage.tbPayment.Text = (int.Parse(ucMessage.tbPayment.Text) - ((oldQty - int.Parse(newqty.TbNewQty.Text)) * price)).ToString();
                    }
                    else
                    {
                        ucMessage.tbPayment.Text = (int.Parse(ucMessage.tbPayment.Text) + (int.Parse(newqty.TbNewQty.Text) - oldQty) * price).ToString();
                    }
                }
            }
            dataB.UpdateOrder_update(int.Parse(ucMessage.tbOrdercode.Text), int.Parse(ucMessage.tbPayment.Text));
            FillMsgOrderDetails(dataB.SelectAllOrderDetail(int.Parse(ucMessage.tbOrdercode.Text)));
        }
        /*UcMessage Events Ends*/
        /*********************************/
        /*Statics Event Start*/
        //UC statics load
        public void Statics_Load()
        {
            statics.Onclicksavemostapp += Statics_OnClicksaveMostapp;
            statics.ChangeM += ChangeMonth;
        }
        //function to  save PDF DOC 
        private void Statics_OnClicksaveMostapp(object sender,EventArgs e)
        {
            PDF pdf = new PDF(@"C:\Users\Razi\Desktop\Storage\Storage\Storage\Reports\Most Appearance");
            pdf.SetTitle("Most Appearance Last Two Months");
            pdf.SetsumTable(dataB.MostAppearance(DateTime.Parse(statics.FirstD.Text).Month, DateTime.Parse(statics.FirstD.Text).Year, DateTime.Parse(statics.SecD.Text).Month, DateTime.Parse(statics.SecD.Text).Year));
            pdf.CloseReport();
            MessageBox.Show("PDF file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void ChangeMonth(object sender,EventArgs e)
        {
            statics.Loadchart1(dataB.SumProM((statics.DateM.Value.Month), statics.DateM.Value.Year));
        }


        /*Statics Eents Ends*/
        /*********************************/
        /*Settings Events start*/
        //UC settings load
        public void Settings_Load()
        {
            FillSettings(dataB.Getinfo());
            settings.OnClickSave += Settings_OnClickSave;
        }
        //function to fill settings
        private void FillSettings(Company[] comp)
        {
            if (comp.Length  >0)
            {
                compid = comp[0].CompID;
                settings.tbName.Text = comp[0].CompName;
                settings.tbEmail.Text = comp[0].CompEmail;
            }
        }
        //Function to save new data(bytton)
        private void Settings_OnClickSave(object sender,EventArgs e)
        {
            if(settings.tbNewName.Text==""||settings.tbNewEmail.Text==""||settings.tbNewPassword.Text=="")
            {
                MessageBox.Show("Please fill all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(IsValidEmail(settings.tbNewEmail.Text) == 0)
            {
                MessageBox.Show("Email Format is incorrect!!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Company comp = new Company(settings.tbNewName.Text, settings.tbNewEmail.Text, settings.tbNewPassword.Text);
                dataB.UpdateCompany(comp,compid);
                MessageBox.Show("Info Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        /*Settings Eents End*/
        /***********************************/

        /*Menu Item Events Start */
        // Home page
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show
            actions.Show();
            actions.BringToFront();
            //Hide
            login.Hide();
            register.Hide();
            ucEmployeeManagement.Hide();
            products.Hide();
            ucProductManagement.Hide();
            ucSupplierManagement.Hide();
            orderDetails.Hide();
            updateOrder.Hide();
        }
        //Employee managment page
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillEmployees();
            //Show
            ucEmployeeManagement.Show();
            ucEmployeeManagement.BringToFront();
            //Hide
            login.Hide();
            register.Hide();
            actions.Hide();
            products.Hide();
            ucProductManagement.Hide();
            ucSupplierManagement.Hide();
            orderDetails.Hide();
            updateOrder.Hide();
            
        }
        //Productmanagemnet page
        private void addDelUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show
            ucProductManagement.Show();
            ucProductManagement.BringToFront();
            RestproductTbs();
            FillProducts(dataB.SelectAllProducts());
            fillcbsupplier();
            //Hide
            login.Hide();
            register.Hide();
            actions.Hide();
            products.Hide();
            ucEmployeeManagement.Hide();
            ucSupplierManagement.Hide();
            orderDetails.Hide();
            updateOrder.Hide();
        } 
        //fill combo box of sppliers(help)
        private void fillcbsupplier()
        {
            if (dataB.SelectAllSupplier().Length == 0)
            {
                MessageBox.Show("Add Supplier ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ucSupplierManagement.Show();
                ucSupplierManagement.BringToFront();
                return;
            }
            if (ucProductManagement.cbSupplierName.Items.Count == 0)
            {
                for (int s = 0; s < dataB.SelectAllSupplier().Length; s++)//combo box to choose supplier to add new product
                {
                    ucProductManagement.cbSupplierName.Items.Add(dataB.SelectAllSupplier()[s].SupName);
                }
            }
            if (ucProductManagement.cbSupplier.Items.Count == 0)//combo box for choose supplier to fill his products
            {
                for (int s = 0; s < dataB.CAllSupp().Length; s++)
                {
                    ucProductManagement.cbSupplier.Items.Add(dataB.CAllSupp()[s].CSuppName);
                }
            }
        }
        //Storage page( UC produtcs)
        private void importexportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show
            FillProduct(dataB.SelectAllProducts());
            products.Show();
            products.BringToFront();
           
            //Hide
 
            login.Hide();
            register.Hide();
            actions.Hide();
            ucEmployeeManagement.Hide();
            ucProductManagement.Hide();
            ucSupplierManagement.Hide();
            orderDetails.Hide();
            updateOrder.Hide();
        }
        //New Order page
        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show
            orderDetails.Show();
            orderDetails.BringToFront();
            orderDetails.dgvOrderDetails.Rows.Clear();
            orderDetails.tbPayment.Text = "0"; 
            if (orderDetails.cbSupplier.Items.Count == 0)
            {
                for (int s = 0; s < dataB.SelectAllSupplier().Length; s++)
                {
                    orderDetails.cbSupplier.Items.Add(dataB.SelectAllSupplier()[s].SupName);
                }
            }   
            //Hide
            login.Hide();
            register.Hide();
            actions.Hide();
            products.Hide();
            ucEmployeeManagement.Hide();
            ucProductManagement.Hide();
            ucSupplierManagement.Hide();
            updateOrder.Hide();
        }
        //Supplier managment 
        private void addDelUpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Show
            ucSupplierManagement.tbSearch.Text = "";
            ucSupplierManagement.cbSearchBy.Text = "Choose Option";
            ucSupplierManagement.Show();
            ucSupplierManagement.BringToFront();
            FillSupplier(dataB.SelectAllSupplier());
            //Hide
            login.Hide();
            register.Hide();
            actions.Hide();
            products.Hide();
            ucEmployeeManagement.Hide();
            ucProductManagement.Hide();
            orderDetails.Hide();
            updateOrder.Hide();
        }
        //Settings page
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show
            settings.Show();
            settings.BringToFront();
            //Hide
            login.Hide();
            register.Hide();
            actions.Hide();
            products.Hide();
            ucEmployeeManagement.Hide();
            ucProductManagement.Hide();
            ucSupplierManagement.Hide();
            orderDetails.Hide();
            updateOrder.Hide();
        }
        //All Order page
        private void allOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allOrders.Show();
            allOrders.BringToFront();
            //Hide
            login.Hide();
            register.Hide();
            actions.Hide();
            products.Hide();
            ucEmployeeManagement.Hide();
            ucProductManagement.Hide();
            ucSupplierManagement.Hide();
            orderDetails.Hide();
            updateOrder.Hide();
            
        }
        //Update order page
        private void updateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //show
            FillOrder_Update(dataB.GetAllOrderNotOK());
            updateOrder.Show();
            updateOrder.BringToFront();
            //Hide
            login.Hide();
            register.Hide();
            actions.Hide();
            products.Hide();
            ucEmployeeManagement.Hide();
            ucProductManagement.Hide();
            ucSupplierManagement.Hide();
            orderDetails.Hide();
       
        }
        //Statics page
        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statics.Show();
            statics.BringToFront();
            statics.Loadchart1(dataB.SumProM((statics.DateM.Value.Month), statics.DateM.Value.Year));
            statics.LoadChart2(dataB.AllProducts());
        }
        //Message page
        private void messagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show
            if (dataB.GetNewMsgs().Length == 0)
            {
                MessageBox.Show("No messages", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FillMsgs(dataB.GetNewMsgs());
                ucMessage.Show();
                ucMessage.BringToFront();
                ucMessage.DgvmsgOrderDetails.Rows.Clear();
                ucMessage.tbOrdercode.Text = "";
                ucMessage.tbOrderDate.Text = "";
                ucMessage.tbSupplierName.Text = "";
                ucMessage.tbPayment.Text = "";
            }
            //Hide
            login.Hide();
            register.Hide();
            actions.Hide();
            products.Hide();
            ucEmployeeManagement.Hide();
            ucSupplierManagement.Hide();
            ucProductManagement.Hide();
            orderDetails.Hide();
            updateOrder.Hide();       
        }
        //Exit 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                return;
            }
        }
        /*Menu Item Events Ends */

        //Function to Check if the Text Box conatins letter
        public int CheckNumber(string tb)
        {
            int n=0,i=0;
            while(i<tb.Length)
            {
                if (char.IsNumber(tb[i]) == false)
                {
                    n = 1;
                }
                i++;
            }
            return n;
        }
        public int IsValidEmail(string email)
        {
            Regex check = new Regex(@"^\w+[\w-\.]+\@\w{5}\.[a-z]{2,3}$");
            bool valid = false;
            valid = check.IsMatch(email);
            if (valid == true)
            {
                return 1;
            }
            else { return 0; }

        }
      //functin for prepare automticlly order
       public void AutoOrder()
        {
            while (dataB.SelectAllProductToOrder().Length > 0)
            {
                int sc = MinQtyOrder(dataB.SelectAllProductToOrder());
                dataB.DelProdFromOrder(sc);
            }
        }
        //function for add products for automaticlly order
        public int MinQtyOrder(Product[] prodArr)
        {
            int pay = 0;
            Product[] minArr = prodArr;
            int sc = minArr[0].SupplierCode;
            for(int i=0;i<minArr.Length;i++)
            {
                if (minArr[i].SupplierCode == sc)
                {
                   
                    OrderDetails od = new OrderDetails(0, minArr[i].ProdCode, minArr[i].ProdName.ToString(), (minArr[i].MinQty - minArr[i].ProdAmount) + 1);
                    dataB.InsertOrderDetails(od);
                    pay += ((minArr[i].MinQty - minArr[i].ProdAmount) + 1) * minArr[i].ProdPrice;
                }
            }
            MSG msg = new MSG("Submit the order (auto)");
            dataB.NewMsg(msg);
            Order ord = new Order(DateTime.Now.Date, sc, false, dataB.GetLastMsg(), pay);
            dataB.NewOrder(ord);
            for(int k=0;k<dataB.SelectAllOrderDetails().Length;k++)
            {
                dataB.ChangeOrdercode(dataB.GetLastOrder());
            }
            return sc; 
        }
        //Refresh messages
        public void RefreshMSG()
        {
            timer1.Start();
        }
        //Function of timer that refresh data of messages every 30 min
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (dataB.SelectAllProductToOrder().Length > 0)
            {
                AutoOrder();
                FillMsgs(dataB.GetNewMsgs());
                MessageBox.Show("New Order ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RefreshMSG();
        }
    }
}
