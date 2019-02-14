Public Class time_block_UC
    Private Sub block_UC_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim user_o As time_ListProj_UC = New time_ListProj_UC
        Dim data As New getProjectList()
        Dim getData = data.getdata()

        For Each d In getData
            Dim user As time_ListProj_UC = New time_ListProj_UC
            '  user.Location = ListProj_UC1.Location
            '  user.Size = ListProj_UC1.Size
            '  user.Anchor = ListProj_UC1.Anchor
            user.Top = user_o.Bottom + 10
            Panel2.Controls.Add(user)
            Panel2.Size = New Size(932, user.Bottom)

            user_o = user
        Next






    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
