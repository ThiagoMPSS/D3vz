package com.rocketteam.d3vs.db

import com.rocketteam.d3vs.db.models.Aluno
import com.rocketteam.d3vs.db.models.Professor
import retrofit2.Call
import retrofit2.http.*
import java.time.LocalDateTime

interface IAlunoEndPoint {
    @GET("User") fun get(
        @Query("email") email: String,
        @Query("discriminacao") discriminacao: String = "aluno"
    ): Call<Aluno>;

    @GET("User/GetById") fun getById(@Query("id") id: Long): Call<Aluno>;

    @GET("User/GetAll") fun getAll(@Query("discriminacao") discriminacao: String = "aluno"): Call<List<Aluno>>

    @POST("User") fun add(
        @Query("nm_user") nm_user: String,
        @Query("email") email: String,
        @Query("senha") senha: String,
        @Query("cpf") cpf: String,
        @Query("dt_nasc") dt_nasc: LocalDateTime,
        @Body interesses: List<String>,
        @Query("discriminacao") discriminacao: String = "aluno"
    ): Call<Void>;

    @DELETE("User") fun remove(@Query("id") id: Long): Call<Void>;

    @PUT("User") fun update(
        @Query("id") id: Long,
        @Query("nm_user") nm_user: String?,
        @Query("email") email: String?,
        @Query("senha") senha: String?,
        @Query("cpf") cpf: String?,
        @Query("dt_nasc") dt_nasc: LocalDateTime?,
        @Body interesses: List<String>?,
        @Query("discriminacao") discriminacao: String = "aluno"
    ): Call<Void>;
}