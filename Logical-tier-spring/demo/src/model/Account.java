package model;

import java.io.Serializable;
public class Account implements Serializable

{

    private String username,password, role;

    public Account(String username, String password, String role)
    {
        this.username = username;
        this.password = password;
        this.role = role;
    }

    public String getUsername()
    {
        return username;
    }

    public String getPassword()
    {
        return username;
    }

    public String getRole()
    {
        return role;
    }

    @Override public String toString()
    {
        return "User{" + "username='" + username + '\'' + ", password='" + password
                + '\'' + ", role='" + role + '\'' + '}';
    }
}