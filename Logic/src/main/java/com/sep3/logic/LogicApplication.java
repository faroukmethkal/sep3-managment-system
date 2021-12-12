package com.sep3.logic;

import com.sep3.logic.domain.*;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;

@SpringBootApplication
public class LogicApplication {

    public static void main(String[] args) throws MalformedURLException, NotBoundException, RemoteException {
        ProfileLogic ProfileLogic = new ProfileLogicManager();
        TaskLogic taskLogic = new TaskLogicManager();
        ShiftLogic shiftLogic = new ShiftLogicManager();
        SpringApplication.run(LogicApplication.class, args);
    }

}
