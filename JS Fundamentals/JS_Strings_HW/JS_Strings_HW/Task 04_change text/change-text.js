/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function change() {

    var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.",
        regions = [
        ["<upcase>", "</upcase>"],
        ["<lowcase>", "</lowcase>"],
        ["<mixcase>", "</mixcase>"]
        ],
        currentSubString,
        openTag;

    while (findRegion(text)) {
        openTag = findRegion(text);
        currentSubString = getSubstring(openTag);
        applyCasing(currentSubString, openTag);
    }
    console.log(text);

    function findRegion(textString) {
        var tagStart = -1,
            tagEnd = -1,
            tag;

        tagStart = textString.indexOf("<");
        tagEnd = textString.indexOf(">");
        tag = textString.substring(tagStart, tagEnd + 1);
        if (tagStart > -1) {
            return tag;
        } else {
            return false;
        }
    }

    function getSubstring(openingTag) {
        var openingTagLength = openingTag.length,
            openingTagIndex = 0,
            closingTag = getClosingTag(openingTag),
            closingTagIndex = 0;

        openingTagIndex = text.indexOf(openingTag);
        closingTagIndex = text.indexOf(closingTag);

        return text.substring(openingTagIndex + openingTagLength, closingTagIndex);

    }

    function getClosingTag(openingTag) {

        switch (openingTag) {
            case regions[0][0]:
                return regions[0][1];
            case regions[1][0]:
                return regions[1][1];
            case regions[2][0]:
                return regions[2][1];
            default:
                break;
        }
    }

    function getRandomInt(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    function applyCasing(substr, openingTag) {
        var newSubStr = "";

        switch (openingTag) {
            case regions[0][0]:
                newSubStr = substr.toUpperCase();
                text = text.replace(substr, newSubStr);
                text = text.replace(openingTag, "");
                text = text.replace(getClosingTag(openingTag), "");
                break;
            case regions[1][0]:
                newSubStr = substr.toLowerCase();
                text = text.replace(substr, newSubStr);
                text = text.replace(openingTag, "");
                text = text.replace(getClosingTag(openingTag), "");
                break;

            case regions[2][0]:
                for (var i = 0; i < substr.length; i++) {
                    switch (getRandomInt(0, 1)) {
                        case 0:
                            newSubStr += substr[i].toLowerCase();
                            break;
                        case 1:
                            newSubStr += substr[i].toUpperCase();
                            break;

                        default:
                            newSubStr += substr[i];
                            break;
                    }
                }
                text = text.replace(substr, newSubStr);
                text = text.replace(openingTag, "");
                text = text.replace(getClosingTag(openingTag), "");
                break;

            default:
        }
    }

})()

