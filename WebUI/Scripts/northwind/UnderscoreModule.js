var Store;
(function (Store) {
    var underscore = angular.module('Common', []).factory('underscore', [
        '$window',
        function ($window) { return $window._; }
    ]);
})(Store || (Store = {}));
//# sourceMappingURL=UnderscoreModule.js.map