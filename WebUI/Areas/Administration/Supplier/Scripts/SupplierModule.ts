/// <reference path="_allSuppliers.ts"/>

module NorthwindStore.Admin.Supplier {
    var storeMVC = angular.module('NorthwindStore', ['Common'])
        .controller('SupplierController', SupplierRepository)
        .service('SupplierRepository', SupplierRepository);
}