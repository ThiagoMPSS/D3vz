import { TestBed } from '@angular/core/testing';
import { PerfilTutorAlunoComponent } from './perfil-tutor-aluno.component';
describe('PerfilTutorAlunoComponent', () => {
    let component;
    let fixture;
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [PerfilTutorAlunoComponent]
        })
            .compileComponents();
        fixture = TestBed.createComponent(PerfilTutorAlunoComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=perfil-tutor-aluno.component.spec.js.map