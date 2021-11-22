package com.example.loginspring.controller;

import com.example.loginspring.domain.ShiftLogic;
import model.Shift;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping
public class ShiftController {
    private ShiftLogic shiftLogic;

    @Autowired
    public ShiftController(ShiftLogic shiftLogic) {
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
    public List<Shift> getAllShift(){
        return shiftLogic.getAllShifts();
    }



}
