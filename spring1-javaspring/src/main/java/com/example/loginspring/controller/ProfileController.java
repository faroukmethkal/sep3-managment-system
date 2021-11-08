package com.example.loginspring.controller;


import com.example.loginspring.domain.ProfileLogic;
import model.Profile;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("api/profile")
public class ProfileController {
    private ProfileLogic ProfileLogic;

    @Autowired
    public ProfileController(ProfileLogic ProfileLogic) {
        this.ProfileLogic = ProfileLogic;
    }

    @PostMapping
    @PreAuthorize("hasAnyRole('ROLE_admin')")
    public void createEmployee(@RequestBody Profile profile) {
          this.ProfileLogic.createEmployee(profile);
           System.out.println(profile);
    }


}
