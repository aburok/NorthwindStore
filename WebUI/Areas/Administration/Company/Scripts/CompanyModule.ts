/// <reference path="_allCompany.ts"/>

module NorthwindStore.Admin.Company {

    var store = angular.module('NorthwindStore', ['Common'])
        //.controller(Admin.iCompanyCtrl, CompanyController)
        .service("CompanyRepository", CompanyRepository)
        .controller("CompanyController", CompanyController);
    //.service(Admin.iCompanyRepository, CompanyRepository);
}