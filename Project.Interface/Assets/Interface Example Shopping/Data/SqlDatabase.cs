
using UnityEngine;

public class SqlDatabase : IPersistence
{
    public void Save(Shopping shopping)
    {
        // Save to sql
        Debug.Log("Gurdando en sql database");
    }
}

public interface IPersistence
{
    void Save(Shopping shopping);
}

