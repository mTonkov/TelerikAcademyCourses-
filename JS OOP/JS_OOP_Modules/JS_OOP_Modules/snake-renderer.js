var Renderer = (function () {
    
    function CanvasRenderer(canvas) {
        this._canvas = canvas;
        this._ctx = this._canvas.getContext('2d');
}
        function drawObj(obj, color, context) {
            context.fillStyle = color;
            context.fillRect(obj.x, obj.y, obj.size, obj.size);
        }

        function drawSnake(snake, context) {
            var i,
                currentPart;

            for (i = 0; i < snake.tail.length; i++) {
                currentPart = snake.tail[i];
                drawObj(currentPart, 'green', context);
            }
        }

        function drawFood(food, context) {
            drawObj(food, 'red', context);
        }
    
    CanvasRenderer.prototype = {
        draw: function (obj) {
            if (obj instanceof GameObjects.Snake) {
                drawSnake(obj, this._ctx);
            }
            else if (obj instanceof GameObjects.Food) {
                drawFood(obj, this._ctx);
            }
        },
        drawGameOver: function () {
            this._ctx.strokeStyle = 'red'
            this._ctx.font = "40px Calibri, Times New Roman";
            this._ctx.fillText("Game over!", this._canvas.width / 2 , this._canvas.height / 2);
        },
        clear: function () {
            var width,
                height;
            width = this._canvas.width;
            height = this._canvas.height;
            this._ctx.clearRect(0, 0, width, height);
        }
    }

    return {
        getCanvas: function (canvas) {
            return new CanvasRenderer(canvas);
        }
    }
}());