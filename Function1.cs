using System.Text.Json;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Azure.Storage.Queues;

namespace StoreShop.Function
{
    public class Function1
    {
        [FunctionName("StoreShopFunction")]
        public void Run([QueueTrigger("storeshopsmsqueue", Connection = "QueueConnection")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");

            //string connectionString = "DefaultEndpointsProtocol=http;AccountName=devstoreaccount1;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==;QueueEndpoint=http://127.0.0.1:10001/devstoreaccount1;";
            //var queueServiceClient = new QueueServiceClient(connectionString);
            //QueueClient queueClient = queueServiceClient.GetQueueClient("storeshopsmsqueue");
            //var queueMessage = queueClient.ReceiveMessage();
            SMS sMS = JsonSerializer.Deserialize<SMS>(myQueueItem);
            
            //call sms service provider
        }
    }
}
