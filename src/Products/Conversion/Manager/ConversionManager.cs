using GroupDocs.Conversion.Handler;
using GroupDocs.Conversion.WebForms.Products.Conversion.Entity.Web.Request;
using GroupDocs.Conversion.Options.Save;
using System.Collections.Generic;
using System.IO;

namespace GroupDocs.Conversion.WebForms.Products.Conversion.Manager
{
    public class ConversionManager
    {

        private readonly ConversionHandler conversionHandler;

        public ConversionManager(ConversionHandler conversionHandler)
        {
            this.conversionHandler = conversionHandler;
        }

        public void Convert(ConversionPostedData postedData)
        {
            string sourceType = Path.GetExtension(postedData.guid).TrimStart('.');
            string destinationType = postedData.GetDestinationType();
            string resultFileName = Path.GetFileNameWithoutExtension(postedData.guid) + "." + postedData.GetDestinationType();
            dynamic saveOptions = GetSaveOptions(sourceType, destinationType);

            ConvertedDocument convertedDocument = conversionHandler.Convert(postedData.guid, saveOptions);

            if (convertedDocument.PageCount > 1 && saveOptions is ImageSaveOptions)
            {
                for (int i = 1; i <= convertedDocument.PageCount; i++)
                {
                    string fileName = Path.GetFileNameWithoutExtension(resultFileName) + "-page" + i + "." + Path.GetExtension(resultFileName);
                    convertedDocument.Save(fileName, i);
                }
            }
            else
            {
                convertedDocument.Save(resultFileName);
            }
        }

        private SaveOptions GetSaveOptions(string sourceType, string destinationType)
        {
            dynamic saveOptions = null;
            Dictionary<string, SaveOptions> availableConversions = conversionHandler.GetSaveOptions(sourceType);
            //list all available conversions
            foreach (var conversion in availableConversions)
            {
                if (conversion.Key.Equals(destinationType))
                {
                    saveOptions = conversion.Value;
                }
            }
            return saveOptions;
        }
    }
}