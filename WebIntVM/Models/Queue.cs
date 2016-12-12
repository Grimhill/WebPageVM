using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Configuration;
using System.IO;
using Microsoft.WindowsAzure.Storage.Queue;


namespace WebIntVM.Models
{
    public class Queue
    {
        public Queue()
        {
            string connstring = ConfigurationManager.AppSettings["AzureStorageConn"];
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connstring);

            //blob client
            CloudQueueClient client = storageAccount.CreateCloudQueueClient();

            //containter
            CloudQueue queue = client.GetQueueReference("queue");

            queue.CreateIfNotExists();

            CloudQueueMessage message = new CloudQueueMessage("Hello, World");
            queue.AddMessage(message);
        }
    }
}