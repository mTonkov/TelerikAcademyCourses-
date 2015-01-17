/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_Animations_HW\JS_UI_Animations_HW\external-libraries/kinetic-v5.1.0.min.js" />

var stage = new Kinetic.Stage({
    container: 'container',
    width: 1440,
    height: 960
});

var layer = new Kinetic.Layer();

var imageObj = new Image();

imageObj.onload = function () {
    var mario = new Kinetic.Sprite({
        x: 350,
        y: 285,
        image: imageObj,
        animation: 'stand',
        animations: {
            stand: [
              // x, y, width, height 
              300, 975, 200, 260,
            ],
            move: [
              // x, y, width, height (2 frames)
              20, 975, 230, 260,
              600, 660, 170, 250,
            ]
        },
        frameRate: 4,
        frameIndex: 0
    });

    // add the shape to the layer
    layer.add(mario);

    // add the layer to the stage
    stage.add(layer);

    // start sprite animation
    mario.start();

    var frameCount = 0;

    mario.on('frameIndexChange', function (evt) {
        if (mario.animation() === 'move' && ++frameCount > 2) {
            mario.animation('stand'); // restore original animation
            frameCount = 0;
        }
    });

    function onKeyDown(evt) {
        switch (evt.keyCode) {
            case 37:  // left arrow
                mario.setX(mario.attrs.x -= 10);
                mario.attrs.animations.move = [
                    20, 975, 230, 260,
                    600, 660, 170, 250,
                    20, 975, 230, 260,
                    600, 660, 170, 250,
                ];
                mario.attrs.animation = "move";
                break;
            case 39:  // right arrow
                mario.setX(mario.attrs.x += 10);
                mario.attrs.animations.move = [
                                  800, 350, 230, 260,
                                  1120, 370, 170, 250,
                                  800, 350, 230, 260,
                                  1120, 370, 170, 250,
                ];
                mario.attrs.animation = "move";
                break;
        }
    }

    window.addEventListener('keydown', onKeyDown);
};

imageObj.src = '../imgs/Mario Hi-Res.png';
