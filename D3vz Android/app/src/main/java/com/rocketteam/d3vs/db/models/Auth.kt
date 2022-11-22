package com.rocketteam.d3vs.db.models

import com.google.gson.annotations.SerializedName


data class Auth(
    @SerializedName("auth") val Auth: Boolean,
    @SerializedName("id") val Id: Long?
);