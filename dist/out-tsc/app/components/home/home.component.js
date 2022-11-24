import { __decorate } from "tslib";
import { Component } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
let HomeComponent = class HomeComponent {
    constructor(formBuilder, lerUsuario, snackBar, router) {
        this.formBuilder = formBuilder;
        this.lerUsuario = lerUsuario;
        this.snackBar = snackBar;
        this.router = router;
    }
    ngOnInit() {
        this.form = this.formBuilder.group({
            email: new FormControl('', [Validators.required]),
            senha: new FormControl('', [Validators.required]),
            checktutor: new FormControl('')
        });
    }
    realizarLogin() {
        const email = this.form.controls["email"].value;
        const senha = this.form.controls["senha"].value;
        const discriminacao = this.form.controls["checktutor"].value;
        const usuario = { discriminacao: discriminacao ? "prof" : "aluno", email: email, senha: senha };
        this.lerUsuario.authUser(usuario).subscribe({
            next: (user) => {
                if (user.discriminacao == "aluno") {
                    this.router.navigate(['../inicio-aluno']);
                }
                if (user.discriminacao == "prof") {
                    this.router.navigate(['../inicio-tutor']);
                }
            },
            error: () => {
                this.alertaDados("falha");
            }
        });
    }
    alertaDados(tipoExecucao) {
        switch (tipoExecucao) {
            case "falha":
                this.snackBar.open("Não foi possível realizar o login", undefined, { duration: 2000 });
                break;
        }
    }
};
HomeComponent = __decorate([
    Component({
        selector: 'app-home',
        templateUrl: './home.component.html',
        styleUrls: ['./home.component.css']
    })
], HomeComponent);
export { HomeComponent };
//# sourceMappingURL=home.component.js.map