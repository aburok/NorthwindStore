var Store;
(function (Store) {
    var ProductAdminController = (function () {
        function ProductAdminController($scope, repository) {
            this.scope = $scope;
            this.repository = repository;
            this.products = [];
        }
        ProductAdminController.prototype.getAll = function () {
            var _this = this;
            this.repository.getProducts().then(function (data) { return _this.scope.items = data; });
        };
        ProductAdminController.prototype.getById = function () {
            this.repository.getProducts();
        };
        return ProductAdminController;
    })();
    Store.ProductAdminController = ProductAdminController;
})(Store || (Store = {}));
//# sourceMappingURL=ProductAdminController.js.map