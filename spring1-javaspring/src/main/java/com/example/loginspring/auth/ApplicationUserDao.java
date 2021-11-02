package com.example.loginspring.auth;

public interface ApplicationUserDao {

     ApplicationUser selectApplicationUserByUsername(String username);
}
