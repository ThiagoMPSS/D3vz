import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
let interqualiServiceService = class interqualiServiceService {
    constructor(httpClient) {
        this.httpClient = httpClient;
        this.url = 'https://d3vzapi.azurewebsites.net/API/InterQuali';
    }
    lerInterquali() {
        return this.httpClient.get(this.url + "/GetAll");
    }
};
interqualiServiceService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], interqualiServiceService);
export { interqualiServiceService };
//# sourceMappingURL=interquali-service.service.js.map