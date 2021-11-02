import database.AccountDAO;
import database.AccountDAOImpl;
import model.Account;
import network.RemoteModelManager;

import java.net.MalformedURLException;
import java.rmi.RemoteException;
import java.sql.SQLException;

public class main
{
  public static void main(String[] args) throws SQLException, MalformedURLException, RemoteException {
    RemoteModelManager server = new RemoteModelManager();
  }
}
