
//var google;

//function init() {
//    // Basic options for a simple Google Map
//    // For more options see: https://developers.google.com/maps/documentation/javascript/reference#MapOptions
//    // var myLatlng = new google.maps.LatLng(40.71751, -73.990922);
//    var myLatlng = new google.maps.LatLng(28.6756909, 77.257445);
//    // 39.399872
//    // -8.224454
    
//    var mapOptions = {
//        // How zoomed in you want the map to start at (always required)
//        zoom: 7,

//        // The latitude and longitude to center the map (always required)
//        center: myLatlng,

//        // How you would like to style the map. 
//        scrollwheel: false,
//        styles: [{"featureType":"administrative.land_parcel","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"landscape.man_made","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"poi","elementType":"labels","stylers":[{"visibility":"off"}]},{"featureType":"road","elementType":"labels","stylers":[{"visibility":"simplified"},{"lightness":20}]},{"featureType":"road.highway","elementType":"geometry","stylers":[{"hue":"#f49935"}]},{"featureType":"road.highway","elementType":"labels","stylers":[{"visibility":"simplified"}]},{"featureType":"road.arterial","elementType":"geometry","stylers":[{"hue":"#fad959"}]},{"featureType":"road.arterial","elementType":"labels","stylers":[{"visibility":"off"}]},{"featureType":"road.local","elementType":"geometry","stylers":[{"visibility":"simplified"}]},{"featureType":"road.local","elementType":"labels","stylers":[{"visibility":"simplified"}]},{"featureType":"transit","elementType":"all","stylers":[{"visibility":"off"}]},{"featureType":"water","elementType":"all","stylers":[{"hue":"#a1cdfc"},{"saturation":30},{"lightness":49}]}]
//    };

    

//    // Get the HTML DOM element that will contain your map 
//    // We are using a div with id="map" seen below in the <body>
//    var mapElement = document.getElementById('map');

//    // Create the Google Map using out element and options defined above
//    var map = new google.maps.Map(mapElement, mapOptions);
    
//    var addresses = ['Brooklyn'];

//    for (var x = 0; x < addresses.length; x++) {
//        $.getJSON('http://maps.googleapis.com/maps/api/geocode/json?address='+addresses[x]+'&sensor=false', null, function (data) {
//            var p = data.results[0].geometry.location
//            var latlng = new google.maps.LatLng(p.lat, p.lng);
//            new google.maps.Marker({
//                position: latlng,
//                map: map,
//                icon: 'images/loc.png'
//            });

//        });
//    }
    
//}
//google.maps.event.addDomListener(window, 'load', init);

window.onload = function () {
    var mapOptions = {
        center: new google.maps.LatLng(28.6756909, 77.257445),
        zoom:1,
        zoomControl: true,
        zoomControlOptions: {
            style: google.maps.ZoomControlStyle.DEFAULT,
        },
        disableDoubleClickZoom: true,
        mapTypeControl: false,
        scaleControl: true,
        scrollwheel: true,
        panControl: true,
        streetViewControl: true,
        draggable: true,
        overviewMapControl: true,
        overviewMapControlOptions: {
            opened: false,
        },
        mapTypeId: google.maps.MapTypeId.ROADMAP,
        styles: [
            {
                "featureType": "administrative",
                "elementType": "labels",
                "stylers": [
                    {
                        "visibility": "off"
                    }
                ]
            },
        ],
    }

    var infoWindow = new google.maps.InfoWindow();
    //var mapOptions = {
    //   // mapTypeId: google.maps.MapTypeId.ROADMAP,
    //    disableDefaultUI: true,
    //    zoom: 2,
    //};
    var map = new google.maps.Map(document.getElementById("map"), mapOptions);
    var icon = "";
    var latlngbounds = new google.maps.LatLngBounds();
  
        url: 'http://maps.google.com/mapfiles/ms/icons/blue-dot.png'
        var myLatlng = new google.maps.LatLng(28.6756909, 77.257445);
        var marker = new google.maps.Marker({
            position: myLatlng,
            map: map,
            icon: 'http://maps.google.com/mapfiles/ms/icons/blue-dot.png',
            label: {
                text: 'Srv',
                fontSize: "10px",
                color: 'Black',
                font: 'bold 50px',
                size: '5px',

            },
            title: 'Srv'
        });
        //(function (marker, data) {
        //    google.maps.event.addListener(marker, "click", function (e) {
        //        GetSiteDetails(data.title, data.FacilityID, data.PostalCode);
        //    });
        //})(marker, data);
        //Extend each marker's position in LatLngBounds object.
        latlngbounds.extend(marker.position);
   // }
    //Get the boundaries of the Map.
    var bounds = new google.maps.LatLngBounds();

    //Center map and adjust Zoom based on the position of all markers.
    map.setCenter(latlngbounds.getCenter());
    map.fitBounds(latlngbounds);
}