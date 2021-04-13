window.onload = function addMargin() {
    const rows = document.querySelectorAll(".row");

    if (rows.length >= 5) {
        document.getElementsByClassName("container")[0].style.marginBottom = "15px";
    }
}
