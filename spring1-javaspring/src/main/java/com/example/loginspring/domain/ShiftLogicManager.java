package com.example.loginspring.domain;

import model.Shift;
import network.RemoteShiftManager;
import org.springframework.stereotype.Service;

import javax.annotation.Nullable;
import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.ArrayList;
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
        try {
            return server.getShiftById(shiftId);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return null;
    }

    @Override
    public List<Shift> getAllAvailableShift(LocalDate date, LocalTime startTime, LocalTime endTime) {
        List<Shift> shifts =  server.getAllAvailableShift(LocalDate.now().plusDays(1));
        List<Shift> shiftList = new ArrayList<>();

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
        server.assignEmployeeToShift(shiftId, username);
    }

    @Override
    public void removeEmployeeFromShift(int shiftId, String username) {
        server.removeEmployeeFromShift(shiftId, username);
    }
}
