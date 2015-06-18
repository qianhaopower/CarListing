
'use strict';

var application = angular.module('app');
application.controller('carDetailsCtrl', ['$scope', '$http','$location','$window','carSvc',
   function ($scope, $http, $location, $window, carSvc) {
       $scope.init = function (priceType, salesType, carId) {
           $scope.priceType = priceType;
           $scope.salesType = salesType;
           $scope.displayEGC = priceType == 'EGC';
           $scope.displayDAP = priceType == 'DAP';
           $scope.isPrivate = salesType == 'Private';
           $scope.isDelear = salesType == 'Dealer';

           $scope.carId = carId;
       }

       $scope.enquire =
           {
               EnquiryName: null,
               Email: null,
               Content: null,
               CarId: $scope.carId,
           };

       $scope.SaveEnquire = function (carId) {
           var protocol = $location.protocol();
           var host = $location.host();
           var port = $location.port();
           var url = protocol + '://' + host + ':' + port + '/Enquiry/Create';
           var thanksURL = protocol + '://' + host + ':' + port + '/Car/ThankYou';

           $scope.enquire.CarId = carId;

           carSvc.save(carId, $scope.enquire, url, thanksURL);
       }

       $scope.setForm = function (enquiryForm) {
           $scope.enquiryForm = enquiryForm;
       };

   }]
);

