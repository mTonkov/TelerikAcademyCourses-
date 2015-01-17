/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_KIneticJS_HW\JS_UI_KIneticJS_HW\kinetic-v5.1.0.min.js" />
var familyMembers = [
    {
        mother: 'Maria Petrova',
        father: 'Georgi Petrov',
        children: ['Teodora Petrova', 'Peter Petrov']
    }, {
        mother: 'Petra Stamatova',
        father: 'Todor Stamatov',
        children: ['Maria Petrova']
    }
];

var stage = new Kinetic.Stage({
    container: 'kinetic-container',
    width: 1500,
    height: 1000
});
var layer = new Kinetic.Layer();

createText(familyMembers[1].father, stage.width() / 2 - 150, 100);
createRect(familyMembers[1].father, stage.width() / 2 - 150, 100);

var line = new Kinetic.Line({
    points: [stage.width() / 2 - 50, 140, stage.width() / 2 - 25, 170, stage.width() / 2+80, 180, stage.width() / 2 + 100, 200],
    stroke: 'yellowgreen',
    strokeWidth: 3,
    lineCap: 'round',
    tension: 0.6
});
layer.add(line);

createText(familyMembers[1].mother, stage.width() / 2 + 150, 100);
createRect(familyMembers[1].mother, stage.width() / 2 + 150, 100);
var line = new Kinetic.Line({
    points: [stage.width() / 2 + 250, 140, stage.width() / 2 + 225, 170, stage.width() / 2 + 120, 180, stage.width() / 2 + 100, 200],
    stroke: 'yellowgreen',
    strokeWidth: 3,
    lineCap: 'round',
    tension: 0.6
});
layer.add(line);

createText(familyMembers[0].mother, stage.width() / 2, 200);
createRect(familyMembers[0].mother, stage.width() / 2, 200);

var line = new Kinetic.Line({
    points: [stage.width() / 2 + 100, 240, stage.width() / 2 + 80, 270, stage.width() / 2 - 25, 280, stage.width() / 2 - 50, 300],
    stroke: 'yellowgreen',
    strokeWidth: 3,
    lineCap: 'round',
    tension: 0.6
});
layer.add(line);

createText(familyMembers[0].father, stage.width() / 2 - 300, 200);
createRect(familyMembers[0].father, stage.width() / 2 - 300, 200);
var line = new Kinetic.Line({
    points: [stage.width() / 2 + 100, 240, stage.width() / 2 + 120, 270, stage.width() / 2 + 225, 280, stage.width() / 2 + 250, 300],
    stroke: 'yellowgreen',
    strokeWidth: 3,
    lineCap: 'round',
    tension: 0.6
});
layer.add(line);
createText(familyMembers[0].children[1], stage.width() / 2 - 150, 300);
createRect(familyMembers[0].children[1], stage.width() / 2 - 150, 300);

var line = new Kinetic.Line({
    points: [stage.width() / 2 - 200, 240, stage.width() / 2 - 170, 270, stage.width() / 2 -70, 280, stage.width() / 2 - 50, 300],
    stroke: 'yellowgreen',
    strokeWidth: 3,
    lineCap: 'arrow',
    tension: 0.6
});
layer.add(line);

createText(familyMembers[0].children[0], stage.width() / 2 + 150, 300);
createRect(familyMembers[0].children[0], stage.width() / 2 + 150, 300);

stage.add(layer);




function isWoman(name) {
    if (name[name.length - 1] == 'a') {
        return 2;
    }
    return 1;
}

function createText(name, locationX, locationY) {
    var text = new Kinetic.Text({
        text: name,
        fontSize: 20,
        x: locationX,
        y: locationY,
        width: 200,
        fill: 'black',
        align: "center",
        padding: 10
    });
    layer.add(text);
}

function createRect(name, locationX, locationY) {
    var rect = new Kinetic.Rect({
        x: locationX,
        y: locationY,
        stroke: 'yellowgreen',
        width: 200,
        height: 40,
        strokeWidth: 3,
        cornerRadius: 10 * isWoman(name)
    });
    layer.add(rect);
}

