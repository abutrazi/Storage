using System;
using System.Data.OleDb;
using System.Data;
using System.Collections;

namespace Storage.Classes
{
    /*This class is where i write all queries to use the data that stored in data base*/
    public class DBSQL : DbAccess
    {
        private static string connString;
        private static DBSQL instance;

        //c'tor
        public DBSQL(string connectionString) : base(connectionString)
        {
        }
        //Function that returns instance of database
        public static DBSQL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBSQL(connString);
                }
                return instance;
            }
        }
        //Getter/Setter for the connection string
        public static string ConnectionString
        {
            get
            {
                return connString;
            }
            set
            {
                connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + value + ";Persist Security Info=False;";
            }
        }
        /*Company Functions Start*/
        //Function that add company info
        public void InsertCompany(Company comp)
        {
            string cmdStr = "INSERT INTO Company (CompanyName,CompanyEmail,CompanyPassword) VALUES(@cn,@ce,@cp)";
            using(OleDbCommand command=new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@cn", comp.CompName);
                command.Parameters.AddWithValue("@ce", comp.CompEmail);
                command.Parameters.AddWithValue("@cp", comp.CompPass);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Function that update company info
        public void UpdateCompany(Company comp,int compid)
        {
            string cmdStr = "UPDATE Company SET CompanyName=@cn,CompanyEmail=@ce,CompanyPassword=@cp WHERE ID=@compid ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@cn", comp.CompName);
                command.Parameters.AddWithValue("@ce", comp.CompEmail);
                command.Parameters.AddWithValue("@cp", comp.CompPass);
                command.Parameters.AddWithValue("@compid", compid);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Return array of Comapny info 
        public Company[] Getinfo()
        {
            DataSet ds = new DataSet();
            ArrayList comp = new ArrayList();
            string cmdStr = "SELECT * From Company";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows) //deep copy to the arrayList
            {
                Company com = new Company();
                com.CompID = int.Parse(tType[0].ToString());
                com.CompName = tType[1].ToString();
                com.CompEmail = tType[2].ToString();
                com.CompPass = tType[3].ToString();

                comp.Add(com);
            }
            return (Company[])comp.ToArray(typeof(Company));

        }
        /*Company Funtion Ends*/
        /************************/
        /* Employee function start */
        //Function that Add an Employee
        public void InsertEmployee(Employee emp)
        {
            string cmdStr = "Insert INTO Employee (ID,Fname,Lname,Telphone,Email,Address,Username,[Password],Role)VALUES" +
                "(@ID,@Fname,@Lname,@Telphone,@Email,@Address,@Username,@Password,@Role)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@ID", emp.EmpID);
                command.Parameters.AddWithValue("@Fname", emp.EmpFname);
                command.Parameters.AddWithValue("@Lname", emp.EmpLname);
                command.Parameters.AddWithValue("@Telphone", emp.EmpTel);
                command.Parameters.AddWithValue("@Email", emp.EmpEmail);
                command.Parameters.AddWithValue("@Address", emp.EmpAddress);
                command.Parameters.AddWithValue("@Username", emp.EmpUsername);
                command.Parameters.AddWithValue("@Password", emp.EmpPassword);
                command.Parameters.AddWithValue("@Role", emp.EmpRole);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Return an array of all Employees 
        public Employee[] SelectAllEmployees()
        {
            DataSet ds = new DataSet();
            ArrayList Employee = new ArrayList();
            string cmdStr = "SELECT * From Employee WHERE Active=true";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows) //deep copy to the arrayList
            {
                Employee emp = new Employee();
                emp.EmpID = int.Parse(tType[0].ToString());
                emp.EmpFname = tType[1].ToString();
                emp.EmpLname = tType[2].ToString();
                emp.EmpTel = tType[3].ToString();
                emp.EmpEmail = tType[4].ToString();
                emp.EmpAddress = tType[5].ToString();
                emp.EmpUsername = tType[6].ToString();
                emp.EmpPassword = tType[7].ToString();
                emp.EmpRole = tType[8].ToString();

                Employee.Add(emp);
            }
            return (Employee[])Employee.ToArray(typeof(Employee));

        }
        //function that Update an Employee
        public void UpdateEmployee(Employee emp,int id)
        {
            string cmdStr = "UPDATE Employee set ID=@id,Fname=@fn,Lname=@ln,Telphone=@tel,Email=@em,Address=@add, UserName=@un,[Password]=@pw ,Role=@rl WHERE  ID=@id_a";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", emp.EmpID);
                command.Parameters.AddWithValue("@fn", emp.EmpFname);
                command.Parameters.AddWithValue("@ln", emp.EmpLname);
                command.Parameters.AddWithValue("@tel", emp.EmpTel);
                command.Parameters.AddWithValue("@em", emp.EmpEmail);
                command.Parameters.AddWithValue("@add", emp.EmpAddress);
                command.Parameters.AddWithValue("@un", emp.EmpUsername);
                command.Parameters.AddWithValue("@pw", emp.EmpPassword);
                command.Parameters.AddWithValue("@rl", emp.EmpRole);
                command.Parameters.AddWithValue("@id_a", id);
                base.ExecuteSimpleQuery(command);
            }
        }

        //Function that deletean Employee
        public void DeleteEmployee(int Empid)
        {
            string cmdStr = "UPDATE Employee set Active=false where ID=@id_a";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("id_a", Empid);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Return count of username and password that have same data
        public int LoginCheck(string username,string password)
        {
            int res;
            string cmdStr = "SELECT COUNT(*) from Employee WHERE Username= '" + username +" 'AND Password='"+password +"'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }
        //Return an array of data for employee that has same username anad password
        public Employee[] CheckAdmin(string username, string password)
        {
            DataSet ds = new DataSet();
            ArrayList Employee = new ArrayList();
            string cmdStr = "SELECT Role FROM Employee WHERE Username = '" + username +" 'AND Password = '"+password +"'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows) //deep copy to the arrayList
            {
                Employee emp = new Employee();
                emp.EmpRole = tType[0].ToString();

                Employee.Add(emp);
            }
            return (Employee[])Employee.ToArray(typeof(Employee));
           
        }
        //Return count of ID taht has same id
        public int CheckID(int id)
        {
            int res;
            string cmdStr = "SELECT COUNT(ID) FROM Employee WHERE ID=@id";
            using (OleDbCommand command=new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", id);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }
        //Return count of username tha has me username
        public int CheckUsername(string username)
        {
            int res;
            string cmdStr = "SELECT COUNT(UserName) FROM Employee WHERE UserName=@username";
            using(OleDbCommand command=new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@username", username);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }
        /*Employee functions ends*/
        /*********************************************/
        /*Product functions start */
        //Function that insert Product
        public void InsertProd(Product p)
        {
            string cmdStr = "INSERT INTO Product ( ProductCode, ProductName, [ProductSize], ProductPrice,ProductAmount,MinQty,SupplierCode )" +
                " VALUES (@Code,@Name,@Size,@Price,@Amount,@MinQty,@sc)";
            using(OleDbCommand command= new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@Code", p.ProdCode);
                command.Parameters.AddWithValue("@Name", p.ProdName);
                command.Parameters.AddWithValue("@Size", p.ProdSize);
                command.Parameters.AddWithValue("@Price", p.ProdPrice);
                command.Parameters.AddWithValue("@Amount", 0);
                command.Parameters.AddWithValue("@MinQty", p.MinQty);
                command.Parameters.AddWithValue("@sc", p.SupplierCode);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Function that Update Product 
        public void UpdateProduct(Product p ,int Pid)
        {
            string cmdStr = "UPDATE Product SET ProductCode = @code, ProductName = @name, [ProductSize] = @size," +
                " ProductPrice = @price ,ProductAmount=@amount, MinQty=@minqty ,SupplierCode=@sc where ProductCode=@Pid ";
            using(OleDbCommand command=new OleDbCommand (cmdStr))
            {
                command.Parameters.AddWithValue("@code", p.ProdCode);
                command.Parameters.AddWithValue("@name", p.ProdName);
                command.Parameters.AddWithValue("@size", p.ProdSize);
                command.Parameters.AddWithValue("@price", p.ProdPrice);
                command.Parameters.AddWithValue("@amount", p.ProdAmount);
                command.Parameters.AddWithValue("@minqty", p.MinQty);
                command.Parameters.AddWithValue("@sc", p.SupplierCode);
                command.Parameters.AddWithValue("@Pid", Pid);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Function that delete Product
        public void DeleteProduct(int Pid)
        {
            string cmdStr = "DELETE FROM Product where ProductCode=@pid_a";
            using(OleDbCommand command=new OleDbCommand(cmdStr))
                {
                command.Parameters.AddWithValue("@pid_a", Pid);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Function that select all products
        public Product[] SelectAllProducts()
        {
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = "Select * From Product";
            using(OleDbCommand command =new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach(DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Product prod = new Product();
                prod.ProdCode = int.Parse(tType[0].ToString());
                prod.ProdName = tType[1].ToString();
                prod.ProdSize = tType[2].ToString();
                prod.ProdPrice = int.Parse(tType[3].ToString());
                prod.ProdAmount = int.Parse(tType[4].ToString());
                prod.MinQty = int.Parse(tType[5].ToString());
                prod.SupplierCode =int.Parse( tType[6].ToString());

                products.Add(prod);
            }
            return (Product[])products.ToArray(typeof(Product));
        }
        //Return an array of Products of supplier by supplier code 
        public Product[] SelectAllProductsSup(int sc)
        {
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = "Select * From Product  WHERE SupplierCode=@sc";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@sc", sc);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Product prod = new Product();
                prod.ProdCode = int.Parse(tType[0].ToString());
                prod.ProdName = tType[1].ToString();
                prod.ProdSize = tType[2].ToString();
                prod.ProdPrice = int.Parse(tType[3].ToString());
                prod.ProdAmount = int.Parse(tType[4].ToString());
                prod.MinQty = int.Parse(tType[5].ToString());
                prod.SupplierCode = int.Parse(tType[6].ToString());

                products.Add(prod);
            }
            return (Product[])products.ToArray(typeof(Product));
        }
        //Return an array of Products of supplier by supplier code (for update order)
        public Product[] SelectOrderProduct(int sc)
        {
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = "Select ProductCode,ProductName,ProductSize,ProductPrice From Product WHERE SupplierCode=@sc";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@sc", sc);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Product prod = new Product();
                prod.ProdCode = int.Parse(tType[0].ToString());
                prod.ProdName = tType[1].ToString();
                prod.ProdSize = tType[2].ToString();
                prod.ProdPrice = int.Parse(tType[3].ToString());

                products.Add(prod);
            }
            return (Product[])products.ToArray(typeof(Product));
        }
       //Return an array of products that have same product code 
        public Product[] SearchByCode(int valueToSearch)
        {
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = "SELECT * FROM Product WHERE ProductCode LIKE '%" + valueToSearch + "%'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arrayList  
            {
                Product p = new Product();
                p.ProdCode = int.Parse(tType[0].ToString());
                p.ProdName = tType[1].ToString();
                p.ProdSize = tType[2].ToString();
                p.ProdPrice = int.Parse(tType[3].ToString());
                p.ProdAmount = int.Parse(tType[4].ToString());
               

                products.Add(p);
            }
            return (Product[])products.ToArray(typeof(Product));
        }
        //Return an array of products that have same product name
        public Product[] SearchByName(string valueToSearch)
        {
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = "SELECT * FROM Product WHERE ProductName LIKE '%" + valueToSearch + "%'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arrayList  
            {
                Product p = new Product();
                p.ProdCode = int.Parse(tType[0].ToString());
                p.ProdName = tType[1].ToString();
                p.ProdSize = tType[2].ToString();
                p.ProdPrice = int.Parse(tType[3].ToString());
                p.ProdAmount = int.Parse(tType[4].ToString());
                


                products.Add(p);
            }
            return (Product[])products.ToArray(typeof(Product));
        }
        //Function that return count of products that have same code
        public int CheckProd(int code)
        {
            int res;
            string cmdStr = "SELECT COUNT(ProductCode) FROM Product WHERE ProductCode=@code";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", code);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }
        public Product[] AllProducts()
        {
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = "Select ProductName,Sum(ProductAmount) From Product " +
                "GROUP BY ProductName";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Product prod = new Product();
              //  prod.ProdCode = int.Parse(tType[0].ToString());
                prod.ProdName = tType[0].ToString();
                //prod.ProdSize = tType[2].ToString();
                //prod.ProdPrice = int.Parse(tType[3].ToString());
                prod.ProdAmount = int.Parse(tType[1].ToString());
                //prod.MinQty = int.Parse(tType[5].ToString());
                //prod.SupplierCode = int.Parse(tType[6].ToString());

                products.Add(prod);
            }
            return (Product[])products.ToArray(typeof(Product));
        }
        /*Product functions ends */

        /**********************************/
        /*Product To Order*/
        //Function that add product to list to prepare automaticlly order
        public void AddProdToOrder(Product p)
        {
            string cmdStr = "INSERT INTO ProductToOrder ( ProductCode, ProductName, [ProductSize], ProductPrice,ProductAmount,MinQty,SupplierCode )" +
                " VALUES (@Code,@Name,@Size,@Price,@Amount,@MinQty,@sc)";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@Code", p.ProdCode);
                command.Parameters.AddWithValue("@Name", p.ProdName);
                command.Parameters.AddWithValue("@Size", p.ProdSize);
                command.Parameters.AddWithValue("@Price", p.ProdPrice);
                command.Parameters.AddWithValue("@Amount", p.ProdAmount);
                command.Parameters.AddWithValue("@MinQty", p.MinQty);
                command.Parameters.AddWithValue("@sc", p.SupplierCode);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Function that delete product from list 
        public void DelProdFromOrder(int sc)
        {
            string cmdStr = "DELETE FROM ProductToOrder where SupplierCode=@sc";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@sc", sc);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Return ana array of products to prepare automaticlly order 
        public Product[] SelectAllProductToOrder()
        {
            DataSet ds = new DataSet();
            ArrayList products = new ArrayList();
            string cmdStr = "Select * From ProductToOrder";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Product prod = new Product();
                prod.ProdCode = int.Parse(tType[0].ToString());
                prod.ProdName = tType[1].ToString();
                prod.ProdSize = tType[2].ToString();
                prod.ProdPrice = int.Parse(tType[3].ToString());
                prod.ProdAmount = int.Parse(tType[4].ToString());
                prod.MinQty = int.Parse(tType[5].ToString());
                prod.SupplierCode = int.Parse(tType[6].ToString());

                products.Add(prod);
            }
            return (Product[])products.ToArray(typeof(Product));
        }
        /**********************************/
        /*Supplier Functions Start*/
        //Function that add Supplier
        public void InsertSupplier(Supplier s)
        {
            string cmdstring = "INSERT INTO Supplier ( SupplierCode, SupplierName, SupplierTelphone, SupplierEmail, SupplierAddress ) VALUES " +
                "(@Code,@Name,@Telphone,@Email,@Address) ";
            using (OleDbCommand command=new OleDbCommand(cmdstring))
            {
                command.Parameters.AddWithValue("@Code", s.SupCode);
                command.Parameters.AddWithValue("@Name", s.SupName);
                command.Parameters.AddWithValue("@Telphone", s.SupTel);
                command.Parameters.AddWithValue("@Email", s.SupEmail);
                command.Parameters.AddWithValue("@Address", s.SupAdd);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Function that update supplier
        public void UpdateSupplier(Supplier s,int Supid)
        {
            string cmdstring = "UPDATE Supplier SET Code=@code ,Name=@name ,Telphone=@telphone ,Email=@email ,Address=@address" +
                " WHERE Sid_auto=@Supid";
            using(OleDbCommand command=new OleDbCommand(cmdstring))
            {
                command.Parameters.AddWithValue("@code", s.SupCode);
                command.Parameters.AddWithValue("@name", s.SupName);
                command.Parameters.AddWithValue("@telphone", s.SupTel);
                command.Parameters.AddWithValue("@email", s.SupEmail);
                command.Parameters.AddWithValue("@address", s.SupAdd);
                command.Parameters.AddWithValue("@Supid", Supid);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Function that delete supplier
        public void DeleteSupplier(int Supid)
        {
            string cmdStr = "UPDATE Supplier set Active=false WHERE Sid_auto=@Supid";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@Supid", Supid);
                base.ExecuteSimpleQuery(command);
            }
        }
        //REturn an array of suppliers
        public Supplier[] SelectAllSupplier()
        {
            DataSet ds = new DataSet();
            ArrayList suppliers = new ArrayList();
            string cmdStr = "Select * From Supplier WHERE Active=true";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Supplier s = new Supplier();
                s.SUPID_AUTO = int.Parse(tType[0].ToString());
                s.SupCode = int.Parse(tType[1].ToString());
                s.SupName = tType[2].ToString();
                s.SupTel = tType[3].ToString();
                s.SupEmail= tType[4].ToString();
                s.SupAdd = tType[5].ToString();

                suppliers.Add(s);
            }
            return (Supplier[])suppliers.ToArray(typeof(Supplier));
        }
        //Reurn an array of all supplier from copy table of supplier
        public Supp[] CAllSupp()
        {
            DataSet ds = new DataSet();
            ArrayList suppliers = new ArrayList();
            string cmdStr = "Select * From Supp";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Supp s = new Supp();
                s.CSuppCode = int.Parse(tType[0].ToString());
                s.CSuppName = tType[1].ToString();
                suppliers.Add(s);
            }
            return (Supp[])suppliers.ToArray(typeof(Supp));
        }
        //Return name of supplier by supplier id from copy table of supplier
        public string GetSupplierName(int id)
        {
            string supplierName;
            string cmdStr = "SELECT Suppname FROM Supp WHERE ID=@id";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", id);
                supplierName = ExecuteScalarQuery(command);
            }
            return supplierName;
        }
        //Return id supplier by supplier name from copy table of supplier
        public int GetSupplierId(string supplierName)
        {
            int id;
            string cmdStr = "SELECT ID FROM Supp WHERE Suppname=@name";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@name", supplierName);
                id = ExecuteScalarIntQuery(command);
            }

            return id;
        }
        //Return an array of supplier taht has same code(Search )
        public Supplier[] SearchSupplierByCode(int valueToSearch)
        {
            DataSet ds = new DataSet();
            ArrayList supplier = new ArrayList();
            string cmdStr = "SELECT * FROM Supplier WHERE SupplierCode LIKE '%" + valueToSearch + "%'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arrayList  
            {
                Supplier s = new Supplier();
                s.SUPID_AUTO = int.Parse(tType[0].ToString());
                s.SupCode= int.Parse(tType[1].ToString());
                s.SupName = tType[2].ToString();
                s.SupTel = tType[3].ToString();
                s.SupEmail = tType[4].ToString();
                s.SupAdd = tType[5].ToString();


                supplier.Add(s);
            }
            return (Supplier[])supplier.ToArray(typeof(Supplier));
        }
        //Return an array of supplier taht has same name(Search )
        public Supplier[] SearchSupplierByName(string valueToSearch)  
        {
            DataSet ds = new DataSet();
            ArrayList supplier = new ArrayList();
            string cmdStr = "SELECT * FROM Supplier WHERE SupplierName LIKE '%" + valueToSearch + "%'";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arrayList  
            {
                Supplier s = new Supplier();
                s.SUPID_AUTO = int.Parse(tType[0].ToString());
                s.SupCode = int.Parse(tType[1].ToString());
                s.SupName = tType[2].ToString();
                s.SupTel = tType[3].ToString();
                s.SupEmail = tType[4].ToString();
                s.SupAdd = tType[5].ToString();


                supplier.Add(s);
            }
            return (Supplier[])supplier.ToArray(typeof(Supplier));
        }
        //Return Email of Supplier by scan by supplier code 
        public string EmailSupplier(int sc)
        {
            string mail;
            string cmdStr = "SELECT SupplierEmail FROM Supplier WHERE SupplierCode=@sc";
            using(OleDbCommand command=new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@sc", sc);
                mail = ExecuteScalarQuery(command);
            }
            return mail;
        }
        //Function that return count of suppliers that have same code 
        public int CheckSupp(int scode)
        {
            int res;
            string cmdStr = "SELECT COUNT(SupplierCode) FROM Supplier WHERE SupplierCode=@scode";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@id", scode);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }
        //Function to insert supplier code and name to copy table of supplier
        public void CopySuplier(Supp s)
        {
            string cmdstring = "INSERT INTO Supp ( ID, Suppname ) VALUES " +
               "(@ID,@Name) ";
            using (OleDbCommand command = new OleDbCommand(cmdstring))
            {
                command.Parameters.AddWithValue("@ID", s.CSuppCode);
                command.Parameters.AddWithValue("@Name", s.CSuppName);
            
                base.ExecuteSimpleQuery(command);
            }
        }
        //Function that return count of products of supplier 
        public int checksupplierproduct(int code)
        {
            int res;
            string cmdStr = "Select COUNT(ProductCode) FROM Product WHERE SupplierCode=@code";
            using(OleDbCommand command=new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@code", code);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }
        /*Supplier Functions Ends*/
        /*********************************/
        /*Order Events Start*/
        //Function of new order
        public void NewOrder(Order ord)
        {
            string cmdStr = "INSERT INTO [Order] (OrderDate,SupplierCode,OK,MsgId,Payment) VALUES (@od,@sc,@ok,@msgid,@pay)";
            using (OleDbCommand command=new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@od", ord.OrderDate);
                command.Parameters.AddWithValue("@sc", ord.SupplierCode);
                command.Parameters.AddWithValue("@ok", ord.OrderOK);
                command.Parameters.AddWithValue("@msgid", ord.MsgId);
                command.Parameters.AddWithValue("@pay", ord.Payment);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Function to confirme the order
        public void OKOreder(int oc)
        {
            string cmdStr= "UPDATE [Order] SET   OK=true WHERE OrderCode=@oc";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@oc", oc);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Return an array of order not yet confirmed
        public Order[] GetAllOrderNotOK()
        {
            DataSet ds = new DataSet();
            ArrayList orders = new ArrayList();
            string cmdStr = "Select * From [Order]  WHERE OK=false";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Order od = new Order();
                od.OrderCode = int.Parse(tType[0].ToString());
                od.OrderDate = DateTime.Parse(tType[1].ToString());
                od.SupplierCode = int.Parse(tType[2].ToString());
                od.OrderOK = bool.Parse(tType[3].ToString());
                od.MsgId = int.Parse(tType[4].ToString());
                od.Payment = int.Parse(tType[5].ToString());


                orders.Add(od);
            }
            return (Order[])orders.ToArray(typeof(Order));
        }
        //Retrun an array of order that confirmed
        public Order[] GetOrderOK(int oc)
        {
            DataSet ds = new DataSet();
            ArrayList orders = new ArrayList();
            string cmdStr = "Select * From [Order]  WHERE OrderCode=@oc";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@oc", oc);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Order od = new Order();
                od.OrderCode = int.Parse(tType[0].ToString());
                od.OrderDate = DateTime.Parse(tType[1].ToString());
                od.SupplierCode = int.Parse(tType[2].ToString());
                od.OrderOK = bool.Parse(tType[3].ToString());
                od.MsgId = int.Parse(tType[4].ToString());
                od.Payment = int.Parse(tType[5].ToString());


                orders.Add(od);
            }
            return (Order[])orders.ToArray(typeof(Order));
        }
        //return an array of order by message id 
        public Order[] GetOrder(int msid)
        {
            DataSet ds = new DataSet();
            ArrayList orders = new ArrayList();
            string cmdStr = "Select * From [Order] WHERE MsgId=@msgid ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@msgid", msid);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Order od = new Order();
                od.OrderCode = int.Parse(tType[0].ToString());
                od.OrderDate = DateTime.Parse(tType[1].ToString());
                od.SupplierCode = int.Parse(tType[2].ToString());
                od.OrderOK = bool.Parse(tType[3].ToString());
                od.MsgId = int.Parse(tType[4].ToString());
                od.Payment = int.Parse(tType[5].ToString());

                orders.Add(od);
            }
            return (Order[])orders.ToArray(typeof(Order));
        }
        //return an array of orders by month and year 
        public Order[] GetOrderByMonth(int m,int y)
        {
            DataSet ds = new DataSet();
            ArrayList orders = new ArrayList();
            string cmdStr = "Select * From [Order]  WHERE OK=true AND   " +
                " MONTH([Order].OrderDate)=@m AND YEAR([Order].OrderDate)=@y ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@m", m);
                command.Parameters.AddWithValue("@y", y);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                Order od = new Order();
                od.OrderCode = int.Parse(tType[0].ToString());
                od.OrderDate = DateTime.Parse(tType[1].ToString());
                od.SupplierCode = int.Parse(tType[2].ToString());
                od.OrderOK = bool.Parse(tType[3].ToString());
                od.MsgId = int.Parse(tType[4].ToString());
                od.Payment = int.Parse(tType[5].ToString());


                orders.Add(od);
            }
            return (Order[])orders.ToArray(typeof(Order));
        }
        //Return number of last order    
        public int GetLastOrder()
        {
            int res;
            string cmdStr = "SELECT TOP 1 OrderCode FROM [Order] ORDER BY OrderCode DESC";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }
        //Function that update order by order code 
        public void UpdateOrder_update(int Uoc,int pay)
        {
            string cmdStr = "UPDATE [Order] SET Payment=@pay WHERE OrderCode=@uoc";
            using (OleDbCommand command=new OleDbCommand(cmdStr))
            {
                
                command.Parameters.AddWithValue("@pay", pay);
                command.Parameters.AddWithValue("@uoc", Uoc);
                base.ExecuteSimpleQuery(command);
            }
        }

        /*Order Events Ends*/
        /********************************/
        /*Order Details Events Start*/
        //Function to add product to order
        public void InsertOrderDetails(OrderDetails od)
        {
            string cmdString = "INSERT INTO [Order Details] ( OrderCode,ProductCode, ProductName, Quantity )" +
                "VALUES(@ordercode,@prodcode,@prodname,@qty)";             
            using (OleDbCommand command=new OleDbCommand(cmdString))
            {
                command.Parameters.AddWithValue("@ordercode", od.OrderCode);
                command.Parameters.AddWithValue("@prodcode", od.ProductCode);
                command.Parameters.AddWithValue("@prodname", od.ProductName);
                command.Parameters.AddWithValue("@qty", od.Quantity);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Function to update order details 
        public void UpdateOrderdetails(OrderDetails od,int odid)
        {
            string cmdStr = "UPDATE [Order Details] set  OrderCode=@oc,ProductCode=@pc, ProductName=@pn, Quantity=@qty WHERE Orderid=@odid";
            using(OleDbCommand command=new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@oc", od.OrderCode);
                command.Parameters.AddWithValue("@pc", od.ProductCode);
                command.Parameters.AddWithValue("@pn", od.ProductName);
                command.Parameters.AddWithValue("@qty", od.Quantity);
                command.Parameters.AddWithValue("@odid", odid);
                base.ExecuteSimpleQuery(command);
            }

        }
        //Function to update quantity of produts in order
        public void UpdateOrderdetails_Update(OrderDetails od, int odid)
        {
            string cmdStr = "UPDATE [Order Details] set  Quantity=@qty WHERE Orderid=@odid ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
               
                command.Parameters.AddWithValue("@qty", od.Quantity);
                command.Parameters.AddWithValue("@odid", odid);
                base.ExecuteSimpleQuery(command);
            }

        }
        //Function to update order code 
        public void ChangeOrdercode(int oc)
        {
            string cmdStr = "UPDATE [Order Details] set  OrderCode=@oc WHERE OrderCode=0";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@oc", oc);
                base.ExecuteSimpleQuery(command);
            }

        }
        public void DeleteOrderdeatils(int odid)
        {
            string cmdStr = "DELETE FROM [Order Details] WHERE Orderid=@odid";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@odid", odid);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Return an array of order details 
       public OrderDetails[] SelectAllOrderDetails()
        {
            DataSet ds = new DataSet();
            ArrayList orderdetails = new ArrayList();
            string cmdStr = "SELECT * FROM [Order Details] WHERE OrderCode=0";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
 
                ds = GetMultipleQuery(command);
   
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                OrderDetails od = new OrderDetails();
                od.Orderid = int.Parse(tType[0].ToString());
                od.OrderCode = int.Parse(tType[1].ToString());
                od.ProductCode = int.Parse(tType[2].ToString());
                od.ProductName = tType[3].ToString();
                od.Quantity = int.Parse(tType[4].ToString());
                orderdetails.Add(od);
            }
            return (OrderDetails[])orderdetails.ToArray(typeof(OrderDetails));
        }
        //Return an array of order details of order by order code 
        public OrderDetails[] SelectAllOrderDetail(int odc)
        {
            DataSet ds = new DataSet();
            ArrayList orderdetails = new ArrayList();
            string cmdStr = "SELECT * FROM [Order Details] WHERE OrderCode=@odc";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@odc", odc);
                ds = GetMultipleQuery(command);

            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                OrderDetails od = new OrderDetails();
                od.Orderid = int.Parse(tType[0].ToString());
                od.OrderCode = int.Parse(tType[1].ToString());
                od.ProductCode = int.Parse(tType[2].ToString());
                od.ProductName = tType[3].ToString();
                od.Quantity = int.Parse(tType[4].ToString());
                orderdetails.Add(od);
            }
            return (OrderDetails[])orderdetails.ToArray(typeof(OrderDetails));
        }
        //Return number of products in order by product code and order code 
        public int SearchProductInOrderDetails(int pc,int oc)
        {
            int res;
            string cmdStr = "SELECT Count(*) FROM [Order Details] INNER JOIN  [Order] ON [Order].OrderCode=[Order Details].OrderCode WHERE [Order Details].ProductCode=@pc AND [Order].OrderCode=@oc ";
            using(OleDbCommand command =new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@pc", pc);
                command.Parameters.AddWithValue("@oc", oc);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }
        //Return Price of product by order product code 
        public int GetPrice(int odid)
        {
            int price;
            string cmdStr = "SELECT ProductPrice From Product INNER JOIN [Order Details] ON [Order Details].ProductCode=Product.ProductCode WHERE [Order Details].ProductCode=@odid";
            using(OleDbCommand command=new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@odid", odid);
                price = ExecuteScalarIntQuery(command);
            }
            return price;
        }
        //Return number of products that order code = 0
        public int CheckProduct(int po)
        {
            int res;
            string cmdStr = "SELECT COUNT(ProductCode) FROM [Order Details] WHERE ProductCode=@po AND OrderCode=0";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@po", po);
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }
        //Return an array of oder details with sum of Quantity for month
        public OrderDetails[] SumProM(int m,int y)
        {
            DataSet ds = new DataSet();
            ArrayList orderdetails = new ArrayList();
            string cmdStr = "SELECT ProductCode,ProductName,sum(Quantity)  FROM [Order Details] INNER JOIN [Order] ON " +
                "[Order Details].OrderCode=[Order].OrderCode WHERE MONTH([Order].OrderDate)=@m AND YEAR([Order].OrderDate)=@y " +
                "GROUP BY [Order Details].ProductCode,[Order Details].ProductName";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@m", m);
                command.Parameters.AddWithValue("@y", y);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                OrderDetails od = new OrderDetails();

                od.ProductCode = int.Parse(tType[0].ToString());
                od.ProductName = tType[1].ToString();
                od.Quantity = int.Parse(tType[2].ToString());

                orderdetails.Add(od);
            }
            return (OrderDetails[])orderdetails.ToArray(typeof(OrderDetails));
        }
        //Return an array of oder details with sum of Quantity for year 
        public OrderDetails[] SumProYear( int y)
        {
            DataSet ds = new DataSet();
            ArrayList orderdetails = new ArrayList();
            string cmdStr = "SELECT ProductCode,ProductName,sum(Quantity)  FROM [Order Details] INNER JOIN [Order] ON " +
                "[Order Details].OrderCode=[Order].OrderCode WHERE  YEAR([Order].OrderDate)=@y " +
                "GROUP BY [Order Details].ProductCode,[Order Details].ProductName";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {

                command.Parameters.AddWithValue("@y", y);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                OrderDetails od = new OrderDetails();

                od.ProductCode = int.Parse(tType[0].ToString());
                od.ProductName = tType[1].ToString();
                od.Quantity = int.Parse(tType[2].ToString());

                orderdetails.Add(od);
            }
            return (OrderDetails[])orderdetails.ToArray(typeof(OrderDetails));
        }
        //Return an array of order details that product has most appaerance
        public OrderDetails[] MostAppearance(int m1,int m2,int y1,int y2)
        {
            DataSet ds = new DataSet();
            ArrayList orderdetails = new ArrayList();
            string cmdStr = "SELECT Top 3 ProductCode,ProductName, sum(Quantity)   FROM [Order Details] INNER JOIN [Order] ON " +
                "[Order Details].OrderCode=[Order].OrderCode WHERE (MONTH([Order].OrderDate BETWEEN @m1 AND @m2) AND (YEAR[Order].OrderDate) " +
                "GROUP BY [Order Details].ProductCode,[Order Details].ProductName" +
                " Order BY sum(Quantity) DESC";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@m1", m1);
                command.Parameters.AddWithValue("@m2", m2);
                command.Parameters.AddWithValue("@y1", y1);
                command.Parameters.AddWithValue("@y2", y2);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                OrderDetails od = new OrderDetails();

                od.ProductCode = int.Parse(tType[0].ToString());
                od.ProductName = tType[1].ToString();
                od.Quantity = int.Parse(tType[2].ToString());

                orderdetails.Add(od);
            }
            return (OrderDetails[])orderdetails.ToArray(typeof(OrderDetails));
        }
        /*Order Details Events Ends*/
        /************************************/
        /*Message Events Start*/
        //Function to add new message
        public void NewMsg(MSG msg)
        {
            string cmdStr = "INSERT INTO Message (MessageSub) VALUES(@msgsub)";
            using(OleDbCommand command=new OleDbCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@msgsub", msg.MsgSubject);
                base.ExecuteSimpleQuery(command);
            }
        }
        //Return an array of messages
        public MSG[] GetNewMsgs()
        {
            DataSet ds = new DataSet();
            ArrayList msgs = new ArrayList();
            string cmdStr = "Select * From Message INNER JOIN [Order] ON [Order].MsgId=Message.MsgId WHERE [Order].OK=false ORDER BY Message.MsgID DESC ";
            using (OleDbCommand command = new OleDbCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch { }
            foreach (DataRow tType in dt.Rows)//deep copy to the arraylist
            {
                MSG msg = new MSG();
                msg.MsgID = int.Parse(tType[0].ToString());
                msg.MsgSubject = tType[1].ToString();
                msgs.Add(msg);
            }
            return (MSG[])msgs.ToArray(typeof(MSG));
        }
        //Return number of last message 
        public int GetLastMsg()
        {
            int res;
            string cmdStr = "SELECT TOP 1 MsgID FROM Message ORDER BY MsgID DESC";
            using(OleDbCommand command=new OleDbCommand(cmdStr))
            {
                res = ExecuteScalarIntQuery(command);
            }
            return res;
        }
        /*Message Events Ends*/
    } 
}
