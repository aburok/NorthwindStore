module NorthwindStore.Admin.Order {
    export class OrderController {

        private _: UnderscoreStatic;
        private repository: IOrderRepository;
        private scope: IOrderScope;
        private location: ng.ILocationService;

        static $inject = [
            Names.Angular.scope,
            Names.Angular.location,

            Names.Administration.orderRepository,
            Names.Common.underscore];

        constructor($scope: IOrderScope,
            location: ng.ILocationService,
            repository: IOrderRepository,
            _: UnderscoreStatic) {
            this._ = _;
            this.repository = repository;
            this.location = location;

            this.setupScope($scope);

            this.getAll();
        }

        private setupScope($scope: IOrderScope) {
            this.scope = $scope;

            this.scope.orderList = [];

            this.scope.showDetails = (data: OrderViewModel) => {
                var id = data.data.Id;
                this.location.path("/details/" + id);
            }
        }

        getAll() {
            var callback = $.proxy(this.getAllCallback, this);
            this.repository.getAllItems()
                .then(callback);
        }

        getAllCallback(data: ng.IHttpPromiseCallbackArg<OrderDto[]>) {
            this._.each(data.data,
                (item: OrderDto) => {
                    var viewModel = new OrderViewModel(item);
                    this.scope.orderList.push(viewModel);
                },
                this);
        }
    }

    export class OrderViewModel {
        data: OrderDto;
        isVisible: boolean = true;

        constructor(data: OrderDto) {
            this.data = data;
            this.isVisible = true;
        }
    }

    export interface IOrderScope extends ng.IScope {
        orderList: OrderViewModel[];
        showDetails(item: OrderViewModel);
    }
}