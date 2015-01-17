function checkBrowser(event, args) {
    "use strict";
    /*global window, alert */

    var currentWindow = window,
        browser = currentWindow.navigator.appCodeName,
        isMozilla = (browser === "Mozilla");

    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}
