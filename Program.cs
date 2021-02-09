using System;

using Amazon.S3;
using Amazon.S3.Model;
namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            var bucketName = Guid.NewGuid().ToString().ToLower();      
            var creds = new Amazon.Runtime.BasicAWSCredentials("key", "secret");
            var s3Client = new AmazonS3Client(creds, new AmazonS3Config { ServiceURL = Environment.GetEnvironmentVariable("AWS_S3_ENDPOINT"), ForcePathStyle = true });
            //s3Client.ListBucketsAsync().Wait();
            s3Client.PutBucketAsync(new PutBucketRequest { BucketName = bucketName, UseClientRegion = true }).Wait();
            Console.WriteLine("Bucket Created!");
            // visit to see results http://localhost:9090
        }
    }
}
