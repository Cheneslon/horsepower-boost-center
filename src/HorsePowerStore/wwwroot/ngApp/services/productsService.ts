namespace HorsePowerStore.Services {
    export class ProductsService {
        private productsResource;
        public ratings;

        constructor(
            $resource: ng.resource.IResourceService,
            $stateParams: ng.ui.IStateParamsService) {

            this.productsResource = $resource("/api/products", {}, {
                getProductWithRatings: {
                    method: 'GET',
                    url: '/api/products/:id/ratings/:page'
                },
                listProducts: {
                    method: 'GET',
                    url: '/api/products/:page',
                    isArray: true
                },
                addRating: {
                    method: 'POST',
                    url: '/api/products/addRating',
                },
                removeRating: {
                    method: 'POST',
                    url: '/api/products/removeRating',
                }
            });
        }

        public getProduct(productId: number) {
            return this.productsResource.getProductWithRatings({ id: productId });
        }

        public addRating(rating) {
            this.productsResource.addRating(rating);
        }

        public removeRating(ratingId: number) {
            this.productsResource.removeRating({ id: ratingId });
        }

        public listProducts(page: number) {
            this.productsResource.removeRating({ page: page });
        }
    }
    angular.module('HorsePowerStore').service('productsService', ProductsService);
}