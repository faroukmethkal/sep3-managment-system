package com.example.loginspring.domain;


import model.Account;
import model.Profile;

import javax.annotation.Nullable;
import java.util.List;

public interface ProfileLogic {
    Account findUserByUsername(String username);

    void createEmployee(Profile profile);

    List<Account> getAllAccount();

    public List<Profile> getAllProfiles(@Nullable Boolean partTimeEmpl,
                                        @Nullable Boolean fullTimeEmpl
    );

}
