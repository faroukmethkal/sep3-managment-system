package com.example.loginspring.domain;



import model.Account;

import java.rmi.RemoteException;

public interface Model {
    Account findUserByUsername(String username) throws RemoteException;

}
