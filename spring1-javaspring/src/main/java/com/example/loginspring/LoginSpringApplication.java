package com.example.loginspring;

import com.example.loginspring.domain.Model;
import com.example.loginspring.domain.ModelManager;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;

@SpringBootApplication
public class LoginSpringApplication {

    public static void main(String[] args) throws MalformedURLException, NotBoundException, RemoteException {
        Model model = new ModelManager();
        SpringApplication.run(LoginSpringApplication.class, args);
    }

}
