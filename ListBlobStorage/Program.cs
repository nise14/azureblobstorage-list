using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

string connectionString = "DefaultEndpointsProtocol=https;AccountName=demoappcoreaz;AccountKey=wLC/iMzDwJhL1daIgKKnWV1CyubHAB2kQjzTcHXltGi7dz/VfqhDwb2iCvYbnAIV1REBi5CMiWR3+AStTZhO7Q==;EndpointSuffix=core.windows.net";

string containerName = "makec";

BlobContainerClient blobContainerClient = new BlobContainerClient(connectionString, containerName);

await foreach (BlobItem blobItem in blobContainerClient.GetBlobsAsync())
{
    Console.WriteLine($"The blob name is: {blobItem.Name}");
    Console.WriteLine($"The blob size is: {blobItem.Properties.ContentLength}");
}