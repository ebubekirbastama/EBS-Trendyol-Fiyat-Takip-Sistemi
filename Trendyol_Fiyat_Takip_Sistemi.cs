using System.Net;
using System.Net.Http;

namespace Trendyol_Fiyat_Takip_Sistemi_
{
    public class trendyolisbnsearch
    {
        //Web Site: www.ebubekirbastama.com
        //Whatshapp : 05554128854
        //Youtube : https://www.youtube.com/user/Yazilimegitim 
        //Ücretli Destek için : 05554128854
        
        string EBSBarcodeUrl = "https://sellerpublic-sdc.trendyol.com/product-spm-sellercenterproductbff-service/v2/single-product/";
        string EBSBarcodeURL1 = "?searchTerm=";
        string EBSBarcodeURL2 = "&page=0&pageSize=9&type=barcode";
        string EBSNameURL = "https://sellerpublic-sdc.trendyol.com/product-spm-sellercenterproductbff-service/v2/single-product/content-groups?searchTerm=";
        string EBSNameURL1 = "&page=1&pageSize=9&name=";
        string EBSREfererUrl = "https://partner.trendyol.com/products/single-operations";
        string origin = "https://partner.trendyol.com";
        async void EBSİSBNSEARCH(string BeartCode, string Barcode)
        {

            var handler = new HttpClientHandler();


            handler.AutomaticDecompression = ~DecompressionMethods.None;

            using (var httpClient = new HttpClient(handler))
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), EBSBarcodeUrl + Barcode + EBSBarcodeURL1 + Barcode + EBSBarcodeURL2))
                {
                    request.Headers.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:65.0) Gecko/20100101 Firefox/65.0 IceDragon/65.0.2");
                    request.Headers.TryAddWithoutValidation("Accept", "application/json, text/plain, */*");
                    request.Headers.TryAddWithoutValidation("Accept-Language", "tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3");
                    request.Headers.TryAddWithoutValidation("Referer", EBSREfererUrl);
                    request.Headers.TryAddWithoutValidation("x-header-version", "f93ed63c");
                    request.Headers.TryAddWithoutValidation("x-banner-version", "2eef8cf5");
                    request.Headers.TryAddWithoutValidation("x-child-version", "b47c6f40");
                    request.Headers.TryAddWithoutValidation("authorization", BeartCode);
                    request.Headers.TryAddWithoutValidation("Origin", "https://partner.trendyol.com");
                    request.Headers.TryAddWithoutValidation("Connection", "keep-alive");
                    request.Headers.TryAddWithoutValidation("TE", "Trailers");
                    request.Headers.TryAddWithoutValidation("Pragma", "no-cache");
                    request.Headers.TryAddWithoutValidation("Cache-Control", "no-cache");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
        async void EBSNameSEARCH(string BearCode, string name)
        {
            var handler = new HttpClientHandler();

            handler.AutomaticDecompression = ~DecompressionMethods.None;

            using (var httpClient = new HttpClient(handler))
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), EBSNameURL + name + EBSNameURL1 + name))
                {
                    request.Headers.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:65.0) Gecko/20100101 Firefox/65.0 IceDragon/65.0.2");
                    request.Headers.TryAddWithoutValidation("Accept", "application/json, text/plain, */*");
                    request.Headers.TryAddWithoutValidation("Accept-Language", "tr-TR,tr;q=0.8,en-US;q=0.5,en;q=0.3");
                    request.Headers.TryAddWithoutValidation("Referer", EBSREfererUrl);
                    request.Headers.TryAddWithoutValidation("x-header-version", "f93ed63c");
                    request.Headers.TryAddWithoutValidation("x-banner-version", "2eef8cf5");
                    request.Headers.TryAddWithoutValidation("x-child-version", "b47c6f40");
                    request.Headers.TryAddWithoutValidation("authorization", BearCode);
                    request.Headers.TryAddWithoutValidation("Origin", origin);
                    request.Headers.TryAddWithoutValidation("Connection", "keep-alive");
                    request.Headers.TryAddWithoutValidation("TE", "Trailers");

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
    }
}
