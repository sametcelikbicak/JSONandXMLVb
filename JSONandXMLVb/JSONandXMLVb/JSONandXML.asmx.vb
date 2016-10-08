Imports System.ComponentModel
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class JSONandXML
    Inherits System.Web.Services.WebService

    <WebMethod>
    Public Function GetTeamFromXML() As Member()
        Dim team As New Team()
        Return team.GetTeamMembers()
    End Function

    <WebMethod>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Function GetTeamFromJSON() As String
        Dim team As New Team()
        Return New JavaScriptSerializer().Serialize(team.GetTeamMembers())
    End Function

End Class