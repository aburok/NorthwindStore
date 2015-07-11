
 
 

 

/// <reference path="Enums.ts" />

declare module NorthwindStore.Admin.Company {
	interface CompanyDto {
		Id: string;
		Name: string;
		Phone: string;
		Fax: string;
	}
}
declare module NorthwindStore.Admin.Products {
	interface ProductDto {
		Name: string;
		Units: number;
	}
}

declare module NorthwindStore.WebUI.Areas.Administration.Supplier {
	interface SupplierDto {
		Id: string;
		Name: string;
	}
}


