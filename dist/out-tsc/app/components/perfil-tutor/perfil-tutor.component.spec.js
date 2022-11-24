import { TestBed } from '@angular/core/testing';
import { PerfilTutorComponent } from './perfil-tutor.component';
describe('PerfilTutorComponent', () => {
    let component;
    let fixture;
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [PerfilTutorComponent]
        })
            .compileComponents();
        fixture = TestBed.createComponent(PerfilTutorComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=perfil-tutor.component.spec.js.map