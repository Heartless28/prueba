function searchmethod(sch) {

    var baseURL = window.location.protocol + "//" + window.location.host + "/";
    $.ajax({
        type: "POST",
        url: baseURL + "Search/Index",
        cache: false,
        data: { sch: sch },
        success: function (data) {
            alert(data.d);
        },
       
    })


}