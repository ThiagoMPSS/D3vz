package com.rocketteam.d3vs.activities

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Button
import androidx.appcompat.app.AppCompatDelegate
import com.google.android.gms.auth.api.signin.GoogleSignInAccount
import com.rocketteam.d3vs.R
import com.rocketteam.d3vs.db.D3vzAPIConsumer

class MainActivity : AppCompatActivity() {

    private var btRegistrar: Button? = null
    private var btEntrar: Button? = null
    private var account: GoogleSignInAccount? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO)

        //BtEntrar
        btEntrar = findViewById(R.id.btEntrar)
        btEntrar!!.setOnClickListener { btEntrarOnClick(it) }

        //BtRegistrar
        btRegistrar = findViewById(R.id.btregistrar)
        btRegistrar!!.setOnClickListener { btRegistrarOnClick(it) }
    }

    override fun onStart() {
        super.onStart()
    }

    private fun btRegistrarOnClick(it: View?) {

        var db = D3vzAPIConsumer();
        var aluno = db?.aluno()?.get("thiago@hotmail.com");
//        aluno?.enqueue(object : Callback<Aluno> {
//            override fun onFailure(call: Call<Aluno>, t: Throwable) {
//                Toast.makeText(baseContext, t.message, Toast.LENGTH_SHORT).show();
//                Log.e("Erro", t.stackTraceToString());
//            }
//
//            override fun onResponse(call: Call<Aluno>, response: Response<Aluno>) {
//                var resposta = response.body()!!;
//                Toast.makeText(baseContext, resposta.nascimento.toString(), Toast.LENGTH_LONG).show();
//            }
//        });
//
        var activityCadastro: Intent = Intent(this, Cadastro::class.java)
        startActivity(activityCadastro)
    }

    private fun btEntrarOnClick(it: View?) {
        var activityLogin: Intent = Intent(this, Login::class.java)
        startActivity(activityLogin)
    }
}