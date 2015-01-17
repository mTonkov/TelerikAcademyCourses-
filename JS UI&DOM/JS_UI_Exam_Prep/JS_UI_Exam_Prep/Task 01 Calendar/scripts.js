function createCalendar(containerID, events) {
    var daysOfTheWeek = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];
    var dFrag = document.createDocumentFragment();

    for (var i = 0; i < 30; i++) {//building DOM
        var dayTitle = document.createElement("div");
        var dayEvent = document.createElement("div");
        var calendarDay = document.createElement("div");
        calendarDay.className = "calendar-day";
        calendarDay.addEventListener("click", onMouseClick);
        calendarDay.addEventListener("mouseover", onMouseOver);
        calendarDay.addEventListener("mouseout", onMouseOut);

        dayTitle.innerHTML = daysOfTheWeek[i % daysOfTheWeek.length] + " " + (i + 1) + " June 2014";
        dayTitle.className = "calendar-day-title";
        dayTitle.style.backgroundColor = "#aaa";
        calendarDay.appendChild(dayTitle);

        dayEvent.innerHTML = "&nbsp;";
        dayEvent.className = "calendar-day-event";
        calendarDay.appendChild(dayEvent);
        dFrag.appendChild(calendarDay);

        if ((i + 1) % 7 == 0) {
            dFrag.appendChild(document.createElement("br"));
        }
    }
    var container = document.querySelector(containerID);
    container.appendChild(dFrag);// end building DOM


    var allDaysInCalendar = document.getElementsByClassName("calendar-day");// styling day boxes
    for (var i = 0; i < allDaysInCalendar.length; i++) {
        allDaysInCalendar[i].style.width = "200px";
        allDaysInCalendar[i].style.height = "200px";
        allDaysInCalendar[i].style.border = "1px solid black";
        allDaysInCalendar[i].style.display = "inline-block";
    }// end styling day boxes

    var dayTitles = document.getElementsByClassName("calendar-day-title");//style titles
    for (var i = 0; i < dayTitles.length; i++) {
        dayTitles[i].style.textAlign = "center";
        dayTitles[i].style.borderBottom = "1px solid black";
        dayTitles[i].style.backgroundColor = "#aaa";
    }

    var dateEventContainer = document.getElementsByClassName("calendar-day-event");
    for (var i = 0; i < events.length; i++) {
        var eventDate = parseInt(events[i].date);
        dateEventContainer[eventDate - 1].innerHTML = events[i].hour + " " + events[i].title;
    }
    var clicked = null;
    function onMouseClick() {
        if (clicked) {
            clicked.style.backgroundColor = "";
        }
        if (clicked === this) {
            clicked = null;
        } else {
            this.style.backgroundColor = "#aaa";
            clicked = this;
        }
    }
    function onMouseOver() {
        if (this != clicked) {
            this.style.backgroundColor = "pink";
        }
    }
    function onMouseOut() {
        if (this != clicked) {
            this.style.backgroundColor = "";
        }
    }
}