let messageBuilder = function () {
    let message = null;
    let container = null;
    let bubbleContainer = null;

    let header = null;
    let content = null;
    let footer = null;

    return {
        createMessage: function (classList) {
            message = document.createElement("div")
            if (classList === undefined) { classList = []; }

            for (var i = 0; i < classList.length; i++) {
                message.classList.add(classList[i])
            }

            return this;
        },
        withContainer: function (target, classList) {
            container = document.createElement("div")
            
            if (classList === undefined) { classList = []; }
            if (target === undefined) { throw new Error("Target must be provided!"); }

            for (let i = 0; i < classList.length; i++) {
                container.classList.add(classList[i])
            }

            message.appendChild(container);
            return this;
        },
        withBubbles: function (bubbleClassList) {
            bubbleContainer = document.createElement("div")

            if (bubbleClassList === undefined) { bubbleClassList = []; }

            for (let i = 0; i < bubbleClassList.length; i++) {
                bubbleContainer.classList.add(bubbleClassList[i]);
            }

            container.appendChild(bubbleContainer);
            return this;
        },
        withHeader: function (text) {
            header = document.createElement("div");
            
            let strong = document.createElement("strong");
            let textNode = document.createTextNode(text);
            let colon = document.createTextNode(":");
            
            strong.appendChild(textNode);
            header.appendChild(strong);
            header.appendChild(colon);
            
            return this;
        },
        withParagraph: function (text) {
            content = document.createElement("span")
            content.appendChild(document.createTextNode(text))
            return this;
        },
        withFooter: function (text, classList) {
            if (classList === undefined) { classList = []; }
            
            let time = DateTime.fromISO(text, { zone: "utc", locale: "bg" });
            let localized = time.toLocal().toLocaleString(DateTime.DATETIME_MED);
            
            footer = document.createElement("small")
            footer.appendChild(document.createTextNode(localized))

            for (let i = 0; i < classList.length; i++) {
                footer.classList.add(classList[i]);
            }
            
            return this;
        },
        build: function () {
            bubbleContainer.appendChild(header);
            bubbleContainer.appendChild(content);
            container.appendChild(footer);

            return message;
        }
    }
}
