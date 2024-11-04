<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MapsWebView = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(MapsWebView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MapsWebView
        ' 
        MapsWebView.AllowExternalDrop = True
        MapsWebView.CreationProperties = Nothing
        MapsWebView.DefaultBackgroundColor = Color.White
        MapsWebView.Location = New Point(26, 33)
        MapsWebView.Name = "MapsWebView"
        MapsWebView.Size = New Size(585, 380)
        MapsWebView.TabIndex = 0
        MapsWebView.ZoomFactor = 1R
        ' 
        ' MapsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MapsWebView)
        Name = "MapsForm"
        Text = "Form1"
        CType(MapsWebView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MapsWebView As Microsoft.Web.WebView2.WinForms.WebView2
End Class
