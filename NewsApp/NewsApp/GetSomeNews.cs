using System.Collections.Generic;
using System.Net;
using HtmlAgilityPack;

namespace NewsApp
{
    public class GetTheNews
    {
        public List<string> gettingNewsItemsWebRequest()
        {
            var webget = new HtmlWeb();
            //HtmlWeb.Load
            WebRequest request = WebRequest.Create("http://i.stuff.co.nz");
            WebResponse response = request.GetResponse();

            var doc = webget.Load("http://i.stuff.co.nz");
            //var doc = webrequest.Load()
            List<string> newsHeadlines = null;
            //HtmlNodeCollection testing = response.;
            HtmlNodeCollection headlines = doc.DocumentNode.SelectNodes("//*[@id='mobContent']/div/div/div/h3/a");

            foreach (var title in headlines)
            {
                newsHeadlines.Add(title.InnerHtml);
            }
            return newsHeadlines;
        }
    }
}