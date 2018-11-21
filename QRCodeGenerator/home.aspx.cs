using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace QRCodeGenerator
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            List<RunnerInfo> infos = new List<RunnerInfo>();
            using (RunningDatabaseDataContext r = new RunningDatabaseDataContext())
            {
                infos = r.RunnerInfos.Where(x => x.RunnerID >= 11731).ToList();
            }

            foreach (var info in infos)
            {
                int widthHeight = Convert.ToInt32(txtWidthHeight.Text.Trim());
                int fontSize = 12;
                int startX = (widthHeight / 2) - (widthHeight / 20);
                int startY = widthHeight - (fontSize * 2);
                WebResponse response = default(WebResponse);
                Stream remoteStream = default(Stream);
                StreamReader readStream = default(StreamReader);
                var text = $"http://runningqrapi.azurewebsites.net/RunningTimes/RecordByScanView?runnerIdentification={info.RunnerBIB}";
                var url = string.Format("http://chart.apis.google.com/chart?cht=qr&chs={1}x{2}&chl={0}", text, txtWidthHeight.Text.Trim(), txtWidthHeight.Text.Trim());
                WebRequest request = WebRequest.Create(url);
                response = request.GetResponse();
                remoteStream = response.GetResponseStream();
                readStream = new StreamReader(remoteStream);
                System.Drawing.Image img = System.Drawing.Image.FromStream(remoteStream);

                Bitmap bitMapImage = new Bitmap(img);
                Graphics graphicImage = Graphics.FromImage(bitMapImage);
                graphicImage.DrawString(info.RunnerBIB.ToString(), new Font("Arial", fontSize, FontStyle.Bold), SystemBrushes.WindowText, new Point(startX, startY));
                Response.ContentType = "image/jpeg";
                bitMapImage.Save($"E:/Projects/MillionCreation/QRCode3/{ info.RunnerBIB }.png", ImageFormat.Jpeg);

                graphicImage.Dispose();
                bitMapImage.Dispose();
                response.Close();
                remoteStream.Close();
                readStream.Close();
            }
        }
    }
}