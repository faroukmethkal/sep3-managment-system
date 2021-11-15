package com.example.loginspring;

import com.example.loginspring.domain.ProfileLogic;
import com.example.loginspring.domain.ProfileLogicManager;
import com.example.loginspring.domain.TaskLogic;
import com.example.loginspring.domain.TaskLogicManager;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;

@SpringBootApplication
public class LoginSpringApplication {

    public static void main(String[] args) throws MalformedURLException, NotBoundException, RemoteException {
        ProfileLogic ProfileLogic = new ProfileLogicManager();
        TaskLogic taskLogic = new TaskLogicManager();
        SpringApplication.run(LoginSpringApplication.class, args);
    }

}
