
(function () {
    'use strict';

    angular
        .module('app')
        .factory('carSvc', CarSvc);

    CarSvc.$inject = ['$window', '$http', '$log'];

    function CarSvc($window, $http,$log) {
        var _save = function (carId, enquiry, createURL, thanksURL) {



            $http({
                url: createURL,
                method: "POST",
                data: enquiry
            })
     .then(function (response) {
         // success
         if (response.data == 'success') {
             $window.location.href = thanksURL;
         }
     },
     function (response) { // optional
         //log the error,
         $log.log(response);
     });
        }

        var service = {
            save: _save,
        };

        return service;
    }
})();