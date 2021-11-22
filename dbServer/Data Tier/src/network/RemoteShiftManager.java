package network;

import model.Shift;

import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

public class RemoteShiftManager implements RemoteShift{

    public RemoteShiftManager() throws MalformedURLException, NotBoundException, RemoteException {
        startServer();
    }

    private void startServer() throws RemoteException, MalformedURLException
    {
        UnicastRemoteObject.exportObject(this, 0);
        Naming.rebind("Shift", this);
        System.out.println("Shift Server started...");
    }

    @Override
    public void createShift(Shift shift) throws RemoteException {

    }

    @Override
    public void getAllShifts() throws RemoteException {

    }
}
