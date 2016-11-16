namespace HorsePowerStore.Services {
    export class CarInstanceService {
        private carInstanceResource

        constructor($resource: ng.resource.IResourceService) {
            this.carInstanceResource = $resource('/api/carInstances/');
        }

        public listCarInstances() {
            return this.carInstanceResource.query();
        }
    }
    angular.module('HorsePowerStore').service('carInstanceService', CarInstanceService);
}