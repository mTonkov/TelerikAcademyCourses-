var dFrag = document.createDocumentFragment(),
    textarea = document.createElement("textarea"),
    fontColorPicker = document.createElement("input"),
    backgroundColorPicker = document.createElement("input"),
    fontColorLabel = document.createElement("p"),
    backgroundColorLabel = document.createElement("p");

textarea.id = "text";
textarea.value = "Some text here...";
dFrag.appendChild(textarea);

fontColorLabel.innerHTML = "Choose text color:"
dFrag.appendChild(fontColorLabel);

fontColorPicker.type = "color";//font color input
fontColorPicker.id = "font-color-picker";
fontColorPicker.setAttribute("onchange", "onFontColorChange()");
//fontColorPicker.onchange = "onFontColorChange()";
dFrag.appendChild(fontColorPicker);

backgroundColorLabel.innerHTML = "Choose textbox background color:"
dFrag.appendChild(backgroundColorLabel);

backgroundColorPicker.type = "color"; //background color input
backgroundColorPicker.id = "background-color-picker";
backgroundColorPicker.setAttribute("onchange", "onBackgroundColorChange()");
//backgroundColorPicker.onchange = "onBackgroundColorChange()";
dFrag.appendChild(backgroundColorPicker);

document.body.appendChild(dFrag);


function onFontColorChange() {
    var color = document.getElementById("font-color-picker").value;

    document.getElementById("text").style.color = color;
}

function onBackgroundColorChange() {
    var color = document.getElementById("background-color-picker").value;

    textarea.style.backgroundColor = color;
}