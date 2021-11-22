package network;

import model.Shift;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.List;

public interface RemoteShift extends Remote {
    void createShift(Shift shift) throws RemoteException;
    List<Shift> getAllShifts() throws RemoteException;
}
