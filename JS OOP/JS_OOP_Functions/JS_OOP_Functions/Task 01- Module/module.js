var domModule = (function () {
    "use strict";

    var bufferSelectorsHolder = [], //will keep the selectors as string values and their indexes will serve as properties of the "buffer" object.                               Some selectors may contain invalid symbols or spaces and cannot be used directly as properties of the "buffer"
        buffer = {}; //properties will be the indexes of the selectors from the above array, which will hold a documentFragment with all buffered HTML objects

    function appendNewChild(htmlElement, selectorOfParent) {
        var parent = document.querySelector(selectorOfParent);
        parent.appendChild(htmlElement);
    }

    function removeOldChild(parentSelector, elementBeingRemovedSelector) {
        var parent = document.querySelector(parentSelector),
            elementToBeRemoved = document.querySelector(elementBeingRemovedSelector);

        parent.removeChild(elementToBeRemoved);
    }

    function addEvent(eventHolderSelector, eventType, eventFunction) {
        var eventHolder = document.querySelector(eventHolderSelector);

        eventHolder.addEventListener(eventType, eventFunction);
    }

    function addToBuffer(adopterSelector, htmlElement) {
        var i,
            bufferSelectorIndex,
            length,
            adopter;

        for (i = 0, length = bufferSelectorsHolder.length; i < length; i++) {
            if (adopterSelector == bufferSelectorsHolder[i]) {
                bufferSelectorIndex = i;
                break;
            } else if (i == length - 1) {
                bufferSelectorsHolder.push(adopterSelector);
                bufferSelectorIndex = length;
            }
        }

        if (length == 0) {
            bufferSelectorsHolder.push(adopterSelector);
            bufferSelectorIndex = 0;
        }

        if (!buffer.hasOwnProperty(bufferSelectorIndex)) {
            buffer[bufferSelectorIndex] = document.createDocumentFragment();
        }

        buffer[bufferSelectorIndex].appendChild(htmlElement);

        if (buffer[bufferSelectorIndex].childNodes.length == 100) {
            adopter = document.querySelector(adopterSelector);
            adopter.appendChild(buffer[bufferSelectorIndex]);
        }
    }

    return {
        appendChild: appendNewChild,
        removeChild: removeOldChild,
        addHandler: addEvent,
        addToBuffer: addToBuffer
    }
}());

//TESTS
var div = document.createElement("div"),
    button = document.createElement("div"),
    divBufferedToWrapper = document.createElement("div"),
    tableBufferedToWrapper = document.createElement("table"),
    inputBufferedToBody = document.createElement("input"),
    spanBufferedToBody = document.createElement("span");

div.innerHTML = "new div";
button.innerHTML = "button";
button.className = "button";
button.style.border = "2px solid black";
button.style.display = "inline-block";

domModule.appendChild(div, "#wrapper");
domModule.appendChild(button, "#wrapper");

setTimeout(function () {
    domModule.removeChild("#wrapper", "#wrapper div");
}, 1500);

domModule.addHandler("div.button", "click", function () {
    alert("Clicked")
});

domModule.addToBuffer("#wrapper", divBufferedToWrapper);
domModule.addToBuffer("#wrapper", tableBufferedToWrapper);

for (var i = 0; i < 99; i++) {
    if (i%2==0) {
        domModule.addToBuffer("body", inputBufferedToBody.cloneNode(true));
    } else {
        domModule.addToBuffer("body", spanBufferedToBody.cloneNode(true));
    }
}
domModule.addToBuffer("body", inputBufferedToBody);
domModule.addToBuffer("body", spanBufferedToBody);
