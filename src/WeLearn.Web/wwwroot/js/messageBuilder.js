var messageBuilder = function () {
    var message = null;
    var span1 = null;
    var span2 = null;
    var span3 = null;

    return {
        createMessage: function (classList) {
            message = document.createElement("div")
            if (classList === undefined) { classList = []; }

            for (var i = 0; i < classList.length; i++) {
                message.classList.add(classList[i])
            }

            message.classList.add('message')
            message.classList.add('mb-1')
            return this;
        },
        withHeader: function (text) {
            span1 = document.createElement("span")
            let b = document.createElement("b")
            b.appendChild(document.createTextNode(text))
            span1.appendChild(b)
            return this;
        },
        withParagraph: function (text) {
            span2 = document.createElement("span")
            span2.appendChild(document.createTextNode(': ' + text + ' | '))
            return this;
        },
        withFooter: function (text) {
            span3 = document.createElement("span")
            span3.appendChild(document.createTextNode(text))
            return this;
        },
        build: function () {
            message.appendChild(span1);
            message.appendChild(span2);
            message.appendChild(span3);
            return message;
        }
    }
}
