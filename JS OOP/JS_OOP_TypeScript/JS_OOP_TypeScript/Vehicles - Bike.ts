module Vehicles {
    export class Bike extends Vehicle implements Interfaces.IBike {
        static numberOfTires = 4;
        typeOfBike: Vehicles.BikeType;
        type: BikeType;

        constructor(make: string, type: BikeType,engine: Interfaces.IEngine, doorsCount: number, hasSunroof: boolean) {
            super(make, engine);
            this.type = type;
        }

        driveOnBackTyre(): void {
            console.log("Ensure the engine is at least in the middle range RPM's, move your wheight backwards and squeeze the throttle");
        }
    }

} 