package com.rocketteam.d3vs.db

import com.rocketteam.d3vs.db.models.Aula
import retrofit2.Call
import retrofit2.http.*
import java.time.LocalDateTime

interface IAulaEndPoint {

    @GET("Aula") fun get(@Query("id") id: Long): Call<Aula>;

    @GET("Aula/GetByUser") fun getByUser(
        @Query("userId") id: Long,
        @Query("discriminacao") discriminacao: String
    ): Call<Aula>;

    @GET("Aula/GetByInterlocutores") fun getByInterlocutores(
        @Query("professorId") idProfessor: Long,
        @Query("alunoId") idAluno: Long
    ): Call<Aula>;

    @POST("Aula") fun add(
        @Query("profId") idProfessor: Long,
        @Query("alunoId") idAluno: Long,
        @Query("datahora") dataHora: LocalDateTime,
        @Query("url") url: String
    ): Call<Void>;

    @PUT("Aula") fun update(
        @Query("id") id: Long,
        @Query("datahora") dataHora: LocalDateTime,
        @Query("url") url: String
    ): Call<Void>;

    @DELETE("Aula") fun remove(
        @Query("id") id: Long
    );

}