
module NorthwindStore.Admin.Company {

    export interface ICompanyRepository {
        getAllItems(): ng.IHttpPromise<CompanyDto[]>;
    }

    export class CompanyRepository
        extends Admin.BaseRepository<CompanyDto>
        implements ICompanyRepository {

        static $inject = [Names.Angular.http];

        constructor($http: ng.IHttpService) {
            super($http);
            this.apiAddress = "/Administration/Company/";
            this.getAllMethodName = "GetCompanyList";
        }
    }
}