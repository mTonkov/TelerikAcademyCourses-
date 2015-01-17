var Game = (function () {

        var canvas = document.getElementById('snake-renderer'),
            renderer = Renderer.getCanvas(canvas),
            SIZE = 10,
            SNAKE_START_X = 30,
            SNAKE_START_Y = canvas.height / 2,
            SNAKE_SPEED = 10,
            snake = new GameObjects.Snake(SNAKE_START_X, SNAKE_START_Y, SIZE, SNAKE_SPEED),
            foodMaxX = canvas.width,
            foodMaxY = canvas.height,
            food = new GameObjects.Food(foodMaxX - SIZE, foodMaxY - SIZE, SIZE), // the size is subtracted from the dimensions, in order to keep the food full-size visible when its coordinates happen to be on the borders
            LEFT_ARROW = 37,
            UP_ARROW = 38,
            DOWN_ARROW = 40,
            RIGHT_ARROW = 39,
            GAME_SPEED = 80,
            runGame;

        document.addEventListener("keydown", function (ev) {
            if (ev.keyCode === LEFT_ARROW) {
                if (snake.direction === 'right') {
                    snake.isAlive = false; // the snake eats itself
                }
                snake.direction = 'left';
            }
            else if (ev.keyCode === UP_ARROW) {
                if (snake.direction === 'down') {
                    snake.isAlive = false;
                }
                snake.direction = 'up';
            }
            else if (ev.keyCode === RIGHT_ARROW) {
                if (snake.direction === 'left') {
                    snake.isAlive = false;
                }
                snake.direction = 'right';
            }
            else if (ev.keyCode === DOWN_ARROW) {
                if (snake.direction === 'up') {
                    snake.isAlive = false;
                }
                snake.direction = 'down';
            }
        });

        function detectCollisions() {
            var headX = snake.tail[0].x;
            var headY = snake.tail[0].y;

            if (headX < 0 || headX >= canvas.width) {
                snake.isAlive = false;
            } else if (headY < 0 || headY >= canvas.height) {
                snake.isAlive = false;
            }

            for (var i = 1; i < snake.tail.length; i++) {
                var currentPartOfSnake = snake.tail[i];

                if (headX === currentPartOfSnake.x &&
                    headY === currentPartOfSnake.y) {
                    snake.isAlive = false;
                }
            }

            if (snake.tail[0].x < food.x + food.size &&
                snake.tail[0].x + snake.size > food.x &&
                snake.tail[0].y < food.y + food.size &&
                snake.tail[0].y + snake.size > food.y) {
                food.updatePosition();
                snake.grow();
            }
        }
        function stopGame() {
            clearInterval(runGame);
            renderer.drawGameOver(canvas);
        }

        function Engine() {
            if (snake.isAlive) {
                renderer.clear();
                renderer.draw(snake);
                snake.move();
                renderer.draw(food);
                detectCollisions();
            }
            else {
                stopGame();
            }
        }

        function StartGame() {
            runGame = setInterval(Engine, GAME_SPEED);
        }

    return {
        start: StartGame
        }
}());

Game.start();