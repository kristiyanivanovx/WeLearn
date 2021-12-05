﻿let DateTime = luxon.DateTime;

(function () {
    let timeTags = [...document.getElementsByTagName("time")];

    timeTags.forEach((e) => {
        let dateTime = e.getAttribute("datetime");
        if (!dateTime) {
            return;
        }

        let time = DateTime.fromISO(dateTime, { zone: "utc", locale: "bg" });
        let localized = time.toLocal().toLocaleString(DateTime.DATETIME_MED);

        e.innerHTML = localized;
        e.setAttribute("localtime", localized);
	})
}());

function escapeHtml(unsafe)
{
    return unsafe
        .replace(/&/g, "&amp;")
        .replace(/</g, "&lt;")
        .replace(/>/g, "&gt;")
        .replace(/"/g, "&quot;")
        .replace(/'/g, "&#039;");
}