package com.rocketteam.d3vs.db.models;

import java.lang.System;

@kotlin.Metadata(mv = {1, 7, 1}, k = 1, d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b1\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0099\u0001\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0005\u0012\b\b\u0002\u0010\u0006\u001a\u00020\u0005\u0012\b\b\u0002\u0010\u0007\u001a\u00020\u0005\u0012\b\b\u0002\u0010\b\u001a\u00020\u0005\u0012\b\b\u0002\u0010\t\u001a\u00020\u0005\u0012\b\b\u0002\u0010\n\u001a\u00020\u0005\u0012\n\b\u0002\u0010\u000b\u001a\u0004\u0018\u00010\f\u0012\u0010\b\u0002\u0010\r\u001a\n\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u000e\u0012\n\b\u0002\u0010\u000f\u001a\u0004\u0018\u00010\u0005\u0012\u0010\b\u0002\u0010\u0010\u001a\n\u0012\u0004\u0012\u00020\u0011\u0018\u00010\u000e\u0012\u0010\b\u0002\u0010\u0012\u001a\n\u0012\u0004\u0012\u00020\u0011\u0018\u00010\u000e\u00a2\u0006\u0002\u0010\u0013J\t\u00104\u001a\u00020\u0003H\u00c6\u0003J\u000b\u00105\u001a\u0004\u0018\u00010\u0005H\u00c6\u0003J\u0011\u00106\u001a\n\u0012\u0004\u0012\u00020\u0011\u0018\u00010\u000eH\u00c6\u0003J\u0011\u00107\u001a\n\u0012\u0004\u0012\u00020\u0011\u0018\u00010\u000eH\u00c6\u0003J\t\u00108\u001a\u00020\u0005H\u00c6\u0003J\t\u00109\u001a\u00020\u0005H\u00c6\u0003J\t\u0010:\u001a\u00020\u0005H\u00c6\u0003J\t\u0010;\u001a\u00020\u0005H\u00c6\u0003J\t\u0010<\u001a\u00020\u0005H\u00c6\u0003J\t\u0010=\u001a\u00020\u0005H\u00c6\u0003J\u000b\u0010>\u001a\u0004\u0018\u00010\fH\u00c6\u0003J\u0011\u0010?\u001a\n\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u000eH\u00c6\u0003J\u009d\u0001\u0010@\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u00052\b\b\u0002\u0010\u0007\u001a\u00020\u00052\b\b\u0002\u0010\b\u001a\u00020\u00052\b\b\u0002\u0010\t\u001a\u00020\u00052\b\b\u0002\u0010\n\u001a\u00020\u00052\n\b\u0002\u0010\u000b\u001a\u0004\u0018\u00010\f2\u0010\b\u0002\u0010\r\u001a\n\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u000e2\n\b\u0002\u0010\u000f\u001a\u0004\u0018\u00010\u00052\u0010\b\u0002\u0010\u0010\u001a\n\u0012\u0004\u0012\u00020\u0011\u0018\u00010\u000e2\u0010\b\u0002\u0010\u0012\u001a\n\u0012\u0004\u0012\u00020\u0011\u0018\u00010\u000eH\u00c6\u0001J\u0013\u0010A\u001a\u00020\u00112\b\u0010B\u001a\u0004\u0018\u00010CH\u00d6\u0003J\t\u0010D\u001a\u00020EH\u00d6\u0001J\t\u0010F\u001a\u00020\u0005H\u00d6\u0001R \u0010\u000f\u001a\u0004\u0018\u00010\u00058\u0016@\u0016X\u0097\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\u0014\u0010\u0015\"\u0004\b\u0016\u0010\u0017R\u001e\u0010\n\u001a\u00020\u00058\u0016@\u0016X\u0097\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\u0018\u0010\u0015\"\u0004\b\u0019\u0010\u0017R\u001e\u0010\u0007\u001a\u00020\u00058\u0016@\u0016X\u0097\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\u001a\u0010\u0015\"\u0004\b\u001b\u0010\u0017R&\u0010\u0010\u001a\n\u0012\u0004\u0012\u00020\u0011\u0018\u00010\u000e8\u0006@\u0006X\u0087\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\u001c\u0010\u001d\"\u0004\b\u001e\u0010\u001fR\u001e\u0010\u0004\u001a\u00020\u00058\u0016@\u0016X\u0097\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b \u0010\u0015\"\u0004\b!\u0010\u0017R\u001e\u0010\b\u001a\u00020\u00058\u0016@\u0016X\u0097\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\"\u0010\u0015\"\u0004\b#\u0010\u0017R&\u0010\u0012\u001a\n\u0012\u0004\u0012\u00020\u0011\u0018\u00010\u000e8\u0006@\u0006X\u0087\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b$\u0010\u001d\"\u0004\b%\u0010\u001fR\u001e\u0010\u0002\u001a\u00020\u00038\u0016@\u0016X\u0097\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b&\u0010\'\"\u0004\b(\u0010)R&\u0010\r\u001a\n\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u000e8\u0016@\u0016X\u0097\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b*\u0010\u001d\"\u0004\b+\u0010\u001fR \u0010\u000b\u001a\u0004\u0018\u00010\f8\u0016@\u0016X\u0097\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b,\u0010-\"\u0004\b.\u0010/R\u001e\u0010\u0006\u001a\u00020\u00058\u0016@\u0016X\u0097\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b0\u0010\u0015\"\u0004\b1\u0010\u0017R\u001e\u0010\t\u001a\u00020\u00058\u0016@\u0016X\u0097\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b2\u0010\u0015\"\u0004\b3\u0010\u0017\u00a8\u0006G"}, d2 = {"Lcom/rocketteam/d3vs/db/models/Professor;", "Lcom/rocketteam/d3vs/db/models/IUser;", "id", "", "discriminacao", "", "nome", "descricao", "email", "senha", "cpf", "nascimento", "Ljava/util/Date;", "interQuali", "", "authGoogle", "dias", "", "horarios", "(JLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/Date;Ljava/util/List;Ljava/lang/String;Ljava/util/List;Ljava/util/List;)V", "getAuthGoogle", "()Ljava/lang/String;", "setAuthGoogle", "(Ljava/lang/String;)V", "getCpf", "setCpf", "getDescricao", "setDescricao", "getDias", "()Ljava/util/List;", "setDias", "(Ljava/util/List;)V", "getDiscriminacao", "setDiscriminacao", "getEmail", "setEmail", "getHorarios", "setHorarios", "getId", "()J", "setId", "(J)V", "getInterQuali", "setInterQuali", "getNascimento", "()Ljava/util/Date;", "setNascimento", "(Ljava/util/Date;)V", "getNome", "setNome", "getSenha", "setSenha", "component1", "component10", "component11", "component12", "component2", "component3", "component4", "component5", "component6", "component7", "component8", "component9", "copy", "equals", "other", "", "hashCode", "", "toString", "app_debug"})
public final class Professor implements com.rocketteam.d3vs.db.models.IUser {
    @com.google.gson.annotations.SerializedName(value = "id")
    private long id;
    @org.jetbrains.annotations.NotNull()
    @com.google.gson.annotations.SerializedName(value = "discriminacao")
    private java.lang.String discriminacao;
    @org.jetbrains.annotations.NotNull()
    @com.google.gson.annotations.SerializedName(value = "nome")
    private java.lang.String nome;
    @org.jetbrains.annotations.NotNull()
    @com.google.gson.annotations.SerializedName(value = "descricao")
    private java.lang.String descricao;
    @org.jetbrains.annotations.NotNull()
    @com.google.gson.annotations.SerializedName(value = "email")
    private java.lang.String email;
    @org.jetbrains.annotations.NotNull()
    @com.google.gson.annotations.SerializedName(value = "senha")
    private java.lang.String senha;
    @org.jetbrains.annotations.NotNull()
    @com.google.gson.annotations.SerializedName(value = "cpf")
    private java.lang.String cpf;
    @org.jetbrains.annotations.Nullable()
    @com.google.gson.annotations.SerializedName(value = "nascimento")
    private java.util.Date nascimento;
    @org.jetbrains.annotations.Nullable()
    @com.google.gson.annotations.SerializedName(value = "interquali")
    private java.util.List<java.lang.String> interQuali;
    @org.jetbrains.annotations.Nullable()
    @com.google.gson.annotations.SerializedName(value = "googleauth")
    private java.lang.String authGoogle;
    @org.jetbrains.annotations.Nullable()
    @com.google.gson.annotations.SerializedName(value = "dias")
    private java.util.List<java.lang.Boolean> dias;
    @org.jetbrains.annotations.Nullable()
    @com.google.gson.annotations.SerializedName(value = "horarios")
    private java.util.List<java.lang.Boolean> horarios;
    
