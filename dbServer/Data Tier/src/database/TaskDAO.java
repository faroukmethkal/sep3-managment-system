package database;

import model.Profile;
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
  void setStatusOfTask(int taskId, Status status); //use this for manager to approve/reject task
  List<Task> getTasksWhereStatusIs(Status status);
  List<Task> getTasksBetweenDates(LocalDate startDate, LocalDate deadline);
  List<Task> getAvailableTasks();
  List<Task> getFinishedTasks();
  void removeTask(int taskId);
  void editTask(Task task);
  void editSpecialtiesOfTask(Task task);
  void removeSpecialtyFromTask(int taskId, Specialties specialty);
  int getTeamIdByTask(int taskId);
  boolean assignEmployeeToTeam(String username, int teamId);
  //get My tasks
  List<Task> getTasksOfEmployee(String username);
  List<Task> getTasksOfEmployeeWithStatus(String username, Status status);
  //idk if needed
  void assignEmployeeToTask(String username, int taskId );

  List<Profile> getAllTeamMembersOfTask(int taskId); //use this for manager to view team members
  void removeEmployeeFromTask(int taskId, String username);
  //estimate and spentHours

  void setSpentHoursForTask(int taskId, double spentHours);

  //validation methods
  int getNumberOfEmpAssignedToTaskWithSpecialties(int taskId, Specialties s);
  int getNumberOfEmpWithSpecialtiesAreRequiredForTask(int taskId, Specialties s);
}
