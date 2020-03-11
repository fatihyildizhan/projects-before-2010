using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


public class DbManager

    private enum TransactionState { Opened, Closed };
    private TransactionState _transactionState = TransactionState.Closed;
    bool _transactionMode;
    private ArrayList _parameters = new ArrayList();
    private SqlConnection sc = new SqlConnection();
    private SqlTransaction st = null;

    public DbManager(bool TransactionMode)
    {
        _transactionMode = TransactionMode;
        sc = ConnectionProvider.GetConnection();
    }

    public DbManager(bool TransactionMode, SqlTransaction StTrans)
    {
        _transactionMode = TransactionMode;
        st = StTrans;
        sc = ConnectionProvider.GetConnection();
    }

    private SqlCommand GetCommand(string commandText, CommandType commandType)
    {
        SqlCommand command = sc.CreateCommand();
        command.CommandType = commandType;
        command.CommandText = commandText;
        try
        {
            if (_transactionMode == true)
            {
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }
                ManageTransaction();
                command.Transaction = st;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return command;
    }

    private void ProcessParameters(SqlCommand command)
    {
        foreach (SqlParameter myparameter in _parameters)
        {
            command.Parameters.Add(myparameter);
        }
    }

    public void AddInParameters(string parameterName, SqlDbType dbType, object value)
    {
        SqlParameter myParameter = new SqlParameter();
        myParameter.ParameterName = parameterName;
        myParameter.SqlDbType = dbType;
        myParameter.Value = value;
        _parameters.Add(myParameter);
    }

    public void AddOutParameter(string parameterName, SqlDbType dbType)
    {
        SqlParameter myParameter = new SqlParameter();
        myParameter.ParameterName = parameterName;
        myParameter.SqlDbType = dbType;
        myParameter.Direction = ParameterDirection.Output;
        _parameters.Add(myParameter);
    }

    public object GetParameterValue(string parameterName)
    {
        object return_value = null;
        foreach (SqlParameter myParameter in _parameters)
        {
            if (myParameter.ParameterName == parameterName)
            {
                return_value = myParameter.Value;
            }
        }
        return return_value;
    }

    public void ClearParameters()
    {
        _parameters.Clear();
    }

    private void ManageCommandConnectionState(SqlCommand cmd, bool Islem)
    {
        if (_transactionMode == false)
        {
            if (Islem == true)
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
            }
            else
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }
    }

    public int ExecuteNonQuery(string commandText, CommandType commandType)
    {
        int return_value = 0;
        SqlCommand myCommand = this.GetCommand(commandText, commandType);
        this.ProcessParameters(myCommand);
        try
        {
            ManageCommandConnectionState(myCommand, true);

            return_value = myCommand.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            ManageCommandConnectionState(myCommand, false);
        }
        return return_value;
    }

    public object ExecuteScalar(string commandText, CommandType commandType)
    {
        object return_value = null;
        SqlCommand myCommand = this.GetCommand(commandText, commandType);
        this.ProcessParameters(myCommand);
        try
        {
            ManageCommandConnectionState(myCommand, true);
            return_value = myCommand.ExecuteScalar();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            ManageCommandConnectionState(myCommand, false);
        }
        return return_value;
    }

    public SqlDataReader ExecuteReader(string commandText, CommandType commandType)
    {
        SqlDataReader return_value;
        SqlCommand myCommand = this.GetCommand(commandText, commandType);
        this.ProcessParameters(myCommand);
        try
        {
            ManageCommandConnectionState(myCommand, true);
            return_value = myCommand.ExecuteReader();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            ManageCommandConnectionState(myCommand, false);
        }
        return return_value;
    }

    public DataSet ExecuteDataSet(string commandText, CommandType commandType)
    {
        return ExecuteDataSet(commandText, commandType, "");
    }

    public DataSet ExecuteDataSet(string commandText, CommandType commandType, string dataTableName)
    {
        DataSet return_value = new DataSet();
        SqlDataAdapter myAdapter = new SqlDataAdapter();
        myAdapter.SelectCommand = this.GetCommand(commandText, commandType);
        this.ProcessParameters(myAdapter.SelectCommand);
        try
        {
            ManageCommandConnectionState(myAdapter.SelectCommand, true);
            if (dataTableName == "")
            {
                myAdapter.Fill(return_value);
            }
            else
            {
                myAdapter.Fill(return_value, dataTableName);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            ManageCommandConnectionState(myAdapter.SelectCommand, false);
        }
        return return_value;
    }

    public DataTable ExecuteDataTable(string commandText, CommandType commandType)
    {
        return ExecuteDataSet(commandText, commandType).Tables[0];

    }

    public DataTable ExecuteDataTable(string commandText, CommandType commandType, string dataTableName)
    {
        return ExecuteDataSet(commandText, commandType, dataTableName).Tables[0];
    }

    private void ManageTransaction()
    {
        if (_transactionState != TransactionState.Opened)
        {
            _transactionState = TransactionState.Opened;
            st = sc.BeginTransaction();
        }
    }

    public void RollBack()
    {
        if (_transactionState == TransactionState.Opened)
        {
            _transactionState = TransactionState.Closed;
            st.Rollback();
            sc.Close();
            sc.Dispose();
        }
    }

    public void Commit()
    {
        if (_transactionState == TransactionState.Opened)
        {
            _transactionState = TransactionState.Closed;
            st.Commit();
            sc.Close();
            sc.Dispose();
        }
    }

    public void Dispose()
    {
        st.Dispose();        
        sc.Dispose();
    }
}