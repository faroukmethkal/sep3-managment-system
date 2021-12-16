import database.*;
import model.*;
import org.junit.jupiter.api.AfterAll;
import org.junit.jupiter.api.BeforeAll;
import org.junit.jupiter.api.Test;


import java.time.LocalDate;
import java.time.LocalTime;

import static org.junit.jupiter.api.Assertions.*;

class ShiftDAOImplTest
{
  private static ShiftDAO db;
  private static Shift testShift;
  private static Shift testShiftOne;
  private static Shift testShiftZero;
  private static Shift testShiftMany;
  private static Shift testShiftBoundaries;
  private static Shift testShiftException;
  private static Account acc;
  private static Profile profile;

  private static AccountDAO accDB;
  private static ProfileDAO profileDB;

  @BeforeAll
  static void setUpAll()
  {
    db = new ShiftDAOImpl();

    testShift = new Shift("TestingShift", LocalDate.now(), LocalTime.of(14, 30),
        LocalTime.of(18, 0), "description testing", 2);

    testShiftOne = new Shift("s", LocalDate.now(), LocalTime.of(14, 30),
        LocalTime.of(18, 0), "d", 1);

    testShiftZero = new Shift("", LocalDate.now(), LocalTime.of(0, 0),
        LocalTime.of(0, 0), "", 0);

    testShiftMany = new Shift("TestingShiftTestingShiftTestingShiftTestingShift", LocalDate.now(),
        LocalTime.of(14, 30), LocalTime.of(18, 0),
        "description testing description testing description testing", 38);

    testShiftBoundaries = new Shift("TestingShift", LocalDate.now(),
        LocalTime.of(0, 59), LocalTime.of(23, 0), "description testing", -1);

    testShiftException = new Shift("TestingShift", LocalDate.now(),
        LocalTime.of(14, 30), LocalTime.of(18, 0), "description testing", -1);

    acc = new Account("testing", "testing", Role.admin);
    profile = new Profile("testing", "testName", "testLastName", Specialties.dataScientist, LocalDate.of(2000,
        4, 15));

    accDB = new AccountDAOImpl();
    profileDB = new ProfileDAOImpl();
    //accDB.addAccount(acc);
    //profileDB.AddProfile(profile);
  }

  @Test
  void getShiftById()
  {
    if(db.getShiftById(db.getLatestId("TestingShift")) == null)
    {
      db.addShift(testShift);
      testShift.setId(db.getLatestId("TestingShift"));
    }
    Shift shift = null;
    shift = db.getShiftById(db.getLatestId("TestingShift"));

    assertNotNull(shift);
    db.removeShift(shift.getId());
  }

  @Test void addShift()
  {
    db.addShift(testShift);
    testShift.setId(db.getLatestId(testShift.getName()));
    assertNotNull(db.getShiftById(testShift.getId()));
  }

  @Test void editShift()
  {
    if(db.getShiftById(db.getLatestId("TestingShift")) == null)
    {
      db.addShift(testShift);
      testShift.setId(db.getLatestId("TestingShift"));
    }
    Shift testShiftEdit = new Shift("TestingShiftEdited", LocalDate.now(),
        LocalTime.of(14, 0), LocalTime.of(18, 0), "description testing edit", 1);
    testShiftEdit.setId(testShift.getId());

    db.editShift(testShiftEdit);

    assertNotEquals(testShift.getName(),
        db.getShiftById(db.getLatestId("TestingShiftEdited")).getName());
    assertNotEquals(testShift.getDescription(),
        db.getShiftById(db.getLatestId("TestingShiftEdited")).getDescription());
    assertNotEquals(testShift.getNumberOfEmployees(),
        db.getShiftById(db.getLatestId("TestingShiftEdited")).getNumberOfEmployees());

    db.removeShift(db.getLatestId("TestingShiftEdited"));
  }

  @Test void getAvailableShifts()
  {
    assertNotNull(db.getAvailableShifts(LocalDate.of(2021, 11, 20)));
  }

  @Test void getAssignedEmployeesToShift()
  {
    assertTrue(db.getAssignedEmployeesToShift(testShift.getId()).isEmpty());
  }

  @Test void assignAndRemoveEmployeeFromShift()
  {
    if(db.getShiftById(db.getLatestId("TestingShift")) == null)
    {
      db.addShift(testShift);
      testShift.setId(db.getLatestId("TestingShift"));
    }

    db.assignEmployeeToShift(testShift.getId(), acc.getUsername());
    assertFalse(db.getAssignedEmployeesToShift(testShift.getId()).isEmpty());

    db.removeEmployeeFromShift(testShift.getId(), acc.getUsername());
    assertTrue(db.getAssignedEmployeesToShift(testShift.getId()).isEmpty());

    db.removeShift(db.getLatestId("TestingShift"));
  }

  @Test void getShiftsStartingAtDate()
  {
    assertNotNull(db.getShiftsStartingAtDate(LocalDate.of(2021,11,21)));
  }

  @Test void getShiftsStartingAtTime()
  {
    assertNotNull(db.getShiftsStartingAtTime(LocalTime.of(8,20)));
  }

  @Test void removeShift()
  {
    db.removeShift(db.getLatestId("TestingShift"));
    assertNull(db.getShiftById(testShift.getId()));
  }

  @AfterAll
  static void CleanUp()
  {
  }
}