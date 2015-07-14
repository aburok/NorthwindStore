/// <reference path="_allProduct.ts"/>

module NorthwindStore.Admin.Products {
    var storeMVC = angular.module(
        Names.Administration.moduleName,
        [Names.Common.moduleName])
        .controller(Names.Administration.productController, ProductController)
        .service(Names.Administration.productRepository, ProductRepository);
}