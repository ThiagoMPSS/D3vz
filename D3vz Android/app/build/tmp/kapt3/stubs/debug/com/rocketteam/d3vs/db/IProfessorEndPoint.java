package com.rocketteam.d3vs.db;

import java.lang.System;

@kotlin.Metadata(mv = {1, 7, 1}, k = 1, d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0005\u001a\u00020\u0006H\'J\u0018\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\b0\u00032\b\b\u0001\u0010\u0005\u001a\u00020\bH\'J\u0018\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00060\u00032\b\b\u0001\u0010\n\u001a\u00020\u000bH\'J\u001e\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00060\r0\u00032\b\b\u0003\u0010\u000e\u001a\u00020\u000bH\'J\u0018\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00060\u00032\b\b\u0001\u0010\u0010\u001a\u00020\u0011H\'J\u0018\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0010\u001a\u00020\u0011H\'J\u0018\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0005\u001a\u00020\u0006H\'\u00a8\u0006\u0014"}, d2 = {"Lcom/rocketteam/d3vs/db/IProfessorEndPoint;", "", "add", "Lretrofit2/Call;", "Ljava/lang/Void;", "user", "Lcom/rocketteam/d3vs/db/models/Professor;", "auth", "Lcom/rocketteam/d3vs/db/models/Auth;", "get", "email", "", "getAll", "", "discriminacao", "getById", "id", "", "remove", "update", "app_debug"})
public abstract interface IProfessorEndPoint {
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.GET(value = "User")
    public abstract retrofit2.Call<com.rocketteam.d3vs.db.models.Professor> get(@org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "email")
    java.lang.String email);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.GET(value = "User/GetById")
    public abstract retrofit2.Call<com.rocketteam.d3vs.db.models.Professor> getById(@retrofit2.http.Query(value = "id")
    long id);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.GET(value = "User/GetAll")
    public abstract retrofit2.Call<java.util.List<com.rocketteam.d3vs.db.models.Professor>> getAll(@org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "discriminacao")
    java.lang.String discriminacao);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.POST(value = "User")
    public abstract retrofit2.Call<java.lang.Void> add(@org.jetbrains.annotations.NotNull()
    @retrofit2.http.Body()
    com.rocketteam.d3vs.db.models.Professor user);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.POST(value = "User/Auth")
    public abstract retrofit2.Call<com.rocketteam.d3vs.db.models.Auth> auth(@org.jetbrains.annotations.NotNull()
    @retrofit2.http.Body()
    com.rocketteam.d3vs.db.models.Auth user);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.DELETE(value = "User")
    public abstract retrofit2.Call<java.lang.Void> remove(@retrofit2.http.Query(value = "Id")
    long id);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.PUT(value = "User")
    public abstract retrofit2.Call<java.lang.Void> update(@org.jetbrains.annotations.NotNull()
    @retrofit2.http.Body()
    com.rocketteam.d3vs.db.models.Professor user);
    
    @kotlin.Metadata(mv = {1, 7, 1}, k = 3)
    public final class DefaultImpls {
    }
}