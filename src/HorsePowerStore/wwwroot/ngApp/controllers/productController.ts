namespace HorsePowerStore.Controllers {
    export class ProductsController {
        public product;
        private productsService;

        constructor(
            productsService: HorsePowerStore.Services.ProductsService) {

            this.productsService = productsService;
            this.productsService.getProduct().$promise.then((product) => {
                this.product = product;
            })
        }
    }
}