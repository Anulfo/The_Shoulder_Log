// Write your Javascript code.
var CurrentUrl = window.location.href;

if (CurrentUrl == 'http://localhost:50663/Physician/Library') {
    var libraryButton = document.getElementById('libraryButton');
    libraryButton.style.visibility = "hidden";
}