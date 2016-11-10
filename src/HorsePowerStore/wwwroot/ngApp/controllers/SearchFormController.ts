namespace HorsePowerStore.Controllers {

    export class SearchFormController {
        public makes;
        public make;
        public models;
        public model;
        public years;
        public year;
        public car;
        public cars;
        public budget;
        public engine;
        public engineArray = []; 
        constructor(
            public searchFormService: HorsePowerStore.Services.SearchFormService,
            public $location: ng.ILocationService) {

            searchFormService.getMakes().$promise.then((makes) => {
                this.makes = makes;
                
            })
        }
        //you need to use dependency injection to get the ILocationService
        //in your controller


        //then in the onSubmit() method that gets activated
        //when you finish the form you need:
        public submit() {
            this.searchFormService.save(this.engine.id, this.budget ); // calls service
            this.$location.path('/result'); // bumps them to resultpage
        }

        public getModels() {
            this.searchFormService.getModels(this.make).$promise.then((models) => {
                this.models = models;
            });
        }

        public getYears() {
            this.searchFormService.getYears(this.make, this.model).$promise.then((years) => {
                this.years = years;
            });
        }

        public getCars() {
            this.searchFormService.getCars(this.make, this.model, this.year).$promise.then((cars) => {
                this.cars = cars;
                //let carArray = [];
                //for (let car of this.cars) {
                //    let carString =
                //        car.doors + " doors, " +
                //        car.drive + " drive, " +
                //        car.fuel + " fuel, " +
                //        car.transmission + " transmission";
                //    this.engineArray.push(car.compatibleEngines);
                //    console.log(car);
                //    carArray.push(carString);
                //}
                //this.cars = carArray;
            });
        }
    }

    // angular.module('HorsePowerStore').controller('searchFormController', SearchFormController);
}