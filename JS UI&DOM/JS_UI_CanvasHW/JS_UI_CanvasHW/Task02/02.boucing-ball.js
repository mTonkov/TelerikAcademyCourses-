var canvas = document.getElementById("current-canvas"),
    field = canvas.getContext("2d");

canvas.style.border = "2px solid black";

var random = Math.random(),
    startX = parseInt(random * canvas.width),
    startY = parseInt(random * canvas.height),
    r = 5,
    speed = 2,
    directionX = speed,
    directionY = speed;

if (random > 0.5) {
    directionX = -speed;
}

function movingCircle() {
    field.clearRect(startX - 2*speed * r, startY - 2*speed * r, startX + 2*speed * r, startY + 2*speed * r);
    field.beginPath();
    field.arc(startX, startY, r, 0, 2 * Math.PI);

    if (startX - r <= 0) {
        directionX = speed;
    } else if (startX + r >= canvas.width - 1) {
        directionX = -speed;
    }
    if (startY - r <= 0) {
        directionY = speed;
    } else if (startY + r >= canvas.height - 1) {
        directionY = -speed;
    }

    startX += directionX;
    startY += directionY;

    field.stroke();
    requestAnimationFrame(movingCircle);
};

movingCircle();
