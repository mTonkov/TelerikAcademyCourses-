/// <reference path="jquery.min.js" />
$.fn.gallery = function (columns) {
    var $gallery = $(this);
    var cols = columns || 4;
    var $galleryList = $($gallery.find(".gallery-list")[0]);
    $gallery.addClass("gallery");


    // set the number of columns
    var $children = $gallery.find(".image-container");
    for (var i = 0; i < $children.length; i++) {
        if (i % cols == 0) {
            var $endOfRow = $($children[i]);
            $endOfRow.addClass("clearfix");
        }
    }

    //clear selected
    var $selectedSubGallery = $gallery.find(".selected");
    $selectedSubGallery.hide();

    //set the images that have to be previewed, depending on the "data-info" attribute of each image.
    //"data-info" is a custom attribute and I believe this is the best way to use it.
    function setPreviewPictures($clickedImage) {
        var $clickedSrc = $clickedImage.attr("src");
        var $clickedDataInfo = parseInt($clickedImage.attr("data-info"));
        var prevDataInfo,
            nextDataInfo;

        if ($clickedDataInfo == 1) {
            prevDataInfo = 12;
            nextDataInfo = ($clickedDataInfo + 1);
        } else if ($clickedDataInfo == 12) {
            prevDataInfo = ($clickedDataInfo - 1);
            nextDataInfo = 1;
        } else {
            prevDataInfo = ($clickedDataInfo - 1);
            nextDataInfo = ($clickedDataInfo + 1);
        }
        var prevSrc = $("img[data-info=" + prevDataInfo + "]").attr("src");
        var nextSrc = $("img[data-info=" + nextDataInfo + "]").attr("src");

        $("#current-image").attr("src", $clickedSrc);
        $("#previous-image").attr("src", prevSrc).attr("data-info", prevDataInfo);
        $("#next-image").attr("src", nextSrc).attr("data-info", nextDataInfo);
        //"data-info" attribute is transfered to the previewed image in order to reuse the current function when setting the images that have to be previewed
    }

    $gallery.on("click", ".image-container", function () {
        var $clickedContainer = $(this);
        var $clickedImage = $clickedContainer.find("img");
        $galleryList.addClass("blurred").addClass("disabled-background");
        setPreviewPictures($clickedImage);
        $selectedSubGallery.show();
    });

    $selectedSubGallery.on("click", "#current-image", function () {
        $galleryList.removeClass("blurred").removeClass("disabled-background");
        $selectedSubGallery.hide();
    });

    $selectedSubGallery.on("click", "#next-image, #previous-image", function () {
        setPreviewPictures($(this));
    });
}