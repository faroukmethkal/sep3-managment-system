package model;

import java.io.Serializable;
import java.time.LocalDate;
import java.util.Map;

public class Task implements Serializable {


   private int id;
   private String title;
   private String description;
   private Map<String, Integer> specialties;
   private LocalDate startDate;
   private double estimatedTime;
   private LocalDate deadline;
   private Status status;
   private double spentHours;

   public Task(String title, String description, Map<String, Integer> specialties, LocalDate startDate, double estimatedTime, LocalDate deadline, Status status) {
      this.id = id;
      this.title = title;
      this.description = description;
      this.specialties = specialties;
      this.startDate = startDate;
      this.estimatedTime = estimatedTime;
      this.deadline = deadline;
      this.status = status;
      this.spentHours = 0;
   }

   public void setSpecialties(Map<String, Integer> specialties) {
      this.specialties = specialties;
   }

   public Status getStatus() {
      return status;
   }

   public void setStatus(Status status) {
      this.status = status;
   }

   public int getId()
   {
      return id;
   }

   public void setId(int id)
   {
      this.id = id;
   }

   public String getTitle() {
      return title;
   }

   public void setTitle(String title) {
      this.title = title;
   }

   public String getDescription() {
      return description;
   }

   public void setDescription(String description) {
      this.description = description;
   }

   public Map<String, Integer> getSpecialties() {
      return specialties;
   }

   public LocalDate getStartDate() {
      return startDate;
   }

   public void setStartDate(LocalDate startDate) {
      this.startDate = startDate;
   }

   public double getEstimatedTime() {
      return estimatedTime;
   }

   public void setEstimatedTime(double estimatedTime) {
      this.estimatedTime = estimatedTime;
   }

   public LocalDate getDeadline() {
      return deadline;
   }

   public void setDeadline(LocalDate deadline) {
      this.deadline = deadline;
   }

   public double getSpentHours()
   {
      return spentHours;
   }

   public void setSpentHours(double spentHours)
   {
      this.spentHours = spentHours;
   }


   @Override
   public String toString() {
      return "Task{" +
              "title='" + title + '\'' +
              ", description='" + description + '\'' +
              ", specialties=" + specialties +
              ", startDate=" + startDate +
              ", estimatedTime=" + estimatedTime +
              ", deadline=" + deadline +
              '}';
   }
}