package com.sep3.logic.controller;


import com.sep3.logic.domain.ProfileLogic;
import model.Account;
import model.Profile;
import model.Role;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;

import javax.annotation.Nullable;
import java.time.LocalDate;
import java.util.List;

@RestController
@RequestMapping("api/profile")
public class ProfileController {
    private ProfileLogic profileLogic;

    @Autowired
    public ProfileController(ProfileLogic profileLogic) {
        this.profileLogic = profileLogic;
    }


    @PostMapping
    @PreAuthorize("hasAnyRole('ROLE_admin')")
    public void createEmployee(@RequestBody Profile profile) {
        this.profileLogic.createEmployee(profile);
    }

    @GetMapping()
    @PreAuthorize("hasAnyRole('ROLE_admin')")
    public List<Profile> getAllProfile(
            @RequestParam("role") @Nullable Role role) {

        return profileLogic.getAllProfiles(role);

    }

    @GetMapping("/myProfile")
    @PreAuthorize("hasAnyRole('ROLE_partTimeEmployee','ROLE_fullTimeEmployee')")
    public Profile getMyProfile(
            @RequestParam("username") String username) {

        return profileLogic.getMyProfile(username);
    }


    @GetMapping("/accounts")
    @PreAuthorize("hasAnyRole('ROLE_admin')")
    public List<Account> getAllAccount() {

        return profileLogic.getAllAccounts();
    }

    @GetMapping("/account")
    @PreAuthorize("hasAnyRole('ROLE_admin')")
    public Account getAccountByUsername(@RequestParam("username") String username){
        return profileLogic.findUserByUsername(username);
    }

    @PostMapping("/calendar")
    @PreAuthorize("hasAnyRole('ROLE_partTimeEmployee')")
    public void addDateToCalendar(@RequestParam("username") String username, @RequestParam("date") @DateTimeFormat(pattern = "dd/MM/yyyy HH.mm.ss") LocalDate date){
        profileLogic.addEntryToCalendar(username, date);
    }

    @GetMapping("/calendar")
    @PreAuthorize("hasAnyRole('ROLE_partTimeEmployee')")
    public List<LocalDate> getAllDates(@RequestParam("username") String username){
       return profileLogic.getDatesOfEmployee(username);
    }

}
