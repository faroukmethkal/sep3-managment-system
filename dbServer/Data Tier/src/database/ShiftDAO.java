package database;

import model.Shift;

import java.rmi.RemoteException;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.List;

public interface ShiftDAO
{
  void addShift(Shift shift);
  List<Shift> getAllShifts();
  void removeShift(int shiftId);
  void editShift(Shift shift);
  Shift getShiftById(int shiftId);
  List<Shift> getShiftsStartingAtDate(LocalDate date);
  List<Shift> getShiftsStartingAtTime(LocalTime time);
  List<Shift> getShiftsBetweenTime (LocalTime startTime, LocalTime endTime);
  //employee
  List<Shift> getAvailableShifts(LocalDate date);
  void assignEmployeeToShift(int shiftId, String username);
  void removeEmployeeFromShift(int shiftId, String username);
  List<String> getAssignedEmployeesToShift(int shiftId);
  List<Shift> getShiftsOfEmployee(String username);
  //for test
  int getLatestId(String shiftName);
}
