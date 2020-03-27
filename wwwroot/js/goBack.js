function backAway() {
    if (history.length === 1) {
        window.location = "/";
    } else {
        history.back();
    }
}