import { TestBed } from '@angular/core/testing';
import { MenuFiltroComponent } from './menu-filtro.component';
describe('MenuFiltroComponent', () => {
    let component;
    let fixture;
    beforeEach(async () => {
        await TestBed.configureTestingModule({
            declarations: [MenuFiltroComponent]
        })
            .compileComponents();
        fixture = TestBed.createComponent(MenuFiltroComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', () => {
        expect(component).toBeTruthy();
    });
});
//# sourceMappingURL=menu-filtro.component.spec.js.map