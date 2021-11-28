package database;

import model.Profile;
import model.Role;
import model.Specialties;

import java.util.List;

public interface ProfileDAO
{
  void AddProfile(Profile profile);
  List<Profile> getAllProfiles();
  Specialties getSpecialtyByUsername(String username);
  List<Profile> getProfilesByRole(Role role);
}
