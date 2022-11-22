package com.rocketteam.d3vs.db

import com.rocketteam.d3vs.db.models.Auth
import retrofit2.Call
import retrofit2.http.POST
import retrofit2.http.Query

interface IUserEndPoint {

    enum class Discriminacao(val value: String) {
        prof("prof"),
        aluno("aluno")
    }

    @POST("User/Auth") fun auth(
        @Query("email") email: String,
        @Query("senha") senha: String,
        @Query("discriminacao") discriminacao: Discriminacao
    ): Call<Auth>

    @POST("User/AuthGoogle") fun authGoogle(
        @Query("code") code: String,
        @Query("discriminacao") discriminacao: Discriminacao
    ): Call<Auth>
}