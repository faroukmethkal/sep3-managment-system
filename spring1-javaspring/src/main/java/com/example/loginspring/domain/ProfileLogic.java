package com.example.loginspring.domain;


import model.Account;
import model.Profile;
import model.Role;
import model.Specialties;

import javax.annotation.Nullable;
import java.rmi.RemoteException;
import java.time.LocalDate;
import java.util.List;

public interface ProfileLogic {
    Account findUserByUsername(String username);
    void createEmployee(Profile profile);
    List<Account> getAllAccounts();
    List<Profile> getAllProfiles(@Nullable Role role);
    Specialties getSpecialty(String username);

    void addDateToCalendar(LocalDate date);
}
