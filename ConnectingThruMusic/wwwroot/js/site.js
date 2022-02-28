// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function recipient() {
    if (document.getElementById('instructorOpt').checked) {

        document.getElementById('instructor').style.visibility = 'visible';
        document.getElementById('parent').style.visibility = 'hidden';


    }
    else {
        document.getElementById('instructor').style.visibility = 'hidden';
        document.getElementById('parent').style.visibility = 'visible';
    }
}

