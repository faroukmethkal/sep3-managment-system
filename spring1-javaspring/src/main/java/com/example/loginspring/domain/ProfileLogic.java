package com.example.loginspring.domain;



import model.Account;

import java.util.List;

public interface ProfileLogic {
    Account findUserByUsername(String username);
    void createEmployee(model.Profile IProfile);
    List<Account> getAllAccount();
}
