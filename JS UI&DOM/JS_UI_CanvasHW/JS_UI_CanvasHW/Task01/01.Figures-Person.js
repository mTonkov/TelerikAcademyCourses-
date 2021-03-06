﻿var canvas = document.getElementById("canvas"),
    context = canvas.getContext('2d');
canvas.style.backgroundColor = "#444";

context.strokeStyle = "#006060";
context.lineWidth = 2;
context.fillStyle = "#87CEEB";
context.save();

drawElipse(100, 150, 50, 1, 1); // head

drawElipse(70, 130, 10, 1, 0.5);//left eye as we see it on the display
context.fillStyle = context.strokeStyle;
drawElipse(65, 130, 4, 0.5, 1);

drawElipse(110, 130, 10, 1, 0.5);//right eye 
context.fillStyle = context.strokeStyle;
drawElipse(105, 130, 4, 0.5, 1);

context.beginPath();//mouth
context.translate(80, 170);
context.rotate(15 * Math.PI / 180);
context.scale(1, 0.3);
context.arc(0, 0, 20, 0, 2 * Math.PI);
context.fill();
context.stroke();
context.restore();
context.save();

context.moveTo(90, 130);//nose
context.lineTo(75, 155);
context.lineTo(90, 155);
context.stroke();

context.strokeStyle = "#000";
context.lineWidth = 1;
context.fillStyle = "#048";
context.save();

drawElipse(100, 100, 50, 1, 0.3);// hat base
context.strokeRect(75, 30, 50, 70);
context.fillRect(75, 30, 50, 70);

context.beginPath();// hat cylinder base
context.lineWidth = 1;
context.scale(1, 0.3);
context.arc(100, 100/0.3, 25, 0, Math.PI);
context.fill();
context.stroke();
context.restore();

context.beginPath();//hat cylinder top
context.lineWidth = 1;
context.save();
drawElipse(100, 30, 25, 1, 0.3);
context.fill();
context.stroke();

function drawElipse(x, y, radius, scaleX, scaleY) {
    context.beginPath();
    context.scale(scaleX, scaleY);
    //context.beginPath();
    context.arc(x / scaleX, y / scaleY, radius, 0, 2 * Math.PI);
    context.fill();
    context.stroke();
    context.restore();
    context.save();
}

    
