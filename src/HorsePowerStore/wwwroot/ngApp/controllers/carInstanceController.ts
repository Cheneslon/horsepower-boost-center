namespace HorsePowerStore.Controllers {
    export class CarInstanceController {
        public carInstances;

        constructor(private carInstanceService: HorsePowerStore.Services.CarInstanceService) {
            this.refresh();
        }

        private refresh() {
            this.carInstanceService.listCarInstances().$promise.then((carInstances) => {
                this.carInstances = carInstances;
            })
        }

        public delete(id: number) {
            this.carInstanceService.delete(id).then(() => {
                this.refresh();
            });
        }
    }
}