package com.rocketteam.d3vs.db;

import java.lang.System;

@kotlin.Metadata(mv = {1, 7, 1}, k = 1, d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001:\u0001\tJ4\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032$\b\u0001\u0010\u0002\u001a\u001e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00060\u0005j\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u0006`\u0007H\'J4\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00040\u00032$\b\u0001\u0010\u0002\u001a\u001e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00060\u0005j\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u0006`\u0007H\'\u00a8\u0006\n"}, d2 = {"Lcom/rocketteam/d3vs/db/IUserEndPoint;", "", "auth", "Lretrofit2/Call;", "Lcom/rocketteam/d3vs/db/models/Auth;", "Ljava/util/HashMap;", "", "Lkotlin/collections/HashMap;", "authGoogle", "Discriminacao", "app_debug"})
public abstract interface IUserEndPoint {
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.POST(value = "User/Auth")
    public abstract retrofit2.Call<com.rocketteam.d3vs.db.models.Auth> auth(@org.jetbrains.annotations.NotNull()
    @retrofit2.http.Body()
    java.util.HashMap<java.lang.String, java.lang.String> auth);
    
    @org.jetbrains.annotations.NotNull()
    @retrofit2.http.POST(value = "User/AuthGoogle")
    public abstract retrofit2.Call<com.rocketteam.d3vs.db.models.Auth> authGoogle(@org.jetbrains.annotations.NotNull()
    @retrofit2.http.Body()
    java.util.HashMap<java.lang.String, java.lang.String> auth);
    
    @kotlin.Metadata(mv = {1, 7, 1}, k = 1, d1 = {"\u0000\u0012\n\u0002\u0018\u0002\n\u0002\u0010\u0010\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\b\u0086\u0001\u0018\u00002\b\u0012\u0004\u0012\u00020\u00000\u0001B\u000f\b\u0002\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u00a2\u0006\u0002\u0010\u0004R\u0011\u0010\u0002\u001a\u00020\u0003\u00a2\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006j\u0002\b\u0007j\u0002\b\b\u00a8\u0006\t"}, d2 = {"Lcom/rocketteam/d3vs/db/IUserEndPoint$Discriminacao;", "", "value", "", "(Ljava/lang/String;ILjava/lang/String;)V", "getValue", "()Ljava/lang/String;", "Prof", "Aluno", "app_debug"})
    public static enum Discriminacao {
        /*public static final*/ Prof /* = new Prof(null) */,
        /*public static final*/ Aluno /* = new Aluno(null) */;
        @org.jetbrains.annotations.NotNull()
        private final java.lang.String value = null;
        
        Discriminacao(java.lang.String value) {
        }
        
        @org.jetbrains.annotations.NotNull()
        public final java.lang.String getValue() {
            return null;
        }
    }
}