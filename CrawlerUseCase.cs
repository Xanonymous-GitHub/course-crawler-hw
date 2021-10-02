using System;
using System.Text;
using HtmlAgilityPack;

namespace CourseCrawler
{
    internal interface ICrawlerUseCase
    {
        HtmlDocument Do();
    }

    internal class CrawlerUseCase : ICrawlerUseCase
    {
        public CrawlerUseCase(Uri uri)
        {
            _uri = uri;
            _webClient = new HtmlWeb();
            _webClient.OverrideEncoding = Encoding.Default;
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
