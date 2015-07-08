var Store;
(function (Store) {
    var ProductRepository = (function () {
        function ProductRepository($http) {
            this.apiAddress = "api/Administration/ProductAdminApi/";
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
        ProductRepository.$inject = [];
        return ProductRepository;
    })();
    Store.ProductRepository = ProductRepository;
})(Store || (Store = {}));
//# sourceMappingURL=IProductRepository.js.map