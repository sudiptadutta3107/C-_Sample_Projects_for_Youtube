Imports ZWCAD
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myDoc As ZcadDocument
        Dim ss As ZcadApplication
        Dim myspace As ZcadModelSpace
        ss = GetObject(, "ZWCAD.Application.2025")
        myDoc = ss.ActiveDocument
        myspace = myDoc.ModelSpace
        ss.Visible = True
        Dim myline As ZcadLine
        Dim startpoint(2) As Double
        startpoint(0) = 0 : startpoint(1) = 0 : startpoint(2) = 0
        Dim endpoint(2) As Double
        endpoint(0) = 10 : endpoint(1) = 200 : endpoint(2) = 0
        myline = myspace.AddLine(startpoint, endpoint)
        myline.Update()
        ss.ZoomExtents()

    End Sub

End Class
