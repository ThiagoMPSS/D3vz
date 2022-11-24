import { __decorate } from "tslib";
import { Injectable } from '@angular/core';
let UserServiceService = class UserServiceService {
    constructor(httpClient) {
        this.httpClient = httpClient;
        this.url = 'https://d3vzapi.azurewebsites.net/API/User';
    }
    authUser(auth) {
        return this.httpClient.post(this.url + "/Auth", auth);
    }
    salvarUser(usuario) {
        return this.httpClient.post(this.url, usuario);
    }
};
UserServiceService = __decorate([
    Injectable({
        providedIn: 'root'
    })
], UserServiceService);
export { UserServiceService };
//# sourceMappingURL=user-service.service.js.map