package com.rocketteam.d3vs.db.models

import com.google.gson.annotations.SerializedName
import java.time.LocalDateTime
import java.util.*

interface IUser {
    var id: Long;
    var nome: String;
    var descricao: String;
    var email: String;
    var cpf: String;
    var nascimento: Date;
    var interquali: List<String>?;
}