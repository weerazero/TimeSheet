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

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub projectid_onItemSelected(sender As Object, e As EventArgs) Handles projectid.onItemSelected
        Dim proid As Integer
        Dim proname As String
        Dim managerid As Integer
        Dim start As Date
        Dim enddate As Date
        ' select all 
    End Sub
End Class
