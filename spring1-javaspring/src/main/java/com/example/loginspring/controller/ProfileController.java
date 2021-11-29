package com.example.loginspring.controller;
import com.example.loginspring.domain.ProfileLogic;
import model.Account;
import model.Profile;
import model.Role;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;
import javax.annotation.Nullable;
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

}
