package network;

import model.Shift;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface RemoteShift extends Remote {
    void createShift(Shift shift) throws RemoteException;
    void getAllShifts() throws RemoteException;
}
