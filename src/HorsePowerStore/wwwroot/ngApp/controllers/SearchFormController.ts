namespace HorsePowerStore.Controllers {

    export class SearchFormController {
        public makes = [{ "name": "Honda" }, { "name": "Acura" }];
        public make;
        public models;
        public model;
        public years;
        public year;
        public car;
        public cars;
        constructor(
            public searchFormService: HorsePowerStore.Services.SearchFormService,
            public $location: ng.ILocationService) {

            //searchFormService.getMakes().$promise.then((makes) => {
            //    this.makes = makes;
            //})
        }
        //you need to use dependency injection to get the ILocationService
        //in your controller


        //then in the onSubmit() method that gets activated
        //when you finish the form you need:
        public submit(carId,budget) {
            this.searchFormService.save(carId,budget); // calls service
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
            });
        }
    }

    // angular.module('HorsePowerStore').controller('searchFormController', SearchFormController);
}