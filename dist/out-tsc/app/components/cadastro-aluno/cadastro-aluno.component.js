import { __decorate } from "tslib";
import { Component } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
let CadastroAlunoComponent = class CadastroAlunoComponent {
    constructor(formBuilder, criarUsuario, criarInterquali, router) {
        this.formBuilder = formBuilder;
        this.criarUsuario = criarUsuario;
        this.criarInterquali = criarInterquali;
        this.router = router;
        this.interesse = [];
    }
    ngOnInit() {
        this.form = this.formBuilder.group({
            email: new FormControl('', [Validators.required]),
            senha: new FormControl('', [Validators.required]),
            interesse: new FormControl(''),
            nome: new FormControl('', [Validators.required]),
            cpf: new FormControl('', [Validators.required]),
            nascimento: new FormControl('', [Validators.required]),
            descricao: new FormControl('')
        });
        this.criarInterquali.lerInterquali().subscribe({
            next: (usuario) => {
                this.interquali = usuario;
            }
        });
    }
    converterInterQuali2String(interquali) {
        let str = [];
        interquali.forEach(e => str.push(e.nome));
        return str;
    }
    selecionarInteresse() {
        const interesse = this.form.controls["interesse"].value;
        const interesses = { nome: interesse };
        this.interesse.push(interesses);
    }
    cadastrarUsuario() {
        const email = this.form.controls["email"].value;
        const senha = this.form.controls["senha"].value;
        const nome = this.form.controls["nome"].value;
        const cpf = this.form.controls["cpf"].value;
        const nascimento = this.form.controls["nascimento"].value;
        const descricao = this.form.controls["descricao"].value;
        const usuario = { discriminacao: "aluno", email: email, senha: senha,
            interquali: this.converterInterQuali2String(this.interesse), nome: nome, cpf: cpf, nascimento: nascimento, descricao: descricao };
        this.criarUsuario.salvarUser(usuario).subscribe({
            next: () => {
                this.router.navigateByUrl('/inicio-aluno');
            }
        });
    }
};
CadastroAlunoComponent = __decorate([
    Component({
        selector: 'app-cadastro-aluno',
        templateUrl: './cadastro-aluno.component.html',
        styleUrls: ['./cadastro-aluno.component.css']
    })
], CadastroAlunoComponent);
export { CadastroAlunoComponent };
//# sourceMappingURL=cadastro-aluno.component.js.map