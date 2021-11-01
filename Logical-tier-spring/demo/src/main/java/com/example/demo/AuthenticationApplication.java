package com.example.demo;

import com.example.demo.domain.Model;
import com.example.demo.domain.ModelManager;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;


@SpringBootApplication
public class AuthenticationApplication {

	public static void main(String[] args) throws MalformedURLException, NotBoundException, RemoteException {
		Model model = new ModelManager();
		SpringApplication.run(AuthenticationApplication.class, args);
	}

}
