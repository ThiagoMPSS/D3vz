import { TestBed } from '@angular/core/testing';
import { InicioAlunoComponent } from './inicio-aluno.component';
describe('InicioAlunoComponent', () => {
    let component;
    let fixture;
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [InicioAlunoComponent]
        })
            .compileComponents();
        fixture = TestBed.createComponent(InicioAlunoComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=inicio-aluno.component.spec.js.map