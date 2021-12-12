package com.sep3.logic.domain;

import model.Profile;
import model.Shift;

import javax.annotation.Nullable;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.List;

public interface ShiftLogic {

    void createShift(Shift shift);
    List<Shift> getAllShifts(@Nullable LocalDate date, @Nullable LocalTime startTime, @Nullable LocalTime endTime);
    void removeShift(int shiftId);
    void editShift(Shift shift);
    Shift getShiftById(int shiftId);

    /**
     * part-time employee
     * **/
    List<Shift> getAllAvailableShift(String username,LocalDate date, LocalTime startTime, LocalTime endTime, Boolean inMyCalendar);
    void assignEmployeeToShift(int shiftId, String username);
    void removeEmployeeFromShift(int shiftId, String username);
    List<Shift> getCriticalShift();
    List<Shift> getMyShifts(String username, @Nullable LocalDate date);

    int getNumAssignedEmployeesToShift(int shiftId);
    List<Profile> getAssignedEmployeesToShift(int shiftId);



}
