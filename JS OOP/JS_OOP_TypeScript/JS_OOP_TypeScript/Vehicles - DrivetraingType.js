var Vehicles;
(function (Vehicles) {
    (function (DrivetrainType) {
        DrivetrainType[DrivetrainType["FrontWheelDrive"] = 0] = "FrontWheelDrive";
        DrivetrainType[DrivetrainType["RearWheelDrive"] = 1] = "RearWheelDrive";
    })(Vehicles.DrivetrainType || (Vehicles.DrivetrainType = {}));
    var DrivetrainType = Vehicles.DrivetrainType;
})(Vehicles || (Vehicles = {}));
//# sourceMappingURL=Vehicles - DrivetraingType.js.map
