namespace HorsePowerStore.Controllers {

    export class HomeController {//added showModal++ for login (DG)

        public login() {
            this.$uibModal.open({
                templateUrl: '/ngApp/views/login.html',
                controller: HorsePowerStore.Controllers.LoginController,
                controllerAs: 'controller',
                size: 'sm'
            });
        }
        //public Ok() {
        //    this.$uibModalInstance.close();
        //}
        //constructor(private $uibModalInstance: angular.ui.bootstrap.IModalServiceInstance) { }


          constructor(private $uibModal: angular.ui.bootstrap.IModalService) { }
    }

    angular.module('HorsePowerStore').controller('HomeController', HomeController);

    class DialogController {//added DialogController to go with modal login (DG)

        public Ok() {
            this.$uibModalInstance.close();
        }
        constructor(private $uibModalInstance: angular.ui.bootstrap.IModalServiceInstance) { }

    }
    angular.module('HorsePowerStore').controller('DialogController', DialogController);
    



    // removed SecretController 11/4/16--DG//

    export class AboutController {
        public message = 'ITS A TRAP!';
    }

}
