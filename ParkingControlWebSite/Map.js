//var mapcode;
//var diag;
//function initialize()
//{
//    mapcode = new google.maps.geocoder();
//    var lnt = new google.maps.latlng(-2.897409, -79.004473);

//    var diagchoice =
//        {
//            zoom: 14,
//            center: lnt,
//            diagid: google.maps.maptypeid.roadmap
//        };

//    diag = new google.maps.map(document.getelementbyid('map_populate'), diagchoice);
//}
//google.maps.event.adddomlistener(window, 'load', initialize);

var map, infoWindow;
function initMap() {
    map = new google.maps.Map(document.getElementById('map_populate'), {
        center: { lat: -2.897409, lng: -79.004473 },
        zoom: 14
    });
    infoWindow = new google.maps.InfoWindow;

    // Try HTML5 geolocation.
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            var pos = {
                lat: position.coords.latitude,
                lng: position.coords.longitude
            };

            infoWindow.setPosition(pos);
            infoWindow.setContent('Location found.');
            infoWindow.open(map);
            map.setCenter(pos);
        }, function () {
            handleLocationError(true, infoWindow, map.getCenter());
        });
    } else {
        // Browser doesn't support Geolocation
        handleLocationError(false, infoWindow, map.getCenter());
    }
}

function handleLocationError(browserHasGeolocation, infoWindow, pos) {
    infoWindow.setPosition(pos);
    infoWindow.setContent(browserHasGeolocation ?
        'Error: The Geolocation service failed.' :
        'Error: Your browser doesn\'t support geolocation.');
    infoWindow.open(map);
}