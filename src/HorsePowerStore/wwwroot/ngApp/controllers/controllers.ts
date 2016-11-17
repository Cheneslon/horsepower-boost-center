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
        public productId;
        public stars;
        public startingBudget;

        constructor(resultService: HorsePowerStore.Services.ResultService,
            private $uibModal: angular.ui.bootstrap.IModalService,
            private accountService: HorsePowerStore.Services.AccountService) {
            this.car = resultService.get().split(',');
            this.startingBudget = parseInt(resultService.get().split(',')[1]);
            resultService.getProducts().then((result) => {
                this.products = result;
                console.log(result);
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
        public isLoggedIn(productId) {
            this.productId = productId;
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

        public showModal(productId, rating: string) {
            if (this.accountService.isLoggedIn()) {
            this.$uibModal.open({
                templateUrl: '/ngApp/views/ratingsDialog.html',
                controller: 'RatingsDialogController',
                controllerAs: 'modal',
                resolve: {
                    rating: () => rating,
                    productId: () => productId
                },
                size: 'sm'
            });
            }
        }
        public saveButton() {
            console.log(this.productId);
        }
    }//end of result controller

    class RatingsDialogController {
        public userName;
        public userMessage;
        public rate = {value: '', productId: '', message: '', date: new Date() , applicationUserId: ''};
        public beerstring = "beers";

        constructor(public productId,public rating,
            private $uibModalInstance: angular.ui.bootstrap.IModalServiceInstance,
            private accountService: HorsePowerStore.Services.AccountService) {
            this.rate.value = rating;
            this.rate.productId = productId;
            this.rate.applicationUserId = accountService.getUserName();
            if (parseInt(rating) == 1) {
                this.beerstring = "beer"
            }
        }
        public ok() {
            this.$uibModalInstance.close();
        }
        public save() {
            this.rate.message = this.userMessage;
            this.rate.date = new Date();
            console.log(this.rate);
            this.ok();
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
