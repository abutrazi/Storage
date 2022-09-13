using System;
using System.Data;
using System.Data.OleDb;

namespace Storage.Classes
{    /*In this class i connet phsiclly to data base*/
    public class DbAccess
    {    
        #region Constructor + Members
        protected OleDbConnection _conn = null;
        public DbAccess(string connectionString)
        {
            try
            {
                _conn = new OleDbConnection(connectionString);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Protected Methods
        //Connect
        protected void Connect()
        {
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
        }
        //Disconnect
        protected void Disconnect()
        {
            _conn.Close();
        }
        //function recive a command and resolve a simple query like add,update,delete
        protected void ExecuteSimpleQuery(OleDbCommand command)
        {
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    command.ExecuteNonQuery();//Query like insert/update/delete
                }
                finally
                {
                    Disconnect();
                }
            }
        }
        //function recive a command and returns a numeric value after resolving a query
        protected int ExecuteScalarIntQuery(OleDbCommand command)
        {
            int ret = -1;
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    ret = (int)command.ExecuteScalar();
                }
                finally
                {
                    Disconnect();
                }
            }
            return ret;
        }
        //function recive a command and returns a string value after resolving a query
        protected string ExecuteScalarQuery(OleDbCommand command)
        {
            string result = "";
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    result = command.ExecuteScalar().ToString();
                }
                finally
                {
                    Disconnect();
                }
            }
            return result;
        }

        //returns a data set (the table as is in the data base)
        protected DataSet GetMultipleQuery(OleDbCommand command)
        {
            DataSet dataset = new DataSet();
            lock (_conn)
            {
                Connect();
                command.Connection = _conn;
                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataset);

                }
                catch (TypedDataSetGeneratorException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DataException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Disconnect();
                }
            }
            return dataset;
        }
        #endregion
    }
}
