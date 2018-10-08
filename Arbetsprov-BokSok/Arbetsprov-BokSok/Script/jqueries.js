jQuery(document).ready(function () {
    jQuery('#titleTxt').keyup(function () {
        var caps = jQuery('#titleTxt').val();
        caps = caps.charAt(0).toUpperCase() + caps.slice(1);
        jQuery('#titleTxt').val(caps);
    });
});

$('#GetBookByTitle').click(function () {

    var api = 'api/find/';
    var jstring = $('#titleTxt').val();
    $('#titleTxt').val('');


    $.getJSON(api + jstring, function (data) {
        $('#books').empty();

        $.each(data, function (key, val) {
            var row = '<td>' + val.author + '</td><td>' + val.title + '</td><td>' + val.genre + '</td><td>' + val.price + '</td><td>' + val.publish_date + '</td><td>' + val.description + '</td>';
            $('<tr>', { html: row }).appendTo($('#books'));
        });
    });

});

$('#getAllBtn').click(function () {
    $.getJSON("api/getAllBooks",
        function (data) {
            $('#books').empty();

            $.each(data, function (key, val) {

                var row = '<td>' + val.author + '</td><td>' + val.title + '</td><td>' + val.genre + '</td><td>' + val.price + '</td><td>' + val.publish_date + '</td><td>' + val.description + '</td>';
                $('<tr/>', { html: row })
                    .appendTo($('#books'));
            });
         });
});

$('#cBtn').click(function () {

    $('#books').empty();
});
