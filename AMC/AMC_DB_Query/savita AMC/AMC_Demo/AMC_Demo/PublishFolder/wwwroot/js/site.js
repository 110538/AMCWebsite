

// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function displayDetails(keysArray) {
    if ($.fn.DataTable.isDataTable('#statusTable')) {
        table.destroy();
    }
    keyTable = $('<table class="display" id="statusTable" style="width:100%">');
    var thead = $('<thead>');
    var tr = $('<tr>')/*.append('<th data-sort="name" class="tooltipPoint clickable"> Id </th>')*/.append('<th data-sort="name" class="tooltipPoint clickable"> Name </th>').append('<th data-sort="date" class="tooltipPoint clickable"> Developement </th>').append('<th data-sort="date" class="tooltipPoint clickable"> Testing </th>').append('<th data-sort="date" class="tooltipPoint clickable"> Staging </th>').append('<th data-sort="date" class="tooltipPoint clickable"> Production </th>');
    thead.append(tr);
    keyTable.append(thead);
    if (keysArray.length > 0) {
        var tbody = $('<tbody>');
        for (var i = 0; i < keysArray.length; i++) {
            tr = $('<tr>');
            //tr.append('<td>' + keysArray[i].id + '</td>');
            tr.append('<td>' + keysArray[i].ui + '</td>');
            if (keysArray[i].developement)
                tr.append('<td class="success-working"> <i class="fa fa-check" ></i> </td>');
            else
                tr.append('<td class="failed-working"> <i class="fa fa-remove" ></i> </td>');
            if (keysArray[i].testing)
                tr.append('<td class="success-working"> <i class="fa fa-check" ></i> </td>');
            else
                tr.append('<td class="failed-working"><i class="fa fa-remove" ></i></td>');
            if (keysArray[i].staging)
                tr.append('<td class="success-working"> <i class="fa fa-check" ></i> </td>');
            else
                tr.append('<td class="failed-working"><i class="fa fa-remove" ></i></td>');
            if (keysArray[i].production)
                tr.append('<td class="success-working"> <i class="fa fa-check" ></i> </td>');
            else
                tr.append('<td class="failed-working"><i class="fa fa-remove" ></i></td>');

            tbody.append(tr);
        }
        keyTable.append(tbody);
    }

    $("#statusTable").replaceWith(keyTable);
    table = $('#statusTable').DataTable({
        "pagingType": "full_numbers"
    });
}


function getStatus() {
    $("#loader").show();
    $.ajax({
        type: "POST",
        async: true,
        contentType: "application/json; charset=UTF-8",
        data: {},
        url: "/AMCDevOps/getDevOpsStatus"
    })
        .done(function (state) {
            $("#loader").hide();
            updateTimer();
            if (state.result === true) {
                if ($.isArray(state.message)) {
                    displayDetails(state.message);
                    //window.location.reload();

                }
            } else if (state.result === false) {
                $("#statusTable").replaceWith('<p>' + status.message + '</p>');
            }
        })
        .fail(function (error) {
            $("#statusTable").replaceWith('<p>' + error + '</p>');
            updateTimer();
        });
    setTimeout(function () { getStatus(); }, 30 * 60 * 1000);// call for every 30 mins //Update time in site.js as well for timer
}

var timeToRefresh = 30 * 60; // replace value based on how frequent api is called
var mins_left = Math.floor(timeToRefresh / 60);

function updateTimer() {
    document.getElementById('timer_div').innerHTML = --mins_left;
    if (mins_left <= 5)
        $('#timer_div').css('color', 'red');
    else
        $('#timer_div').css('color', 'black');
    if (mins_left <= 0) {
        mins_left = Math.floor(timeToRefresh / 60);
    }
    setTimeout(function () { updateTimer(); }, 60 * 1000);// call for every 1 min
}