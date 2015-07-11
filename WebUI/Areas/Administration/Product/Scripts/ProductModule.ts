/// <reference path="_allProduct.ts"/>

module NorthwindStore.Admin.Products {
    var storeMVC = angular.module('NorthwindStore', ['Common'])
        .controller("ProductController", ProductController)
        .service("ProductRepository", ProductRepository);
}