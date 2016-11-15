namespace HorsePowerStore.Services {
    export class SearchFormService {
        constructor($resource: ng.resource.IResourceService) {
            this.searchFormResource = $resource("/api/cars", {}, {
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
                getCars: {
                   method: 'GET',
                   url: '/api/cars/:make/:model/:year',
                   isArray: true
               }
            });

        }
        private searchFormResource
        public getMakes() {
            return this.searchFormResource.query();
        }
        
        public getYears(make, model) {
            var data = {
                make: make,
                model: model
            }
            return this.searchFormResource.getYears(data);
        }
        public getModels(make) {
            return this.searchFormResource.getModels({ make:make });
        }
        
        public getCars(make, model, year) {
            return this.searchFormResource.getCars({
                make: make,
                model: model,
                year: year
            })
        }
        public save(engineId, budget:number, name: string) {
            window.sessionStorage.setItem('car', engineId + ',' + budget + ',' + name); // saves id
        }
    }
    angular.module("HorsePowerStore").service("searchFormService", SearchFormService);
    
}