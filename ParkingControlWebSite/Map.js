var mapcode;
var diag;
function initialize()
{
    mapcode = new google.maps.Geocoder();
    var lnt = new google.maps.LatLng(-2.897409, -79.004473);

    var diagChoice =
        {
            zoom: 14,
            center: lnt,
            diagId: google.maps.MapTypeId.ROADMAP
        };

    diag = new google.maps.Map(document.getElementById('map_populate'), diagChoice);
}
google.maps.event.addDomListener(window, 'load', initialize);

function getmap(location)
{
    if (location = undefined)
    {
        location= 'Cuenca'
    }

    var completeaddress = document.getElementById(location).value;
    mapcode.geocode({ 'address': completeaddress },
    function (results, status)
    {
        if (status === google.maps.GeocoderStatus.OK)
        {
            diag.setCenter(results[0].geometry.location);
            var hint = new google.maps.Marker({ diag: diag, position: results[0].geometry.location });
        }
        else
        {
            alert('Location Not Tracked. ' + status);
        }
    });
}
google.maps.event.addDomListener(window, 'load', initialize);