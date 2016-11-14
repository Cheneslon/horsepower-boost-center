namespace HorsePowerStore.Controllers {
    export class CarInstanceController {
        public carInstances;

        constructor(private carInstanceService: HorsePowerStore.Services.CarInstanceService) {
            carInstanceService.listCarInstances().$promise.then((carInstances) => {
                this.carInstances = carInstances;
            })
        }
    }
}