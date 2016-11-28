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
                getYears: {
                    method: 'GET',
                    url: '/api/cars/years/:model',
                    isArray: true
                },
                getCars: {
                    method: 'GET',
                    url: '/api/cars/:make/:model/:year'
                }
            });
        }

        public getEdmundsMakes() {
            return this.searchFormResource.getEdmundsMakes();
        }

        private searchFormResource
        public getEdmundsTrims(make, model, year) {

            if (year >= 1990) return this.searchFormResource.getEdmundsTrims({
                make: make,
                model: model,
                year: year
            });

            return this.searchFormResource.getCars({
                make: make,
                model: model,
                year: year
            });
        }

        public getYears(model) {
            return this.searchFormResource.getYears({
                model: model
            });
        }

        public save(carId, budget:number, car: string) {
            window.sessionStorage.setItem('car', carId + ',' + budget + ',' + car); // saves id
        }
    }
    angular.module("HorsePowerStore").service("searchFormService", SearchFormService);
    
}