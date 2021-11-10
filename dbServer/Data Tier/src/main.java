import model.Profile;
import network.ProfileModel;
import network.ProfileModelManager;

import java.net.MalformedURLException;
import java.rmi.RemoteException;
import java.sql.SQLException;

public class main
{
  public static void main(String[] args) throws SQLException, MalformedURLException, RemoteException {

    ProfileModel server = new ProfileModelManager();

    //testing db
    /*Profile profile = new Profile("javaTest", "idk","lol", VIDEOGAMEDESIGNER, LocalDate.of(2000,4,15));
    ProfileDAO pdb = ProfileDAOImpl.getInstance();
    pdb.AddProfile(profile);
    ProfileDAO pdb = ProfileDAOImpl.getInstance();
    pdb.getAllProfiles();
    AccountDAO adb = AccountDAOImpl.getInstance();
    adb.getAllAccounts();*/
  }
}
