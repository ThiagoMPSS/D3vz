package com.rocketteam.d3vs.db

import com.rocketteam.d3vs.db.models.Auth
import retrofit2.Call
import retrofit2.http.Body
import retrofit2.http.POST
import retrofit2.http.Query

interface IUserEndPoint {

    enum class Discriminacao(val value: String) {
        Prof("prof"),
        Aluno("aluno")
    }

    @POST("User/Auth") fun auth(@Body auth: HashMap<String, String>): Call<Auth>

    @POST("User/AuthGoogle") fun authGoogle(@Body auth: HashMap<String, String>): Call<Auth>

}