define(function () {
    var Animal = (function () {

        function Animal(kind, species, legsCount) {
            this.kind = kind;
            this.species = species;
            this.legsCount = legsCount;
        }

        Animal.prototype.toString = function () {
            return this.kind + " " + this.species + " " + this.legsCount;
        }

        return Animal;
    }());

    var species = {
        mammal: "mammal",
        reptile: "reptile",
        bird: "bird",
        insect: "insect",
        arthropods: "arthropods"
    }

    var animals = [
        new Animal("cow", species.mammal, 4),
        new Animal("human", species.mammal, 2),
        new Animal("snake", species.reptile, 0),
        new Animal("eagle", species.bird, 2),
        new Animal("fly", species.insect, 6),
        new Animal("caterpillar", species.arthropods, 100),
        new Animal("spider", species.arthropods, 8),
        new Animal("kangaroo", species.mammal, 2),
        new Animal("horse", species.mammal, 4)
    ];

    return animals;
})