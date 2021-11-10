package model;

import java.io.Serializable;
import java.time.LocalDate;

public class Profile implements Serializable {
    private String firstName;
    private String lastName;
    private Specialties specialties;
    private LocalDate birthday;
    private String Role;
    private String username;

    public Profile() {

    }


    public Profile(String username, String firstName, String lastName, Specialties specialties, LocalDate birthday) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.specialties = specialties;
        this.birthday = birthday;
        this.username = username;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public Specialties getSpecialties() {
        return specialties;
    }

    public void setSpecialties(Specialties specialties) {
        this.specialties = specialties;
    }

    public LocalDate getBirthday() {
        return birthday;
    }

    public void setBirthday(LocalDate birthday) {
        this.birthday = birthday;
    }

    public String getRole() {
        return Role;
    }

    public void setRole(String role) {
        Role = role;
    }

    @Override
    public String toString() {
        return "Profile{" +
                "firstName='" + firstName + '\'' +
                ", lastName='" + lastName + '\'' +
                ", specialties=" + specialties +
                ", birthday=" + birthday +
                ", Role='" + Role + '\'' +
                '}';
    }
}
