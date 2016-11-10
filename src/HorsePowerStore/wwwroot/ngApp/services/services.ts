namespace HorsePowerStore.Services {

    export class ResultService {
        public products;
        public productResource;
        public sessionStorage;
        constructor(private $resource: ng.resource.IResourceService) {
            this.sessionStorage = this.get().split(',');
            this.productResource = $resource("/api/carMods/" + this.sessionStorage[0] + "/0")
            console.log(this.productResource);
            //this.productResource.then((result) => { this.secondaryResource = result });
        }


        public get() {
            return window.sessionStorage.getItem('car');
            // car is the session storage key to the information on the users selected car
        }
        public getProducts() {
            console.log(this.productResource)
            return this.productResource.query().$promise
        }
    }
    angular.module('HorsePowerStore').service('resultService', ResultService);

    }
// didn't do anything here -- DG//