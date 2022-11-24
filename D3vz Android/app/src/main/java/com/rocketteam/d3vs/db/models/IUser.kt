package com.rocketteam.d3vs.db.models

import com.google.gson.annotations.SerializedName
import java.time.LocalDateTime
import java.util.*

interface IUser {
    var id: Long;
    var discriminacao: String;
    var nome: String;
    var descricao: String;
    var email: String;
    var senha: String;
    var cpf: String;
    var nascimento: Date?;
    var interQuali: List<String>?;
    var authGoogle: String?;
}