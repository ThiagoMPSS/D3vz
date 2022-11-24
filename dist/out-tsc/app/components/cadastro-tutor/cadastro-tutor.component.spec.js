import { TestBed } from '@angular/core/testing';
import { CadastroTutorComponent } from './cadastro-tutor.component';
describe('CadastroTutorComponent', () => {
    let component;
    let fixture;
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [CadastroTutorComponent]
        })
            .compileComponents();
        fixture = TestBed.createComponent(CadastroTutorComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=cadastro-tutor.component.spec.js.map