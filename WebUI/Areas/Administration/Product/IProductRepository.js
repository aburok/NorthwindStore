var Store;
(function (Store) {
    var ProductRepository = (function () {
        function ProductRepository() {
        }
        ProductRepository.prototype.GetProducts = function () {
            throw new Error("Not implemented");
        };
        ProductRepository.$inject = [];
        return ProductRepository;
    })();
    Store.ProductRepository = ProductRepository;
})(Store || (Store = {}));
//# sourceMappingURL=IProductRepository.js.map