/// <reference path="_allSuppliers.ts"/>

module NorthwindStore.Admin.Suppliers {
    var storeMVC = angular.module('NorthwindStore', ['Common'])
        .controller('SupplierController', ProductController)
        .service('SupplierRepository', ProductRepository);
}