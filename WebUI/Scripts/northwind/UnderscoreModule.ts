module Store {
    var underscore = angular.module('Common', [])
        .factory('underscore', [
            // The function (lambda) must return non null value

            // Else it will throw : 'must return $get'
        '$window', $window => $window._
    ]);
}