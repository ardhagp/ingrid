Imports Amazon.S3.Model
Imports Amazon.Runtime
Imports Amazon.S3

Namespace Api
    Public Class BackblazeB2
        Private ReadOnly varAccessKey As String
        Private ReadOnly varSecretKey As String
        Private ReadOnly varServiceURL As String
        Private ReadOnly AWSCredentials As BasicAWSCredentials
        Private ReadOnly AWSClient As Amazon.S3.AmazonS3Client

        Private Sub New(accessKey As String, secretkey As String, serviceurl As String)
            varAccessKey = accessKey
            varSecretKey = secretkey
            varServiceURL = serviceurl

            Dim varAwsConfig As New AmazonS3Config With {
                .ServiceURL = serviceurl,
                .ForcePathStyle = True
            }

            AWSCredentials = New BasicAWSCredentials(accessKey, secretkey)
            AWSClient = New AmazonS3Client(AWSCredentials, varAwsConfig)
        End Sub

        Private Async Function Upload(bucketname As String, key As String, filepath As String) As Task
            Dim varAwsRequest As New PutObjectRequest With {
                .BucketName = bucketname,
                .Key = key,
                .FilePath = filepath
                }

            Dim varAwsResponse As PutObjectResponse
            varAwsResponse = Await AWSClient.PutObjectAsync(varAwsRequest)
            'Console.WriteLine("Upload completed with status: " & AWSResponse.HttpStatusCode.ToString())

        End Function

    End Class
End Namespace
