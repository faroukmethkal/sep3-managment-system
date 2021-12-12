package com.sep3.logic.controller;


import com.sep3.logic.domain.ShiftLogic;
import com.sep3.logic.exception.ApiRequestException;
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
                                         @RequestParam("endTime") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalTime endTime,
                                         @RequestParam("inMyCalendar") @Nullable Boolean inMyCalendar,
                                         @RequestParam("username") String username) {

        return shiftLogic.getAllAvailableShift(username, date, startTime, endTime, inMyCalendar);
    }
    @GetMapping("myShifts")
    @PreAuthorize("hasAnyRole('ROLE_partTimeEmployee')")
    public List<Shift> getMyShifts(@RequestParam("date") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") @Nullable LocalDate date,
                                         @RequestParam("username") String username) {
            return shiftLogic.getMyShifts(username, date);
    }

    @PutMapping("shift")
    @PreAuthorize("hasAnyRole('ROLE_partTimeEmployee','ROLE_admin')")
    public void assignEmplToShift(@RequestParam("username") String username,
                                  @RequestParam("Id") int shiftId) {

        try {
            shiftLogic.assignEmployeeToShift(shiftId, username);
        } catch (Exception e) {
            throw new ApiRequestException(e.getMessage());
        }
    }

    @DeleteMapping("shift")
    @PreAuthorize("hasAnyRole('ROLE_partTimeEmployee')")
    public void unAssignEmplToShift(@RequestParam("username") String username,
                                    @RequestParam("Id") int shiftId) {
        try {
            shiftLogic.removeEmployeeFromShift(shiftId, username);

        }catch (Exception e){
            throw new ApiRequestException(e.getMessage());
        }
    }


}
