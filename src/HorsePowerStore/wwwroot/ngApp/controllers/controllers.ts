namespace HorsePowerStore.Controllers {

    export class HomeController {//added showModal++ for login (DG)
        
    }

    export class DialogController {//added DialogController to go with modal login (DG)

        public Ok() {
            this.$modalInstance.close();
        }
        constructor(private $modalInstance: angular.ui.bootstrap.IModalServiceInstance) { }

    }
    angular.module('HorsePowerStore').controller('DialogController', DialogController);
    



    // removed SecretController 11/4/16--DG//

    export class AboutController {
        public message = 'ITS A TRAP!';
    }

    export class ResultController {
        public car; // array : [carId, budget]
        public products; // list of products for car
        public select = "product.price"; // sort <select> element
        public stars;
        public startingBudget;

        constructor(resultService: HorsePowerStore.Services.ResultService,
            private $uibModal: angular.ui.bootstrap.IModalService,
            private accountService: HorsePowerStore.Services.AccountService) {
            this.car = resultService.get().split(',');
            this.startingBudget = parseInt(resultService.get().split(',')[1]);
            resultService.getProducts().then((result) => {
                this.products = result;
            });;
        }

        public budget(price) { // returns true if the item is in budget or false if it is over.
            if (this.startingBudget == "0") {
                return true
            }
            if (price <= this.startingBudget) {
                return true
            }
            return false
        }
        public isLoggedIn() {
            if (this.accountService.isLoggedIn()) {
                return false;
            };
            return true;
        }
        public loginCheck() {
            if (!this.accountService.isLoggedIn()) {
                this.$uibModal.open({
                    templateUrl: '/ngApp/views/pleaseLoginDialog.html',
                    controller: 'PleaseDialogController',
                    controllerAs: 'modal',
                    resolve: {
                    },
                    size: 'sm'
                });
            };
        }

        public showModal(rating: string) {
            if (this.accountService.isLoggedIn()) {
            this.$uibModal.open({
                templateUrl: '/ngApp/views/ratingsDialog.html',
                controller: 'RatingsDialogController',
                controllerAs: 'modal',
                resolve: {
                    rating: () => rating
                },
                size: 'sm'
            });
            }
        }
    }//end of result controller

    class RatingsDialogController {

        public ok() {
            this.$uibModalInstance.close();
        }
        public userRating;
        public beerstring = "beers";

        constructor(public rating: string, private $uibModalInstance: angular.ui.bootstrap.IModalServiceInstance) {
            this.userRating = rating;
            if (parseInt(this.userRating) == 1) {
                this.beerstring = "beer"
            }
        }
    }

    angular.module('HorsePowerStore').controller('RatingsDialogController', RatingsDialogController);

    class PleaseDialogController {

        public ok() {
            this.$uibModalInstance.close();
        }

        constructor(private $uibModalInstance: angular.ui.bootstrap.IModalServiceInstance) {
        }
    }

    angular.module('HorsePowerStore').controller('PleaseDialogController', PleaseDialogController);
}
