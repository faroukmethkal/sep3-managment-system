package com.example.loginspring.domain;

import model.Shift;
import network.RemoteShiftManager;
import org.springframework.stereotype.Service;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.util.List;

@Service
public class ShiftLogicManager implements ShiftLogic{
    private RemoteShiftManager server;

    public ShiftLogicManager() throws MalformedURLException, NotBoundException, RemoteException {
        this.server = new RemoteShiftManager();
    }

    @Override
    public void createShift(Shift shift) {
        try {
            server.createShift(shift);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @Override
    public List<Shift> getAllShifts() {
        try {
            return server.getAllShifts();
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        return null;
    }
}
