/// <reference path="_allProduct.ts"/>
var NorthwindStore;
(function (NorthwindStore) {
    var Admin;
    (function (Admin) {
        var Products;
        (function (Products) {
            var ProductController = (function () {
                function ProductController($scope, repository, _) {
                    "use strict";
                    this.scope = $scope;
                    this.repository = repository;
                    this._ = _;
                    this.scope.getAll = $.proxy(this.getAll, this);
                    this.scope.getById = this.getById;
                    this.scope.items = [];
                    this.getAll();
                }
                ProductController.prototype.getAll = function () {
                    var callbackProxy = $.proxy(this.getAllCallback, this);
                    this.repository.getProducts().then(callbackProxy);
                };
                ProductController.prototype.getAllCallback = function (data) {
                    this._.each(data.data, this.addToScope, this);
                };
                ProductController.prototype.addToScope = function (item) {
                    var viewModelItem;
                    this.scope.items.push(item);
                };
                ProductController.prototype.getById = function () {
                    this.repository.getProducts();
                };
                ProductController.$inject = ["$scope", "ProductRepository", "underscore"];
                return ProductController;
            })();
            Products.ProductController = ProductController;
            var ProductViewModel = (function () {
                function ProductViewModel() {
                }
                return ProductViewModel;
            })();
            Products.ProductViewModel = ProductViewModel;
        })(Products = Admin.Products || (Admin.Products = {}));
    })(Admin = NorthwindStore.Admin || (NorthwindStore.Admin = {}));
})(NorthwindStore || (NorthwindStore = {}));
//# sourceMappingURL=ProductController.js.map