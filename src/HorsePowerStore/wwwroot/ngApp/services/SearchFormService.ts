namespace HorsePowerStore.Services {
    export class SearchFormService {
        constructor($resource: ng.resource.IResourceService) {
            this.searchFormResource = $resource("/api/cars", {}, {
                getEdmundsMakes: {
                    method: 'GET',
                    url: 'https://api.edmunds.com/api/vehicle/v2/makes?fmt=json&api_key=mawsu5ejs266r89add5gxwqt',
                    isArray: false
                },
                getEdmundsTrims: {
                    method: 'GET',
                    url: 'https://api.edmunds.com/api/vehicle/v2/:make/:model/:year/styles?fmt=json&api_key=mawsu5ejs266r89add5gxwqt',
                    isArray: false
                },
            });

        }
        public getEdmundsMakes() {
            return this.searchFormResource.getEdmundsMakes();

        }
        private searchFormResource
        public getEdmundsTrims(make, model, year) {
            return this.searchFormResource.getEdmundsTrims({
                make: make,
                model: model,
                year: year
            })
        }
        public save(carId, budget:number) {
            window.sessionStorage.setItem('car', carId + ',' + budget); // saves id
        }
    }
    angular.module("HorsePowerStore").service("searchFormService", SearchFormService);
    
}