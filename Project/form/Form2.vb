Public Class Form2
    Dim drag As Boolean
    Dim mousex As Integer

    Dim mousey As Integer
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        Form1.Show()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserControl21.Hide()
        Time_container_UC1.Hide()
        Data1.Hide()

        Edit1.Hide()
        Delete1.Hide()

    End Sub
    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, BunifuGradientPanel2.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, BunifuGradientPanel2.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, BunifuGradientPanel2.MouseUp
        drag = False
    End Sub

    Private Sub BunifuGradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel2.Paint

    End Sub

    Private Sub UserControl22_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        UserControl21.Show()
        Data1.Hide()
        Edit1.Hide()
        Delete1.Hide()
        Time_container_UC1.Hide()

    End Sub

    Private Sub UserControl21_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Test3_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        UserControl21.Hide()
        Time_container_UC1.Hide()
        Delete1.Hide()
        Data1.Hide()
        Edit1.Show()
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        UserControl21.Hide()
        Time_container_UC1.Hide()

        Data1.Hide()
        Edit1.Hide()
        Delete1.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        UserControl21.Hide()
        Edit1.Hide()
        Delete1.Hide()
        Time_container_UC1.Hide()
        Data1.Show()
    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        UserControl21.Hide()


        Data1.Hide()
        Edit1.Hide()
        Delete1.Hide()
        Time_container_UC1.Show()
    End Sub
End Class