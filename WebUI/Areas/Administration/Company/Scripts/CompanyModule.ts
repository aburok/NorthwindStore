/// <reference path="_allCompany.ts"/>

module NorthwindStore.Admin.Company {
    angular.module(Admin.Names.moduleName, [Common.Names.moduleName])
        .service(Admin.Names.iCompanyRepositoryName, CompanyRepository)
        .controller(Admin.Names.iCompanyCtrl, CompanyController);
}