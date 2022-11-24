import { TestBed } from '@angular/core/testing';
import { HistoricoAlunoComponent } from './historico-aluno.component';
describe('HistoricoAlunoComponent', () => {
    let component;
    let fixture;
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [HistoricoAlunoComponent]
        })
            .compileComponents();
        fixture = TestBed.createComponent(HistoricoAlunoComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=historico-aluno.component.spec.js.map