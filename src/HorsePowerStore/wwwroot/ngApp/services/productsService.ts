namespace HorsePowerStore.Services {
    export class ProductsService {
        private productsResource;
        public ratings;

        constructor(
            $resource: ng.resource.IResourceService,
            $stateParams: ng.ui.IStateParamsService) {

            this.productsResource =
                $resource('/api/products/' + $stateParams['id'] + '/0')
        }

        public getProduct() {
            return this.productsResource.query();
        }
    }
    angular.module('HorsePowerStore').service('productsService', ProductsService);
}