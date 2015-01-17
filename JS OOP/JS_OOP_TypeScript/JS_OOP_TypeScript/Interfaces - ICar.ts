module Interfaces{

    export interface ICar extends IVehicle{
        numberOfDoors: number;
        hasSunroof: boolean;
        drivetrain: Vehicles.DrivetrainType
    }

} 