namespace HorsePowerStore.Controllers {

    export class HomeController {
        public message = 'jack and jill went down the hill, then they died.';
        //of natural causes
        public showModal(animalName: string) {
            this.$uibModal.open({
                templateUrl: '/ngApp/views/modal.html',
                controller: HorsePowerStore.Controllers.DialogController,
                controllerAs: 'modal',
                resolve: {
                    animalName: () => animalName
                },
                size: 'sm'
            });
        }
        constructor(private $uibModal: angular.ui.bootstrap.IModalService) { }
    }
    export class DialogController {

        public ok() {
            this.$uibModalInstance.close();
        }

        constructor(public animalName: string, private $uibModalInstance: angular.ui.bootstrap.IModalServiceInstance) { }
    }

// removed SecretController --DG//

    export class AboutController {
        public message = 'ITS A TRAP!';
    }

    export class ResultController {
        public car; // array : [carId, budget]
        public products; // list of products for car
        public select; // sort <select> element

        constructor(resultService: HorsePowerStore.Services.ResultService) {
            this.car = resultService.get().split(',');
            this.products = resultService.productResource;
        }

        public budget(price) {
            if (price < this.car[1]) {
                return true
            }
            return false;
        }
        // budget function

    }


}
