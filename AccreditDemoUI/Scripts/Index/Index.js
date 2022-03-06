var urls = {
    getData: '/GitHub/GetGutHubDetails',
};

var GetGitHubUserData = function (userrequest) {

    $('.spinner').show();

    $("#GitHubUserDetails").html("");

    $.ajax({
        type: "POST",
        url: urls.getData,
        dataType: 'html',
        headers: {
            'RequestVerificationToken': gettoken()
        },
        data: userrequest,
        success: function (result) {
            $('.spinner').hide();
            $("#GitHubUserDetails").html(result);
            document.getElementById("txtUsername").value = "";
        }
    });
};