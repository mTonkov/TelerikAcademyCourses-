var Vehicles;
(function (Vehicles) {
    var Garage = (function () {
        function Garage() {
            this.vehiclesInGarage = [];
        }
        Garage.prototype.addVehicle = function (newVehicle) {
            this.vehiclesInGarage.push(newVehicle);
        };

        Garage.prototype.removeVehicle = function (vehicle) {
            var vehicleIndex;

            vehicleIndex = this.vehiclesInGarage.indexOf(vehicle);

            this.vehiclesInGarage.splice(vehicleIndex, 1);
        };

        Garage.prototype.changeTyres = function (vehicle) {
            var numberOfTyres;
            if (vehicle instanceof Vehicles.Car) {
                numberOfTyres = Vehicles.Car.numberOfTires;
            } else {
                numberOfTyres = Vehicles.Bike.numberOfTires;
            }

            for (var i = 0; i < numberOfTyres; i++) {
                console.log("Tyre " + (i + 1) + " changed!");
            }
        };
        return Garage;
    })();
    Vehicles.Garage = Garage;
})(Vehicles || (Vehicles = {}));
//# sourceMappingURL=Vehicles-Garage.js.map
