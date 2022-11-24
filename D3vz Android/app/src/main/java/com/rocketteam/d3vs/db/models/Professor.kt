package com.rocketteam.d3vs.db.models

import com.google.gson.annotations.SerializedName
import java.util.*

data class Professor(
    @SerializedName("id")
    override var id: Long = -1,
    @SerializedName("discriminacao")
    override var discriminacao: String = "prof",
    @SerializedName("nome")
    override var nome: String = "",
    @SerializedName("descricao")
    override var descricao: String = "",
    @SerializedName("email")
    override var email: String = "",
    @SerializedName("senha")
    override var senha: String = "",
    @SerializedName("cpf")
    override var cpf: String = "",
    @SerializedName("nascimento")
    override var nascimento: Date? = null,
    @SerializedName("interquali")
    override var interQuali: List<String>? = null,
    @SerializedName("googleauth")
    override var authGoogle: String? = null,
    @SerializedName("dias")
    var dias: List<Boolean>? = null,
    @SerializedName("horarios")
    var horarios: List<Boolean>? = null
): IUser;