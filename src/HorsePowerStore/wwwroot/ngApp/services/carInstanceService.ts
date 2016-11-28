namespace HorsePowerStore.Services {
    export class CarInstanceService {
        private carInstanceResource
        public car;

        constructor($resource: ng.resource.IResourceService) {
            this.carInstanceResource = $resource('/api/carInstances/');
        }

        public listCarInstances() {
            return this.carInstanceResource.query();
        }

        public saveCarInstance(car) {
            return this.carInstanceResource.save(car).$promise;
        }
    }
    angular.module('HorsePowerStore').service('carInstanceService', CarInstanceService);
}