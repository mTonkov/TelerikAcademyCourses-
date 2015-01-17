module Vehicles {
    
    export class Car extends Vehicle implements Interfaces.ICar {
        static numberOfTires = 4;
        numberOfDoors: number;
        hasSunroof: boolean;
        drivetrain: Vehicles.DrivetrainType

        constructor(make: string, engine: Interfaces.IEngine, doorsCount: number, hasSunroof: boolean, drivetrain: DrivetrainType) {
            super(make, engine);
            this.numberOfDoors = doorsCount;
            this.hasSunroof = hasSunroof;
        }

        drift(): void {
            if (this.drivetrain == DrivetrainType.FrontWheelDrive)
            {
                console.log("Perform a slide turning and pull the handbrake for a moment");
            }
            if (this.drivetrain == DrivetrainType.RearWheelDrive) {
                console.log("Perform a slide turning, switch one gear down and push the throttle");
            }
        }
    }
} 