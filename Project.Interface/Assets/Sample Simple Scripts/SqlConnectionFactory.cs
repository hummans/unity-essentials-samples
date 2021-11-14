
using UnityEngine;

public class SqlConnectionFactory : IConnection, IDbConnectionFactory
{
    public SqlConnectionFactory(int port, string connectionString)
    {
        Port = port;
        ConnectionString = connectionString;
    }

    public int Port { get; set; }
    public string ConnectionString { get; set; }

    public string CreateConnection()
    {
        Debug.Log($"We are creating a connection in port {Port}");
        Debug.Log($"Connected succesful to {ConnectionString}");
        return "Connection Success";
    }
}