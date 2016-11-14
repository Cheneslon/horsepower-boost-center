namespace HorsePowerStore.Controllers {

    export class HomeController {//added showModal++ for login (DG)
        
    }

    export class DialogController {//added DialogController to go with modal login (DG)

        public Ok() {
            this.$modalInstance.close();
        }
        constructor(private $modalInstance: angular.ui.bootstrap.IModalServiceInstance) { }

    }
    angular.module('HorsePowerStore').controller('DialogController', DialogController);
    



    // removed SecretController 11/4/16--DG//

    export class AboutController {
        public message = 'ITS A TRAP!';
    }

    export class ResultController {
        public car; // array : [carId, budget]
        public products; // list of products for car
        public select = "product.price"; // sort <select> element
       

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
