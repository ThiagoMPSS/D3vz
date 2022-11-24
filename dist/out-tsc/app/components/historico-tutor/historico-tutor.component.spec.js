import { TestBed } from '@angular/core/testing';
import { HistoricoTutorComponent } from './historico-tutor.component';
describe('HistoricoTutorComponent', () => {
    let component;
    let fixture;
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [HistoricoTutorComponent]
        })
            .compileComponents();
        fixture = TestBed.createComponent(HistoricoTutorComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=historico-tutor.component.spec.js.map