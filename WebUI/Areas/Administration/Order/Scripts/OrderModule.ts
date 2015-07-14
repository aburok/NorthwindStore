module NorthwindStore.Admin.Order {

    var routes = (routeProvider: ng.route.IRouteProvider) => {
        routeProvider
            .when("/list",
            {
                templateUrl: "/Administration/Order/List",
                controller: Names.Administration.orderController
            })
            .when("/details/:orderId",
            {
                templateUrl: "/Administration/Order/Details",
                controller: Names.Administration.orderDetailsCtrl
            })
            .when("/edit/:orderId",
            {
                templateUrl: "/Administration/Order/Edit",
                controller: Names.Administration.orderDetailsCtrl
            })
            .when("/add",
            {
                templateUrl: "/Administration/Order/Edit",
                controller: Names.Administration.orderAddEditCtrl
            })
            .otherwise(
            {
                templateUrl: "/Administration/Order/List",
                controller: Names.Administration.orderController
            });
    };

    angular.module(Names.Administration.moduleName,
        [Names.Common.moduleName, Names.Angular.ngRoute])
        .service(Names.Administration.orderRepository, OrderRepository)
        .config([Names.Angular.routeProvider, routes])

        .controller(Names.Administration.orderController, OrderController)
        .controller(Names.Administration.orderDetailsCtrl, OrderDetailsController);
}