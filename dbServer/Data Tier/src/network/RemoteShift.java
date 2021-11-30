package network;

import model.Shift;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.List;

public interface RemoteShift extends Remote {
    void createShift(Shift shift) throws RemoteException;
    List<Shift> getAllShifts() throws RemoteException;
    void removeShift(int shiftId) throws RemoteException;
    void editShift(Shift shift) throws RemoteException;
    Shift getShiftById(int shiftId) throws RemoteException;
    List<Shift> getAllAvailableShift(LocalDate date) throws RemoteException;
    List<Shift> getAllShiftsStartAtDate(LocalDate date) throws RemoteException;
    List<Shift> getAllShiftsStartAndEndAtTime(LocalTime startTime, LocalTime endTime) throws RemoteException;
    List<Shift> getAllShiftsStartAtTime(LocalTime startTime) throws RemoteException;
    //remove, edit
}
