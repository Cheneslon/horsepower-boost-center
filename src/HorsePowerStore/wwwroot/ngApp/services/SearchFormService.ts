namespace HorsePowerStore.Services {
    export class SearchFormService {
        private searchFormResource

        constructor($resource: ng.resource.IResourceService) {
            this.searchFormResource = $resource("/api/cars", {}, {
                getMakes: {
                    method: 'GET',
                    url: '/api/cars',
                    isArray: true
                },
                getModels: {
                    method: 'GET',
                    url: '/api/cars/:make',
                    isArray: true
                },
                getYears: {
                    method: 'GET',
                    url: '/api/cars/years/:model',
                    isArray: true
                },
                getTrims: {
                    method: 'GET',
                    url: '/api/cars/:make/:model/:year'
                }
            });
        }

        public getMakes() {
            return this.searchFormResource.getMakes().$promise;
        }

        public getModels(make: string) {
            return this.searchFormResource.getModels({
                make: make
            }).$promise;
        }

        public getYears(model: string) {
            return this.searchFormResource.getYears({
                model: model
            }).$promise;
        }

        public getTrims(make: string, model: string, year: number) {
            return this.searchFormResource.getTrims({
                make: make,
                model: model,
                year: year
            }).$promise;
        }

        public save(styleId: number, budget: number, car: string) {
            window.sessionStorage.setItem('car', styleId + ',' + budget + ',' + car); // saves id
        }
    }
    angular.module("HorsePowerStore").service("searchFormService", SearchFormService);
}