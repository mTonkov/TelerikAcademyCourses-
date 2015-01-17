/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function extract() {
    var text = "for more information, please contact academy@telerik.com; help@telerik.com",
        emailStartIndex = 0,
        idHostSeparatorIndex = 0,
        hostDomainSeparatorIndex = 0,
        emailEnd = 0,
        identifier = '',
        host = '',
        domain = "",
        isThereEmail = false,
        emailArray = [],
        email;

    console.log(text);

    if (!String.prototype.trimRightChars) {
        String.prototype.trimRightChars = function (chars) {

            var regEx = new RegExp('[' + chars + ']+$');
            return this.replace(regEx, '');
        }
    }

    for (var i = 0; i < text.length; i++) {
        if (text[i] === " ") {
            emailStartIndex = i + 1;
            isThereEmail = false;
        } else if (text[i] === "@" && ((i - 1) !== emailStartIndex)) {
            //if "@" is reached but the previos sign is not 'space' - this check excludes texts like this "i am @home"
            idHostSeparatorIndex = i + 1;
        } else if (text[i] === "." && ((i + 1) !== " ") && i < text.length - 2 /*if the email is in the end, the domain needs at least 2 charachters*/) {
            hostDomainSeparatorIndex = i + 1;
            isThereEmail = true;
            if (text.indexOf(" ", hostDomainSeparatorIndex) >= 0) {
                emailEnd = text.indexOf(" ", hostDomainSeparatorIndex);
            } else if (text.indexOf(";", hostDomainSeparatorIndex) >= 0) {
                emailEnd = text.indexOf(";", hostDomainSeparatorIndex);
            } else if (text.indexOf(",", hostDomainSeparatorIndex) >= 0) {
                emailEnd = text.indexOf(",", hostDomainSeparatorIndex);
            } else {
                emailEnd = text.length;
            }
        }

        if (isThereEmail) {
            identifier = text.substring(emailStartIndex, idHostSeparatorIndex - 1);
            host = text.substring(idHostSeparatorIndex, hostDomainSeparatorIndex - 1);
            domain = text.substring(hostDomainSeparatorIndex, emailEnd);
            //domain = domain.replace(/,+$/, "");
            //domain = domain.replace(/;+$/, "");
            domain = domain.trimRightChars(",;")
            
            email = identifier + "@" + host + "." + domain;

            if (emailArray[emailArray.length-1] !== email) {
                emailArray.push(email);
            }
        }
    }
    console.log(emailArray);
})()

