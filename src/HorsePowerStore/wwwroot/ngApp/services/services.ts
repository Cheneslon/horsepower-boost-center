namespace HorsePowerStore.Services {

    export class ResultService {
        public productResource;
        public sessionStorage;
        constructor($resource: ng.resource.IResourceService) {
            //this.sessionStorage = this.get().split(',');
            //this.productResource = $resource('/api/products/'+this.sessionStorage[0]).query();
        }

        public get() {
            return window.sessionStorage.getItem('car');
            // car is the session storage key to the information on the users selected car
        }
    }
    angular.module('HorsePowerStore').service('resultService', ResultService);

    }
// didn't do anything here -- DG//