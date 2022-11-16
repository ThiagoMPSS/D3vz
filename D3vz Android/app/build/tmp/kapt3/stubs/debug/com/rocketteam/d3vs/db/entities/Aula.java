package com.rocketteam.d3vs.db.entities;

import java.lang.System;

@androidx.room.Entity(tableName = "t_aula", foreignKeys = {@androidx.room.ForeignKey(entity = com.rocketteam.d3vs.db.entities.Usuario.class, childColumns = {"t_aluno_t_user_id_user"}, parentColumns = {"id_user"}), @androidx.room.ForeignKey(entity = com.rocketteam.d3vs.db.entities.Usuario.class, childColumns = {"t_prof_t_user_id_user"}, parentColumns = {"id_user"})})
@kotlin.Metadata(mv = {1, 7, 1}, k = 1, d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0010\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0000\b\u0087\b\u0018\u00002\u00020\u0001B#\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0003\u00a2\u0006\u0002\u0010\u0006J\t\u0010\u000f\u001a\u00020\u0003H\u00c6\u0003J\t\u0010\u0010\u001a\u00020\u0003H\u00c6\u0003J\t\u0010\u0011\u001a\u00020\u0003H\u00c6\u0003J\'\u0010\u0012\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u0003H\u00c6\u0001J\u0013\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0001H\u00d6\u0003J\t\u0010\u0016\u001a\u00020\u0003H\u00d6\u0001J\t\u0010\u0017\u001a\u00020\u0018H\u00d6\u0001R\u001e\u0010\u0002\u001a\u00020\u00038\u0006@\u0006X\u0087\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\u0007\u0010\b\"\u0004\b\t\u0010\nR\u001e\u0010\u0004\u001a\u00020\u00038\u0006@\u0006X\u0087\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\u000b\u0010\b\"\u0004\b\f\u0010\nR\u001e\u0010\u0005\u001a\u00020\u00038\u0006@\u0006X\u0087\u000e\u00a2\u0006\u000e\n\u0000\u001a\u0004\b\r\u0010\b\"\u0004\b\u000e\u0010\n\u00a8\u0006\u0019"}, d2 = {"Lcom/rocketteam/d3vs/db/entities/Aula;", "", "Id", "", "IdAluno", "IdTutor", "(III)V", "getId", "()I", "setId", "(I)V", "getIdAluno", "setIdAluno", "getIdTutor", "setIdTutor", "component1", "component2", "component3", "copy", "equals", "", "other", "hashCode", "toString", "", "app_debug"})
public final class Aula {
    @androidx.room.ColumnInfo(name = "id_aula")
    @androidx.room.PrimaryKey(autoGenerate = true)
    private int Id;
    @androidx.room.ColumnInfo(name = "t_aluno_t_user_id_user")
    private int IdAluno;
    @androidx.room.ColumnInfo(name = "t_prof_t_user_id_user")
    private int IdTutor;
    
    @org.jetbrains.annotations.NotNull()
    public final com.rocketteam.d3vs.db.entities.Aula copy(int Id, int IdAluno, int IdTutor) {
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
    
    public Aula() {
        super();
    }
    
    public Aula(int Id, int IdAluno, int IdTutor) {
        super();
    }
    
    public final int component1() {
        return 0;
    }
    
    public final int getId() {
        return 0;
    }
    
    public final void setId(int p0) {
    }
    
    public final int component2() {
        return 0;
    }
    
    public final int getIdAluno() {
        return 0;
    }
    
    public final void setIdAluno(int p0) {
    }
    
    public final int component3() {
        return 0;
    }
    
    public final int getIdTutor() {
        return 0;
    }
    
    public final void setIdTutor(int p0) {
    }
}