package com.sep3.logic.auth;



import com.sep3.logic.domain.ProfileLogic;
import model.Account;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.core.authority.SimpleGrantedAuthority;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Repository;

import java.rmi.RemoteException;
import java.util.ArrayList;
import java.util.Collection;


@Repository()
public class ApplicationUserDaoService implements ApplicationUserDao {

    private final PasswordEncoder passwordEncoder;
    private ProfileLogic ProfileLogic;



    @Autowired
    public ApplicationUserDaoService(PasswordEncoder passwordEncoder, ProfileLogic ProfileLogic) {
        this.passwordEncoder = passwordEncoder;
        this.ProfileLogic = ProfileLogic;
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
        Account account = ProfileLogic.findUserByUsername(username);
        String myusername = account.getUsername().trim();
        String password = account.getPassword().trim();
        String role = account.getRole().toString().trim();
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
