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
  List<Shift> getAvailableShifts(LocalDate date);
  List<Shift> getShiftsStartingAtDate(LocalDate date);
  List<Shift> getShiftsStartingAtTime(LocalTime time);
  List<Shift> getShiftsBetweenTime(LocalTime startTime, LocalTime endTime);
}
