import database.TaskDAO;
import database.TaskDAOImpl;
import model.Specialties;
import model.Status;
import model.Task;
import network.*;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.sql.SQLException;
import java.time.LocalDate;
import java.util.HashMap;
import java.util.Map;

public class main
{
  public static void main(String[] args) throws SQLException, MalformedURLException, RemoteException, NotBoundException {

    RemoteProfile server = new RemoteProfileManager();
    RemoteTask server2 = new RemoteTaskManager();
    RemoteShift server3 = new RemoteShiftManager();

    //testing db
    /*Profile profile = new Profile("javaTest", "idk","lol", fullstackEngineer, LocalDate.of(2000,4,15));
    ProfileDAO pdb = ProfileDAOImpl.getInstance();
    pdb.AddProfile(profile);
    ProfileDAO pdb = ProfileDAOImpl.getInstance();
    pdb.getAllProfiles();
    AccountDAO adb = AccountDAOImpl.getInstance();
    adb.getAllAccounts();*/
    /*Map<String, Integer> specialties = new HashMap<>();
    specialties.put("qualityAssuranceEngineer", 1);
    specialties.put("frontendEngineer",2);
    Task t = new Task("test2","description test version 2",specialties,
        LocalDate.of(2021,5,13),15.5, LocalDate.of(2000,6,13), Status.valueOf("Created"));*/

    //TaskDAO db = TaskDAOImpl.getInstance();
    /*db.addTask(t);    //WORKS !!!
    db.getAllTasks(); //WORKS !!!
    db.getTasksWhereSpecialtiesIs(Specialties.valueOf("qualityAssuranceEngineer")); //WORKS !!!
    db.assignTeamToTask(1,5) //WORKS !!!;
    db.setStatusOfTask(4,Status.valueOf("Started")); //WORKS !!! */
  }
}
