package network;

import model.Shift;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
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
    public Shift getShiftById(int shiftId) throws RemoteException {
        return remoteShift.getShiftById(shiftId);
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
}
