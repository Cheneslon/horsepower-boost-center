namespace HorsePowerStore.Controllers {

    export class AccountController {
        public externalLogins;
        public modalInstance;
        public validationMessages;
        public user;


        public getUserName() {
            return this.accountService.getUserName();
        }

        public getClaim(type) {
            return this.accountService.getClaim(type);
        }

        public isLoggedIn() {
            return this.accountService.isLoggedIn();
        }

        public deleteUser() {
            return this.accountService.deleteUser();
        }

        public logout() {
            this.accountService.logout();
            this.$location.path('/');
        }

        public getExternalLogins() {
            return this.accountService.getExternalLogins();
        }

        public assignLogo(provider) { //assigns logos to links view
            return this.accountService.assignLogo(provider);
        }

        public deleteAccountModal() {
            this.modalInstance = this.$uibModal.open({
                templateUrl: '/ngApp/views/deleteAccountModal.html',
                scope: this.$scope,
                size: "sm"
            });
        }

        public changePasswordModal() {
            this.modalInstance = this.$uibModal.open({
                templateUrl: '/ngApp/views/changePasswordModal.html',
                scope: this.$scope,
                size: "sm"
            });
        }

        public ok() {
            this.modalInstance.close();
        }

        public deleteAccount() {
            this.accountService.deleteUser();
            this.$state.go('home');
            this.accountService.logout();
        };

        public resetPassword() {
            this.accountService.resetPassword(this.user)
                .then(() => { this.ok() })
                .catch((result) => { this.validationMessages = result });
        }

        constructor(private accountService: HorsePowerStore.Services.AccountService,
                    private $location: ng.ILocationService,
                    private $uibModal: angular.ui.bootstrap.IModalService,
                    private $scope: angular.IScope,
                    private $state: ng.ui.IStateService) {
            this.getExternalLogins().then((results) => {
                this.externalLogins = results;
            });
        }
    }
    angular.module('HorsePowerStore').controller('AccountController', AccountController);


    export class LoginController {
        public loginUser;
        public validationMessages;
        private modalInstance: ng.ui.bootstrap.IModalServiceInstance;
        public popoverOpen = false;
        public username;

        constructor(
            private $uibModal: angular.ui.bootstrap.IModalService,
            private $scope: angular.IScope,
            private accountService: HorsePowerStore.Services.AccountService,
            private $location: ng.ILocationService
        ) { this.username = this.accountService.getUserName();
             };

        public login() {
            this.accountService.login(this.loginUser).then(() => {
                this.ok();
                this.$location.path('/');
                this.username = this.accountService.getUserName();
            }).catch((results) => {
                this.validationMessages = results;
            });
        }
        
        public openLoginDialog() {
            this.validationMessages = {};
            this.modalInstance = this.$uibModal.open({
                templateUrl: '/ngApp/views/login.html',
                scope: this.$scope,
                size: 'sm'
            });
        }

        public ok() {
            this.modalInstance.close();
        }

        public cancel() {
            this.modalInstance.close();
        }
        public openRegister() {
            this.modalInstance.close();
        }
        public registerLink() {
            this.modalInstance.close();
            this.accountService.openRegisterModal();
        };
    }
    angular.module('HorsePowerStore').controller('LoginController', LoginController);

    export class RegisterController {
        public externalLogins;
        public registerUser;
        public validationMessages;
        private modalInstance: ng.ui.bootstrap.IModalServiceInstance;

        constructor(
            private $uibModal: angular.ui.bootstrap.IModalService,
            private $scope: angular.IScope,
            private accountService: HorsePowerStore.Services.AccountService,
            private $location: ng.ILocationService) {
            this.getExternalLogins().then((results) => {
                this.externalLogins = results;
              });
            }

        public register() {
            this.accountService.register(this.registerUser).then(() => {
                this.ok();
                this.$location.path('/');
            }).catch((results) => {
                this.validationMessages = results;
            });
        }

        public openRegisterDialog() {
            this.modalInstance = this.$uibModal.open({
                templateUrl: '/ngApp/views/register.html',
                scope: this.$scope,
                size: 'sm'
            });
        }

        public ok() {
            if (this.accountService.modalOpen) { // checks to see if your trying to close the special register modal
                this.accountService.modalInstance.close();
                this.accountService.modalOpen = false;
            }
            else { // closes regular register modal
                this.modalInstance.close();
            };
        }

        public cancel() {
            this.modalInstance.close();
        }

        public getExternalLogins() {
            return this.accountService.getExternalLogins();
        }

        public assignLogo(provider) { //assigns logos to links view
            return this.accountService.assignLogo(provider);
        }
    }
    angular.module('HorsePowerStore').controller('RegisterController', RegisterController);

    export class ExternalRegisterController {
        public registerUser;
        public validationMessages;
        public modalInstance;

        constructor(
            private accountService: HorsePowerStore.Services.AccountService,
            private $uibModal: angular.ui.bootstrap.IModalService,
            private $scope: angular.IScope,
            private $location: ng.ILocationService) { this.openEmailModal(); }

        public register() {
            this.accountService.registerExternal(this.registerUser.email)
                .then((result) => {
                    this.$location.path('/');
                }).catch((result) => {
                    this.validationMessages = result;
                });
        }

        public openEmailModal() {
            this.modalInstance = this.$uibModal.open({
                templateUrl: '/ngApp/views/externalRegister2.html',
                scope: this.$scope,
                size: 'sm',
                backdrop: 'static',
                keyboard: false
            });
          }

        }

    export class ConfirmEmailController {
        public validationMessages;

        constructor(
            private accountService: HorsePowerStore.Services.AccountService,
            private $http: ng.IHttpService,
            private $stateParams: ng.ui.IStateParamsService,
            private $location: ng.ILocationService
        ) {
            let userId = $stateParams['userId'];
            let code = $stateParams['code'];
            accountService.confirmEmail(userId, code)
                .then((result) => {
                    this.$location.path('/');
                }).catch((result) => {
                    this.validationMessages = result;
                });
        }
    }

    export class DeleteAccountController {
        constructor(private accountService: HorsePowerStore.Services.AccountService,
                    private $state: ng.ui.IStateService) { }
        public deleteAccount() {
            this.accountService.deleteUser();
            this.$state.go('home');
            this.accountService.logout();
        };
    }

}
