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
  List<Task> getTasksWhereSpecialtiesIs(Specialties specialty);
  List<Task> getTasksWhereStatusIs(Status status);
  List<Task> getTasksBetweenDates(LocalDate startDate, LocalDate deadline);

  void assignTeamToTask(int teamId, int taskId);
  void setStatusOfTask(int taskId, Status status);
}
