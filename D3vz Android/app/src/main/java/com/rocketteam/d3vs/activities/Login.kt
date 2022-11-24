package com.rocketteam.d3vs.activities

import android.app.Activity
import android.app.Instrumentation.ActivityResult
import android.content.Intent
import android.os.Bundle
import android.util.Log
import android.view.View
import android.widget.Button
import android.widget.EditText
import android.widget.Switch
import android.widget.TextView
import android.widget.Toast
import androidx.activity.result.ActivityResultLauncher
import androidx.activity.result.contract.ActivityResultContract
import androidx.activity.result.contract.ActivityResultContracts
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
import org.jetbrains.annotations.Nullable
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

    var startForResult: ActivityResultLauncher<Intent>? = null;
    private var db: D3vzAPIConsumer? = null
    var gso: GoogleSignInOptions? = null

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_login)
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO);

        startForResult =
            registerForActivityResult(ActivityResultContracts.StartActivityForResult()) {
//                Toast.makeText(this, "Teste", Toast.LENGTH_LONG).show();
                if (it.resultCode == Activity.RESULT_OK) {
                    when (val account = GoogleSignIn.getSignedInAccountFromIntent(it.data).result) {
                        null -> Toast.makeText(this, R.string.NaoLogado, Toast.LENGTH_SHORT)
                            .show()
                        else -> {
                            val cont = this;
                            val tipoUser =
                                if (switchProf!!.isChecked) IUserEndPoint.Discriminacao.Prof
                                else IUserEndPoint.Discriminacao.Aluno;
                            db!!.user()!!.authGoogle(
                                hashMapOf(
                                    "id" to account.id!!,
                                    "discriminacao" to tipoUser.value
                                )
                            ).enqueue(object : Callback<Auth> {
                                override fun onFailure(call: Call<Auth>, t: Throwable) {
                                    throw t;
                                }

                                override fun onResponse(
                                    call: Call<Auth>,
                                    response: Response<Auth>
                                ) {
                                    val resposta = response.body()!!;
                                    if (resposta.Auth) {
                                        startActivity(
                                            Home.newInstance(
                                                cont,
                                                resposta.Id!!,
                                                tipoUser
                                            )
                                        )
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
                } else {
                    val account = GoogleSignIn.getSignedInAccountFromIntent(it.data).exception;
                    Toast.makeText(this, account.toString(), Toast.LENGTH_LONG).show();
                }
            };

        gso = GoogleSignInOptions.Builder(GoogleSignInOptions.DEFAULT_SIGN_IN)
            .requestIdToken(getString(R.string.GoogleClientID))
            .requestEmail()
            .requestProfile()
            .build()

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
    }

    override fun onActivityResult(requestCode: Int, resultCode: Int, data: Intent?) {
        super.onActivityResult(requestCode, resultCode, data);
    }

    var SignInIntent: Intent? = null;
    private fun btGoogleOnClick(it: View?) {
        try {
            val client = GoogleSignIn.getClient(this, gso!!)
            SignInIntent = client.signInIntent;
            startForResult!!.launch(SignInIntent);
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
            val tipoUser = if (switchProf!!.isChecked) IUserEndPoint.Discriminacao.Prof
            else IUserEndPoint.Discriminacao.Aluno;
            db!!.user()!!.auth(
                hashMapOf(
                    "email" to edtEmail!!.text.toString(),
                    "senha" to edtSenha!!.text.toString(),
                    "discriminacao" to tipoUser.value
                )
            )
                .enqueue(object : Callback<Auth> {
                    override fun onFailure(call: Call<Auth>, t: Throwable) {
                        throw t;
                    }

                    override fun onResponse(call: Call<Auth>, response: Response<Auth>) {
                        if (response.body() == null) {
                            Toast.makeText(cont, "", Toast.LENGTH_LONG).show();
                            return;
                        }

                        val resposta = response.body()!!;
                        if (resposta.Auth) {
                            val homeActivity: Intent =
                                Home.newInstance(cont, resposta.Id!!, tipoUser);
                            startActivity(homeActivity);
                        } else {
                            Toast.makeText(cont, R.string.dadosIncorretos, Toast.LENGTH_SHORT)
                                .show()
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