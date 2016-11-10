namespace HorsePowerStore.Controllers {

    export class HomeController {
        public message = 'jack and jill went down the hill, then they died.';
        //of natural causes
        constructor() { }
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
            resultService.getProducts().then((result) => {
                this.products = result; console.log(this.products);
            });;

        }

        public budget(price) { // returns true if the item is in budget or false if it is over.
            if (price <= this.car[1]) {
                return true
            }
            return false
        }
    }//end of result controller


}
