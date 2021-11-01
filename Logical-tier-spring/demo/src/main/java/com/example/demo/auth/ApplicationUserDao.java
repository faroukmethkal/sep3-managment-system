package com.example.demo.auth;

import org.springframework.security.core.userdetails.User;

public interface ApplicationUserDao {

     ApplicationUser selectApplicationUserByUsername(String username);
}
