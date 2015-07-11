/// <reference path="_allProduct.ts"/>

module NorthwindStore.Admin.Products {
    var storeMVC = angular.module(
        Admin.Names.moduleName,
        [Common.Names.moduleName])
        .controller(Admin.Names.productController, ProductController)
        .service(Admin.Names.productRepository, ProductRepository);
}