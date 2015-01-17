var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Vehicles;
(function (Vehicles) {
    var Bike = (function (_super) {
        __extends(Bike, _super);
        function Bike(make, type, engine, doorsCount, hasSunroof) {
            _super.call(this, make, engine);
            this.type = type;
        }
        Bike.prototype.driveOnBackTyre = function () {
            console.log("Ensure the engine is at least in the middle range RPM's, move your wheight backwards and squeeze the throttle");
        };
        Bike.numberOfTires = 4;
        return Bike;
    })(Vehicles.Vehicle);
    Vehicles.Bike = Bike;
})(Vehicles || (Vehicles = {}));
//# sourceMappingURL=Vehicles - Bike.js.map
