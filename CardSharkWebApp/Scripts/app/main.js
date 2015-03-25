(function () {
    var app = angular.module("CardSharkApp", ["ngRoute", "ngResource"])
    var baseUrl;

    app.config(function ($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: "/templates/Organization.html", controller: "OrganizationCtrl"
        });
        $routeProvider.when('/Organization/:orgID/Event', {
            templateUrl: "/templates/Event.html", controller: "OrganizationCtrl"
        });
        $routeProvider.when('/Organization/:orgID/Event/:eventID', {
            templateUrl: "/templates/Match.html", controller: "OrganizationCtrl"
        });

    });

    app.factory("OrganizationFactory", ["$resource", function ($resource) {
        return $resource("api/organization");
    }]);

    app.factory("EventFactory", ["$resource", function ($resource) {
        return $resource("api/organization/:org/event", {
            org: null
        });
    }]);

    app.factory("MatchFactory", ["$resource", function ($resource) {
        return $resource("api/organization/:org/event/:eve"), {
            org: null,
            eve: null
        };
    }]);

    app.service("OrganizationService", function () {

    });

    //{controller}/{action}/{id}

    app.controller("OrganizationCtrl", ["$scope", "OrganizationFactory", function ($scope, OrganizationFactory) {
        $scope.organizations = OrganizationFactory.query();
    }]);

    app.controller("EventCtrl", ["$scope", "$routeParams", "EventFactory", function ($scope, $routeParams, EventFactory) {
        $scope.events = EventFactory.query({ org: $routeParams.orgID }, function () {
            console.log($scope.events)
        });
    }]);

    app.controller("MatchCtrl", ["$scope", "MatchFactory", function ($scope, MatchFactory) {
        $scope.matches = MatchFactory.query();
    }]);
})();


//angular.module('OptimaList')
//.config(['$routeProvider', function ($routeProvider) {
//    $routeProvider
//    .when('/recipes/:id', {
//        controller: 'DetailsController',
//        templateUrl: '/Client/Views/detail.html'
//    });
//}])
//.controller('DetailsController', ['$scope', 'recipeService', '$routeParams',
//                          function ($scope, recipeService, $routeParams) {
//                              var id = $routeParams.id;
//                              recipeService.getRecipe(id).then(function (recipe) {
//                                  $scope.recipe = recipe;
//                              });
//                          }]);

//angular.module('WhereToApp', ['ngRoute', 'ngResource'])
//    .config(function ($routeProvider) {
//        $routeProvider.when("/ViewDestination", {
//            templateUrl: "/templates/ViewDestination.html", controller: "ViewCtrl"
//        });
//        $routeProvider.when("/AddDestination", {
//            templateUrl: "/templates/AddDestination.html", controller: "PlaceCtrl"
//        });
//        $routeProvider.when("/:id/edit", {
//            templateUrl: "/templates/EditDestination.html", controller: "EditCtrl"

//        })
//    })




//.factory('Products', ['$resource',
//    function($resource) {
//        return $resource('products/:productId', {
//            productId: '@id'
//        }, {
//            query: {
//                isArray: false
//            },
//            update: {
//                method: 'PUT'
//            }
//        });
//    }
//])
//The controller:

//    $scope.getProduct = function(id, from) {
//        $scope.product = Products.get({ id: id }, function(){
//            console.log($scope.product);
//        });
//    }