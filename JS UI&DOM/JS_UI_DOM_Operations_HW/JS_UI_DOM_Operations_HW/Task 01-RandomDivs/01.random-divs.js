function getRandom(min, max) {
    return ""+(0 | Math.random() * (max - min) + min);
}

function getRandomColor() {
    return "rgb(" + getRandom(0, 255) + ", " +
                    getRandom(0, 255) + ", " +
                    getRandom(0, 255) + ")";
}

function createInitialElements() {
    var text = document.createElement("p");
    text.innerHTML = "Enter the number of random divs you want to create:"

    var input = document.createElement("input");
    input.id = "user-input";
    input.type = "text";

    var btn = document.createElement("input");
    btn.type = "button";
    btn.addEventListener("click", getDivs);
    btn.value = "Go";

    document.body.appendChild(text);
    document.body.appendChild(input);
    document.body.appendChild(btn);
}
createInitialElements();

function getDivs() {
    var n = 0 | document.getElementById("user-input").value;

    var divsFragment = document.createDocumentFragment();
    for (var i = 0; i < n; i++) {
        var div = document.createElement("div");
        div.style.display = "inline-block";
        div.style.width = getRandom(20, 100) + "px";
        div.style.height = getRandom(20, 100) + "px";
        
        div.style.backgroundColor = getRandomColor();

        div.style.color = getRandomColor();

        var x = window.innerWidth,
            y = window.innerHeight;
        div.style.position = "absolute";
        div.style.left = getRandom(0, x) + "px";
        div.style.top = getRandom(0, y) + "px";

        var strong = document.createElement("strong");
        strong.innerText= "div";

        div.appendChild(strong);

        div.style.borderRadius = getRandom(0, 20)+"px";
        div.style.borderWidth = getRandom(1, 20) + "px";
        div.style.borderStyle = " solid ";
        div.style.borderColor = getRandomColor();

        divsFragment.appendChild(div);
    }

    document.body.appendChild(divsFragment);
}
