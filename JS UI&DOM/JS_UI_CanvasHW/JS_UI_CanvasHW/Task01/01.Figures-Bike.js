var canvas = document.getElementById("canvas"),
    context = canvas.getContext('2d');
canvas.style.backgroundColor = "#444";

context.strokeStyle = "#006060";
context.lineWidth = 2;
context.fillStyle = "#87CEEB";
context.save();


context.beginPath();//rear wheel
context.arc(110, 400, 50, 0, 2 * Math.PI);
context.stroke();
context.fill();
    
context.beginPath();//front wheel
context.arc(300, 400, 50, 0, 2 * Math.PI);
context.stroke();
context.fill();

context.beginPath();//frame
context.moveTo(200, 400);
context.lineTo(170, 330);//seat tube
context.lineTo(110, 400);
context.lineTo(200, 400);
context.lineTo(280, 330);
context.lineTo(170, 330);
context.lineTo(157, 300);//seat
context.lineTo(140, 300);
context.lineTo(190, 300);
context.moveTo(275, 300);//steering
context.lineTo(300, 400);
context.moveTo(260, 310);
context.lineTo(290, 290);
context.moveTo(260, 310);
context.bezierCurveTo(280, 310, 280, 330, 250, 325);
context.moveTo(290, 290);
context.bezierCurveTo(310, 290, 310, 310, 280, 305);
context.stroke();

context.beginPath();//chainwheel
context.arc(200, 400, 20, 0, 2 * Math.PI);
context.moveTo(230, 430);
context.lineTo(170, 370);
context.stroke();

