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
        private String ReaderName;

        public ConnectionManager(string HostAddress, String ApiKey, String ReaderName)
        {
            this.HostAddress = HostAddress;
            this.ApiKey = ApiKey;
            this.ReaderName = ReaderName;
        }

        public void SendReadReport(string Code, DateTime ReadTime)
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["ApiKey"] = ApiKey;
                data["ReaderName"] = ReaderName;
                data["Code"] = Code;
                data["ReadTime"] = ReadTime.ToString();

                Uri address = new Uri(HostAddress + "/readReport");

                bool send = false;

                while (!send)
                {
                    try
                    {
                        var response = wb.UploadValues(address, "POST", data);
                        Console.WriteLine(System.Text.Encoding.Default.GetString(response));
                        send = true;
                    }
                    catch (System.Net.WebException e)
                    {
                        Console.WriteLine(e);
                        send = false;
                    }
                }
            }
        }
    }
}
