package com.rocketteam.d3vs.db

import com.google.gson.GsonBuilder
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory

class D3vzAPIConsumer {
    var instance: Retrofit? = null;

    constructor(path: String? = null) {
        var path = path ?: "https://d3vzapi.azurewebsites.net/API/"
        var gson = GsonBuilder().setDateFormat("yyyy-MM-dd'T'HH:mm:ss").create();
        instance = Retrofit.Builder()
            .baseUrl(path)
            .addConverterFactory(GsonConverterFactory.create(gson))
            .build();
    }

    fun aluno(): IAlunoEndPoint? {
        return instance?.create(IAlunoEndPoint::class.java);
    }

    fun professor(): IProfessorEndPoint? {
        return instance?.create(IProfessorEndPoint::class.java);
    }

    fun aula(): IAulaEndPoint? {
        return instance?.create(IAulaEndPoint::class.java);
    }

    fun user(): IUserEndPoint? {
        return instance?.create(IUserEndPoint::class.java);
    }

}