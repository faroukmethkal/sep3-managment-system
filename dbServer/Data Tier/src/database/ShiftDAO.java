package database;

import model.Shift;

import java.rmi.RemoteException;
import java.util.List;

public interface ShiftDAO
{
  void addShift(Shift shift);
  List<Shift> getAllShifts();
  void removeShift(int shiftId);
  void editShift(Shift shift);
  Shift getShiftById(int shiftId);

}
