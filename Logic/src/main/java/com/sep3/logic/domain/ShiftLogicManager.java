package com.sep3.logic.domain;


import com.sep3.logic.exception.ApiRequestException;
import model.Account;
import model.Profile;
import model.Role;
import model.Shift;
import network.RemoteProfile;
import network.RemoteProfileManager;
import network.RemoteShiftManager;
import org.springframework.stereotype.Service;

import javax.annotation.Nullable;
import java.net.MalformedURLException;
import java.rmi.AccessException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.List;

@Service
public class ShiftLogicManager implements ShiftLogic {
    private RemoteShiftManager server;
    private RemoteProfile profile;

    public ShiftLogicManager() throws MalformedURLException, NotBoundException, RemoteException {
        this.server = new RemoteShiftManager();
        this.profile = new RemoteProfileManager();
    }

    @Override
    public void createShift(Shift shift) {
        server.createShift(shift);
    }

    @Override
    public List<Shift> getAllShifts(@Nullable LocalDate date, @Nullable LocalTime startTime, @Nullable LocalTime endTime) {
        if (date !=null && startTime != null){

            List<Shift> shiftList = server.getAllShiftsStartAtDate(date);
            List<Shift> list = new ArrayList<>();
            for(Shift shift: shiftList){
                if (shift.getStartTime().equals(startTime)) list.add(shift);
            }

            return list;
        }
       if (date != null){
           List<Shift> list =  server.getAllShiftsStartAtDate(date);
           System.out.println("Logic---->>>>>>"+list);
           return list;
       }
       if(startTime != null && endTime != null){
           return server.getAllShiftsStartAndEndAtTime(startTime, endTime);
       }
       if (startTime != null){
           return server.getAllShiftsStartAtTime(startTime);
       }

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

            return server.getShiftById(shiftId);

    }

    @Override
    public List<Shift> getAllAvailableShift(String username, LocalDate date, LocalTime startTime, LocalTime endTime, Boolean inMyCalendar) {
        List<Shift> shifts =  server.getAllAvailableShift(LocalDate.now().plusDays(30));
        List<Shift> shiftList = new ArrayList<>();

        // filter by inMyCalendar
        if (inMyCalendar != null){
            List<Shift> list = new ArrayList<>();
            List<LocalDate> myDates = new ArrayList<>();
            try {
                myDates = profile.getDatesOfEmployee(username);
            } catch (RemoteException e) {
                e.printStackTrace();
            }
            if (inMyCalendar){
                for (Shift shift: shifts) {
                    for (LocalDate date1 : myDates){
                        if (shift.getDate().equals(date1)) list.add(shift);
                    }
                }
            }
            shifts = list;
        }

        if(date != null && startTime != null){
            for(Shift shift: shifts){
                if(shift.getDate().equals(date) && shift.getStartTime().equals(startTime)) shiftList.add(shift);
            }
            return shiftList;
        }
        if(date != null){
            for(Shift shift: shifts){
                if(shift.getDate().equals(date)) shiftList.add(shift);
            }
            return shiftList;
        }

        if(startTime != null && endTime != null){
            for(Shift shift: shifts){
                if(shift.getStartTime().equals(startTime) && shift.getEndTime().equals(endTime)) shiftList.add(shift);
            }
            return shiftList;
        }

        return shifts;
    }

    @Override
    public void assignEmployeeToShift(int shiftId, String username) {
        try {
            Account account = profile.login(username);
            if (!account.getRole().equals(Role.partTimeEmployee)) throw new IllegalArgumentException("Employee must be part time ");
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        if (getNumAssignedEmployeesToShift(shiftId) >= server.getShiftById(shiftId).getNumberOfEmployees()){
            throw new ApiRequestException("Shift already been taken");
        }
        server.assignEmployeeToShift(shiftId, username);
    }

    @Override
    public void removeEmployeeFromShift(int shiftId, String username) {
        Shift shift = server.getShiftById(shiftId);
        if (shift.getDate().isBefore(LocalDate.now().plusDays(1))){
            throw new IllegalArgumentException("IT is too late to cancel shift please contact Manager");
        }
        server.removeEmployeeFromShift(shiftId, username);
    }

    @Override
    public List<Shift> getCriticalShift() {
        List<Shift>  shiftList = server.getAllAvailableShift(LocalDate.now().plusDays(2));

        return shiftList;
    }

    @Override
    public List<Shift> getMyShifts(String username, @Nullable LocalDate date) {

        List<Shift> shiftList =  server.getShiftsOfEmployee(username);
        if (date != null){
            List<Shift> list = new ArrayList<>();
            for (Shift shift: shiftList){
                if (shift.getDate().equals(date)) list.add(shift);
            }

            return list;
        }
        return shiftList;
    }

    @Override
    public int getNumAssignedEmployeesToShift(int shiftId) {
        return server.getNumAssignedEmployeesToShift(shiftId);
    }

    @Override
    public List<Profile> getAssignedEmployeesToShift(int shiftId) {
        List<Profile> profiles = server.getAssignedEmployeesToShift(shiftId);
        System.out.println("from logic team working on shift---> "+ profiles);
        return profiles;
    }


}
