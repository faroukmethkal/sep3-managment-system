package com.sep3.logic.auth;

public interface ApplicationUserDao {

     ApplicationUser selectApplicationUserByUsername(String username);
}
