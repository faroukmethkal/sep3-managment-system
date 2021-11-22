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
    public void createShift(Shift shift) throws RemoteException {
        remoteShift.createShift(shift);
    }

    @Override
    public List<Shift> getAllShifts() throws RemoteException {
        return remoteShift.getAllShifts();
    }
}
