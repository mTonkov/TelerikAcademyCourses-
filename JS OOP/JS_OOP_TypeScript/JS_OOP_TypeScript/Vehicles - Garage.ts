module Vehicles {
    export class Garage implements Interfaces.IGarage {
        vehiclesInGarage: Interfaces.IVehicle[];

        constructor(){
            this.vehiclesInGarage = [];
        }

        addVehicle(newVehicle: Interfaces.IVehicle): void {
            this.vehiclesInGarage.push(newVehicle);
        }

        removeVehicle(vehicle: Interfaces.IVehicle): void {
            var vehicleIndex: number;

            vehicleIndex = this.vehiclesInGarage.indexOf(vehicle);

            this.vehiclesInGarage.splice(vehicleIndex, 1);
        }

        changeTyres(vehicle: Interfaces.IVehicle): void {
            var numberOfTyres;
            if (vehicle instanceof Car) {
                numberOfTyres = Car.numberOfTires;
            }
            else {
                numberOfTyres = Bike.numberOfTires;
            }

            for (var i = 0; i < numberOfTyres; i++) {
                console.log("Tyre " + (i + 1) + " changed!");
            }
        }
    }

} 