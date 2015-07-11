
module NorthwindStore.Admin.Company {

    export interface ICompanyRepository {
        getComapanyList(): ng.IHttpPromise<CompanyDto[]>;
    }

    export class CompanyRepository implements ICompanyRepository {

        private http: angular.IHttpService;

        private apiAddress: string = "/Administration/Company/GetCompanyList";

        static $inject = [Common.Names.http];

        constructor($http: ng.IHttpService) {
            this.http = $http;
        }

        getComapanyList() : ng.IHttpPromise<CompanyDto[]> {
            var promis = this.http.get<CompanyDto[]>(this.apiAddress);
            return promis;
        }
    }
}