var map, infoWindow, pos;
var cuenca = { lat: -2.897409, lng: -79.004473 };
var azogues = { lat: -2.744761, lng: -78.847598 };
function initMap()
{
    //Mapa centrado en Cuenca
    var directionsDisplay = new google.maps.DirectionsRenderer;
    var directionsService = new google.maps.DirectionsService;
    map = new google.maps.Map(document.getElementById('map_populate'),
    {
        center: cuenca,
        zoom: 17,
        mapTypeId:'roadmap',
            styles: [
                { elementType: 'geometry', stylers: [{ color: '#242f3e' }] },
                { elementType: 'labels.text.stroke', stylers: [{ color: '#242f3e' }] },
                { elementType: 'labels.text.fill', stylers: [{ color: '#746855' }] },
                {
                    featureType: 'administrative.locality',
                    elementType: 'labels.text.fill',
                    stylers: [{ color: '#d59563' }]
                },
                {
                    featureType: 'poi',
                    elementType: 'labels.text.fill',
                    stylers: [{ color: '#d59563' }]
                },
                {
                    featureType: 'poi.park',
                    elementType: 'geometry',
                    stylers: [{ color: '#263c3f' }]
                },
                {
                    featureType: 'poi.park',
                    elementType: 'labels.text.fill',
                    stylers: [{ color: '#6b9a76' }]
                },
                {
                    featureType: 'road',
                    elementType: 'geometry',
                    stylers: [{ color: '#38414e' }]
                },
                {
                    featureType: 'road',
                    elementType: 'geometry.stroke',
                    stylers: [{ color: '#212a37' }]
                },
                {
                    featureType: 'road',
                    elementType: 'labels.text.fill',
                    stylers: [{ color: '#9ca5b3' }]
                },
                {
                    featureType: 'road.highway',
                    elementType: 'geometry',
                    stylers: [{ color: '#746855' }]
                },
                {
                    featureType: 'road.highway',
                    elementType: 'geometry.stroke',
                    stylers: [{ color: '#1f2835' }]
                },
                {
                    featureType: 'road.highway',
                    elementType: 'labels.text.fill',
                    stylers: [{ color: '#f3d19c' }]
                },
                {
                    featureType: 'transit',
                    elementType: 'geometry',
                    stylers: [{ color: '#2f3948' }]
                },
                {
                    featureType: 'transit.station',
                    elementType: 'labels.text.fill',
                    stylers: [{ color: '#d59563' }]
                },
                {
                    featureType: 'water',
                    elementType: 'geometry',
                    stylers: [{ color: '#17263c' }]
                },
                {
                    featureType: 'water',
                    elementType: 'labels.text.fill',
                    stylers: [{ color: '#515c6d' }]
                },
                {
                    featureType: 'water',
                    elementType: 'labels.text.stroke',
                    stylers: [{ color: '#17263c' }]
                }
            ]
        });

    infoWindow = new google.maps.InfoWindow;
    directionsDisplay.setMap(map);

    // Ubicacion del Usuario
    if (navigator.geolocation)
    {
        navigator.geolocation.getCurrentPosition(function (position)
        {
            var pos =
            {
                lat: position.coords.latitude,
                lng: position.coords.longitude
            };

            //Llama al metodo que calcula la ruta
            calculateAndDisplayRoute(directionsService, directionsDisplay);

            var marker = new google.maps.Marker
            ({
                position: pos,
                map: map
            });

            infoWindow.setPosition(pos);
            infoWindow.setContent('Usted está aquí.');
            infoWindow.open(map);
            map.setCenter(pos);
        },
        function ()
        {
            handleLocationError(true, infoWindow, map.getCenter());
        });
    }
    else
    {
        //En caso de que le navegador no soporte la geolocalizacion, lanza este error
        handleLocationError(false, infoWindow, map.getCenter());
    }
}

function calculateAndDisplayRoute(directionsService, directionsDisplay)
{
    directionsService.route
        ({
            origin: pos,
            destination: azogues,
            travelMode: 'DRIVING'
        },
        function (response, status)
        {
            if (status == 'OK')
            {
                directionsDisplay.setDirections(response);
            }
            else
            {
                window.alert('Directions request failed due to ' + status);
            }
        });
}

//HandleLocationError Ubicacion del Usuario
function handleLocationError(browserHasGeolocation, infoWindow, pos)
{
    infoWindow.setPosition(pos);
    infoWindow.setContent(browserHasGeolocation ?
        'Error: The Geolocation service failed.' :
        'Error: Your browser doesn\'t support geolocation.');
    infoWindow.open(map);
}