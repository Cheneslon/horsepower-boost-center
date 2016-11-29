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
            this.searchFormService.save(this.car.id, this.budget, this.make.name + ' ' + this.model.name + ' ' + this.car.name); // calls service
            this.$location.path('/result'); // bumps them to resultpage
        }

        public getYears() {
            this.searchFormService.getLocalYears(this.model.name).$promise.then((years) => {
                var edmundsYears = this.model.years.map((year) => year.year)
                years = years
                    .filter((year) => edmundsYears.indexOf(year) == -1)
                    .map((year) => { return { id: null, year: year } })
                
                this.model.years = this.model.years.concat(years)

                this.model.years.sort((a, b) => {
                    if (a.year > b.year) return 1
                    if (a.year < b.year) return -1
                    return 0
                })
            });
        }

        public getTrims() {
            this.searchFormService.getTrims(
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