(function () {
    'use strict';
    /*jslint browser:true */

    var b = navigator.appName,
        addScroll = false,
        theLayer,
        positionX = 0,
        positionY = 0;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6') > 0)) {
        addScroll = true;
    }

    //var off = 0,    //the code is commented because it is not used
    //    txt = "",

    function popTip() {

        if (b === "Netscape") {
            theLayer = 'document.layers[\'ToolTip\']';

            if ((positionX + 120) > window.innerWidth) {
                positionX = window.innerWidth - 150;
            }

            theLayer.left = positionX + 10;
            theLayer.top = positionY + 15;
            theLayer.visibility = 'show';
        } else {
            theLayer = 'document.all[\'ToolTip\']';

            if (theLayer) {
                positionX = event.x - 5;
                positionY = event.y;

                if (addScroll) {
                    positionX = positionX + document.body.scrollLeft;
                    positionY = positionY + document.body.scrollTop;
                }

                if ((positionX + 120) > document.body.clientWidth) {
                    positionX = positionX - 150;
                }

                theLayer.style.pixelLeft = positionX + 10;
                theLayer.style.pixelTop = positionY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function mouseMove(evn) {

        if (b === "Netscape") {
            positionX = evn.pageX - 5;
            positionY = evn.pageY;
        } else {
            positionX = event.x - 5;
            positionY = event.y;
        }

        if (b === "Netscape") {
            if (document.layers.ToolTip.visibility === 'show') {
                popTip();
            }
        } else {
            if (document.all.ToolTip.style.visibility === 'visible') {
                popTip();
            }
        }
    }

    document.onmousemove = mouseMove();

    if (b === "Netscape") {
        document.captureEvents(Event.MOUSEMOVE);
    }

    //The following code is commented because it is not used in the file

    //function hideTip() {
    //    var args = HideTip.arguments;

    //    if (b === "Netscape") {
    //        document.layers['ToolTip'].visibility = 'hide';
    //    } else {
    //        document.all['ToolTip'].style.visibility = 'hidden';
    //    }
    //}

    //function hideMenu1() {
    //    if (b === "Netscape") {
    //        document.layers['menu1'].visibility = 'hide';
    //    } else {
    //        document.all['menu1'].style.visibility = 'hidden';
    //    }
    //}

    //function showMenu1() {
    //    if (b === "Netscape") {
    //        theLayer = eval('document.layers[\'menu1\']');
    //        theLayer.visibility = 'show';
    //    } else {
    //        theLayer = eval('document.all[\'menu1\']');
    //        theLayer.style.visibility = 'visible';
    //    }
    //}//

    //function hideMenu2() {
    //    if (b === "Netscape") {
    //        document.layers['menu2'].visibility = 'hide';
    //    } else {
    //        document.all['menu2'].style.visibility = 'hidden';
    //    }
    //}

    //function showMenu2() {
    //    if (b === "Netscape") {
    //        theLayer = 'document.layers[\'menu2\']';
    //        theLayer.visibility = 'show';
    //    } else {
    //        theLayer = 'document.all[\'menu2\']';
    //        theLayer.style.visibility = 'visible';
    //    }
    //} // fostata
}());