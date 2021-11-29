package com.example.loginspring.domain;

import model.Account;
import model.Profile;
import model.Role;
import model.Specialties;
import network.RemoteProfileManager;
import org.springframework.stereotype.Service;


import javax.annotation.Nullable;
import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.security.SecureRandom;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;


@Service
public class ProfileLogicManager implements ProfileLogic {
    private RemoteProfileManager server;

    public ProfileLogicManager() throws MalformedURLException, NotBoundException, RemoteException {
        server = new RemoteProfileManager();
    }

    @Override
    public Account findUserByUsername(String username) {
        try {
            return server.login(username);
        } catch (Exception e) {

        }
        return null;
    }

    @Override
    public void createEmployee(Profile profile) {
        String username = generateUsername(profile);
        String password = generateRandomPassword();
        Account account = new Account(username, password, profile.getRole());
        profile.setUsername(account.getUsername());

        server.createEmployee(profile, account);
    }


    @Override
    public List<Account> getAllAccounts() {
            return server.getAllAccounts();
    }

    @Override
    public List<Profile> getAllProfiles(@Nullable Role role) {

        if(role != null){
            return server.getAllProfileByRole(role);
        }else{
            return server.getAllProfiles();
        }

    }

    @Override
    public Specialties getSpecialty(String username) {
        return server.getSpecialty(username);
    }



    private String generateUsername(Profile profile) {
        StringBuilder username = new StringBuilder();

        String username_p1 = profile.getFirstName().substring(0, 3).toLowerCase();
        username.append(username_p1);

        String username_p2 = profile.getLastName().substring(0, 3).toLowerCase();
        username.append(username_p2);

        username.append(profile.getBirthday().getDayOfMonth());

        if (profile.getBirthday().getMonthValue() < 10) {
            username.append("0");
            username.append(profile.getBirthday().getMonthValue());
        } else {
            username.append(profile.getBirthday().getMonthValue());
        }

        //check for not valid year
        if (profile.getBirthday().getYear() >= 1960) {
            String year = Integer.toString(profile.getBirthday().getYear());
            username.append(year.substring(2, year.length()));
        }else {
            throw new IllegalArgumentException("Year not valied");
        }

        //if username is not unique
        for (Account account:getAllAccounts()){
            if (account.getUsername().equals(username.toString())){
                username.append(generateRandomPassword().charAt(0));
            }
        }
        return username.toString();
    }

    private String generateRandomPassword() {

        final String chars1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        final String chars2 = "abcdefghijklmnopqrstuvwxyz";
        final String char3 = "0123456789";
        final String char4 = "_";

        SecureRandom random = new SecureRandom();
        StringBuilder sb = new StringBuilder();


        for (int i = 0; i < 2; i++) {
            int randomIndex = random.nextInt(chars1.length());
            sb.append(chars1.charAt(randomIndex));
        }
        for (int i = 0; i < 3; i++) {
            int randomIndex = random.nextInt(chars2.length());
            sb.append(chars2.charAt(randomIndex));
        }

        sb.append(char4);

        for (int i = 0; i < 2; i++) {
            int randomIndex = random.nextInt(char3.length());
            sb.append(char3.charAt(randomIndex));
        }
        return sb.toString();
    }

}
