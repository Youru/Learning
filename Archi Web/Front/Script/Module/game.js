var gameModule = (function () {

    var getGameValues = function () {
        $.ajax({
            url: configModule.gameApi,
            success: function (data) {
                $("#main").html(data);
            }
        })
    };



    return {
        getGameValues: getGameValues
    };
})();