    @org.jetbrains.annotations.NotNull()
    public final com.rocketteam.d3vs.db.models.Professor copy(long id, @org.jetbrains.annotations.NotNull()
    java.lang.String discriminacao, @org.jetbrains.annotations.NotNull()
    java.lang.String nome, @org.jetbrains.annotations.NotNull()
    java.lang.String descricao, @org.jetbrains.annotations.NotNull()
    java.lang.String email, @org.jetbrains.annotations.NotNull()
    java.lang.String senha, @org.jetbrains.annotations.NotNull()
    java.lang.String cpf, @org.jetbrains.annotations.Nullable()
    java.util.Date nascimento, @org.jetbrains.annotations.Nullable()
    java.util.List<java.lang.String> interQuali, @org.jetbrains.annotations.Nullable()
    java.lang.String authGoogle, @org.jetbrains.annotations.Nullable()
    java.util.List<java.lang.Boolean> dias, @org.jetbrains.annotations.Nullable()
    java.util.List<java.lang.Boolean> horarios) {
        return null;
    }
    
    @java.lang.Override()
    public boolean equals(@org.jetbrains.annotations.Nullable()
    java.lang.Object other) {
        return false;
    }
    
    @java.lang.Override()
    public int hashCode() {
        return 0;
    }
    
    @org.jetbrains.annotations.NotNull()
    @java.lang.Override()
    public java.lang.String toString() {
        return null;
    }
    
