package com.example.loginspring.controller;

import com.example.loginspring.domain.ShiftLogic;
import model.Shift;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;

import javax.annotation.Nullable;
import java.time.LocalDate;
import java.time.LocalTime;
import java.util.List;

@RestController
@RequestMapping
public class ShiftAdminController {
    private ShiftLogic shiftLogic;

    @Autowired
    public ShiftAdminController(ShiftLogic shiftLogic) {
        System.out.println(shiftLogic);
        this.shiftLogic = shiftLogic;
    }

    @PreAuthorize("hasAnyRole('ROLE_admin')")
    @PostMapping("api/shift")
    public void createShift(@RequestBody Shift shift){
        shiftLogic.createShift(shift);
    }

    @PreAuthorize("hasAnyRole('ROLE_admin')")
    @GetMapping("api/shifts")
    public List<Shift> getAllShift(@RequestParam("date") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalDate date,
                                   @RequestParam("startTime") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalTime startTime,
                                   @RequestParam("endTime") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalTime endTime){
        return shiftLogic.getAllShifts(date,startTime,endTime);
    }

    @PreAuthorize("hasAnyRole('ROLE_admin')")
    @GetMapping("api/criticalShift")
    public List<Shift> getAllShift(){
        return shiftLogic.getCriticalShift();
    }

    @PreAuthorize("hasAnyRole('ROLE_admin')")
    @GetMapping("api/shift")
    public Shift getShift(@RequestParam("id") int id){
        return shiftLogic.getShiftById(id);
    }

    @DeleteMapping("api/shift")
    @PreAuthorize("hasAnyRole('ROLE_admin')")
    public void removeShift(@RequestParam("id") int id){
        shiftLogic.removeShift(id);
    }

    @PutMapping("api/shift")
    @PreAuthorize("hasAnyRole('ROLE_admin')")
    public void editShift(@RequestBody Shift shift){
        shiftLogic.editShift(shift);
    }



}
