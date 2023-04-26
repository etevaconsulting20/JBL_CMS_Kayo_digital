$(document).ready(function () {
    $('#testimonial-logos').flexslider({
        animation: "slide",
        controlNav: false,
        animationLoop: false,
        slideshow: true,
        itemWidth: 80,
        asNavFor: '#testimonial-slider'
    });

    $('#testimonial-slider').flexslider({
        animation: "slide",
        controlNav: false,
        slideshow: true,
        animationLoop: false,
        sync: "#testimonial-logos"
    });

    var tab = $('.c-tabs__link');
    tab.click(function (e) {
        e.preventDefault();
        tab.removeClass('active');
        $(this).addClass('active');

        var targetId = $(this).data('target');
        console.log('#' + targetId);

        $('.b-contact-form__form-wrapper').removeClass('active');
        $('#' + targetId).addClass('active');

    });

    $('.c-navbar__toggle').click(function () {

        if ($('body').hasClass('navopen')) {
            $('body').removeClass('navopen');
        }

        else {
            $('body').addClass('navopen');
        }

    });
});

$(window).resize(function () {
    if ($(window).width() > 992) {
        $('body').removeClass('navopen');
    }
});
