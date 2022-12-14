package com.rocketteam.d3vs.db

import com.rocketteam.d3vs.db.models.Auth
import com.rocketteam.d3vs.db.models.Professor
import retrofit2.Call
import retrofit2.http.*
import java.time.LocalDateTime

interface IProfessorEndPoint {
    @GET("User") fun get(@Query("email") email: String): Call<Professor>;

    @GET("User/GetById") fun getById(@Query("id") id: Long): Call<Professor>;

    @GET("User/GetAll") fun getAll(@Query("discriminacao") discriminacao: String = "prof"): Call<List<Professor>>

    @POST("User") fun add(@Body user: Professor): Call<Void>;

    @POST("User/Auth") fun auth(@Body user: Auth): Call<Auth>;

    @DELETE("User") fun remove(@Query("Id") id: Long): Call<Void>;

    @PUT("User") fun update(@Body user: Professor): Call<Void>;
}