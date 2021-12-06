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
@RequestMapping("api/employee/")
public class ShiftPartTimeEmplyeeController {
    private ShiftLogic shiftLogic;

    @Autowired
    public ShiftPartTimeEmplyeeController(ShiftLogic shiftLogic) {
        this.shiftLogic = shiftLogic;
    }

    @GetMapping("shifts")
    @PreAuthorize("hasAnyRole('ROLE_partTimeEmployee')")
    public List<Shift> getAvailableShift(@RequestParam("date") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalDate date,
                                         @RequestParam("startTime") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalTime startTime,
                                         @RequestParam("endTime") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalTime endTime) {

        return shiftLogic.getAllAvailableShift(date, startTime, endTime);
    }
    @GetMapping("myShifts")
    @PreAuthorize("hasAnyRole('ROLE_partTimeEmployee')")
    public List<Shift> getMyShifts(@RequestParam("date") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalDate date,
                                         @RequestParam("username") String username) {
            return null;
    }

    @PutMapping("shift")
    @PreAuthorize("hasAnyRole('ROLE_partTimeEmployee')")
    public void assignEmplToShift(@RequestParam("username") String username,
                                  @RequestParam("Id") int shiftId) {

        shiftLogic.assignEmployeeToShift(shiftId, username);
    }

    @DeleteMapping("shift")
    @PreAuthorize("hasAnyRole('ROLE_partTimeEmployee')")
    public void unAssignEmplToShift(@RequestParam("username") String username,
                                    @RequestParam("Id") int shiftId) {
        shiftLogic.removeEmployeeFromShift(shiftId, username);
    }
}
