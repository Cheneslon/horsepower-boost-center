namespace HorsePowerStore.Controllers {

    export class HomeController {
        public message = 'jack and jill went down the hill, then they died.';
        //of natural causes
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
