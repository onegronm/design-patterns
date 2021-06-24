using System.Drawing;
using System.Net;
using System.Threading;

namespace HeadFirst.Proxy.VirtualProxy
{
    public class ImageProxy
    {
        private static Image _image = null;
        private int _width = 133;
        private int _height = 154;
        private bool _retrieving = false;

        public int Width
        {
            get
            {
                return _image != null ? _image.Width : _width;
            }
        }

        public int Height
        {
            get
            {
                return _image != null ? _image.Height : _height;
            }
        }

        public Image Image
        {
            get
            {
                if (_image != null)
                {
                    return _image;
                }
                else
                {
                    if (!_retrieving)
                    {
                        _retrieving = true;
                        Thread retrievalThread = new Thread(new ThreadStart(RetrieveImage));
                        retrievalThread.Start();
                    }
                    return PlaceholderImage();
                }
            }
        }

        public void RetrieveImage()
        {
            // Book image from amazon
            string url = "http://images.amazon.com/images/P/0596007124.01._PE34_SCMZZZZZZZ_.jpg";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            _image = Image.FromStream(response.GetResponseStream());
        }

        public Image PlaceholderImage()
        {
            return new Bitmap(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("HeadFirst.Proxy.VirtualProxy.PlaceHolder.jpg"));
        }
    }
}