    public Professor() {
        super();
    }
    
    public Professor(long id, @org.jetbrains.annotations.NotNull()
    java.lang.String discriminacao, @org.jetbrains.annotations.NotNull()
    java.lang.String nome, @org.jetbrains.annotations.NotNull()
    java.lang.String descricao, @org.jetbrains.annotations.NotNull()
    java.lang.String email, @org.jetbrains.annotations.NotNull()
    java.lang.String senha, @org.jetbrains.annotations.NotNull()
    java.lang.String cpf, @org.jetbrains.annotations.Nullable()
    java.util.Date nascimento, @org.jetbrains.annotations.Nullable()
    java.util.List<java.lang.String> interQuali, @org.jetbrains.annotations.Nullable()
    java.lang.String authGoogle, @org.jetbrains.annotations.Nullable()
    java.util.List<java.lang.Boolean> dias, @org.jetbrains.annotations.Nullable()
    java.util.List<java.lang.Boolean> horarios) {
        super();
    }
    
    public final long component1() {
        return 0L;
    }
    
    @java.lang.Override()
    public long getId() {
        return 0L;
    }
    
    @java.lang.Override()
    public void setId(long p0) {
    }
    
    @org.jetbrains.annotations.NotNull()
    public final java.lang.String component2() {
        return null;
    }
    
    @org.jetbrains.annotations.NotNull()
    @java.lang.Override()
    public java.lang.String getDiscriminacao() {
        return null;
    }
    
    @java.lang.Override()
    public void setDiscriminacao(@org.jetbrains.annotations.NotNull()
    java.lang.String p0) {
    }
    
    @org.jetbrains.annotations.NotNull()
    public final java.lang.String component3() {
        return null;
    }
    
