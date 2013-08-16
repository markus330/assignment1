Public Class Form1

    Dim Transport()
    Dim Days As Integer


    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Prompt As String
        Dim Title As String
        Dim i As Short
        Prompt = "Enter name and vehicle"
        Days = InputBox("how many names do you want to add", "Create an Array")
        If Days > 0 Then ReDim Transport(Days - 1)

        For i = 0 To UBound(Transport)
            Title = "Name and Vehicle " & (i + 1)
            Transport(i) = InputBox(Prompt, Title)
        Next
    End Sub

   
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim Result As String
        Dim i As Short
        Dim Total As Single = 0
        Result = "Name and Vehicles" & vbCrLf & vbCrLf
        For i = 0 To UBound(Transport)
            Result = Transport(i)

        Next
        Result = Result
        TextBox1.Text = Result
    End Sub
End Class
