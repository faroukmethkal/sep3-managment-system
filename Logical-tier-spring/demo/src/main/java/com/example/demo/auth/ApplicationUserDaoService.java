package com.example.demo.auth;

import com.example.demo.domain.Model;


import model.Account;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Repository;

import java.rmi.RemoteException;
import java.util.ArrayList;
import java.util.Collection;


@Repository() // tels spring this class need to be instantiated to be able to autowired it
public class ApplicationUserDaoService implements ApplicationUserDao {

    private final PasswordEncoder passwordEncoder;
    private Model model;



    @Autowired
    public ApplicationUserDaoService(PasswordEncoder passwordEncoder, Model model) {
        this.passwordEncoder = passwordEncoder;
        this.model = model;
    }


    @Override
    public ApplicationUser selectApplicationUserByUsername(String username) {

        try {
            return findUserByUsername(username);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return null;
    }

    private ApplicationUser findUserByUsername(String username) throws RemoteException {
        Account account = model.findUserByUsername(username);
        String myusername = account.getUsername().trim();
        String password = account.getPassword().trim();
        String role = account.getRole().trim();
        Collection<SimpleGrantedAuthority> authorities= new ArrayList<>();
        authorities.add(new SimpleGrantedAuthority("ROLE_"+role));
        ApplicationUser applicationUser = new ApplicationUser(
                myusername,
                passwordEncoder.encode(password),
                authorities,
                true,
                true,
                true,
                true

        );
        System.out.println(applicationUser);

        return applicationUser;
    }


}
