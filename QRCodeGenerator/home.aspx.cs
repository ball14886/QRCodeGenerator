using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;

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
                infos = r.RunnerInfos.Where(x => x.RunnerID >= 5676).ToList();
            }

            foreach (var info in infos)
            {
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
                img.Save($"C:/Projects/MillionCreation/Participants/Ozone/{ info.RunnerBIB }.png");
                response.Close();
                remoteStream.Close();
                readStream.Close();
            }
        }
    }
}