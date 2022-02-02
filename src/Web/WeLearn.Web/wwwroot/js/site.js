let DateTime = luxon.DateTime;

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

// Requirements:
// 1. In the page, must generate anti-CSRF token - <form id="likesForm" method="post"></form>
// 2. In the page, must have an DOM element with likesCount id. 
// 3. In the page, must have button with attribute onclick - onclick="toggleLike(@Model.LessonId)"

function toggleLike(lessonId) {
    let token = document.querySelector("#likesForm input[name=__RequestVerificationToken]").value;
    let target = document.getElementById("likesCount");
    let body = { lessonId: lessonId };

    fetch('/api/Likes', {
        method: 'POST',
        headers: {
            'X-CSRF-TOKEN': token,
            'Content-Type': 'application/json; charset=utf-8',
        },
        body: JSON.stringify(body),
    })
    .then(response => response.json())
    .then(data => {
        target.innerHTML = data['likesCount'];
        return data;
    })
    .catch(err => console.error(err));
}