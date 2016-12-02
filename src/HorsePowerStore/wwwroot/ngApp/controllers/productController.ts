namespace HorsePowerStore.Controllers {
    export class ProductsController {
        public product;
        public productId;

        private refreshProduct() {
            this.productsService
                .getProduct(this.productId)
                .$promise.then((product) => {
                    this.product = product;
                    console.log(this.product.userRating)
                })
        }

        constructor(
            private $uibModal: ng.ui.bootstrap.IModalService,
            private $state: ng.ui.IStateService,
            private $stateParams: ng.ui.IStateParamsService,
            private productsService: HorsePowerStore.Services.ProductsService,
            private accountService: HorsePowerStore.Services.AccountService) {

            this.productId = $stateParams['id'];
            this.productsService = productsService;
            this.refreshProduct();
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
                this.refreshProduct();
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
}