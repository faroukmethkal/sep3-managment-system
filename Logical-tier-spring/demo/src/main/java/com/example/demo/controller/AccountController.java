package com.example.demo.controller;

import com.example.demo.domain.Model;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("api/account")
public class AccountController {
    private Model model;

    @Autowired
    public AccountController(Model model) {
        this.model = model;
    }

/*    @PostMapping
    @PreAuthorize("hasAnyRole('ROLE_Admin')")
    public void addAcount(@RequestBody Account account) throws RemoteException {
        model.addAccount(account.getUsername(), account.getPassword(), account.getRole());
    }*/




}
