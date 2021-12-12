package database;

import java.time.LocalDate;
import java.util.List;

public interface CalendarDAO
{
  void addEntryToCalendar(String username, LocalDate date);
  List<LocalDate> getDatesOfEmployee(String username);
}
