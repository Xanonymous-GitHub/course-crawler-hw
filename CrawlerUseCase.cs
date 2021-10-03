using System;
using System.Text;
using HtmlAgilityPack;

namespace CourseCrawler
{
    internal class CrawlerUseCase : IUseCase<HtmlDocument>
    {
        public CrawlerUseCase(Uri uri)
        {
            _uri = uri;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            _webClient = new HtmlWeb
            {
                OverrideEncoding = Encoding.GetEncoding(950)
            };
        }

        private readonly Uri _uri;
        private readonly HtmlWeb _webClient;

        public HtmlDocument Do()
        {
            // TODO Add StatusCode Check & Error handlers.
            // TODO Make request process async.
            return _webClient.Load(_uri);
        }
    }
}
