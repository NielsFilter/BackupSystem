using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace BackupSystem.UI.Wpf.Classes
{
    public class FTP
    {
        #region ctors

        public FTP(string url, string username, string password)
        {
            this.Url = url;
            this.Username = username;
            this.Password = password;
        }

        #endregion

        #region Properties

        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        #endregion

        public void Upload(string source)
        {
            try
            {
                string filename = Path.GetFileName(source);
                string ftpfullpath = this.Url;
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
                ftp.Credentials = new NetworkCredential(this.Username, this.Password);
 
                ftp.KeepAlive = true;
                ftp.UseBinary = true;
                ftp.Method = WebRequestMethods.Ftp.UploadFile;

                using (FileStream fs = File.OpenRead(source))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);

                    using (Stream ftpstream = ftp.GetRequestStream())
                    {
                        ftpstream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
