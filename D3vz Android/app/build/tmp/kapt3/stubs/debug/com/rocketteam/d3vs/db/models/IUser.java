package com.rocketteam.d3vs.db.models;

import java.lang.System;

@kotlin.Metadata(mv = {1, 7, 1}, k = 1, d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0011\n\u0002\u0010\t\n\u0002\b\u0005\n\u0002\u0010 \n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u000b\bf\u0018\u00002\u00020\u0001R\u001a\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u00a6\u000e\u00a2\u0006\f\u001a\u0004\b\u0004\u0010\u0005\"\u0004\b\u0006\u0010\u0007R\u0018\u0010\b\u001a\u00020\u0003X\u00a6\u000e\u00a2\u0006\f\u001a\u0004\b\t\u0010\u0005\"\u0004\b\n\u0010\u0007R\u0018\u0010\u000b\u001a\u00020\u0003X\u00a6\u000e\u00a2\u0006\f\u001a\u0004\b\f\u0010\u0005\"\u0004\b\r\u0010\u0007R\u0018\u0010\u000e\u001a\u00020\u0003X\u00a6\u000e\u00a2\u0006\f\u001a\u0004\b\u000f\u0010\u0005\"\u0004\b\u0010\u0010\u0007R\u0018\u0010\u0011\u001a\u00020\u0003X\u00a6\u000e\u00a2\u0006\f\u001a\u0004\b\u0012\u0010\u0005\"\u0004\b\u0013\u0010\u0007R\u0018\u0010\u0014\u001a\u00020\u0015X\u00a6\u000e\u00a2\u0006\f\u001a\u0004\b\u0016\u0010\u0017\"\u0004\b\u0018\u0010\u0019R \u0010\u001a\u001a\n\u0012\u0004\u0012\u00020\u0003\u0018\u00010\u001bX\u00a6\u000e\u00a2\u0006\f\u001a\u0004\b\u001c\u0010\u001d\"\u0004\b\u001e\u0010\u001fR\u001a\u0010 \u001a\u0004\u0018\u00010!X\u00a6\u000e\u00a2\u0006\f\u001a\u0004\b\"\u0010#\"\u0004\b$\u0010%R\u0018\u0010&\u001a\u00020\u0003X\u00a6\u000e\u00a2\u0006\f\u001a\u0004\b\'\u0010\u0005\"\u0004\b(\u0010\u0007R\u0018\u0010)\u001a\u00020\u0003X\u00a6\u000e\u00a2\u0006\f\u001a\u0004\b*\u0010\u0005\"\u0004\b+\u0010\u0007\u00a8\u0006,"}, d2 = {"Lcom/rocketteam/d3vs/db/models/IUser;", "", "authGoogle", "", "getAuthGoogle", "()Ljava/lang/String;", "setAuthGoogle", "(Ljava/lang/String;)V", "cpf", "getCpf", "setCpf", "descricao", "getDescricao", "setDescricao", "discriminacao", "getDiscriminacao", "setDiscriminacao", "email", "getEmail", "setEmail", "id", "", "getId", "()J", "setId", "(J)V", "interQuali", "", "getInterQuali", "()Ljava/util/List;", "setInterQuali", "(Ljava/util/List;)V", "nascimento", "Ljava/util/Date;", "getNascimento", "()Ljava/util/Date;", "setNascimento", "(Ljava/util/Date;)V", "nome", "getNome", "setNome", "senha", "getSenha", "setSenha", "app_debug"})
public abstract interface IUser {
    
    public abstract long getId();
    
    public abstract void setId(long p0);
    
    @org.jetbrains.annotations.NotNull()
    public abstract java.lang.String getDiscriminacao();
    
    public abstract void setDiscriminacao(@org.jetbrains.annotations.NotNull()
    java.lang.String p0);
    
    @org.jetbrains.annotations.NotNull()
    public abstract java.lang.String getNome();
    
    public abstract void setNome(@org.jetbrains.annotations.NotNull()
    java.lang.String p0);
    
    @org.jetbrains.annotations.NotNull()
    public abstract java.lang.String getDescricao();
    
    public abstract void setDescricao(@org.jetbrains.annotations.NotNull()
    java.lang.String p0);
    
    @org.jetbrains.annotations.NotNull()
    public abstract java.lang.String getEmail();
    
    public abstract void setEmail(@org.jetbrains.annotations.NotNull()
    java.lang.String p0);
    
    @org.jetbrains.annotations.NotNull()
    public abstract java.lang.String getSenha();
    
    public abstract void setSenha(@org.jetbrains.annotations.NotNull()
    java.lang.String p0);
    
    @org.jetbrains.annotations.NotNull()
    public abstract java.lang.String getCpf();
    
    public abstract void setCpf(@org.jetbrains.annotations.NotNull()
    java.lang.String p0);
    
    @org.jetbrains.annotations.Nullable()
    public abstract java.util.Date getNascimento();
    
    public abstract void setNascimento(@org.jetbrains.annotations.Nullable()
    java.util.Date p0);
    
    @org.jetbrains.annotations.Nullable()
    public abstract java.util.List<java.lang.String> getInterQuali();
    
    public abstract void setInterQuali(@org.jetbrains.annotations.Nullable()
    java.util.List<java.lang.String> p0);
    
    @org.jetbrains.annotations.Nullable()
    public abstract java.lang.String getAuthGoogle();
    
    public abstract void setAuthGoogle(@org.jetbrains.annotations.Nullable()
    java.lang.String p0);
}