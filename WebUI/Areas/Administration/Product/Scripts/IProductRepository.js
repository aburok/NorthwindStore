/// <reference path="_allProduct.ts"/>
var NorthwindStore;
(function (NorthwindStore) {
    var Admin;
    (function (Admin) {
        var Products;
        (function (Products) {
            var ProductRepository = (function () {
                function ProductRepository($http) {
                    this.apiAddress = "/Administration/Product/";
                    this.getAllMethod = "GetProducts";
                    this.getByIdMethod = "GetByID";
                    this.http = $http;
                }
                ProductRepository.prototype.getProducts = function () {
                    var result = this.http.get(this.apiAddress + this.getAllMethod);
                    return result;
                };
                ProductRepository.prototype.getById = function (id) {
                    var result = this.http.get(this.apiAddress + this.getByIdMethod + "/" + id);
                    return result;
                };
                ProductRepository.$inject = ['$http'];
                return ProductRepository;
            })();
            Products.ProductRepository = ProductRepository;
        })(Products = Admin.Products || (Admin.Products = {}));
    })(Admin = NorthwindStore.Admin || (NorthwindStore.Admin = {}));
})(NorthwindStore || (NorthwindStore = {}));
//# sourceMappingURL=IProductRepository.js.map