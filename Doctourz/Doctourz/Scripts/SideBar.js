function loadHealthProfile() {
    $.ajax({
        url: '/User/getAppUser',
        type: 'GET',
        dataType: 'json',
        success: function (d) {
            $("#fName").val(d.firstName);
            $("#lName").val(d.lastName);
            $("#UsrName").html(d.name);
            $("#UsrGender").html(d.gender);
            if (d.gender == "Male") {
                $("#male").click()
            } else if (d.gender == "Female") {
                $("#female").click()
            }
            $("#UsrLocation").html(d.location);
            $("#location").val(d.location);
            var bDate = new Date(parseInt(d.birthDate.replace("/Date(", "").replace(")/", ""), 10)).toDateString();
            $("#UsrBirthDate").html(bDate);
            $("#birthDate").val(new Date(parseInt(d.birthDate.replace("/Date(", "").replace(")/", ""), 10)).toLocaleDateString());
            $("#UsrEthnicity").html(d.ethnicity);
            $("#UsrHeight").html(d.height);
            $("#UsrWeight").html(d.weight);
            $("#UsrBmi").html(d.bmi);

        },
        error: function (err) {
            console.log(err)
        }

    })
}

