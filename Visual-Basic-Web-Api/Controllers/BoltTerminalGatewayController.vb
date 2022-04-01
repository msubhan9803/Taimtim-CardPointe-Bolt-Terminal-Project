Imports System.Web.Mvc
Imports System.Configuration
Imports CardPointe_Bolt_Terminal_Library.Implementations
Imports CardPointe_Bolt_Terminal_Library.Dtos

Namespace Controllers
    Public Class BoltTerminalGatewayController
        Inherits Controller

        ' GET: BoltTerminalGateway
        Public Function GetValues() As IEnumerable(Of String)
            Dim sessionKey = ConfigurationManager.AppSettings.GetValues("X-CardConnect-SessionKey")
            Dim authorization = ConfigurationManager.AppSettings.GetValues("Bolt-Authorization")
            Dim merchantId = ConfigurationManager.AppSettings.GetValues("merchantId")
            Dim hsn = ConfigurationManager.AppSettings.GetValues("hsn")

            Return New String() {"value1", "value2"}
        End Function
    End Class
End Namespace