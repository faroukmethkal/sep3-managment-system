package com.example.loginspring.domain;

import model.Shift;

import java.rmi.RemoteException;
import java.util.List;

public interface ShiftLogic {

    void createShift(Shift shift);
    List<Shift> getAllShifts();
    void removeShift(int shiftId);
    void editShift(Shift shift);
    Shift getShiftById(int shiftId);

}
