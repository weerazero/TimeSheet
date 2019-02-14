Public Class Edit
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim check = MessageBox.Show("ยืนยันการแก้ไข", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    End Sub
End Class
