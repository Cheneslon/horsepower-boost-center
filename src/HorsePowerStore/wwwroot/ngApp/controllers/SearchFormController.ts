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

            searchFormService.getEdmundsMakes().$promise.then((makes) => {
                this.makes = makes.makes;
            })
        }
        //you need to use dependency injection to get the ILocationService
        //in your controller


        //then in the onSubmit() method that gets activated
        //when you finish the form you need:
        public submit() {
            this.searchFormService.save(this.car.id, this.budget ); // calls service
            this.$location.path('/result'); // bumps them to resultpage
        }
        public getEdmundsTrims() {
            this.searchFormService.getEdmundsTrims(
                this.make.name,
                this.model.name,
                this.year.year)
                .$promise.then((cars) => {
                    this.cars = cars.styles;
                    this.car = null;
            });
        }
    }
}