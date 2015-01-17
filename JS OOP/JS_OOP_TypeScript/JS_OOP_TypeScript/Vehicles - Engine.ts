module Vehicles {
    export class Engine implements Interfaces.IEngine {
        cubicCapacity: number;
        cylindersCount: number;

        constructor(volume: number, cylinders: number) {
            this.cubicCapacity = volume;
            this.cylindersCount = cylinders;
        }
    }
} 