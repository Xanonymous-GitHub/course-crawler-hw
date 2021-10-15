using System;
using System.Text;
using System.Net;
using HtmlAgilityPack;

namespace CourseCrawler
{
    internal sealed class CrawlerUseCase : IUseCase<Result<HtmlDocument>>
    {
        public CrawlerUseCase(Uri uri)
        {
            _uri = uri;

            _webClient = new HtmlWeb
            {
                OverrideEncoding = Encoding.GetEncoding(950)
            };
        }

        private readonly Uri _uri;
        private readonly HtmlWeb _webClient;

        public Result<HtmlDocument> Do()
        {
            // TODO Make request process async.
            try
            {
                return new SuccessResult<HtmlDocument>(_webClient.Load(_uri));
            }
            catch (WebException e)
            {
                return new ErrorResult<HtmlDocument>(e.Message);
            }
        }
    }
}
