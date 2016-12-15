namespace HorsePowerStore.Services {
    export class AccountService {

        // Store access token and claims in browser session storage
        public storeUserInfo(userInfo) {

            // store user name
            this.$window.sessionStorage.setItem('userName', userInfo.userName);

            // store claims
            this.$window.sessionStorage.setItem('claims', JSON.stringify(userInfo.claims));

        }

        public getUserName() {
            return this.$window.sessionStorage.getItem('userName');
        }

        public getClaim(type) {
            var allClaims = JSON.parse(this.$window.sessionStorage.getItem('claims'));
            return allClaims ? allClaims[type] : null;
        }

        public login(loginUser) {
            return this.$q((resolve, reject) => {
                this.$http.post('/api/account/login', loginUser).then((result) => {
                    this.storeUserInfo(result.data);
                        resolve();
                }).catch((result) => {
                    var messages = this.flattenValidation(result.data);
                    reject(messages);
                });
            });
        }

        public register(userLogin) {
            return this.$q((resolve, reject) => {
                this.$http.post('/api/account/register', userLogin)
                    .then((result) => {
                        this.storeUserInfo(result.data);
                        resolve(result);
                    })
                    .catch((result) => {
                        var messages = this.flattenValidation(result.data);
                        reject(messages);
                    });
            });
        }

        public logout() {
            // clear all of session storage (including claims)
            this.$window.sessionStorage.clear();
            // logout on the server
            return this.$http.post('/api/account/logout', null);

        }

        public isLoggedIn() {
            return this.$window.sessionStorage.getItem('userName');
        }

        // associate external login (e.g., Twitter) with local user account
        public registerExternal(email) {
            return this.$q((resolve, reject) => {
                this.$http.post('/api/account/externalLoginConfirmation', { email: email })
                    .then((result) => {
                        this.storeUserInfo(result.data);
                        resolve(result);
                    })
                    .catch((result) => {
                        // flatten error messages
                        let messages = this.flattenValidation(result.data);
                        reject(messages);
                    });
            });
        }

        getExternalLogins(): ng.IPromise<{}> {
            return this.$q((resolve, reject) => {
                let url = `api/Account/getExternalLogins?returnUrl=%2FexternalLogin&generateState=true`;
                this.$http.get(url).then((result: any) => {
                    resolve(result.data);
                }).catch((result) => {
                    reject(result);
                });
            });
        }
        
        // checks whether the current user is authenticated on the server and returns user info
        public checkAuthentication() {
            this.$http.get('/api/account/checkAuthentication')
                .then((result) => {
                    if (result.data) {
                        this.storeUserInfo(result.data);
                    }
                });
        }

        confirmEmail(userId, code): ng.IPromise<{}> {
            return this.$q((resolve, reject) => {
                let data = {
                    userId: userId,
                    code: code
                };
                this.$http.post('/api/account/confirmEmail', data).then((result: any) => {
                    resolve(result.data);
                }).catch((result) => {
                    reject(result);
                });
            });
        }

        // extract access token from response
        parseOAuthResponse(token) {
            let results = {};
            token.split('&').forEach((item) => {
                let pair = item.split('=');
                results[pair[0]] = pair[1];
            });
            return results;
        }
        
        private flattenValidation(modelState) {
            let messages = [];
            for (let prop in modelState) {
                messages = messages.concat(modelState[prop]);
            }
            return messages;
        }

        // represents a modal
        public modalInstance;
        public modalOpen;
        // method used when linking from the login modal to the register modal
        public openRegisterModal() { 
            this.modalInstance = this.$uibModal.open({
                templateUrl: '/ngApp/views/register.html',
                controller: 'RegisterController',
                controllerAs: 'register',
                size: 'sm'
            })
            this.modalOpen = true;
            return this.modalInstance
        }

        public assignLogo(provider) { //assigns logos to external login links 
            switch (provider) {
                case "Facebook":
                    return "fa fa-facebook-square";
                case "Twitter":
                    return "fa fa-twitter-square";
                case "Google":
                    return "fa fa-google-plus-square";
                case "Microsoft":
                    return "fa fa-windows";
            }
        }

        // delete user :(
        public deleteUser() {
            this.$http.delete("/api/account/delete").then(() => { })
        };

        public checkUser() {
            var user = {}
            this.$http.get("/api/account/getUser/" + this.$window.sessionStorage.getItem('userName'))
                .then((result) => { return result.data });
        }

        // resetPassword method functions like a login
        public resetPassword(user) {
            user.rememberMe = false;
            return this.$q((resolve, reject) => {
                    this.$http.post('/api/account/changePassword', user).then(() => {
                        resolve();
                    }).catch((result) => {
                        var messages = this.flattenValidation(result.data);
                        reject(messages);
                    });
            });
        }

        // resetUsername method functions like a login
        public resetUsername(user) {
            user.rememberMe = false;
            return this.$q((resolve, reject) => {
                    this.$http.post('/api/account/changeUsername', user).then(() => {
                        resolve();
                    }).catch((result) => {
                        var messages = this.flattenValidation(result.data);
                        reject(messages);
                    });
            });
        }
        
        constructor
        (
            private $q: ng.IQService,
            private $http: ng.IHttpService,
            private $window: ng.IWindowService,
            private $uibModal: angular.ui.bootstrap.IModalService
        ) {
          // in case we are redirected from a social provider
          // we need to check if we are authenticated.
            this.modalOpen = false;
            this.checkAuthentication();
        }
    }
    angular.module('HorsePowerStore').service('accountService', AccountService);
}
