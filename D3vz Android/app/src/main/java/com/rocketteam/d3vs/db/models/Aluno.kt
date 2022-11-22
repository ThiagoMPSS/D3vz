package com.rocketteam.d3vs.db.models

import com.google.gson.annotations.SerializedName
import java.util.Date

data class Aluno(
    @SerializedName("id")
    override var id: Long,
    @SerializedName("nome")
    override var nome: String,
    @SerializedName("descricao")
    override var descricao: String,
    @SerializedName("email")
    override var email: String,
    @SerializedName("cpf")
    override var cpf: String,
    @SerializedName("nascimento")
    override var nascimento: Date,
    @SerializedName("interesses")
    override var interquali: List<String>?
) : IUser