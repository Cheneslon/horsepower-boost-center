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
        public info = {}; 
        public products; // list of products for car
        public select = "product.price"; // sort <select> element
        public stars;
        public startingBudget: number;

        constructor(
            private resultService: HorsePowerStore.Services.ResultService,
            private $uibModal: angular.ui.bootstrap.IModalService,
            private accountService: HorsePowerStore.Services.AccountService) {

            let items = resultService.get().split(',');
            this.info['id'] = items[0];
            this.info['budget'] = parseInt(items[1]);
            this.info['car'] = items[2];

            this.startingBudget = this.info['budget'];
            if (isNaN(this.startingBudget)) this.startingBudget = 0;

            resultService.getProducts(this.info['id'], 0).then((result) => {
                this.products = result;
                console.log(result);
            });
        }

        public budget(price) { // returns true if the item is in budget or false if it is over.
            return this.startingBudget == 0 || price <= this.startingBudget;
        }

        public isLoggedIn(productId) {
            return this.accountService.isLoggedIn();
        }

        public loginCheck() {
            if (this.accountService.isLoggedIn()) return; 
            this.$uibModal.open({
                templateUrl: '/ngApp/views/pleaseLoginDialog.html',
                controller: 'PleaseDialogController',
                controllerAs: 'modal',
                resolve: {
                },
                size: 'sm'
            });
        }

        public showModal(productId: number, ratingValue: number) {
            if (!this.accountService.isLoggedIn()) return;
            this.$uibModal.open({
                templateUrl: '/ngApp/views/ratingsDialog.html',
                controller: 'RatingsDialogController',
                controllerAs: 'modal',
                resolve: {
                    productId: () => productId,
                    ratingValue: () => ratingValue
                },
                size: 'sm'
            });
        }

        public saveButton() {
            // Save car instance
        }
    }

    class RatingsDialogController {
        public userName;
        public message;
        public beerstring = "beers";

        constructor (
            public ratingValue,
            public productId,
            private $uibModalInstance: angular.ui.bootstrap.IModalServiceInstance,
            private accountService: HorsePowerStore.Services.AccountService,
            private productsService: HorsePowerStore.Services.ProductsService) {
            
            this.userName = accountService.getUserName();

            if (parseInt(this.ratingValue) == 1) {
                this.beerstring = "beer"
            }
        }

        public ok() {
            this.save();
            this.$uibModalInstance.close();
        }

        public save() {
            this.productsService.addRating({
                value: this.ratingValue,
                message: this.message,
                productId: this.productId
            });
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
