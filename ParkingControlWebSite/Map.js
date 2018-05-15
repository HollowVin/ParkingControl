var map, infoWindow, pos;
var cuenca = { lat: -2.897409, lng: -79.004473 };
var objeto = getAllUrlParams();
var lati = objeto.par_lat;
var longi = objeto.par_long;
var azogues = { lat: parseFloat(lati), lng: parseFloat(longi)};

function getAllUrlParams(url) {

    // get query string from url (optional) or window
    var queryString = url ? url.split('?')[1] : window.location.search.slice(1);

    // we'll store the parameters here
    var obj = {};

    // if query string exists
    if (queryString) {

        // stuff after # is not part of query string, so get rid of it
        queryString = queryString.split('#')[0];

        // split our query string into its component parts
        var arr = queryString.split('&');

        for (var i = 0; i < arr.length; i++) {
            // separate the keys and the values
            var a = arr[i].split('=');

            // in case params look like: list[]=thing1&list[]=thing2
            var paramNum = undefined;
            var paramName = a[0].replace(/\[\d*\]/, function (v) {
                paramNum = v.slice(1, -1);
                return '';
            });

            // set parameter value (use 'true' if empty)
            var paramValue = typeof (a[1]) === 'undefined' ? true : a[1];

            // (optional) keep case consistent
            paramName = paramName.toLowerCase();
            paramValue = paramValue.toLowerCase();

            // if parameter name already exists
            if (obj[paramName]) {
                // convert value to array (if still string)
                if (typeof obj[paramName] === 'string') {
                    obj[paramName] = [obj[paramName]];
                }
                // if no array index number specified...
                if (typeof paramNum === 'undefined') {
                    // put the value on the end of the array
                    obj[paramName].push(paramValue);
                }
                // if array index number specified...
                else {
                    // put the value at that index number
                    obj[paramName][paramNum] = paramValue;
                }
            }
            // if param name doesn't exist yet, set it
            else {
                obj[paramName] = paramValue;
            }
        }
    }

    return obj;
}

function initMap()
{

    //Mapa centrado en Cuenca
    var directionsDisplay = new google.maps.DirectionsRenderer;
    var directionsService = new google.maps.DirectionsService;
    map = new google.maps.Map(document.getElementById('map_populate'),
    {
        center: cuenca,
        zoom: 12,
        mapTypeId:'roadmap',
        styles:
        [
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
            pos =
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

    //Obtiene las imagenes para los marcadores personalizados
    var iconBase = 'https://maps.google.com/mapfiles/kml/shapes/';
    var icons =
    {
        parking:
        {
            icon: iconBase + 'parking_lot_maps.png'
        }
    };

    //Ingresa las coordenadas para los marcadores
    var features =
    [
        {
            position: new google.maps.LatLng(-2.897409, -79.004473),
            type: 'parking'
        }
    ];

    // Crea los marcadores de parqueaderos.
    features.forEach(function (feature)
    {
        var marker = new google.maps.Marker
        ({
            position: feature.position,
            icon: icons[feature.type].icon,
            map: map
        });
    });
}

//Metodo encargado de calcular la ruta del currentLocation al parkeadero
function calculateAndDisplayRoute(directionsService, directionsDisplay)
{
    //document.write(cuenca);
    directionsService.route
        ({
            origin: pos,
            destination: azogues,
            travelMode: 'DRIVING'
        },
        function (response, status)
        {
            if (status === 'OK')
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