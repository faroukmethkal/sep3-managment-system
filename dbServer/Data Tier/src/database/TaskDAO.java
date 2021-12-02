package database;

import model.Specialties;
import model.Status;
import model.Task;

import java.time.LocalDate;
import java.util.List;
import java.util.Map;

public interface TaskDAO
{
  void addTask(Task task);
  Task getTaskById(int id);
  List<Task> getAllTasks();
  Map<String,Integer> getSpecialtiesOfTask(int taskId);
  //void assignTeamToTask(int teamId, int taskId);
  List<Task> getTasksWhereSpecialtiesIs(Specialties specialty);
  void setStatusOfTask(int taskId, Status status);
  List<Task> getTasksWhereStatusIs(Status status);
  List<Task> getTasksBetweenDates(LocalDate startDate, LocalDate deadline);
  void removeTask(int taskId);
  void editTask(Task task);
  //to implement
  int getTeamIdByTask(int taskId);
  void assignEmployeeToTeam(String username, int teamId);
  List<Task> getTasksOfEmployee(String username);
  List<Task> getTasksOfEmployeeWithStatus(String username, Status status);
  //idk if needed
  void assignEmployeeToTask(String username, int taskId);
}
