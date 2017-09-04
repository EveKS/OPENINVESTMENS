$(document).ready(function () {
    $(".open-text").click(function () {
        let text = $('.more-text');
        if (text.is('.more-text--close')) {
            text.removeClass('more-text--close');
            text.addClass('more-text--open');
        } else {
            text.removeClass('more-text--open');
            text.addClass('more-text--close');
        }
    });

    $(".open-list li").click(function () {
        let text = $(this).find(".closed-text");
        if (text.is(':visible')) {
            text.slideUp();
            $(this).addClass("act");
        } else {
            text.slideDown();
            $(this).removeClass("act");
        }
    });
});