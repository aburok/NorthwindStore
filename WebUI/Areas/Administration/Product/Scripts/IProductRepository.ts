/// <reference path="_allProduct.ts"/>

module NorthwindStore.Admin.Products {

    export interface IProductRepository {
        getProducts(): ng.IPromise<ProductDto[]>;

        getById(id: number): ng.IPromise<ProductDto>;
    }

    export class ProductRepository implements IProductRepository {

        apiAddress: string = "/Administration/Product/";
        getAllMethod: string = "GetProducts";
        getByIdMethod: string = "GetByID";

        http: ng.IHttpService;

        static $inject = [Common.Names.http];

        constructor($http: ng.IHttpService) {
            this.http = $http;
        }

        getProducts(): ng.IHttpPromise<ProductDto[]> {
            var result = this.http
                .get<ProductDto[]>(this.apiAddress + this.getAllMethod);
            return result;
        }

        getById(id: number): angular.IPromise<ProductDto> {
            var result = this.http
                .get(this.apiAddress + this.getByIdMethod + "/" + id);

            return result;
        }
    }
} 