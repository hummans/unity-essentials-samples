using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqlConnectionDebug : MonoBehaviour
{
    void Start()
    {
        SqlConnectionFactory mysql = new SqlConnectionFactory(1233, "MySql.Local");
        SqlConnectionFactory sqlserver = new SqlConnectionFactory(1433, "SqlServer.Local");
        
        Connect(mysql);
        Connect(sqlserver);
    }

    void Connect(IDbConnectionFactory db)
    {
        db.CreateConnection();
    }
}