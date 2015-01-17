var DrawShape = function (canvasContainerSelector) {
    var canvas = document.getElementById(canvasContainerSelector);
    var ctx = canvas.getContext("2d");
    canvas.setAttribute("width", 600);
    canvas.setAttribute("height", 400);
    ctx.fillStyle = "#FFF";
    ctx.strokeStyle = "#000";
    
    function drawRect(x, y, width, height) {
        ctx.beginPath();
        ctx.rect(x, y, width, height);
        ctx.fill();
        ctx.stroke();
    }

    function drawCircle(x, y, r) {
        ctx.beginPath();
        ctx.arc(x, y, r, 0, 2 * Math.PI);
        ctx.fill();
        ctx.stroke();
    }

    function drawLine(fromX, fromY, toX, toY) {
        ctx.beginPath();
        ctx.moveTo(fromX, fromY);
        ctx.lineTo(toX, toY);
        ctx.stroke();
    }

    return {
        rect: drawRect,
        circle: drawCircle,
        line: drawLine
    }
};

var drawer = new DrawShape("container");
drawer.rect(50, 50, 50, 50);
drawer.circle(100, 150, 30);
drawer.circle(300, 100, 80);
drawer.line(100, 150, 300, 100);