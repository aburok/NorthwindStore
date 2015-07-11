using TypeLite;

namespace NorthwindStore.WebUI.Areas.Administration.Company
{
    [TsClass(Module = "NorthwindStore.Admin.Company")]
    public class CompanyDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }
    }
}