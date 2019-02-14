Public Class Edit
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim proid As Integer
        Dim proname As String
        Dim managerid As Integer
        Dim start As Date
        Dim enddate As Date

        Dim check = MessageBox.Show("ยืนยันการแก้ไข", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If check = True Then

        Else

        End If
    End Sub
End Class
