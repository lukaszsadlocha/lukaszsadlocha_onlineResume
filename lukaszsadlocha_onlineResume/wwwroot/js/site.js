$(function () {
    var sucessMessage = $('#successMessage');

    if (sucessMessage.length > 0) {
        scrollToElement(sucessMessage[0]);
    }

    var errorMessage = $('#errorMessage');

    if (errorMessage.length > 0) {
        scrollToElement(errorMessage[0]);
    }

    

});

function scrollToElement(ele) {
    $('html, body').animate({ scrollTop: $(ele).offset().top }, 500);
}