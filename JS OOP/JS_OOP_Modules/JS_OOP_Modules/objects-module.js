var GameObjects = (function () {

    function randomNumber(min, max) {
        return 0 | (Math.random() * (max - min) + min);
    }

    var GameObjs = function (x, y, size) {
        this.x = x;
        this.y = y;
        this.size = size;
    }

    var Snake = (function () {

        function Snake(x, y, size, speed) {
            GameObjs.call(this, x, y, size);
            this.direction = 'right';
            this.isAlive = true;
            this.speed = speed;
            this.tail = [new GameObjs(this.x - 1 * this.size, this.y, this.size),
                         new GameObjs(this.x - 2 * this.size, this.y, this.size),
                         new GameObjs(this.x - 3 * this.size, this.y, this.size)];
        }

        Snake.prototype = {
            move: function () {
                for (var i = this.tail.length - 1; i >= 1; i--) {
                    this.tail[i].x = this.tail[i - 1].x;
                    this.tail[i].y = this.tail[i - 1].y;                    
                }

                if (this.direction === 'right') {
                           this.tail[0].x += this.speed;
                }
                else if (this.direction === 'left') {
                           this.tail[0].x -= this.speed;
                }
                else if (this.direction === 'up') {
                           this.tail[0].y -= this.speed;
                }
                else if (this.direction === 'down') {
                           this.tail[0].y += this.speed;
                }
            },
            grow: function () {
                var lastIndex = this.tail.length - 1;
                var addToTail = new GameObjs(this.tail[lastIndex].x, this.tail[lastIndex].y, this.size);
                this.tail.push(addToTail);
            }
        }

        return Snake;
    }());

    var Food = (function () {

        function Food(maxX, maxY, size) {
            this._maxX = maxX;
            this._maxY = maxY;

            this.x = randomNumber(0, this._maxX);
            this.y = randomNumber(0, this._maxY);

            GameObjs.call(this, this.x, this.y, size);
        }

        Food.prototype = {
            updatePosition: function () {
                this.x = randomNumber(0, this._maxX);
                this.y = randomNumber(0, this._maxY);
            }
        }

        return Food;
    }());

    return {
        Snake: Snake,
        Food: Food
    }
}());