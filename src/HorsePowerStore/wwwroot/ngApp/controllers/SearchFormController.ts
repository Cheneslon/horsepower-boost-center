namespace HorsePowerStore.Controllers {

    export class SearchFormController {
        public makes: string[];
        public selectedMake: string;
        public models: string[];
        public selectedModel: string;
        public years: number[];
        public selectedYear: number;
        public styles: string[];
        public selectedStyle;
        public budget: number;

        constructor(
            public searchFormService: HorsePowerStore.Services.SearchFormService,
            public $state: ng.ui.IStateService) {

            searchFormService.getMakes().then((makes) => {
                this.makes = makes;
            })
        }

        public getModels() {
            this.searchFormService.getModels(this.selectedMake).then((models) => {
                this.models = models;
                if (this.models.length == 1) {
                    this.selectedModel = this.models[0];
                    this.getYears();
                }
            });
        }

        public getYears() {
            this.searchFormService.getYears(this.selectedModel).then((years) => {
                this.years = years;
                if (this.years.length == 1) {
                    this.selectedYear = this.years[0];
                    this.getTrims();
                }
            });
        }

        public getTrims() {
            this.searchFormService.getTrims(
                this.selectedMake,
                this.selectedModel,
                this.selectedYear)
                .then((result) => {
                    this.styles = result.styles;
                    if (this.styles.length == 1) 
                        this.selectedStyle = this.styles[0];
                });
        }

        public submit() {
            this.searchFormService.save(
                this.selectedStyle.id,
                this.budget,
                this.selectedMake + ' ' + this.selectedModel + ' ' + this.selectedStyle.name);
            this.$state.go('result'); // bumps them to resultpage
        }
    }
}