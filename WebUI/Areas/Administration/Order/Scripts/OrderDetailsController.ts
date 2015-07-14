module NorthwindStore.Admin.Order {
    export class OrderDetailsController {
        private repository: Order.IOrderRepository;
        private params: IOrderDetailsParams;
        private $scope: IOrderDetailsScope;

        static $inject = [Names.Angular.scope,
            Names.Angular.routeParams,
            Names.Administration.orderRepository];

        constructor($scope: IOrderDetailsScope,
            $routeParams: IOrderDetailsParams,
            repository: IOrderRepository) {

            this.repository = repository;
            this.params = $routeParams;
            this.$scope = $scope;

            var id = this.params.orderId;

            var callback = $.proxy((data: angular.IHttpPromiseCallbackArg<OrderDto>) => {
                this.$scope.order = data.data;
            }, this);

            repository.getItem(id)
                .then(callback);
        }
    }

    export interface IOrderDetailsParams extends angular.route.IRouteParamsService {
        orderId: string;
    }

    export interface IOrderDetailsScope extends angular.IScope {
        order: OrderDto;
    }
}