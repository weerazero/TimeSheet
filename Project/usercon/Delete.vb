Public Class Delete
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim check = MessageBox.Show("ยืนยันการลบ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    End Sub
End Class
