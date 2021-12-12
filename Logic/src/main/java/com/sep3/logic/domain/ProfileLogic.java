package com.sep3.logic.domain;


import model.Account;
import model.Profile;
import model.Role;
import model.Specialties;

import javax.annotation.Nullable;
import java.time.LocalDate;
import java.util.List;

public interface ProfileLogic {
    Account findUserByUsername(String username);
    void createEmployee(Profile profile);
    List<Account> getAllAccounts();
    List<Profile> getAllProfiles(@Nullable Role role);
    Specialties getSpecialty(String username);

    void addEntryToCalendar(String username, LocalDate date) ;
    List<LocalDate> getDatesOfEmployee(String username) ;

    Profile getMyProfile(String username);
}
