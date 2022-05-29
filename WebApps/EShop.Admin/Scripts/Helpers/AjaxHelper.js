
const fetchApi = (uri, method = "GET", data = {}) => {
    return $.ajax({
        type: method,
        url: uri,
        contentType: "application/json;charset=utf-8",
        data: data ? JSON.stringify(data) : null,
    }).success(() => {
        //method === 'GET' ? null : toastr.success("Done");
        console.log("Done");
    }).fail(error => {
     
        console.error(error);
    });
}