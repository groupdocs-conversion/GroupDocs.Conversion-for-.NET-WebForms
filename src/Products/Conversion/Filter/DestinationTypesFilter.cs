using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocs.Conversion.WebForms.Products.Conversion.Filter
{
    public class DestinationTypesFilter
    {

        private readonly string[] allTypes = { "ods", "xls", "xlsx", "xlsm", "xlsb", "csv", "xls2003", "xltx", "xltm", "tsv", "tiff", "tif", "jpeg", "jpg", "png", "gif", "bmp", "ico", "psd", "svg", "webp", "jp2", "pdf", "epub", "xps", "ppt", "pps", "pptx", "ppsx", "odp", "otp", "potx", "potm", "pptm", "ppsm", "doc", "docm", "docx", "dot", "dotm", "dotx", "rtf", "txt", "odt", "ott", "html", };
        private readonly string[] csvTypes = { "ods", "xls", "xlsx", "xlsm", "xlsb", "csv", "xls2003", "xltx", "xltm", "tsv", "tiff", "tif", "jpeg", "jpg", "png", "gif", "bmp", "ico", "psd", "webp", "jp2", "pdf", "epub", "xps", "ppt", "pps", "pptx", "ppsx", "odp", "otp", "potx", "potm", "pptm", "ppsm", "doc", "docm", "docx", "dot", "dotm", "dotx", "rtf", "txt", "odt", "ott", "html", };
        private readonly string[] htmlTypes = { "tiff", "tif", "jpeg", "jpg", "png", "gif", "bmp", "ico", "psd", "svg", "webp", "jp2", "pdf", "epub", "ppt", "pps", "pptx", "ppsx", "odp", "otp", "potx", "potm", "pptm", "ppsm", "doc", "docm", "docx", "dot", "dotm", "dotx", "rtf", "odt", "ott", "html", };
        private readonly string[] slidesTypes = { "tiff", "tif", "jpeg", "jpg", "png", "gif", "bmp", "ico", "psd", "svg", "webp", "jp2", "pdf", "epub", "xps", "ppt", "pps", "pptx", "ppsx", "odp", "otp", "potx", "potm", "pptm", "ppsm", "doc", "docm", "docx", "dot", "dotm", "dotx", "rtf", "odt", "ott", "html", };
        private readonly string[] imageTypes = { "ods", "xls", "xlsx", "xlsm", "xlsb", "xls2003", "xltx", "xltm", "tiff", "tif", "jpeg", "jpg", "png", "gif", "bmp", "ico", "psd", "svg", "webp", "jp2", "pdf", "epub", "xps", "ppt", "pps", "pptx", "ppsx", "odp", "otp", "potx", "potm", "pptm", "ppsm", "doc", "docm", "docx", "dot", "dotm", "dotx", "rtf", "odt", "ott", "html", };
        private readonly string[] tsvTypes = { "ods", "xls", "xlsx", "xlsm", "xlsb", "csv", "xls2003", "xltx", "xltm", "tsv", "tiff", "tif", "jpeg", "jpg", "png", "gif", "bmp", "ico", "psd", "webp", "jp2", "pdf", "epub", "xps", "ppt", "pps", "pptx", "ppsx", "odp", "otp", "potx", "potm", "pptm", "ppsm", "doc", "docm", "docx", "dot", "dotm", "dotx", "rtf", "txt", "odt", "ott", "html", };
        private readonly string[] webpTypes = { "ods", "xls", "xlsx", "xlsm", "xlsb", "xls2003", "xltx", "xltm", "tiff", "tif", "jpeg", "jpg", "png", "gif", "bmp", "ico", "psd", "svg", "webp", "jp2", "pdf", "epub", "xps", "ppt", "pps", "pptx", "ppsx", "odp", "otp", "potx", "potm", "pptm", "ppsm", "doc", "docm", "docx", "dot", "dotm", "dotx", "rtf", "odt", "ott", "html", };
        private readonly string[] cellsTypes = { "ods", "xls", "xlsx", "xlsm", "xlsb", "csv", "xls2003", "xltx", "xltm", "tsv", "tiff", "tif", "pdf", "epub", "xps", "ppt", "pps", "pptx", "ppsx", "odp", "otp", "potx", "potm", "pptm", "ppsm", "doc", "docm", "docx", "dot", "dotm", "dotx", "rtf", "txt", "odt", "ott", "html", };



        public string[] GetPosibleConversions(string extension)
        {
            switch (extension)
            {
                default:
                    return allTypes;
                case "csv":
                    return csvTypes;
                case "tsv":
                    return tsvTypes;
                case "webp":
                    return webpTypes;
                case "html":
                case "htm":
                    return htmlTypes;
                case "ppt":
                case "pps":
                case "pptx":
                case "ppsx":
                case "odp":
                case "otp":
                case "potx":
                case "potm":
                case "pptm":
                case "ppsm":
                    return slidesTypes;
                case "tiff":
                case "tif":
                case "jpeg":
                case "jpg":
                case "png":
                case "gif":
                case "bmp":
                case "ico":
                case "psd":
                case "svg":              
                case "jp2":
                    return imageTypes;
                case "ods":
                case "xls":
                case "xlsb":
                case "xlsx":
                case "xlsm":
                case "xls2003":
                case "xltx":
                case "xltm":
                    return cellsTypes;
            }
        }
    }
}