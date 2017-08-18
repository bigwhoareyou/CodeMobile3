using System;
using Microsoft.WindowsAzure.MobileServices;

namespace CodeMobile3.Helpers
{
    public class Services
    {
        public static MobileServiceClient MobileServiceClient { get; set; } = new MobileServiceClient("https://codemobile3.azurewebsites.net");



    }
}
