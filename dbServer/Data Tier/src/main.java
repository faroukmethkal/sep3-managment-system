import database.*;
import model.*;
import network.*;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.sql.SQLException;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.HashMap;
import java.util.Map;

import static model.Role.*;
import static model.Specialties.*;

public class main
{
  public static void main(String[] args) throws SQLException, MalformedURLException, RemoteException, NotBoundException {

      RemoteProfile server = new RemoteProfileManager();
      RemoteTask server2 = new RemoteTaskManager();
      RemoteShift server3 = new RemoteShiftManager();

    //testing db
    //Account acc = new Account("test","test",admin);
    //Profile profile = new Profile("javaTest", "idk","lol", fullstackEngineer, LocalDate.of(2000,4,15));
    //ProfileDAO profileDB = new ProfileDAOImpl();
    //profileDB.getProfilesByRole(fullTimeEmployee);
    //AccountDAO accDB = AccountDAOImpl.getInstance();
    //accDB.addAccount(acc);
    /*ProfileDAO pdb = ProfileDAOImpl.getInstance();
    pdb.getAllProfiles();
    AccountDAO adb = AccountDAOImpl.getInstance();
    adb.getAllAccounts();*/
    /*Map<String, Integer> specialties = new HashMap<>();
    specialties.put("qualityAssuranceEngineer", 1);
    specialties.put("frontendEngineer",2);
    Task t = new Task("test2","description test version 2",specialties,
        LocalDate.of(2021,5,13),15.5, LocalDate.of(2000,6,13), Status.valueOf("Created"));*/

    //TaskDAO db = new TaskDAOImpl();
    //db.addTask(t);    //WORKS !!!
    //db.getAllTasks(); //WORKS !!!
    //db.getTask
    //db.getTasksWhereSpecialtiesIs(Specialties.valueOf("qualityAssuranceEngineer")); //WORKS !!!
    //db.assignTeamToTask(1,5) //WORKS !!!;
    //db.setStatusOfTask(4,Status.valueOf("Started")); //WORKS !!! */

    //ShiftDAO shiftDB = new ShiftDAOImpl();
    //Shift shift = new Shift("test", LocalDate.of(2000,6,13), LocalTime.of(14,30),
    //                       LocalTime.of(18,0),"description testing",1);

    //Shift shift2 = new Shift("testEdited", LocalDate.of(2000,4,15), LocalTime.of(16,15),
    //   LocalTime.of(20,0),"description testing Edited",2);

    //shiftDB.getShiftsStartingAtDate(LocalDate.of(2021,11,22));
    //shiftDB.getAvailableShifts(LocalDate.of(2021,11,20));

    //shift2.setId(6);
    //shiftDB.addShift(shift);
    //shiftDB.editShift(shift2);
    //shiftDB.removeShift(6);
    //shiftDB.getAllShifts();
    //TaskDAO db = new TaskDAOImpl();
    //db.getTasksWhereStatusIs(Status.valueOf("Created"));
    //db.getTasksWhereSpecialtiesIs(qualityAssuranceEngineer);
    //db.getTasksOfEmployee("useuse10180");
  }
}
