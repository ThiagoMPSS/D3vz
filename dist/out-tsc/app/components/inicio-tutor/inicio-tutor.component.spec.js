import { TestBed } from '@angular/core/testing';
import { InicioTutorComponent } from './inicio-tutor.component';
describe('InicioTutorComponent', () => {
    let component;
    let fixture;
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [InicioTutorComponent]
        })
            .compileComponents();
        fixture = TestBed.createComponent(InicioTutorComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=inicio-tutor.component.spec.js.map