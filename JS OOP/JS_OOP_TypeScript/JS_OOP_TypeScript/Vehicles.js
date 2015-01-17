var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
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
            if (vehicle instanceof Car) {
                numberOfTyres = Car.numberOfTires;
            } else {
                numberOfTyres = Bike.numberOfTires;
            }

            for (var i = 0; i < numberOfTyres; i++) {
                console.log("Tyre " + (i + 1) + " changed!");
            }
        };
        return Garage;
    })();
    Vehicles.Garage = Garage;

    var Vehicle = (function () {
        function Vehicle(manufacturer, engine) {
            this.make = manufacturer;
            this.engine = engine;
        }
        Vehicle.prototype.move = function () {
            console.log("Start moving...");
        };

        Vehicle.prototype.stop = function () {
            console.log("Stop moving...");
        };

        Vehicle.prototype.turnLeft = function () {
            console.log("Turning left...");
        };

        Vehicle.prototype.turnRight = function () {
            console.log("Turning right...");
        };
        return Vehicle;
    })();
    Vehicles.Vehicle = Vehicle;

    var Car = (function (_super) {
        __extends(Car, _super);
        function Car(make, engine, doorsCount, hasSunroof, drivetrain) {
            _super.call(this, make, engine);
            this.numberOfDoors = doorsCount;
            this.hasSunroof = hasSunroof;
        }
        Car.prototype.drift = function () {
            if (this.drivetrain == 0 /* FrontWheelDrive */) {
                console.log("Perform a slide turning and pull the handbrake for a moment");
            }
            if (this.drivetrain == 1 /* RearWheelDrive */) {
                console.log("Perform a slide turning, switch one gear down and push the throttle");
            }
        };
        Car.numberOfTires = 4;
        return Car;
    })(Vehicle);
    Vehicles.Car = Car;

    var Bike = (function (_super) {
        __extends(Bike, _super);
        function Bike(make, engine, doorsCount, hasSunroof) {
            _super.call(this, make, engine);
        }
        Bike.prototype.driveOnBackTyre = function () {
            console.log("Ensure the engine is at least in the middle range RPM's, move your wheight backwards and squeeze the throttle");
        };
        Bike.numberOfTires = 4;
        return Bike;
    })(Vehicle);
    Vehicles.Bike = Bike;

    var Engine = (function () {
        function Engine(volume, cylinders) {
            this.cubicCapacity = volume;
            this.cylindersCount = cylinders;
        }
        return Engine;
    })();
    Vehicles.Engine = Engine;

    (function (BikeType) {
        BikeType[BikeType["Sport"] = 0] = "Sport";
        BikeType[BikeType["Tourer"] = 1] = "Tourer";
        BikeType[BikeType["Enduro"] = 2] = "Enduro";
    })(Vehicles.BikeType || (Vehicles.BikeType = {}));
    var BikeType = Vehicles.BikeType;

    (function (DrivetrainType) {
        DrivetrainType[DrivetrainType["FrontWheelDrive"] = 0] = "FrontWheelDrive";
        DrivetrainType[DrivetrainType["RearWheelDrive"] = 1] = "RearWheelDrive";
    })(Vehicles.DrivetrainType || (Vehicles.DrivetrainType = {}));
    var DrivetrainType = Vehicles.DrivetrainType;
})(Vehicles || (Vehicles = {}));
//# sourceMappingURL=Vehicles.js.map
