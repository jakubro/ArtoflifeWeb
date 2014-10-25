var latlng = new google.maps.LatLng(53.3328057, -6.2634385);
var options = {
   zoom: 18,
   center: latlng,
   scrollwheel: false,
   disableDefaultUI: true,
   panControl: true,
   zoomControl: true,
   mapTypeControl: false,
   scaleControl: true,
   streetViewControl: true,
   overviewMapControl: true,
   mapTypeId: google.maps.MapTypeId.ROADMAP
};
var map = new google.maps.Map(document.getElementById("map-canvas"), options);
var marker = new google.maps.Marker({
   position: latlng,
   map: map
});

window.artOfLife.skrollr = skrollr.init({
   easing: {
      quickSqrt: function(p) {
         return Math.pow(p, 2 / 3);
      }
   },
   mobileCheck: function() {
      return false;
   }
});

$(document).ready(function() {
   skrollr.menu.init(window.artOfLife.skrollr, {
      animate: true,
      easing: 'quickSqrt',
      duration: function(currentTop, targetTop) {
         return Math.abs(currentTop - targetTop) * 1.3;
      },
      handleLink: function(link) {
         var href = $(link).attr('href');
         return $(href).offset().top;
      }
   });
});