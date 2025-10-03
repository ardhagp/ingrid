Imports Amazon.S3.Model
Imports Amazon.Runtime
Imports Amazon.S3

Namespace API
    Public Class BackblazeB2
        Private varAccessKey As String
        Private varSecretKey As String
        Private varServiceURL As String
        Private AWSCredentials As BasicAWSCredentials
        Private AWSClient As IAmazonS3

        Private Sub New(ByVal AccessKey As String, ByVal SecretKey As String, ByVal ServiceURL As String)
            varAccessKey = AccessKey
            varSecretKey = SecretKey
            varServiceURL = ServiceURL

            Dim AWSConfig As New AmazonS3Config With {
                .ServiceURL = ServiceURL,
                .ForcePathStyle = True
            }

            AWSCredentials = New BasicAWSCredentials(AccessKey, SecretKey)
            AWSClient = New AmazonS3Client(AWSCredentials, AWSConfig)
        End Sub

        Private Async Function Upload(ByVal BucketName As String, ByVal Key As String, ByVal FilePath As String) As Task
            Dim AWSRequest As New PutObjectRequest With {
                .BucketName = BucketName,
                .Key = Key,
                .FilePath = FilePath
                }

            Dim AWSResponse As PutObjectResponse = Await AWSClient.PutObjectAsync(AWSRequest)
            'Console.WriteLine("Upload completed with status: " & AWSResponse.HttpStatusCode.ToString())
        End Function

    End Class
End Namespace
