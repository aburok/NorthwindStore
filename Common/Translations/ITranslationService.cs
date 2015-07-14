using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace Common.Translations
{
    public interface ITranslationService
    {
        string Translate(string resourcePath, CultureInfo language = null);
    }

    public class InMemoryTranslationService : ITranslationService
    {
        private IDictionary<string, string> _EnResources = new Dictionary<string, string>()
        {
            {"en__/Admin/Order/CompanyLabel", "Company"}
        };

        public string Translate(string resourcePath, CultureInfo language = null)
        {
            if (language == null)
            {
                language = CultureInfo.CurrentCulture;
            }
            var key = string.Format("{0}__{1}", language.TwoLetterISOLanguageName, resourcePath);

            if (_EnResources.ContainsKey(key))
            {
                return _EnResources[key];
            }
            return "__Please Translate Me__";
        }
    }
}