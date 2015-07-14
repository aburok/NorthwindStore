
module NorthwindStore.Admin.Company {
    angular.module(Names.Administration.moduleName, [Names.Common.moduleName])
        .service(Names.Administration.iCompanyRepositoryName, CompanyRepository)
        .controller(Names.Administration.iCompanyCtrl, CompanyController);
}