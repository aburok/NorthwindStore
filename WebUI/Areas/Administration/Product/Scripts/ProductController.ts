/// <reference path="_allProduct.ts"/>

module NorthwindStore.Admin.Products {

    export class ProductController {
        private repository: IProductRepository;
        private scope: IProductScope;
        _: UnderscoreStatic;

        static $inject = [Common.Names.scope,
            Admin.Names.productRepository,
            Common.Names.underscore];

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

            this.scope.$watch('filterText', $.proxy(this.filterByName, this));
        }

        private filterByName() {
            var predicateProxy = $.proxy(this.filterByNamePredicate, this);
            this.filter(predicateProxy);
        }

        private filterByNamePredicate(item: ProductViewModel): boolean {
            if (this.scope.filterText) {
                var filterText = this.scope.filterText.toLowerCase();
                var name = item.data.Name.toLowerCase();
                return name.indexOf(filterText) > -1;
            }
            return true;
        }

        private filter(predicate: (productViewModel: ProductViewModel) => boolean) {
            this._.each(this.scope.items,(item: ProductViewModel) => {
                item.isVisible = predicate(item);
            }, this);
        }

        public getAll() {
            var callbackProxy = $.proxy(this.getAllCallback, this);
            this.repository
                .getProducts()
                .then(callbackProxy);
        }

        getAllCallback(data: ng.IHttpPromiseCallbackArg<ProductDto[]>) {
            this._.each(
                data.data,
                this.addToScope,
                this);
        }

        private addToScope(item: ProductDto) {
            var itemVm = new ProductViewModel(item);
            this.scope.items.push(itemVm);
        }

        public getById() {
            this.repository.getProducts();
        }
    }

    export class ProductViewModel {
        public data: ProductDto;
        public isVisible: boolean;

        constructor(product: ProductDto) {
            this.data = product;
            this.isVisible = true;
        }
    }

    export interface IProductScope extends ng.IScope {
        items: ProductViewModel[];
        getAll: () => void;
        getById: () => void;
        filterText: string;
    }
}