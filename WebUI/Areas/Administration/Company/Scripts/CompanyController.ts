
module NorthwindStore.Admin.Company {

    export class CompanyController {
        private _: UnderscoreStatic;
        private repository: ICompanyRepository;
        private scope: ICompanyScope;

        static $inject = [
            Common.Names.scope,
            Admin.Names.iCompanyRepositoryName,
            Common.Names.underscore];

        constructor($scope: ICompanyScope,
            repo: ICompanyRepository,
            _: UnderscoreStatic) {

            "use strict";

            this._ = _;
            this.repository = repo;
            this.scope = $scope;

            this.scope.companyList = [];

            this.getAll();
        }

        public getAll() {
            var callback = $.proxy(this.getAllCallback, this);

            this.repository.getComapanyList()
                .then(callback);
        }

        getAllCallback(data: ng.IHttpPromiseCallbackArg<CompanyDto[]>) {
            this._.each(
                data.data,
                this.addToScope,
                this);
        }

        private addToScope(item: CompanyDto) {
            var itemVm = new CompanyViewModel(item);
            this.scope.companyList.push(itemVm);
        }
    }

    export class CompanyViewModel {
        data: CompanyDto;
        isVisible: boolean;

        constructor(data: CompanyDto) {
            this.data = data;
            this.isVisible = true;
        }
    }

    export interface ICompanyScope extends ng.IScope {
        filterText: string;

        companyList: CompanyViewModel[];
    }
}