define(function () {
    var Item;
    Item = (function () {
        function Item(type, name, price) {
            if (type == 'accessory' || type == 'smart-phone' ||
                type == 'notebook' || type == 'pc' ||
                type == 'tablet') {
                this.type = type;
            } else {
                throw new TypeError("The item is not of an allowed type");
            }

            if (name.length < 6 || name.length > 40) {//During the morning exam, Ivaylo Kenov gave instructions that the max length should be 40, not 30.
                throw new RangeError("Length of the item's name should be in the range 6-30 symbols");
            } else {
                this.name = name;
            }

            if (typeof price == 'number') {
                this.price = price;
            } else {
                throw new TypeError("The price should be a number");
            }
        }

        return Item;
    })();

    return Item;
})