import database.AccountDAO;
import database.AccountDAOImpl;
import database.ProfileDAO;
import database.ProfileDAOImpl;
import model.Account;
import model.Profile;
import network.RemoteModelManager;

import java.net.MalformedURLException;
import java.rmi.RemoteException;
import java.sql.Date;
import java.sql.SQLException;
import java.time.LocalDate;

import static model.Speciality.Web;

public class main
{
  public static void main(String[] args) throws SQLException, MalformedURLException, RemoteException {
    RemoteModelManager server = new RemoteModelManager();

    /*Profile profile = new Profile("javaTest", "idk","lol", Web, LocalDate.of(2000,4,15));
    ProfileDAO db = ProfileDAOImpl.getInstance();
    db.AddProfile(profile);*/
  }
}
