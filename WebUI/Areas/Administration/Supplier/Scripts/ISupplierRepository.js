/// <reference path="_allSuppliers.ts"/>
var NorthwindStore;
(function (NorthwindStore) {
    var Admin;
    (function (Admin) {
        var Suppliers;
        (function (Suppliers) {
            var SupplierRepository = (function () {
                function SupplierRepository() {
                }
                return SupplierRepository;
            })();
            Suppliers.SupplierRepository = SupplierRepository;
        })(Suppliers = Admin.Suppliers || (Admin.Suppliers = {}));
    })(Admin = NorthwindStore.Admin || (NorthwindStore.Admin = {}));
})(NorthwindStore || (NorthwindStore = {}));
//# sourceMappingURL=ISupplierRepository.js.map