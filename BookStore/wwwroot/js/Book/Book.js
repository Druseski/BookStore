$(document).ready(function () {
    console.log("Document Ready from included JS Script!!!!!");
});

$("#PublisherID").change(function () {
    var optionSelected = $("option:selected", this);
    console.log(optionSelected);

    var optionName1 = optionSelected[0].innerHTML;
    console.log("OptionName1: " + optionName1);

    var optionName2 = optionSelected.text();
    console.log("OptionName2: " + optionName2)

    $("#PublisherName").val(optionName2);
    console.log("PublisherName Check: " + $("#PublisherName").val());

});

$("#CategoryID").change(function () {
    var optionSelected = $("option:selected", this);
    console.log(optionSelected);

    var optionName1 = optionSelected[0].innerHTML;
    console.log("OptionName1: " + optionName1);

    var optionName2 = optionSelected.text();
    console.log("OptionName2: " + optionName2)

    $("#CategoryName").val(optionName2);
    console.log("CategoryName Check:" + $("#CategoryName").val());

});

$("#AuthorID").change(function () {
    var optionSelected = $("option:selected", this);
    console.log(optionSelected);

    var optionName1 = optionSelected[0].innerHTML;
    console.log("OptionName1: " + optionName1);

    var optionName2 = optionSelected.text();
    console.log("OptionName2: " + optionName2)

    $("#AuthorName").val(optionName2);
    console.log("AuthorName Check: " + $("#AuthorName").val());

});


////$(document).ready(function () {
////    $("#Rsult").click(function () {
////        //Add the page method call as an onclick handler for the div.
////        $.ajax({
////            type: "POST",
////            url: "",
////            data: { someParameter: "some value" },
////            contentType: "aplication/json;charset=utf-8",
////            dataType: "json",
////            success: function (msg) {
////                //Replace the div's content with the page method's return.
////                $("#Result").text(msg.d);
////            }
////        });
////    });
////});

$("#addNewAuthor").click(function () {
    console.log("modal button author add new author");
    var data = {
        Name: $("#AuthorNameDTO").val(),
        Country: $("#AuthorCountryDTO").val(),
        DateBirth: $("#AuthorDateBirthDTO").val(),
        ShortDiscription: $("#AuthorSho:rtDiscriptionDTO").val(),
        Language: $("#AuthorLanguageDTO").val(),
        Gender: $("#AuthorGenderDTO").val()
    };

    $.ajax({
        type: "POST",
        url: "/Author/CreateAuthorAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data);
            $("#AuthorID").append("<option value=" + data.id + ">" + data.name + "</option>")
        },
        error: function () {
            alert("Error Adding New Author!");

        }
    });
});

$("#addNewPublisher").click(function () {
    console.log("modal button author add new publisher")
});

$("#addNewCategory").click(function () {
    console.log("modal button author add new category")
});