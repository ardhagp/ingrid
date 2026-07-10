Imports Amazon.S3.Model
Imports Amazon.Runtime
Imports Amazon.S3

Namespace Api
    ''' <summary>
    ''' The BackblazeB2 class provides functionality to interact with the Backblaze B2 cloud storage service using the AWS SDK for .NET. It allows users to upload files to a specified bucket in Backblaze B2. The class implements IDisposable to ensure proper resource management and cleanup of the Amazon S3 client.
    ''' </summary>
    Public Class BackblazeB2
        Implements IDisposable

        Private ReadOnly AWSCredentials As BasicAWSCredentials
        Private ReadOnly AWSClient As Amazon.S3.AmazonS3Client
        Private disposedValue As Boolean

        ''' <summary>
        ''' Creates an instance of the BackblazeB2 class with the specified access key, secret key, and service URL. This method initializes the Amazon S3 client with the provided credentials and configuration for interacting with Backblaze B2.
        ''' </summary>
        ''' <param name="accessKey">The access key for the Backblaze B2 account.</param>
        ''' <param name="secretKey">The secret key for the Backblaze B2 account.</param>
        ''' <param name="serviceUrl">The service URL for the Backblaze B2 API.</param>
        ''' <returns>An instance of the BackblazeB2 class.</returns>
        Public Shared Function Create(accessKey As String, secretKey As String, serviceUrl As String) As BackblazeB2
            Return New BackblazeB2(accessKey, secretKey, serviceUrl)
        End Function

        Private Sub New(accessKey As String, secretkey As String, serviceurl As String)
            Dim varAwsConfig As New AmazonS3Config With {
                .ServiceURL = serviceurl,
                .ForcePathStyle = True
            }

            AWSCredentials = New BasicAWSCredentials(accessKey, secretkey)
            AWSClient = New AmazonS3Client(AWSCredentials, varAwsConfig)
        End Sub

        ''' <summary>
        ''' Uploads a file to the specified Backblaze B2 bucket using the provided key and file path. This method creates a PutObjectRequest with the specified parameters and uses the Amazon S3 client to perform the upload asynchronously. It returns a Task representing the asynchronous operation.
        ''' </summary>
        ''' <param name="bucketname">The name of the Backblaze B2 bucket to upload the file to.</param>
        ''' <param name="key">The key (path) under which to store the file in the bucket.</param>
        ''' <param name="filepath">The local file path of the file to upload.</param>
        ''' <returns>A Task representing the asynchronous upload operation.</returns>
        Public Async Function Upload(bucketname As String, key As String, filepath As String) As Task
            Dim varAwsRequest As New PutObjectRequest With {
                .BucketName = bucketname,
                .Key = key,
                .FilePath = filepath
                }

            Dim varAwsResponse As PutObjectResponse
            varAwsResponse = Await AWSClient.PutObjectAsync(varAwsRequest)
            'Console.WriteLine("Upload completed with status: " & varAwsResponse.HttpStatusCode.ToString())
        End Function

        ''' <summary>
        ''' Calculates the total storage usage (in bytes) of a Backblaze B2 bucket
        ''' by listing all objects and summing their sizes.
        ''' </summary>
        ''' <param name="bucketname">The name of the Backblaze B2 bucket.</param>
        ''' <returns>Total bytes stored in the bucket.</returns>
        Public Async Function GetCurrentUsageAsync(bucketname As String) As Task(Of Long)
            Dim request As New ListObjectsV2Request With {
        .BucketName = bucketname
    }

            Dim totalBytes As Long = 0
            Dim response As ListObjectsV2Response

            response = Await AWSClient.ListObjectsV2Async(request)

            For Each obj In response.S3Objects
                totalBytes += obj.Size.GetValueOrDefault(0)
            Next

            Return totalBytes
        End Function


        ''' <summary>
        ''' Disposes of the resources used by the BackblazeB2 class. This method is called when the object is no longer needed and ensures that the Amazon S3 client and other resources are properly released. It implements the IDisposable interface to allow for deterministic cleanup of resources.
        ''' </summary>
        ''' <param name="disposing">Indicates whether the method is called from the Dispose method (true) or from the finalizer (false).</param>
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    AWSClient?.Dispose()
                End If
                disposedValue = True
            End If
        End Sub

        ''' <summary>
        ''' Disposes of the resources used by the BackblazeB2 class. This method is called when the object is no longer needed and ensures that the Amazon S3 client and other resources are properly released. It implements the IDisposable interface to allow for deterministic cleanup of resources.
        ''' </summary>
        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class
End Namespace
