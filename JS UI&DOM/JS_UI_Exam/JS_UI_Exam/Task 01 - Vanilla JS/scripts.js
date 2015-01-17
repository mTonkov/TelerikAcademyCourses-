function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector);
    var bigImageContainer = document.createElement("div");
    var sideBarContainer = document.createElement("div");
    sideBarContainer.style.width = "210px";
    var sideBarImages = document.createElement("div");
    var filter = document.createElement("div");
    var filterLabel = document.createElement("div");
    var filterInput = document.createElement("input");

    //creating filter
    filterLabel.innerText = "Filter";
    filterLabel.style.textAlign = "center";
    filterLabel.style.fontSize = "20px";
    filterLabel.style.fontWeight = "bold";
    filterInput.type = "text";
    filterInput.addEventListener("keyup", onKeyUpFilter);
    filter.appendChild(filterLabel);
    filter.appendChild(filterInput);
    sideBarContainer.appendChild(filter);//append filter to sidebar

    var bigImageLabel = document.createElement("div");//big image
    bigImageLabel.innerText = items[0].title;
    bigImageLabel.className = "big-img-label";
    bigImageLabel.style.textAlign = "center";
    bigImageLabel.style.fontSize = "52px";
    bigImageLabel.style.fontWeight = "bold";
    var bigImage = document.createElement("img");
    bigImage.src = items[0].url;
    bigImage.className = "big-image";
    bigImage.style.width = "650px";
    bigImage.style.height = "450px";
    bigImage.style.borderRadius = "25px";
    var bigImageContainer = document.createElement("div");
    bigImageContainer.style.display = "inline-block";
    bigImageContainer.style.position = "relative";
    bigImageContainer.style.top = "0";
    bigImageContainer.style.left = "10px";
    bigImageContainer.appendChild(bigImageLabel);
    bigImageContainer.appendChild(bigImage);

    for (var i = 0; i < items.length; i++) {//creating images in the sidebar
        var imageLabel = document.createElement("div");
        var image = document.createElement("img");
        var imageContainer = document.createElement("div");
        imageContainer.addEventListener("click", onImageClick);
        imageContainer.addEventListener("mouseover", onMouseOver);
        imageContainer.addEventListener("mouseout", onMouseOut);
        imageContainer.classList.add ("small-images");
        imageContainer.classList.add (items[i].title.toLowerCase());

        imageLabel.innerText = items[i].title;
        imageLabel.className = "label"
        imageLabel.style.textAlign = "center";
        imageLabel.style.fontSize = "20px";
        imageLabel.style.fontWeight = "bold";
        image.src = items[i].url;
        image.style.width = "180px";
        image.style.height = "150px";
        image.style.borderRadius = "15px";
        image.style.margin = "5px";

        imageContainer.appendChild(imageLabel);//append each pair of label and image to its container
        imageContainer.appendChild(image);
        sideBarImages.appendChild(imageContainer);//append the image container to the all images container
    }
    sideBarImages.style.overflowY = "scroll";
    sideBarImages.style.height = "500px";

    sideBarContainer.appendChild(sideBarImages);//append all images to sidebar
    sideBarContainer.style.display = "inline-block";
    sideBarContainer.style.position = "relative";
    sideBarContainer.style.top = "30px";
    sideBarContainer.style.right = "-40px";

    container.appendChild(bigImageContainer);
    container.appendChild(sideBarContainer);
    container.style.width = "900px";
    container.style.height = "600px";
    container.style.border = "2px solid blue";
    container.style.position = "absolute";
    

    //events
    function onImageClick(ev) {
        var clickedImg = this.getElementsByTagName("img")[0];
        var clickedImgTitle = this.getElementsByClassName("label")[0];
        var bigImg = container.getElementsByClassName("big-image")[0];
        var bigImgTitle = container.getElementsByClassName("big-img-label")[0];

        bigImgTitle.innerText = clickedImgTitle.innerText;
        bigImage.src = clickedImg.src;
    }
    function onMouseOver(ev) {
        this.style.backgroundColor = "#aaa";
    }
    function onMouseOut(ev) {
        this.style.backgroundColor = "";
    }

    function onKeyUpFilter() {
        var input = this.value.toLowerCase();
        var allImages = container.getElementsByClassName("small-images");

        for (var i = 0; i < allImages.length; i++) {
            var currentElement = allImages[i];
            if (input) {
                currentElement.classList.toggle("small-images");
                var currentElementClass = currentElement.className;
                currentElement.style.display = "";// added after exam
                if (currentElementClass.indexOf(input)<0) {
                    currentElement.style.display = "none";
                }
                currentElement.classList.toggle("small-images");
            } else {
                currentElement.style.display = "";
            }
        }
    }
}