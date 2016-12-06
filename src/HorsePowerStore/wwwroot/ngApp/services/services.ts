namespace HorsePowerStore.Services {

    export class ResultService {
        public carMods;
        private carModResource;
        private carInstanceResource;

        constructor(private $resource: ng.resource.IResourceService) {
            this.carModResource = $resource("/api/carMods/:id/:page")
            this.carInstanceResource = $resource("/api/carInstances/:id")
            //this.productResource.then((result) => { this.secondaryResource = result });
        }

        public get() {
            return window.sessionStorage.getItem('car');
            // car is the session storage key to the information on the users selected car
        }

        public getCarMods(id: number, page: number) {
            return this.carModResource.query({ id: id, page: page }).$promise
        }

        public getCarInstance(id: number) {
            return this.carInstanceResource.get({ id: id }).$promise;
        }
    }
    angular.module('HorsePowerStore').service('resultService', ResultService);

    }
// didn't do anything here -- DG//