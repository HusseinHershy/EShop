$('#SignInButton').click(function () {
  
    $.ajax({
        type: "POST",
        url: "/api/users/Authenticate",
        contentType: "application/json",
        data: JSON.stringify({
            Name: $('#UserInput').val(),
            Password: $('#PasswordInput').val()
        }),
        success: function (data) {
            setCookie('LoginToken', data.token, 7);
            location.href = "/Home/Product";
        },
        error: function (err) {
            alert("Login Failed");
        }
    });
});