var addButton = document.getElementById("btn-add"),
    showHideButton = document.getElementById("btn-show-hide"),
    removeButton = document.getElementById("btn-remove"),
    theList = document.getElementById("the-list");

addButton.addEventListener("click", function () {
    var input = document.getElementById("to-do-input").value;

    if (input) {
        var newItem = document.createElement("li");
        newItem.classList.add("to-do-item");
        newItem.innerHTML = input;

        theList.appendChild(newItem);
    }
});

theList.addEventListener("click", function (ev) {
    var target = ev.target;

    target.classList.toggle("selected");//if there is such class name, it is removed, else it is added

});

removeButton.addEventListener("click", function () {
    var removeables = theList.getElementsByClassName("selected");

    while (removeables[0]) {
        removeables[0].parentNode.removeChild(removeables[0]);
    }
});

showHideButton.addEventListener("click", function () {
    theList.classList.toggle("hidden");
});