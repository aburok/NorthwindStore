/// <reference path="_allProduct.ts"/>

module NorthwindStore.Admin.Products {
    import HttpPromiseCallbackArg = angular.IHttpPromiseCallbackArg;

    export class ProductController {
        private repository: IProductRepository;
        private scope: IProductScope;
        _: UnderscoreStatic;

        static $inject = ["$scope", "ProductRepository", "underscore"];

        constructor($scope: IProductScope,
            repository: IProductRepository,
            _: UnderscoreStatic) {
            "use strict";
            this.scope = $scope;
            this.repository = repository;
            this._ = _;

            this.scope.getAll = $.proxy(this.getAll, this);
            this.scope.getById = this.getById;
            this.scope.items = [];

            this.getAll();
        }

        public getAll() {
            var callbackProxy = $.proxy(this.getAllCallback, this);
            this.repository
                .getProducts()
                .then(callbackProxy);
        }

        getAllCallback(data: HttpPromiseCallbackArg<ProductDto[]>) {
            this._.each(
                data.data,
                this.addToScope,
                this);
        }

        private addToScope(item: ProductDto) {
            var viewModelItem
            this.scope.items.push(item);
        }

        public getById() {
            this.repository.getProducts();
        }
    }

    export class ProductViewModel {
        //constructor(Productdto product) {
            
        //}
        public item: ProductDto;
        public isVisible: boolean;
    }

    export interface IProductScope extends ng.IScope {
        items: Products.ProductDto[];
        getAll: () => void;
        getById: () => void;
        filterText: string;
    }
}