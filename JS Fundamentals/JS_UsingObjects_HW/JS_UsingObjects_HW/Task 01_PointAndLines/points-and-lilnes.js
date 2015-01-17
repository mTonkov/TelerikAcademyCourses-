/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_UsingObjects_HW\JS_UsingObjects_HW\js-console.js" />
// previous row enables the use of 'jsConsole'

function pointBuilder(name, x, y) {
    return {
        name: name,
        xAxis: x,
        yAxis: y,
        toString: function () {
            return name + "(" + this.xAxis + ", " + this.yAxis + ")";
        }
    }
}

function lineBuilder(p, q) {
    return {
        pointP: p,
        pointQ: q,
        toString: function () {
            return "" + p.name + q.name;
        },
        length: function () {
            var a = Math.abs(p.xAxis - q.xAxis),
                b = Math.abs(p.yAxis - q.yAxis);

            return Math.round(Math.sqrt((a * a) + (b * b)));
        }
    }
}

function isTrianglePossible(AB, BC, CA) {
    if (AB.length + BC.length > CA.length ||
        BC.length + CA.length > AB.length ||
        AB.length + CA.length > BC.length) {
        return true;
    } else {
        return false;
    }
}

function makeCalculations() {
    var Ax = document.getElementById("input-a-x").value,
        Ay = document.getElementById("input-a-y").value,
        Bx = document.getElementById("input-b-x").value,
        By = document.getElementById("input-b-y").value,
        Cx = document.getElementById("input-c-x").value,
        Cy = document.getElementById("input-c-y").value,
        points = [
                pointBuilder("A", Ax, Ay),
                pointBuilder("B", Bx, By),
                pointBuilder("C", Cx, Cy)],
        lines = [
                lineBuilder(points[0], points[1]),
                lineBuilder(points[1], points[2]),
                lineBuilder(points[2], points[0])];

    for (var i = 0, leng = lines.length; i < leng; i++) {
        jsConsole.writeLine("The length between " + lines[i].pointP.toString() + " and " + lines[i].pointQ.toString() +
                            " is " + lines[i].length());
    }

    jsConsole.writeLine();
    if (isTrianglePossible(lines[0], lines[1], lines[2])) {
        jsConsole.writeLine("A triangle CAN be formed");
    } else {
        jsConsole.writeLine("A triangle can NOT be formed");
    }
}
