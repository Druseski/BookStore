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
            console.log(data.data);
            if (data.data == "") {
                $("#authorModal").modal('toggle');
                setTimeout(() => {
                    alert("Error:Author has not been added.Pleace enter data in all the fields!");
                }, 500);
                
                
            } else {
                $("#AuthorID").append("<option value=" + data.data.id + ">" + data.data.name + "</option>");
                $("#AuthorID").val(data.data.id);
                $("#authorModal").modal('toggle');
            }
        },
        error: function () {
            alert("Error Adding New Author! Pleace enter data in all the fields! ");

        }
    });
});

$("#addNewPublisher").click(function () {
    console.log("modal button publisher add new publisher")

    var data = {
        Name: $("#PublisherNameDTO").val(),
        Country: $("#PublisherCountryDTO").val(),
        Year: $("#PublisherYearDTO").val() 
    };

    $.ajax({
        type: "POST",
        url: "/Publisher/CreatePublisherAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data.data);
            if (data.data == "") {
                $("#publisherModal").modal('toggle');
                setTimeout(() => {
                    alert("Error:Publisher has not been added.Pleace enter data in all the fields!");
                }, 500);


            } else {
                $("#PublisherID").append("<option value=" + data.data.id + ">" + data.data.name + "</option>");
                $("#PublisherID").val(data.data.id);
                $("#publishermodal").modal('toggle');
            }
        },
        error: function () {
            alert("Error Adding New Publisher! Pleace enter data in all the fields! ");

        }
    });
});

$("#addNewCategory").click(function () {
    console.log("modal button category add new category")
    var data = {
        Name: $("#CategoryNameDTO").val() 
    };
    $.ajax({
        type: "POST",
        url: "/Category/CreateCategoryAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            console.log(data.data);
            if (data.data == "") {
                $('#categorymodal').modal('togle');
                setTimeout(() => {
                    alert("Error:Category has not been added.Pleace enter data in all the fields!");
                }, 500);


            } else {
                $("#CategoryID").append("<option value=" + data.data.id + ">" + data.data.name + "</option>");
                $("#CategoryID").val(data.data.id);
                $("#categorymodal").modal('togle');
            }
        },
        error: function () {
            alert("Error Adding New Category! Pleace enter data in all the fields! ");

        }
    });
});

$("#uploadPhoto").click(function () {
    var data = new FormData();
    var files = $("#photoUpload").get(0).files;

    if (files.length > 0) {
        data.append("UploadedImage", files[0]);
        console.log(data);
    }
    $.ajax({
        type: "POST",
        url: "/Book/UploadPhoto",
        data: data,
        contentType: false,
        processData: false,
        success: function (data) {
            console.log(data.dbPath);
            $("#PhotoURL").val(data);

        },
        error: function () {
            alert("Error Uploading Photo ");
        }
    });


});