namespace HorsePowerStore.Controllers {
    export class ProductsController {
        public product;
        public productId;

        private refreshProduct(id: number) {
            this.productId = id;

            this.productsService
                .getProduct(this.productId)
                .$promise.then((product) => {
                    this.product = product;
                })
        }

        constructor(
            private $uibModal: ng.ui.bootstrap.IModalService,
            private $state: ng.ui.IStateService,
            private $stateParams: ng.ui.IStateParamsService,
            private productsService: HorsePowerStore.Services.ProductsService,
            private accountService: HorsePowerStore.Services.AccountService) {
            
            this.productsService = productsService;
            if ($state.is("productRatings")) {
                this.refreshProduct($stateParams['id'])
            }
        }

        public showModal(ratingValue: number) {
            if (!this.accountService.isLoggedIn()) return;
            this.$uibModal.open({
                templateUrl: '/ngApp/views/ratingsDialog.html',
                controller: 'RatingsDialogController',
                controllerAs: 'modal',
                resolve: {
                    productId: () => this.product.id,
                    ratingValue: () => ratingValue
                },
                size: 'sm'
            }).result.then(() => {
                this.refreshProduct(this.product.id);
            });
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

        public isLoggedIn() {
            return this.accountService.isLoggedIn();
        }
    }
    angular.module('HorsePowerStore').controller('ProductsController', ProductsController);
}