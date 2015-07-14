module NorthwindStore.Admin {
    export class BaseRepository<T> {

        protected http: angular.IHttpService;

        protected apiAddress: string;
        protected getAllMethodName: string;
        protected getItemMethodName: string;

        constructor($http: ng.IHttpService) {
            this.http = $http;
        }

        getAllItems(): angular.IHttpPromise<T[]> {
            if (!this.apiAddress || !this.getAllMethodName)
                throw Error("Missing api address");

            var promise = this.http
                .get<T[]>(this.apiAddress + this.getAllMethodName);
            return promise;
        }

        getItem(id: string): angular.IHttpPromise<T> {
            if (!this.apiAddress || !this.getItemMethodName)
                throw Error("Missing api address");

            var promise = this.http
                .get<T>(this.apiAddress + this.getItemMethodName + "/" + id);
            return promise;
        }
    }
}