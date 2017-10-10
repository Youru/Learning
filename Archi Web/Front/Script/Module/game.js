var gameModule = (function () {

    var getGameValues = function () {
        $.ajax({
            url: configModule.gameApi,
            success: function (data) {

                var content = "<table><tr><th>GameName</th><th>Rating</th><th>LegalAge</th></tr>"
                $.each(data.games, function (index, elem) {
                    content += "<tr><td>"+elem.gameName+"</td><td>"+elem.rating+"</td><td>"+elem.legalAge+"</td></tr>"
                });
                content += "</table>"
                $("#main").html(content);
            }
        })
    };

    return {
        getGameValues: getGameValues
    };
})();