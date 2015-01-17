var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Vehicles;
(function (Vehicles) {
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
    })(Vehicles.Vehicle);
    Vehicles.Car = Car;
})(Vehicles || (Vehicles = {}));
//# sourceMappingURL=Vehicles - Car.js.map
