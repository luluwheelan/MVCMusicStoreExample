$(function () {
    $("#album-list img").mouseover(function () {
        $(this).animate({ height: '+=25', width: '+=25' })
            .animate({ height: '-=25', width: '-=25' });
    });
});

function searchFailed() {
    $('#searchresults').html("Sorry, there was a problem completing your search");
}
$("input[data-autocomplete-source]").each(
    function () {
        var target = $(this);
        target.autocomplete({ source: target.attr("data-autocomplete-source") });
    });
