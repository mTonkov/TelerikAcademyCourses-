var canvas = document.getElementById("canvas"),
    context = canvas.getContext('2d');
canvas.style.backgroundColor = "#444";

context.strokeStyle = "black";
context.lineWidth = 2;
context.fillStyle = "indianred";
context.save();

context.fillRect(400, 200, 350, 250);
context.strokeRect(400, 200, 350, 250);

context.beginPath();
buildWindow(440, 220);
buildWindow(600, 220);
buildWindow(600, 330);
context.scale(1, 0.5);//door
context.arc(490, 700, 50, 0, Math.PI, true);
context.restore();
context.save();
context.moveTo(440, 348);
context.lineTo(440, 450);
context.moveTo(540, 348);
context.lineTo(540, 450);
context.moveTo(490, 325);
context.lineTo(490, 450);
context.stroke();

context.beginPath();
context.arc(480, 400, 5, 0, 2 * Math.PI);//door locks
context.stroke();
context.beginPath();
context.arc(500, 400, 5, 0, 2 * Math.PI);//door locks
context.stroke();

context.beginPath();//roof
context.moveTo(400, 200);
context.lineTo(575, 50);
context.lineTo(750, 200);
context.fill();
context.stroke();

context.beginPath();//chimney
context.moveTo(630, 150);
context.lineTo(630, 90);
context.lineTo(670, 90);
context.lineTo(670, 150);
context.fill();
context.stroke();

context.beginPath();//chimney top
context.scale(1, 0.3);
context.arc(650, 90/0.3, 20, 0, 2*Math.PI);
context.restore();
context.fill();
context.stroke();

context.beginPath();//smoke
context.moveTo(640, 90);
context.bezierCurveTo(660, 70, 620, 50, 640, 50)
context.moveTo(660, 90);
context.bezierCurveTo(640, 80, 680, 75, 660, 50)
context.stroke();

function buildWindow(x, y) {
    var width = 50,
        height = 30,
        offset = 5;

    context.fillStyle = "black";

    context.fillRect(x, y, width, height);
    context.fillRect(x + width + offset, y, width, height);
    context.fillRect(x, y + height + offset, width, height);
    context.fillRect(x + width + offset, y + height + offset, width, height);
    context.restore();
    context.save();
}