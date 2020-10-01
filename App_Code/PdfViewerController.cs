using Newtonsoft.Json;
//using Syncfusion.EJ.PdfViewer;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Http;
namespace PdfViewerEJWeb.WebApi
{
    public class PdfViewerController : ApiController
    {
        ////Post action for processing the PDF documents.
        //public object Load(Dictionary<string, string> jsonResult)
        //{
        //    //PdfViewerHelper helper = new PdfViewerHelper();
        //    ////load the multiple document from client side 
        //    //if (jsonResult.ContainsKey("newFileName"))
        //    //{
        //    //    var name = jsonResult["newFileName"];
        //    //    var pdfName = name.ToString();
        //    //    helper.Load(HttpContext.Current.Server.MapPath("~/competitive-info/data/" + pdfName));
        //    //}
        //    //else
        //    //{
        //    //    if (jsonResult.ContainsKey("isInitialLoading"))
        //    //    {
        //    //        if (jsonResult.ContainsKey("file"))
        //    //        {
        //    //            var name = jsonResult["file"];
        //    //            helper.Load(name);
        //    //        }
        //    //        else
        //    //        {
        //    //            helper.Load(HttpContext.Current.Server.MapPath("/competitive-info/data/Philips_ISP_vs_GEModuleComparison.pdf"));
        //    //        }
        //    //    }
        //    //}
        //    //return JsonConvert.SerializeObject(helper.ProcessPdf(jsonResult));
        //    return "";
        //}

        ////Post action for processing the PDF documents when uploading to the ejPdfviewer widget.
        //public object FileUpload(Dictionary<string, string> jsonResult)
        //{
        //    //PdfViewerHelper helper = new PdfViewerHelper();
        //    //if (jsonResult.ContainsKey("uploadedFile"))
        //    //{
        //    //    var fileUrl = jsonResult["uploadedFile"];
        //    //    byte[] byteArray = System.Convert.FromBase64String(fileUrl);
        //    //    MemoryStream stream = new MemoryStream(byteArray);
        //    //    helper.Load(stream);
        //    //}
        //    //return JsonConvert.SerializeObject(helper.ProcessPdf(jsonResult));
        //    return "";
        //}

        ////Post action for downloading the PDF documents from the ejPdfviewer widget.
        //public object Download(Dictionary<string, string> jsonResult)
        //{
        //    //PdfViewerHelper helper = new PdfViewerHelper();
        //    //return helper.GetDocumentData(jsonResult);
        //}
    }
}