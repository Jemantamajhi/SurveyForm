/*$(document).ready(function () {
    $('#state').prop('disabled', true);
    $('#city').prop('disabled', true);
    LoadStates();

    $('#state').change(function () {
        var StateId = $(this).val();
        if (StateId > 0) {
            LoadCities(StateId);
        }
        else {
            alert("Select State");
            $('#city').empty().prop('disabled', true).append('<option>Select City</option>');
        }
    });
});

function LoadStates() {
    $('#state').empty();
    $.ajax({
        url: '/DropDown/GetStates',
       
        success: function (response) {
            if (response != null && response.length > 0) {
                $('#state').prop('disabled', false);
                $('#state').append('<option>Select State</option>');
                $('#city').append('<option>Select City</option>');
                $.each(response, function (i, data) {
                    $('#state').append('<option value=' + data.id + '>' + data.name + '</option>');
                });
            }
            else {
                $('#state').prop('disabled', true);
                $('#city').prop('disabled', true);
                $('#state').append('<option>States Not Available</option>');
                $('#city').append('<option>Cities Not Available</option>');
            }
        },
        error: function (error) {
            alert(error);
        }
    });
}

function LoadCities(StateId) {
    $('#city').empty();
    $.ajax({
        url: '/DropDown/GetCities?id=' + StateId,
        success: function (response) {
            if (response != null && response.length > 0) {
                $('#city').prop('disabled', false);
                $('#city').append('<option>Select City</option>');
                $.each(response, function (i, data) {
                    $('#city').append('<option value=' + data.id + '>' + data.name + '</option>');
                });
            }
            else {
                $('#city').prop('disabled', true);
                $('#city').append('<option>Cities Not Available</option>');
            }
        },
        error: function (error) {
            alert(error);
        }
    });
}
*/