package com.rocketteam.d3vs.activities

import android.content.Intent
import android.os.Bundle
import android.util.Log
import android.view.View
import android.widget.Button
import android.widget.EditText
import android.widget.Switch
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import androidx.appcompat.app.AppCompatDelegate
import androidx.appcompat.widget.Toolbar
import com.google.android.gms.auth.api.signin.GoogleSignIn
import com.google.android.gms.auth.api.signin.GoogleSignInOptions
import com.google.android.gms.common.SignInButton
import com.rocketteam.d3vs.R
import com.rocketteam.d3vs.db.D3vzAPIConsumer
import com.rocketteam.d3vs.db.IUserEndPoint
import com.rocketteam.d3vs.db.models.Auth
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class Login : AppCompatActivity() {

    private var edtSenha: EditText? = null
    private var edtEmail: EditText? = null
    private var switchProf: Switch? = null
    private var btGoogle: SignInButton? = null
    private var btEntrar: Button? = null
    private var toolBar2: Toolbar? = null

    private var db: D3vzAPIConsumer? = null
    var gso: GoogleSignInOptions? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_login)
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO);

        gso = GoogleSignInOptions.Builder(GoogleSignInOptions.DEFAULT_SIGN_IN).requestEmail()
            .requestProfile()
            .requestEmail().build()

        //toolBar2
        toolBar2 = findViewById(R.id.toolbar2)

        //switchProf
        switchProf = findViewById(R.id.switchProfessor);

        //btEntrar
        btEntrar = findViewById(R.id.btLoginEntrar);
        btEntrar!!.setOnClickListener { btEntrarOnClick(it) };

        //btGoogle
        btGoogle = findViewById(R.id.btGoogle);
        val txtBtGoogle: TextView = btGoogle!!.getChildAt(0) as TextView
        txtBtGoogle.text = resources.getString(R.string.continuar_com_o_goggle)
        btGoogle!!.setOnClickListener { btGoogleOnClick(it) };

        //edtEmail
        edtEmail = findViewById(R.id.ds_email);

        //edtSenha
        edtSenha = findViewById(R.id.ds_senha);

        db = D3vzAPIConsumer();

    }

    override fun onResume() {
        super.onResume()
        try {
            when (val account = GoogleSignIn.getLastSignedInAccount(this)) {
                null -> Toast.makeText(this, R.string.NaoLogado, Toast.LENGTH_SHORT).show()
                else -> {
                    var cont = this;
                    val tipoUser = if (switchProf!!.isChecked) IUserEndPoint.Discriminacao.prof
                                   else IUserEndPoint.Discriminacao.aluno;
                    db!!.user()!!.authGoogle(account.id!!, tipoUser).enqueue(object : Callback<Auth> {
                        override fun onFailure(call: Call<Auth>, t: Throwable) {
                            throw t;
                        }

                        override fun onResponse(call: Call<Auth>, response: Response<Auth>) {
                            var resposta = response.body()!!;
                            if (resposta.Auth) {
                                startActivity(Home.newInstance(cont, resposta.Id!!, tipoUser))
                                finish()
                            }
                        }
                    })

//                    if (db!!.AlunoDAO().autenticar(account.id!!)) {
//                        startActivity(Home.newInstance(this, account.email!!))
//                        finish()
//                    }
                }
            }
        } catch (ex: Exception) {
            Toast.makeText(
                this,
                "Erro ao entrar com o google",
                Toast.LENGTH_SHORT
            ).show()
            Log.e("Google SignIn", ex.stackTraceToString())
        }
    }

    private fun btGoogleOnClick(it: View?) {
        try {
            val client = GoogleSignIn.getClient(this, gso!!)
            val signInIntent: Intent = client.signInIntent
            startActivity(signInIntent)
        } catch (ex: Exception) {
            Toast.makeText(
                this,
                "Erro ao entrar com o google",
                Toast.LENGTH_SHORT
            ).show()
            Log.e("Google SignIn", ex.stackTraceToString())
        }
    }

    private fun btEntrarOnClick(it: View?) {
        try {
            val cont = this;
            val tipoUser = if (switchProf!!.isChecked) IUserEndPoint.Discriminacao.prof
                           else IUserEndPoint.Discriminacao.aluno;
            db!!.user()!!.auth(edtEmail!!.text.toString(), edtSenha!!.text.toString(), tipoUser)
                .enqueue(object : Callback<Auth> {
                    override fun onFailure(call: Call<Auth>, t: Throwable) {
                        throw t;
                    }

                    override fun onResponse(call: Call<Auth>, response: Response<Auth>) {
                        val resposta = response.body()!!;

                        if (resposta.Auth) {
                            val homeActivity: Intent = Home.newInstance(cont, resposta.Id!!, tipoUser);
                            startActivity(homeActivity);
                        } else {
                            Toast.makeText(cont, R.string.dadosIncorretos, Toast.LENGTH_SHORT).show()
                        }
                    }
                });
        } catch (ex: Exception) {
            Toast.makeText(
                this,
                "Erro ao entrar com o google",
                Toast.LENGTH_SHORT
            ).show()
            Log.e("Google SignIn", ex.stackTraceToString())
        }
//        if (auth) {
//            var homeActivity: Intent = Home.newInstance(this, edtEmail!!.text.toString());
//            startActivity(homeActivity);
//        } else
//            Toast.makeText(this, R.string.dadosIncorretos, Toast.LENGTH_SHORT).show()
    }
}