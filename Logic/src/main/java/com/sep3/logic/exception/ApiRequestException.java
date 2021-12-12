package com.sep3.logic.exception;

public class ApiRequestException extends RuntimeException{
    public ApiRequestException(String message) {
        super(message);
    }

    protected ApiRequestException(String message, Throwable cause) {
        super(message, cause);
    }

}
