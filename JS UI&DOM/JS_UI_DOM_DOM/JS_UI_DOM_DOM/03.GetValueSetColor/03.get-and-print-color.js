function getSetColor() {
    var text = document.getElementById("input-text").value;
    var body = document.getElementsByTagName("body")[0];
    
    body.style.backgroundColor = text;
}