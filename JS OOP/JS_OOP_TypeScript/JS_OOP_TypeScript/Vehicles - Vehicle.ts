module Vehicles {

    export class Vehicle implements Interfaces.IVehicle {
        make: string;
        engine: Interfaces.IEngine;

        constructor(manufacturer: string, engine: Interfaces.IEngine) {
            this.make = manufacturer;
            this.engine = engine;
        }

        move():void {
            console.log("Start moving...");
        }

        stop(): void {
            console.log("Stop moving...");
        }

        turnLeft(): void {
            console.log("Turning left...");
        }

        turnRight(): void {
            console.log("Turning right...");
        }
    }
} 