$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Book/GetAllBooksAJAX/",
        success: function (data) {
            console.log(data)
        },
        error: function () {
            alert("Eror getting all books");
        }

    })
});

