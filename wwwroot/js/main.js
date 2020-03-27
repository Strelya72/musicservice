function home() {
    var element = document.getElementById("albumBtn");
    element.classList.add("btn-primary");

    var element = document.getElementById("albumInstance");
    element.classList.add("btn-secondary");
}

function instance() {
    var element = document.getElementById("albumBtn");
    element.classList.add("btn-secondary");

    var element = document.getElementById("albumInstance");
    element.classList.add("btn-primary");
}

function shopPage() {
    var element = document.getElementById("albumBtn");
    element.classList.add("btn-secondary");
    element.parentNode.removeChild(element);

    var element = document.getElementById("albumInstance");
    element.parentNode.removeChild(element);
}