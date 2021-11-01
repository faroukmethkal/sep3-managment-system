package com.example.demo.domain;

import model.Account;
import network.RemoteModelManager;

import org.springframework.stereotype.Service;

import java.net.MalformedURLException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;

@Service
public class ModelManager implements com.example.demo.domain.Model {
    private RemoteModelManager server;

    public ModelManager() throws MalformedURLException, NotBoundException, RemoteException {
        server = new RemoteModelManager();
    }

    @Override
    public Account findUserByUsername(String username)  {
        try {
            return server.login(username);
        }catch (Exception e){

        }
        return null;
    }

}
