import { TestBed } from '@angular/core/testing';
import { InterqualiServiceService } from './interquali-service.service';
describe('InterqualiServiceService', () => {
    let service;
    beforeEach(() => {
        TestBed.configureTestingModule({});
        service = TestBed.inject(InterqualiServiceService);
    });
    it('should be created', () => {
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=interquali-service.service.spec.js.map