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
                    this.scope.$watch('filterText', $.proxy(this.filterByName, this));
                }
                ProductController.prototype.filterByName = function () {
                    var predicateProxy = $.proxy(this.filterByNamePredicate, this);
                    this.filter(predicateProxy);
                };
                ProductController.prototype.filterByNamePredicate = function (item) {
                    if (this.scope.filterText) {
                        var filterText = this.scope.filterText.toLowerCase();
                        var name = item.data.Name.toLowerCase();
                        return name.indexOf(filterText) > -1;
                    }
                    return true;
                };
                ProductController.prototype.filter = function (predicate) {
                    this._.each(this.scope.items, function (item) {
                        item.isVisible = predicate(item);
                    }, this);
                };
                ProductController.prototype.getAll = function () {
                    var callbackProxy = $.proxy(this.getAllCallback, this);
                    this.repository.getProducts().then(callbackProxy);
                };
                ProductController.prototype.getAllCallback = function (data) {
                    this._.each(data.data, this.addToScope, this);
                };
                ProductController.prototype.addToScope = function (item) {
                    var itemVm = new ProductViewModel(item);
                    this.scope.items.push(itemVm);
                };
                ProductController.prototype.getById = function () {
                    this.repository.getProducts();
                };
                ProductController.$inject = ["$scope", "ProductRepository", "underscore"];
                return ProductController;
            })();
            Products.ProductController = ProductController;
            var ProductViewModel = (function () {
                function ProductViewModel(product) {
                    this.data = product;
                    this.isVisible = true;
                }
                return ProductViewModel;
            })();
            Products.ProductViewModel = ProductViewModel;
        })(Products = Admin.Products || (Admin.Products = {}));
    })(Admin = NorthwindStore.Admin || (NorthwindStore.Admin = {}));
})(NorthwindStore || (NorthwindStore = {}));
//# sourceMappingURL=ProductController.js.map