Public Class UserControl2
    Private Sub UserControl2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create two scroll bars

        Dim vs As VScrollBar

        vs = New VScrollBar()

        'set properties

        vs.Location = New Point(200, 30)
        vs.Size = New Size(15, 175)


        'adding the scroll bars to the form


        ' Set the caption bar text of the form.  
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles projectnamebox.OnValueChanged

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim proname As String = projectnamebox.Text
        Dim menegerid As String = menegerbox.selectedValue
        Dim strdate As Date = BunifuDatepicker1.Value
        Dim enddate As Date = BunifuDatepicker2.Value

        Dim check = MessageBox.Show("ยืนยันการส้รางโปรเจค", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If check = True Then

        Else
            projectnamebox.Text = ""
            menegerbox.selectedIndex = -1
            
        End If
    End Sub
    Dim i = 0
    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)
        i += 10
        Me.AutoScrollPosition = New Point(0, i)
        Me.Text = Me.AutoScrollPosition.Y.ToString
    End Sub
End Class
