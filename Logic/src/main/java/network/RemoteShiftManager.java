package network;

import model.Profile;
import model.Shift;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.List;

public class RemoteShiftManager implements RemoteShift{
    private RemoteShift remoteShift;

    public RemoteShiftManager() throws MalformedURLException, NotBoundException, RemoteException {
        this.remoteShift = (RemoteShift) Naming.lookup("rmi://localhost:1099/Shift");
    }

    @Override
    public void createShift(Shift shift) {
        try {
            remoteShift.createShift(shift);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void editShift(Shift shift)  {
        try {
            remoteShift.editShift(shift);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public Shift getShiftById(int shiftId) {
        try {
            return remoteShift.getShiftById(shiftId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return null;
    }


    @Override
    public List<Shift> getAllShifts(){
        try {
            return remoteShift.getAllShifts();
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }


    @Override
    public void removeShift(int shiftId) {
        try {
            remoteShift.removeShift(shiftId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

    }

    @Override
    public List<Shift> getAllShiftsStartAtDate(LocalDate date){
        try {
            return remoteShift.getAllShiftsStartAtDate(date);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return null;
    }

    @Override
    public List<Shift> getAllShiftsStartAndEndAtTime(LocalTime startTime, LocalTime endTime){
        try {
            return remoteShift.getAllShiftsStartAndEndAtTime(startTime, endTime);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public List<Shift> getAllShiftsStartAtTime(LocalTime startTime){
        try {
            return remoteShift.getAllShiftsStartAtTime(startTime);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return null;
    }

    @Override
    public List<Profile> getAssignedEmployeesToShift(int shiftId) {
        try {
            return remoteShift.getAssignedEmployeesToShift(shiftId);
        } catch (RemoteException e) {
            throw new IllegalArgumentException(e.getMessage());
        }
    }

    @Override
    public int getNumAssignedEmployeesToShift(int shiftId) {
        try {
            return remoteShift.getNumAssignedEmployeesToShift(shiftId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return -1;
    }

    @Override
    public List<Shift> getAllAvailableShift(LocalDate date){
        try {
            return remoteShift.getAllAvailableShift(date);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

    @Override
    public void assignEmployeeToShift(int shiftId, String username)  {
        try {
            remoteShift.assignEmployeeToShift(shiftId, username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void removeEmployeeFromShift(int shiftId, String username) {
        try {
            remoteShift.removeEmployeeFromShift(shiftId, username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public List<Shift> getShiftsOfEmployee(String username)  {
        try {
            return remoteShift.getShiftsOfEmployee(username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }

/*    @Override
    public List<LocalDate> getMyCalendar(String username)  {
        try {
            return remoteShift.(username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return null;
    }*/
}
