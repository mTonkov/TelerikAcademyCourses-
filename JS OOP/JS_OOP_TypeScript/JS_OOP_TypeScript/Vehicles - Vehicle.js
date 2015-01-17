var Vehicles;
(function (Vehicles) {
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
})(Vehicles || (Vehicles = {}));
//# sourceMappingURL=Vehicles - Vehicle.js.map
