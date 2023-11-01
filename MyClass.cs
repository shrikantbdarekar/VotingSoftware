using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSoftware
{
    public enum ApplicationMode
    {
        ADMIN_MODE,
        GENERAL_MODULE,
        RESULT_MODE,
        SEARCH_MODE,
        VOTER_VERIFICATION_MODE,
        VOTER_VOTE_MODE
    }

    //class Connection
    //{
    //    private static string MySqlConnectionString
    //    {
    //        get
    //        {
    //            return "Data Source=localhost;Port=3308;Database=online_election_db;User Id=root;Password=root5";
    //        }
    //    }

    //    public static MySqlConnection MySqlCurrentConnection
    //    {
    //        get
    //        {
    //            return new MySqlConnection(MySqlConnectionString);
    //        }
    //    }
    //}

    //public class MyDataClass
    //{
    //    private DataSet ds;
    //    private MySqlCommandBuilder ocb;
    //    private MySqlDataAdapter da;
    //    private BindingSource bs;
    //    private MySqlConnection con;
    //    private string TableName;
    //    private string SqlQuery;

    //    public BindingSource CurrentBindingSource
    //    {
    //        get { return bs; }
    //    }

    //    private DataRow _currentRow;
    //    public DataRow CurrentRow
    //    {
    //        get
    //        {
    //            _currentRow = null;
    //            if (bs != null)
    //                _currentRow = ((DataRowView)bs.Current).Row;
    //            return _currentRow;
    //        }
    //    }

    //    public MyDataClass(string sql, string TName)
    //    {
    //        TableName = TName;
    //        SqlQuery = sql;
    //        CallData();
    //    }

    //    public void Refresh()
    //    {
    //        CallData();
    //    }

    //    private void CallData()
    //    {

    //        con = Connection.MySqlCurrentConnection;
    //        ds = new DataSet();
    //        da = new MySqlDataAdapter(SqlQuery, con);
    //        ocb = new MySqlCommandBuilder(da);
    //        da.Fill(ds, TableName);
    //        bs = new BindingSource(ds, TableName);
    //    }

    //    public void AddNew()
    //    {
    //        bs.AddNew();
    //        //((DataRowView)bs.Current).Row["CompanyCode"] = Program.CompanyCode;
    //    }

    //    public void SaveCurrentRow()
    //    {
    //        //if (CurrentRowOperation.Equals(MyRowState.NEW) || CurrentRowOperation.Equals(MyRowState.EDIT))
    //        //{
    //        bs.EndEdit();
    //        da.Update(ds, TableName);
    //        //}
    //    }

    //    public void CancelEdit()
    //    {
    //        bs.CancelEdit();
    //    }

    //    public void DeleteCurrentRow()
    //    {
    //        if (bs.Current != null)
    //        {
    //            bs.RemoveCurrent();
    //            bs.EndEdit();
    //            da.Update(ds, TableName);
    //        }
    //    }
    //}

    class DBCompanies
    {
        //private MySqlConnection conn;
        //private DataSet ds;
        //private MySqlDataAdapter da;
        //private string _CompanyName;
        //public DataRow CompanyRecord;

        //public DBCompanies()
        //{
        //    //Initialize connection, check for validity, throw exception on error.
        //    conn = Connection.MySqlCurrentConnection;

        //    ds = new DataSet();
        //    da = new MySqlDataAdapter("Select * From Companies", conn);
        //    da.Fill(ds, "Companies");
        //    if (ds.Tables["Companies"].Rows.Count == 1)
        //        CompanyRecord = ds.Tables["Companies"].Rows[0];
        //    else
        //        throw new Exception("Invalid Company Record!");
        //}

        //public string CompanyName
        //{
        //    get
        //    {
        //        _CompanyName = ds.Tables["Companies"].Rows[0]["CompanyName"].ToString();
        //        return _CompanyName;
        //    }
        //}

    }

    class AutoSerial
    {
        public static string GetSerial(string Sql)
        {
            //DataSet ds = new DataSet();
            //MySqlDataAdapter da;
            ////MySqlConnection con = new MySqlConnection(MyClass.ConnectionString);
            //MySqlConnection con = Connection.MySqlCurrentConnection;
            //da = new MySqlDataAdapter(Sql, con);
            //int SrNo = 1;
            //da.Fill(ds, "Serial");
            //if (ds.Tables["Serial"].Rows[0][0] != DBNull.Value)
            //    SrNo = Convert.ToInt32(ds.Tables["Serial"].Rows[0][0].ToString()) + 1;
            //return SrNo.ToString();

            return "0";
        }
        public static string GetSerial(string Sql, int len)
        {
            string SrNo = GetSerial(Sql);

            switch (len)
            {
                case 2:
                    return GetSerial2(SrNo);
                case 3:
                    return GetSerial3(SrNo);
                case 4:
                    return GetSerial4(SrNo);
                case 5:
                    return GetSerial5(SrNo);
                case 6:
                    return GetSerial6(SrNo);
                case 7:
                    return GetSerial7(SrNo);
                case 8:
                    return GetSerial8(SrNo);
                case 9:
                    return GetSerial9(SrNo);
                default: return "0";
            }
        }

        public static string GetSerial2(string ip)
        {
            switch (ip.Length)
            {
                case 0: return "00";
                case 1: return "0" + ip;
                case 2: return ip;
                default: return "-";
            }
        }
        public static string GetSerial3(string ip)
        {
            switch (ip.Length)
            {
                case 0: return "000";
                case 1: return "00" + ip;
                case 2: return "0" + ip;
                case 3: return ip;
                default: return "-";
            }
        }
        public static string GetSerial4(string ip)
        {
            switch (ip.Length)
            {
                case 0: return "0000";
                case 1: return "000" + ip;
                case 2: return "00" + ip;
                case 3: return "0" + ip;
                case 4: return ip;
                default: return "-";
            }
        }
        public static string GetSerial5(string ip)
        {
            switch (ip.Length)
            {
                case 0: return "00000";
                case 1: return "0000" + ip;
                case 2: return "000" + ip;
                case 3: return "00" + ip;
                case 4: return "0" + ip;
                case 5: return ip;
                default: return "-";
            }
        }
        public static string GetSerial6(string ip)
        {
            switch (ip.Length)
            {
                case 0: return "000000";
                case 1: return "00000" + ip;
                case 2: return "0000" + ip;
                case 3: return "000" + ip;
                case 4: return "00" + ip;
                case 5: return "0" + ip;
                case 6: return ip;
                default: return "-";
            }
        }
        public static string GetSerial7(string ip)
        {
            switch (ip.Length)
            {
                case 0: return "0000000";
                case 1: return "000000" + ip;
                case 2: return "00000" + ip;
                case 3: return "0000" + ip;
                case 4: return "000" + ip;
                case 5: return "00" + ip;
                case 6: return "0" + ip;
                case 7: return ip;
                default: return "-";
            }
        }
        public static string GetSerial8(string ip)
        {
            switch (ip.Length)
            {
                case 0: return "00000000";
                case 1: return "0000000" + ip;
                case 2: return "000000" + ip;
                case 3: return "00000" + ip;
                case 4: return "0000" + ip;
                case 5: return "000" + ip;
                case 6: return "00" + ip;
                case 7: return "0" + ip;
                case 8: return ip;
                default: return "-";
            }
        }
        public static string GetSerial9(string ip)
        {
            switch (ip.Length)
            {
                case 0: return "000000000";
                case 1: return "00000000" + ip;
                case 2: return "0000000" + ip;
                case 3: return "000000" + ip;
                case 4: return "00000" + ip;
                case 5: return "0000" + ip;
                case 6: return "000" + ip;
                case 7: return "00" + ip;
                case 8: return "0" + ip;
                case 9: return ip;
                default: return "-";
            }
        }

        public static string GetStringObj(string Sql)
        {
            //DataSet ds = new DataSet();
            //MySqlDataAdapter da;
            //MySqlConnection con = Connection.MySqlCurrentConnection;
            //da = new MySqlDataAdapter(Sql, con);
            //string SrNo = "";
            //da.Fill(ds, "Serial");
            //if (ds.Tables["Serial"].Rows.Count > 0)
            //{
            //    if (ds.Tables["Serial"].Rows[0][0] != DBNull.Value)
            //        SrNo = ds.Tables["Serial"].Rows[0][0].ToString();
            //}
            //return SrNo;

            return "0";
        }
    }

    class DBPanelDetails
    {
        //private MySqlConnection conn;
        //private DataSet ds;
        //private MySqlDataAdapter da;

        //public DBPanelDetails()
        //{
        //    //Initialize connection, check for validity, throw exception on error.
        //    conn = Connection.MySqlCurrentConnection;

        //    ds = new DataSet();
        //    da = new MySqlDataAdapter("Select * From panel_details", conn);
        //    da.Fill(ds, "panel_details");
        //}

        //public DataTable Table
        //{
        //    get
        //    {
        //        return ds.Tables["panel_details"].Copy();
        //    }
        //}

    }

    class DBAreaDetails
    {
        //private MySqlConnection conn;
        //private DataSet ds;
        //private MySqlDataAdapter da;

        //public DBAreaDetails()
        //{
        //    //Initialize connection, check for validity, throw exception on error.
        //    conn = Connection.MySqlCurrentConnection;

        //    ds = new DataSet();
        //    da = new MySqlDataAdapter("Select * From area_details", conn);
        //    da.Fill(ds, "area_details");
        //}

        //public DataTable Table
        //{
        //    get
        //    {
        //        return ds.Tables["area_details"].Copy();
        //    }
        //}

    }

    class DBVoterNames
    {
        //private MySqlConnection conn;
        //private DataSet ds;
        //private MySqlDataAdapter da;

        //public DBVoterNames()
        //{
        //    //Initialize connection, check for validity, throw exception on error.
        //    conn = Connection.MySqlCurrentConnection;

        //    ds = new DataSet();
        //    da = new MySqlDataAdapter("select voter_id,voter_name from voter_details", conn);
        //    da.Fill(ds, "voter_details");
        //}

        //public DataTable Table
        //{
        //    get
        //    {
        //        return ds.Tables["voter_details"].Copy();
        //    }
        //}

    }

    public class MyValidator
    {
        public static void ValidateChar(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 122) && (e.KeyChar != 8) && (e.KeyChar != 32))
                e.Handled = true;
        }

        public static void ValidateNum(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        public static void ValidateNumPercent(KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 57) && e.KeyChar != 8)
                if (e.KeyChar != 37)
                    e.Handled = true;
        }

        //public void enter(KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        SendKeys.Send("{Tab}");
        //    }
        //}

        //public Boolean datecheck(DateTime d)
        //{
        //    return true;
        //}

        //public string ddmmyyyyformat(DateTime d)
        //{
        //    string s = d.Day.ToString() + "/" + d.Month.ToString() + "/" + d.Year.ToString();
        //    return s;
        //}

        //public DateTime mmddyyyyformat(string s)
        //{
        //    return DateTime.Now;
        //}

    }

    class DBTable
    {
        //private MySqlConnection conn;
        //private DataSet ds;
        //private MySqlDataAdapter da;
        //private string filter;

        //public DBTable(string sql)
        //{
        //    //Initialize connection, check for validity, throw exception on error.
        //    conn = Connection.MySqlCurrentConnection;
        //    ds = new DataSet();
        //    da = new MySqlDataAdapter(sql, conn);
        //    da.Fill(ds, "MyTable");
        //}

        //public DataTable Table
        //{
        //    get
        //    {
        //        return ds.Tables["MyTable"].Copy();
        //    }
        //}
    }
}