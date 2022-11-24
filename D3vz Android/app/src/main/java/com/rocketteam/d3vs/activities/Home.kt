package com.rocketteam.d3vs.activities

import android.content.Context
import android.content.Intent
import android.os.Bundle
import android.util.Log
import android.view.ViewGroup
import android.widget.TextView
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import androidx.appcompat.app.AppCompatDelegate
import androidx.fragment.app.Fragment
import com.google.android.gms.auth.api.signin.GoogleSignInAccount
import com.google.android.material.bottomnavigation.BottomNavigationView
import com.rocketteam.d3vs.R
import com.rocketteam.d3vs.activities.fragments.HistoricFragment
import com.rocketteam.d3vs.activities.fragments.HomeFragment
import com.rocketteam.d3vs.activities.fragments.PesquisaFragment
import com.rocketteam.d3vs.activities.model.CardTutor
import com.rocketteam.d3vs.db.D3vzAPIConsumer
import com.rocketteam.d3vs.db.IUserEndPoint
import com.rocketteam.d3vs.db.models.IUser
import com.rocketteam.d3vs.db.models.Professor
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response
import java.time.LocalDate
import java.time.ZoneId

public class Home : AppCompatActivity() {

    private val historicfragment = HistoricFragment()
    private var bottomNavigation: BottomNavigationView? = null
    private var actualFragment: Int = 0
    private var fragmentContainer: ViewGroup? = null

    private var lblUsuario: TextView? = null
    private var lblInteresses: TextView? = null
    private var lblEmail: TextView? = null
    private var lblIdade: TextView? = null

    private var perfil: IUser? = null;
    private var account: GoogleSignInAccount? = null

    private var db: D3vzAPIConsumer? = null;

    companion object {
        fun newInstance(
            Context: Context,
            Id: Long,
            Discriminacao: IUserEndPoint.Discriminacao
        ): Intent {
            val perfil = Intent(Context, Home::class.java);
            val bundle = Bundle();
            bundle.putLong("Id", Id);
            bundle.putString("Discriminacao", Discriminacao.value);
            perfil.putExtras(bundle);
            return perfil;
        }
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO);

        val id = intent.extras!!.getLong("Id", -1);
        val discriminacao = if (intent.extras!!.getString("Discriminacao", "aluno") == "aluno")
            IUserEndPoint.Discriminacao.Aluno
        else
            IUserEndPoint.Discriminacao.Prof;

        try {
            db = D3vzAPIConsumer();
            val user: Call<IUser>? = when (discriminacao) {
                IUserEndPoint.Discriminacao.Aluno -> db?.aluno()?.getById(id) as Call<IUser>?;
                IUserEndPoint.Discriminacao.Prof -> db?.professor()?.getById(id) as Call<IUser>?
            }
            user?.enqueue(object : Callback<IUser> {
                override fun onFailure(call: Call<IUser>, t: Throwable) {
                    Toast.makeText(baseContext, t.message, Toast.LENGTH_SHORT).show();
                }

                override fun onResponse(call: Call<IUser>, response: Response<IUser>) {
                    perfil = response.body();

                    replaceFragment(homeFragment());
                    Toast.makeText(baseContext, perfil!!.cpf, Toast.LENGTH_LONG).show();
                }
            });
        } catch (ex: Exception) {
            Toast.makeText(
                this,
                "Ocorreu um erro ao recuperar os dados da conta.",
                Toast.LENGTH_LONG
            ).show()
            Log.e("SignIn", ex.stackTraceToString())
            finish()
            return
        }

//        supportActionBar!!.hide()
        bottomNavigation = findViewById(R.id.bottom_navigation);
        fragmentContainer = findViewById(R.id.fragment_container);

        bottomNavigation!!.setOnItemSelectedListener {
            when (it.toString()) {
                "Perfil" -> {
                    replaceFragment(homeFragment())
                    actualFragment = 0
                }
                "Busca" -> {
                    val tutores = ArrayList<CardTutor>()
                    db!!.professor()!!.getAll().enqueue(object : Callback<List<Professor>> {
                        override fun onFailure(call: Call<List<Professor>>, t: Throwable) {
                            Toast.makeText(baseContext, t.message, Toast.LENGTH_SHORT).show();
                        }

                        override fun onResponse(call: Call<List<Professor>>, response: Response<List<Professor>>) {
                            var body = response.body()!!;
                            body.forEach { tutor ->
                                tutores.add(
                                    CardTutor(
                                        R.drawable.ic_person,
                                        tutor.nome,
                                        tutor.descricao,
                                        if (tutor.interQuali != null) tutor.interQuali!![0] else "",
                                        ""
                                    )
                                )
                            }
                            replaceFragment(PesquisaFragment.newInstance(tutores.toTypedArray()))
                            actualFragment = 1
                        }
                    });
                }
                "Histórico" -> {
                    replaceFragment(historicfragment)
                    actualFragment = 2
                }
            }
            true
        }
    }

    private fun homeFragment(): Fragment {
        return HomeFragment.newInstance(
            perfil!!.nome,
            calcIdade(perfil!!.nascimento!!.toInstant()
                .atZone(ZoneId.systemDefault())
                .toLocalDate()).toString() + " anos",
            perfil!!.email,
            perfil!!.interQuali.let { it?.toTypedArray() ?: arrayOf(); }
        )
//        throw Exception("");
    }

    private fun calcIdade(date: LocalDate): Int {
        return (LocalDate.now().plusYears(-date.year.toLong())
            .plusMonths(-date.monthValue.toLong())
            .plusDays(-date.dayOfYear.toLong())).year
    }

    private fun replaceFragment(fragment: Fragment) {
        val transaction = supportFragmentManager.beginTransaction()
        transaction.replace(R.id.fragment_container, fragment)
        transaction.commit()
    }
}