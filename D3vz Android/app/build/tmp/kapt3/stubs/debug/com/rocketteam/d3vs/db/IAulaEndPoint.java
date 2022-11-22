package com.rocketteam.d3vs.db;

import java.lang.System;

@kotlin.Metadata(mv = {1, 7, 1}, k = 1, d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J6\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u0005\u001a\u00020\u00062\b\b\u0001\u0010\u0007\u001a\u00020\u00062\b\b\u0001\u0010\b\u001a\u00020\t2\b\b\u0001\u0010\n\u001a\u00020\u000bH\'J\u0018\u0010\f\u001a\b\u0012\u0004\u0012\u00020\r0\u00032\b\b\u0001\u0010\u000e\u001a\u00020\u0006H\'J\"\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\r0\u00032\b\b\u0001\u0010\u0005\u001a\u00020\u00062\b\b\u0001\u0010\u0007\u001a\u00020\u0006H\'J\"\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\r0\u00032\b\b\u0001\u0010\u000e\u001a\u00020\u00062\b\b\u0001\u0010\u0011\u001a\u00020\u000bH\'J\u0012\u0010\u0012\u001a\u00020\u00132\b\b\u0001\u0010\u000e\u001a\u00020\u0006H\'J,\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032\b\b\u0001\u0010\u000e\u001a\u00020\u00062\b\b\u0001\u0010\b\u001a\u00020\t2\b\b\u0001\u0010\n\u001a\u00020\u000bH\'\u00a8\u0006\u0015"}, d2 = {"Lcom/rocketteam/d3vs/db/IAulaEndPoint;", "", "add", "Lretrofit2/Call;", "Ljava/lang/Void;", "idProfessor", "", "idAluno", "dataHora", "Ljava/time/LocalDateTime;", "url", "", "get", "Lcom/rocketteam/d3vs/db/models/Aula;", "id", "getByInterlocutores", "getByUser", "discriminacao", "remove", "", "update", "app_debug"})
public abstract interface IAulaEndPoint {
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.GET(value = "Aula")
    public abstract retrofit2.Call<com.rocketteam.d3vs.db.models.Aula> get(@retrofit2.http.Query(value = "id")
    long id);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.GET(value = "Aula/GetByUser")
    public abstract retrofit2.Call<com.rocketteam.d3vs.db.models.Aula> getByUser(@retrofit2.http.Query(value = "userId")
    long id, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "discriminacao")
    java.lang.String discriminacao);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.GET(value = "Aula/GetByInterlocutores")
    public abstract retrofit2.Call<com.rocketteam.d3vs.db.models.Aula> getByInterlocutores(@retrofit2.http.Query(value = "professorId")
    long idProfessor, @retrofit2.http.Query(value = "alunoId")
    long idAluno);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.POST(value = "Aula")
    public abstract retrofit2.Call<java.lang.Void> add(@retrofit2.http.Query(value = "profId")
    long idProfessor, @retrofit2.http.Query(value = "alunoId")
    long idAluno, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "datahora")
    java.time.LocalDateTime dataHora, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "url")
    java.lang.String url);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.PUT(value = "Aula")
    public abstract retrofit2.Call<java.lang.Void> update(@retrofit2.http.Query(value = "id")
    long id, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "datahora")
    java.time.LocalDateTime dataHora, @org.jetbrains.annotations.NotNull()
    @retrofit2.http.Query(value = "url")
    java.lang.String url);
    
    @retrofit2.http.DELETE(value = "Aula")
    public abstract void remove(@retrofit2.http.Query(value = "id")
    long id);
}