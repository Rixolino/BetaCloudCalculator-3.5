Public Class DEmore
    Dim D, Dxs, Dys As Integer
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Dder_Click(sender As Object, e As EventArgs) Handles Dder.Click
        MsgBox("(" & Linearequations.TextBox1.Text & "*" & Linearequations.TextBox4.Text & ") - (" & Linearequations.TextBox2.Text & " * " & Linearequations.TextBox3.Text & ")")
    End Sub

    Private Sub Dxder_Click(sender As Object, e As EventArgs) Handles Dxder.Click
        MsgBox("(" & Linearequations.TextBox5.Text & "*" & Linearequations.TextBox4.Text & ") - (" & Linearequations.TextBox6.Text & " * " & Linearequations.TextBox3.Text & ")")
    End Sub

    Private Sub Dyder_Click(sender As Object, e As EventArgs) Handles Dyder.Click
        MsgBox("(" & Linearequations.TextBox1.Text & "*" & Linearequations.TextBox6.Text & ") - (" & Linearequations.TextBox2.Text & " * " & Linearequations.TextBox5.Text & ")")
    End Sub

    Private Sub Xder_Click(sender As Object, e As EventArgs) Handles Xder.Click
        MsgBox("(" & Linearequations.TextBox5.Text & "*" & Linearequations.TextBox4.Text & ") - (" & Linearequations.TextBox6.Text & " * " & Linearequations.TextBox3.Text & ") / (" & Linearequations.TextBox1.Text & "*" & Linearequations.TextBox4.Text & ") - (" & Linearequations.TextBox2.Text & " * " & Linearequations.TextBox3.Text & ")")
    End Sub

    Private Sub Yder_Click(sender As Object, e As EventArgs) Handles Yder.Click
        MsgBox("(" & Linearequations.TextBox1.Text & "*" & Linearequations.TextBox6.Text & ") - (" & Linearequations.TextBox2.Text & " * " & Linearequations.TextBox5.Text & " ) / (" & Linearequations.TextBox1.Text & "*" & Linearequations.TextBox4.Text & ") - (" & Linearequations.TextBox2.Text & " * " & Linearequations.TextBox3.Text & ")")
    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Me.Close()
    End Sub

    Private Sub DEmore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        D = (Linearequations.TextBox1.Text * Linearequations.TextBox4.Text) - (Linearequations.TextBox2.Text * Linearequations.TextBox3.Text)
        Dxs = (Linearequations.TextBox5.Text * Linearequations.TextBox4.Text) - (Linearequations.TextBox6.Text * Linearequations.TextBox3.Text)
        Dys = (Linearequations.TextBox1.Text * Linearequations.TextBox6.Text) - (Linearequations.TextBox2.Text * Linearequations.TextBox5.Text)
        Ds.Text = D
        Dx.Text = Dxs
        Dy.Text = Dys
        Resultx.Text = Dxs / D
        Resulty.Text = Dys / D
    End Sub
End Class