package com.rocketteam.d3vs.db;

import java.lang.System;

@kotlin.Metadata(mv = {1, 7, 1}, k = 1, d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\t\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001JZ\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0005\u001a\u00020\u00062\b\b\u0001\u0010\u0007\u001a\u00020\u00062\b\b\u0001\u0010\b\u001a\u00020\u00062\b\b\u0001\u0010\t\u001a\u00020\u00062\b\b\u0001\u0010\n\u001a\u00020\u00062\b\b\u0001\u0010\u000b\u001a\u00020\f2\u000e\b\u0001\u0010\r\u001a\b\u0012\u0004\u0012\u00020\u00060\u000eH\'J\"\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00100\u00032\b\b\u0001\u0010\b\u001a\u00020\u00062\b\b\u0001\u0010\t\u001a\u00020\u0006H\'J\u0018\u0010\u0011\u001a\b\u0012\u0004\u0012\u00020\u00120\u00032\b\b\u0001\u0010\b\u001a\u00020\u0006H\'J\u001e\u0010\u0013\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00120\u000e0\u00032\b\b\u0003\u0010\u0014\u001a\u00020\u0006H\'J\u0018\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00120\u00032\b\b\u0001\u0010\u0016\u001a\u00020\u0017H\'J\u0018\u0010\u0018\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0016\u001a\u00020\u0017H\'Jr\u0010\u0019\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0016\u001a\u00020\u00172\n\b\u0001\u0010\u0005\u001a\u0004\u0018\u00010\u00062\n\b\u0001\u0010\u0007\u001a\u0004\u0018\u00010\u00062\n\b\u0001\u0010\b\u001a\u0004\u0018\u00010\u00062\n\b\u0001\u0010\t\u001a\u0004\u0018\u00010\u00062\n\b\u0001\u0010\n\u001a\u0004\u0018\u00010\u00062\n\b\u0001\u0010\u000b\u001a\u0004\u0018\u00010\f2\u0010\b\u0001\u0010\r\u001a\n\u0012\u0004\u0012\u00020\u0006\u0018\u00010\u000eH\'\u00a8\u0006\u001a"}, d2 = {"Lcom/rocketteam/d3vs/db/IProfessorEndPoint;", "", "add", "Lretrofit2/Call;", "Ljava/lang/Void;", "nm_user", "", "descricao", "email", "senha", "cpf", "dt_nasc", "Ljava/time/LocalDateTime;", "qualidades", "", "auth", "Lcom/rocketteam/d3vs/db/models/Auth;", "get", "Lcom/rocketteam/d3vs/db/models/Professor;", "getAll", "discriminacao", "getById", "id", "", "remove", "update", "app_debug"})
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
    @retrofit2.http.Query(value = "nm_user")
    java.lang.String nm_user, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "descricao")
    java.lang.String descricao, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "email")
    java.lang.String email, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "senha")
    java.lang.String senha, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "cpf")
    java.lang.String cpf, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "dt_nasc")
    java.time.LocalDateTime dt_nasc, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Body()
    java.util.List<java.lang.String> qualidades);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.POST(value = "User/Auth")
    public abstract retrofit2.Call<com.rocketteam.d3vs.db.models.Auth> auth(@org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "email")
    java.lang.String email, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "senha")
    java.lang.String senha);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.DELETE(value = "User")
    public abstract retrofit2.Call<java.lang.Void> remove(@retrofit2.http.Query(value = "Id")
    long id);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.PUT(value = "User")
    public abstract retrofit2.Call<java.lang.Void> update(@retrofit2.http.Query(value = "id")
    long id, @org.jetbrains.annotations.Nullable()
    @retrofit2.http.Query(value = "nm_user")
    java.lang.String nm_user, @org.jetbrains.annotations.Nullable()
    @retrofit2.http.Query(value = "descricao")
    java.lang.String descricao, @org.jetbrains.annotations.Nullable()
    @retrofit2.http.Query(value = "email")
    java.lang.String email, @org.jetbrains.annotations.Nullable()
    @retrofit2.http.Query(value = "senha")
    java.lang.String senha, @org.jetbrains.annotations.Nullable()
    @retrofit2.http.Query(value = "cpf")
    java.lang.String cpf, @org.jetbrains.annotations.Nullable()
    @retrofit2.http.Query(value = "dt_nasc")
    java.time.LocalDateTime dt_nasc, @org.jetbrains.annotations.Nullable()
    @retrofit2.http.Body()
    java.util.List<java.lang.String> qualidades);
    
    @kotlin.Metadata(mv = {1, 7, 1}, k = 3)
    public final class DefaultImpls {
    }
}