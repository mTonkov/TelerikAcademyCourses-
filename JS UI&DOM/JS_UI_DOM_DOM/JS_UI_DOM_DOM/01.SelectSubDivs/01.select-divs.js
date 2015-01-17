/*global document: false */
//function selectDivsByGetElement() { //solution version 1.1 :)
// 'use strict';
//    var divs = document.getElementsByTagName("div");
//    divs = Array.prototype.slice.call(divs); //the "call" method is used to convert an array-like object to a real array

//    var innerDivs = divs.filter(getInnerDivs);
//    for (var i = 0, len = innerDivs.length; i < len; i++) {
//        innerDivs[i].innerText = "Selected with 'getElements' method";
//        innerDivs[i].style.color = "green";
//    }
//    //  console.log(innerDivs);
//    function getInnerDivs(element) { // this is the filtering function
//        return element.className != "outer-div";
//    }
//}

function selectDivsByGetElement() { //solution v.1.2 :)
    'use strict';
    var divs = document.getElementsByTagName("div");

    for (var i = 0, len = divs.length; i < len; i++) {
        if (divs[i].childNodes.length > 0) {// checks for nested elements
            for (var j = 0, length = divs[i].childNodes.length; j < length; j++) {

                var nestedElement = divs[i].childNodes[j];
                if (nestedElement.localName === 'div') {
                    nestedElement.innerText = "Selected with 'getElements' method";
                    nestedElement.style.color = "green";
                }
            }
        }
    }
}

function selectDivsByQuerySelector() {
    var innerDivs = document.querySelectorAll("div.outer-div>div");

    for (var i = 0, len = innerDivs.length; i < len; i++) {
        innerDivs[i].innerText = "Selected with 'querySelectorAll' method";
        innerDivs[i].style.color = "red";
    }
}
setTimeout(selectDivsByGetElement, 1500);
setTimeout(selectDivsByQuerySelector, 3500);
