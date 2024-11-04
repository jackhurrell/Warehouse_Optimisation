Imports System.IO
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms
Imports Newtonsoft.Json

Public Class MapsForm

    Private Async Sub MapsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Await MapsWebView.EnsureCoreWebView2Async(Nothing)
        MapsWebView.CoreWebView2.Settings.IsScriptEnabled = True
        MapsWebView.CoreWebView2.Settings.AreDevToolsEnabled = True


        Dim htmlFilePath As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mapsOriginal.html")

        If File.Exists(htmlFilePath) Then
            MapsWebView.Source = New Uri(htmlFilePath)
        Else
            MessageBox.Show(htmlFilePath & " not found")
        End If

    End Sub

    Private Sub OnWebMessageReceived(sender As Object, args As CoreWebView2WebMessageReceivedEventArgs)
        Dim message As String = args.TryGetWebMessageAsString()

        If Not String.IsNullOrEmpty(message) Then
            ' Deserialize the JSON message to an object
            Dim placeData As Object = JsonConvert.DeserializeObject(message)
            Dim formattedAddress As String = placeData("formattedAddress").ToString()
            Dim latitude As Double = placeData("location")("lat")
            Dim longitude As Double = placeData("location")("lng")

            ' Display or store the data as needed
            MessageBox.Show($"Address: {formattedAddress}" & vbCrLf &
                            $"Latitude: {latitude}" & vbCrLf &
                            $"Longitude: {longitude}")
        End If
    End Sub


End Class