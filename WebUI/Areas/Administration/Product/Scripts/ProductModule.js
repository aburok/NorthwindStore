/// <reference path="_allProduct.ts"/>
var NorthwindStore;
(function (NorthwindStore) {
    var Admin;
    (function (Admin) {
        var Products;
        (function (Products) {
            var storeMVC = angular.module('NorthwindStore', ['Common']).controller('ProductController', Products.ProductController).service('ProductRepository', Products.ProductRepository);
        })(Products = Admin.Products || (Admin.Products = {}));
    })(Admin = NorthwindStore.Admin || (NorthwindStore.Admin = {}));
})(NorthwindStore || (NorthwindStore = {}));
//# sourceMappingURL=ProductModule.js.map