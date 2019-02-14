Public Class time_container_UC

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim user_o As time_block_UC = New time_block_UC
        For index As Integer = 1 To 2
            Dim user As time_block_UC = New time_block_UC
            user.Location = Time_block_UC1.Location
            user.Size = Time_block_UC1.Size
            user.Anchor = Time_block_UC1.Anchor
            user.Top = user_o.Bottom + 10
            Panel1.Controls.Add(user)
            Panel1.Size = New Size(932, user.Bottom)

            user_o = user
        Next

    End Sub
End Class
