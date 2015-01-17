/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function extract() {
    var url = "http://www.devbg.org/forum/index.php",
        jsonObj = {},
        protocolEnd = "://",
        protocolEndIndex = 0
        serverEnd = "/",
        serverEndIndex = 0;

        protocolEndIndex = url.indexOf(protocolEnd);
        jsonObj["protocol"] = url.substring(0, protocolEndIndex);
        url = url.replace(jsonObj["protocol"] + protocolEnd, "");

        serverEndIndex = url.indexOf(serverEnd);
        jsonObj["server"] = url.substring(0, serverEndIndex);
        url = url.replace(jsonObj["server"], "");

        jsonObj["resource"] = url;

        console.log(JSON.stringify(jsonObj));
        jsConsole.writeLine(JSON.stringify(jsonObj));
})()

