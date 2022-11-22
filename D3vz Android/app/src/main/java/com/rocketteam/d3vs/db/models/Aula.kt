package com.rocketteam.d3vs.db.models

import com.google.gson.annotations.SerializedName
import java.time.LocalDateTime

data class Aula(
    @SerializedName("idAula")
    var id: Long,
    @SerializedName("alunoId")
    var aluno: Long,
    @SerializedName("professorId")
    var professor: Long,
    @SerializedName("dataHora")
    var dataHora: LocalDateTime,
    @SerializedName("url")
    var url: String
)
