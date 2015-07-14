module NorthwindStore.Admin.Order {
    export interface IOrderRepository {
        getAllItems(): angular.IHttpPromise<OrderDto[]>;
        getItem(id:string):angular.IHttpPromise<OrderDto>;
    }

    export class OrderRepository
        extends BaseRepository<OrderDto>
        implements IOrderRepository {

        static $inject = [Names.Angular.http];

        constructor($http: ng.IHttpService) {
            super($http);

            this.apiAddress = "/Administration/Order/";
            this.getAllMethodName = "GetOrderList";
            this.getItemMethodName = "GetOrder";
        }
    }
}