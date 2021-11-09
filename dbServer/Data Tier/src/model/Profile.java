package model;

import java.io.Serializable;
import java.time.LocalDate;

public class Profile implements Serializable {
  private String username;
  private String firstName;
  private String lastName;
  private Speciality speciality;
  private LocalDate birthday;
  private String Role;

  public Profile(String username, String firstName, String lastName, Speciality speciality, LocalDate birthday) {
    this.username = username;
    this.firstName = firstName;
    this.lastName = lastName;
    this.speciality = speciality;
    this.birthday = birthday;
  }

  public String getUsername()
  {
    return username;
  }

  public void setUsername(String username)
  {
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

  public Speciality getSpecialties() {
    return speciality;
  }

  public void setSpecialties(Speciality speciality) {
    this.speciality = speciality;
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
}