    @org.jetbrains.annotations.NotNull()
    @java.lang.Override()
    public java.lang.String getNome() {
        return null;
    }
    
    @java.lang.Override()
    public void setNome(@org.jetbrains.annotations.NotNull()
    java.lang.String p0) {
    }
    
    @org.jetbrains.annotations.NotNull()
    public final java.lang.String component4() {
        return null;
    }
    
    @org.jetbrains.annotations.NotNull()
    @java.lang.Override()
    public java.lang.String getDescricao() {
        return null;
    }
    
    @java.lang.Override()
    public void setDescricao(@org.jetbrains.annotations.NotNull()
    java.lang.String p0) {
    }
    
    @org.jetbrains.annotations.NotNull()
    public final java.lang.String component5() {
        return null;
    }
    
    @org.jetbrains.annotations.NotNull()
    @java.lang.Override()
    public java.lang.String getEmail() {
        return null;
    }
    
    @java.lang.Override()
    public void setEmail(@org.jetbrains.annotations.NotNull()
    java.lang.String p0) {
    }
    
    @org.jetbrains.annotations.NotNull()
    public final java.lang.String component6() {
        return null;
    }
    
    @org.jetbrains.annotations.NotNull()
    @java.lang.Override()
    public java.lang.String getSenha() {
        return null;
    }
    
    @java.lang.Override()
    public void setSenha(@org.jetbrains.annotations.NotNull()
    java.lang.String p0) {
    }
    
    @org.jetbrains.annotations.NotNull()
    public final java.lang.String component7() {
        return null;
    }
    
    @org.jetbrains.annotations.NotNull()
    @java.lang.Override()
    public java.lang.String getCpf() {
        return null;
    }
    
    @java.lang.Override()
    public void setCpf(@org.jetbrains.annotations.NotNull()
    java.lang.String p0) {
    }
    
    @org.jetbrains.annotations.Nullable()
    public final java.util.Date component8() {
        return null;
    }
    
    @org.jetbrains.annotations.Nullable()
    @java.lang.Override()
    public java.util.Date getNascimento() {
        return null;
    }
    
    @java.lang.Override()
    public void setNascimento(@org.jetbrains.annotations.Nullable()
    java.util.Date p0) {
    }
    
    @org.jetbrains.annotations.Nullable()
    public final java.util.List<java.lang.String> component9() {
        return null;
    }
    
    @org.jetbrains.annotations.Nullable()
    @java.lang.Override()
    public java.util.List<java.lang.String> getInterQuali() {
        return null;
    }
    
    @java.lang.Override()
    public void setInterQuali(@org.jetbrains.annotations.Nullable()
    java.util.List<java.lang.String> p0) {
    }
    
    @org.jetbrains.annotations.Nullable()
    public final java.lang.String component10() {
        return null;
    }
    
    @org.jetbrains.annotations.Nullable()
    @java.lang.Override()
    public java.lang.String getAuthGoogle() {
        return null;
    }
    
    @java.lang.Override()
    public void setAuthGoogle(@org.jetbrains.annotations.Nullable()
    java.lang.String p0) {
    }
    
    @org.jetbrains.annotations.Nullable()
    public final java.util.List<java.lang.Boolean> component11() {
        return null;
    }
    
    @org.jetbrains.annotations.Nullable()
    public final java.util.List<java.lang.Boolean> getDias() {
        return null;
    }
    
    public final void setDias(@org.jetbrains.annotations.Nullable()
    java.util.List<java.lang.Boolean> p0) {
    }
    
    @org.jetbrains.annotations.Nullable()
    public final java.util.List<java.lang.Boolean> component12() {
        return null;
    }
    
    @org.jetbrains.annotations.Nullable()
    public final java.util.List<java.lang.Boolean> getHorarios() {
        return null;
    }
    
    public final void setHorarios(@org.jetbrains.annotations.Nullable()
    java.util.List<java.lang.Boolean> p0) {
    }
}