using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;

namespace CSharpRFIDDemo
{
    class ConnectionManager
    {
        private string HostAddress = "";
        private string ApiKey = "";
        private int ReaderId;

        public ConnectionManager(string HostAddress, String ApiKey, int ReaderId)
        {
            this.HostAddress = HostAddress;
            this.ApiKey = ApiKey;
            this.ReaderId = ReaderId;
        }

        public void SendReadReport(int Code, DateTime ReadTime)
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["ApiKey"] = ApiKey;
                data["ReaderId"] = ReaderId.ToString();
                data["Code"] = Code.ToString();
                data["ReadTime"] = ReadTime.ToString();

                Uri address = new Uri(HostAddress + "\\ReadReport");

                bool send = false;

                while (!send)
                {
                    try
                    {
                        var response = wb.UploadValues(address, "POST", data);
                        send = true;
                    }
                    catch (System.Net.WebException)
                    {
                        send = false;
                    }
                }
            }
        }
    }
}
