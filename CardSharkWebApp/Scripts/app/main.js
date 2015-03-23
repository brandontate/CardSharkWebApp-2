(function () {
    var app = angular.module("CardSharkApp", ["ngResource"])

    app.factory("OrganizationFactory", ["$resource", function ($resource) {
        return $resource("api/organization/list");
    }]);

    app.factory("EventFactory", ["$resource", function ($resource) {
        return $resource("api/event/:id");
    }]);

    app.factory("MatchFactory", ["$resource", function ($resource) {
        return $resource("api/match/:id");
    }]);

    //{controller}/{action}/{id}

    app.controller("OrganizationCtrl", ["$scope", "OrganizationFactory", function ($scope, OrganizationFactory) {
        $scope.organizations = OrganizationFactory.query();
    }]);

    app.controller("EventCtrl", ["$scope", "EventFactory", function ($scope, EventFactory) {
        $scope.events = EventFactory.query();
    }]);

    app.controller("MatchCtrl", ["$scope", "MatchFactory", function ($scope, MatchFactory) {
        $scope.matches = MatchFactory.query();
    }]);
})();