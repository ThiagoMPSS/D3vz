import { TestBed } from '@angular/core/testing';
import { SolicitacoesComponent } from './solicitacoes.component';
describe('SolicitacoesComponent', () => {
    let component;
    let fixture;
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [SolicitacoesComponent]
        })
            .compileComponents();
        fixture = TestBed.createComponent(SolicitacoesComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=solicitacoes.component.spec.js.map