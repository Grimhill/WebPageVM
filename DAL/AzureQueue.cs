using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Configuration;
using System.IO;
using Microsoft.WindowsAzure.Storage.Queue;

namespace DAL
{
    public class AzureQueue
    {
        private CloudStorageAccount storageAccount;
        private CloudQueueClient client;
        
        public void Queue(string mas)
        {
            string connstring = ConfigurationManager.AppSettings["AzureStorageConn"];

            storageAccount = CloudStorageAccount.Parse(connstring);

            //blob client
            client = storageAccount.CreateCloudQueueClient();

            //containter
            CloudQueue queue = client.GetQueueReference("queue");

            queue.CreateIfNotExists();

            CloudQueueMessage message = new CloudQueueMessage(mas);
            queue.AddMessage(message);
        }
    }
}
