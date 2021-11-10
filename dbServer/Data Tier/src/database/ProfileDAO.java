package database;

import model.Profile;

import java.util.List;

public interface ProfileDAO
{
  void AddProfile(Profile profile);
  List<Profile> getAllProfiles();
}
