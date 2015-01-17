define(["tech-store-models/item"], function (toCheckItemType) {
    var Store;
    Store = (function (ItemType) {
        function Store(name) {
            //During the morning exam, Ivaylo Kenov gave instructions that the max length should be 40, not 30.
            if (name.length < 6 || name.length > 40) {
                throw new RangeError("Length of the item's name should be in the range 6-30 symbols");
            } else {
                this.name = name;
            }
            this._items = [];
        }

        function sortAlphabetically(arr) {
            arr.sort(function (first, second) {
                var nameFirst = first.name.toLowerCase(),
                    nameSecond = second.name.toLowerCase();
                return (nameFirst < nameSecond) ? -1 : (nameFirst > nameSecond) ? 1 : 0;
            });
        }

        Store.prototype.addItem = function (item) {
            if (!(item instanceof ItemType)) {
                throw new TypeError("The passed element is NOT of type 'Item'!");
            } else {
                this._items.push(item);
            }

            return this;
        }

        Store.prototype.getAll = function () {
            var result = this._items.slice();
            sortAlphabetically(result);

            return result;
        }

        Store.prototype.getSmartPhones = function () {
            var result = this._items.filter(function (item) {
                return item.type == 'smart-phone';
            });
            sortAlphabetically(result);

            return result;
        }

        Store.prototype.getMobiles = function () {
            var result = this._items.filter(function (item) {
                return (item.type == 'smart-phone' || item.type == 'tablet');
            });
            sortAlphabetically(result);

            return result;
        }

        Store.prototype.getComputers = function () {
            var result = this._items.filter(function (item) {
                return (item.type == 'pc' || item.type == 'notebook');
            });
            sortAlphabetically(result);

            return result;
        }

        Store.prototype.filterItemsByType = function (filterType) {
            var result = this._items.filter(function (item) {
                return item.type === filterType;
            });
            sortAlphabetically(result);

            return result;
        }

        Store.prototype.filterItemsByPrice = function (options) {
            if (!options) {
                options = {
                    min: 0,
                    max: Number.MAX_VALUE
                }
            }

            var min = options.min || 0,
                max = options.max || Number.MAX_VALUE,
                result = this._items.filter(function (item) {
                    return (item.price >= min && item.price <= max);
                });
            
            result.sort(function (first, second) {                
                return first.price - second.price;
            });

            return result;
        }

        Store.prototype.countItemsByType = function () {
            var result = {},
                i,
                len,
                currentType;

            for (i = 0, len = this._items.length; i < len; i++) {
                currentType = this._items[i].type;
                if (result.hasOwnProperty(currentType)) {
                    result[currentType]++;
                } else {
                    result[currentType] = 1;
                }
            }

            return result;
        }

        Store.prototype.filterItemsByName = function (partOfName) {
            var itemName,
                part = partOfName.toLowerCase(),
                result;

            result = this._items.filter(function (item) {
                itemName = item.name.toLowerCase();
                return itemName.indexOf(part) >= 0;
            });
            sortAlphabetically(result);

            return result;
        }

        return Store;
    })(toCheckItemType);

    return Store;
})