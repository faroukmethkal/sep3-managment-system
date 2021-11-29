package com.example.loginspring.domain;

import model.Shift;
import network.RemoteShiftManager;
import org.springframework.stereotype.Service;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.util.List;

@Service
public class ShiftLogicManager implements ShiftLogic {
    private RemoteShiftManager server;

    public ShiftLogicManager() throws MalformedURLException, NotBoundException, RemoteException {
        this.server = new RemoteShiftManager();
    }

    @Override
    public void createShift(Shift shift) {
        server.createShift(shift);
    }

    @Override
    public List<Shift> getAllShifts() {
        return server.getAllShifts();

    }

    @Override
    public void removeShift(int shiftId) {
        server.removeShift(shiftId);
    }

    @Override
    public void editShift(Shift shift) {
        server.editShift(shift);
    }

    @Override
    public Shift getShiftById(int shiftId) {
        try {
            return server.getShiftById(shiftId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return null;
    }
}
