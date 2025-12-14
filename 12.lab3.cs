using System;
using Microsoft.Data.SqlClient;

class DbManager
{
    private readonly string _connStr;

    private readonly Lazy<SqlConnection> _lazyConn;

    public DbManager(string connStr)
    {
        _connStr = connStr;

        _lazyConn = new Lazy<SqlConnection>(() =>
        {
            Console.WriteLine("Creating SqlConnection now...");
            return new SqlConnection(_connStr);
        }, isThreadSafe: true);
    }

    public SqlConnection Connection => _lazyConn.Value;

    public void DoSomething()
    {
        Console.WriteLine("Doing something that needs DB...");
        var conn = Connection;


    }
}

class Program
{
    static void Main()
    {
        var manager = new DbManager("Server=.;Database=MyDb;Trusted_Connection=True;TrustServerCertificate=True;");

        Console.WriteLine("Program started. Connection not created yet.");
        Console.WriteLine("Press Enter to use DB...");
        Console.ReadLine();

        manager.DoSomething();

        Console.WriteLine("Done.");
    }
}
