/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_DOM_Operations_HW\JS_UI_DOM_Operations_HW\raphael-min.js" />

var tags = ["cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress", "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript", "js", "cms", "html", "javascript", "http", "http", "CMS"]

//var tagCloud = generateTagCloud(tags, 17, 42);

function countWordAppearances() {
    var wordsAndAppearances = {},
        newTagsArray = [];

    for (var i = 0, len = tags.length; i < len; i++) {
        newTagsArray.push(tags[i].toLowerCase());
    }

    for (var i = 0, len = newTagsArray.length; i < len; i++) {
        var word = newTagsArray[i],
            wordMetIndex = newTagsArray.indexOf(word),
            counter = 0;

        while (wordMetIndex >= 0) {
            counter++;
            wordMetIndex = newTagsArray.indexOf(word, wordMetIndex + 1);
        }

        if (!wordsAndAppearances.hasOwnProperty(word)) {
            wordsAndAppearances[word] = counter;
        }
    }

    return wordsAndAppearances;
}

var countedWords = countWordAppearances();

function generateTagCloud(wordsObj, minFont, maxFont) {

    var paper = Raphael(0, 0, 250, 300),
        currentX = 0,
        currentY = 0,
        maxWordAppearance = 0;
    
    for (var word in wordsObj) {//the loops gets the most frequent word, which takes part in font-size calulation
        console.log(word);//for debugging

        if (wordsObj[word] > maxWordAppearance) {
            maxWordAppearance = wordsObj[word];
        }
        console.log(word);//for debugging
    }
    
    for (var word in wordsObj) {
        var newFontSize = getWordSize(wordsObj[word], maxWordAppearance);

        paper.text(currentX + newFontSize, currentY + newFontSize, word)
        .attr({
            "font-size": newFontSize
        });
                
        currentX += (paper.text.length+1)*newFontSize;//finds the next available position for the next word (+1 stands for space)
        if (currentX>paper.width) {
            currentX = 0;
            currentY += newFontSize;
        }
    }

    function getWordSize(currentWordAppearances, maxWordAppearances) {
        return (currentWordAppearances / maxWordAppearances) * (maxFont - minFont) + minFont;
        // the ratio between the current and max appearance multiplied by the range of values + the minimum;
        // this defines a font-size in the passed range
    }
}

generateTagCloud(countedWords, 17, 42);
