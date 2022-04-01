Imports System.Net
Imports System.Web.Http
Imports System.Configuration
Imports CardPointe_Bolt_Terminal_Library.Implementations
Imports CardPointe_Bolt_Terminal_Library.Dtos
Imports RestSharp

Public Class ValuesController
    Inherits ApiController

    ' GET api/values
    Public Function GetValues() As RestResponse
        Dim sessionKey = ConfigurationManager.AppSettings.GetValues("X-CardConnect-SessionKey").First()
        Dim authorization = ConfigurationManager.AppSettings.GetValues("Bolt-Authorization").First()
        Dim merchantId = ConfigurationManager.AppSettings.GetValues("merchantId").First()
        Dim hsn = ConfigurationManager.AppSettings.GetValues("hsn").First()

        Dim obj = New PingRequestDto()
        obj.pingHeaders = New PingHeaders()
        obj.pingHeaders.Authorization = authorization
        obj.pingHeaders.XCardConnectSessionKey = sessionKey


        obj.pingBody = New PingBody()
        obj.pingBody.merchantId = merchantId
        obj.pingBody.hsn = hsn


        Dim result = New BoltTerminalGateway().PingRequest(obj)
        Console.WriteLine("response: ", result)

        Return result
    End Function

    ' GET api/values/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/values
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/values/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
