Public Class Delete
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim check = MessageBox.Show("ยืนยันการลบ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    End Sub

    Private Sub projectid_onItemSelected(sender As Object, e As EventArgs) Handles projectid.onItemSelected

    End Sub

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim proid As Integer
    End Sub
End Class
