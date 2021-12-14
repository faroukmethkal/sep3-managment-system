package database;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConnectionDB {

    private static ConnectionDB instance;

    private ConnectionDB() throws SQLException
    {
        DriverManager.registerDriver(new org.postgresql.Driver());
    }

    public static synchronized ConnectionDB getInstance() throws SQLException
    {
        if (instance == null)
        {
            return instance = new ConnectionDB();
        }
        return instance;
    }

    public Connection getConnection() throws SQLException
    {
        return DriverManager.getConnection(
                "jdbc:postgresql://hattie.db.elephantsql.com:5432/bzjrfgwn?currentSchema=sep",
                "bzjrfgwn", "ZPXdZD4hJLi7bjSr5foQeqn2ithW6iQV");
    }

}
