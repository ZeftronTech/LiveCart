using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace LiveKart.Business
{
    public static class HtmlToImage
    {
        public static Bitmap Create(string url, int width, int height)
        {
            // create a hidden web browser, which will navigate to the page
            System.Windows.Forms.WebBrowser web = new System.Windows.Forms.WebBrowser();
            // we don't want scrollbars on our image
            web.ScrollBarsEnabled = false;
            // don't let any errors shine through
            web.ScriptErrorsSuppressed = true;
            // let's load up that page!
            web.Navigate(url);

            // wait until the page is fully loaded
            while (web.ReadyState != WebBrowserReadyState.Complete)
                System.Windows.Forms.Application.DoEvents();
            System.Threading.Thread.Sleep(1500); // allow time for page scripts to update
            // the appearance of the page

            // set the size of our web browser to be the same size as the page
            //int width = web.Document.Body.ScrollRectangle.Width;
            //int height = web.Document.Body.ScrollRectangle.Height;
            web.Width = width;
            web.Height = height;
            // a bitmap that we will draw to
            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(width, height);
            // draw the web browser to the bitmap
            web.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, width, height));

            return bmp; // return the bitmap for processing
        }

        public static Bitmap CreateImagefromHTML(string html)
        {
            Bitmap myImage = new System.Drawing.Bitmap(200, 118);
            var th = new Thread(() =>
            {
                var webBrowser = new WebBrowser();
                webBrowser.Width = 200;
                webBrowser.Height = 118;
                webBrowser.ScrollBarsEnabled = false;

                webBrowser.DocumentText = html;
                webBrowser.DocumentCompleted += (sender, e) =>
                {
                    webBrowser.DocumentText = html;
                    using (Bitmap bitmap = new Bitmap(webBrowser.Width, webBrowser.Height))
                    {
                        webBrowser.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, bitmap.Width, bitmap.Height));
                        myImage = bitmap;
                    }
                };
                webBrowser.DocumentText = html;
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            return myImage;
        }
    }
}
