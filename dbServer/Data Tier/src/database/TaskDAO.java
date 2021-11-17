package database;

import model.Specialties;
import model.Status;
import model.Task;

import java.util.List;
import java.util.Map;

public interface TaskDAO
{
  void addTask(Task task);
  Task getTaskById(int id);
  List<Task> getAllTasks();
  Map<String,Integer> getSpecialtiesOfTask(int taskId);
  void assignTeamToTask(int teamId, int taskId);
  List<Task> getTasksWhereSpecialtiesIs(Specialties specialty);
  void setStatusOfTask(int taskId, Status status);
}
