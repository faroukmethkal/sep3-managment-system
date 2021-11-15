package model;

import java.io.Serializable;
import java.time.LocalDate;
import java.util.HashMap;

public class Task implements Serializable {
   private int id;
   private String title;
   private String description;
   private HashMap<String, Integer> specialties;
   private LocalDate startDate;
   private double estimatedTime;
   private LocalDate deadline;

   public Task(String title, String description, HashMap<String, Integer> specialties, LocalDate startDate, double estimatedTime, LocalDate deadline) {
      this.title = title;
      this.description = description;
      this.specialties = specialties;
      this.startDate = startDate;
      this.estimatedTime = estimatedTime;
      this.deadline = deadline;
   }

   public Task(int id, String title, String description, HashMap<String, Integer> specialties, LocalDate startDate, double estimatedTime, LocalDate deadline) {
      this.id = id;
      this.title = title;
      this.description = description;
      this.specialties = specialties;
      this.startDate = startDate;
      this.estimatedTime = estimatedTime;
      this.deadline = deadline;
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

   public HashMap<String, Integer> getSpecialties() {
      return specialties;
   }

   public void setSpecialties(HashMap<String, Integer> specialties) {
      this.specialties = specialties;
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
