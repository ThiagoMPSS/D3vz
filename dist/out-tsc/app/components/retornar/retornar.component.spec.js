import { TestBed } from '@angular/core/testing';
import { RetornarComponent } from './retornar.component';
describe('RetornarComponent', () => {
    let component;
    let fixture;
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [RetornarComponent]
        })
            .compileComponents();
        fixture = TestBed.createComponent(RetornarComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=retornar.component.spec.js.map