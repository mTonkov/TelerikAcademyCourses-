var Vehicles;
(function (Vehicles) {
    (function (BikeType) {
        BikeType[BikeType["Sport"] = 0] = "Sport";
        BikeType[BikeType["Tourer"] = 1] = "Tourer";
        BikeType[BikeType["Enduro"] = 2] = "Enduro";
    })(Vehicles.BikeType || (Vehicles.BikeType = {}));
    var BikeType = Vehicles.BikeType;
})(Vehicles || (Vehicles = {}));
//# sourceMappingURL=Vehicles - BikeType.js.map
