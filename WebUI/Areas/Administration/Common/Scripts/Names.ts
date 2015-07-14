
// Names need to be in separate file to be referenced before other page specific scripts
// TODO : maybe there is a better way

module Names {
    export class Administration {
        static moduleName = "NorthwindStore";
        static iCompanyRepositoryName = "CompanyRepository";
        static iCompanyCtrl = "CompanyController";

        static productRepository = "ProductRepository";
        static productController = "ProductController";

        static orderController = "OrderController";
        static orderRepository = "OrderRepository";

        static orderDetailsCtrl = "OrderDetailsController";

        static orderAddEditCtrl = "OrderAddEditController";

    }
}
