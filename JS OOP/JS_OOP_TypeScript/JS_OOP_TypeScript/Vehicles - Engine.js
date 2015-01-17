var Vehicles;
(function (Vehicles) {
    var Engine = (function () {
        function Engine(volume, cylinders) {
            this.cubicCapacity = volume;
            this.cylindersCount = cylinders;
        }
        return Engine;
    })();
    Vehicles.Engine = Engine;
})(Vehicles || (Vehicles = {}));
//# sourceMappingURL=Vehicles - Engine.js.map
