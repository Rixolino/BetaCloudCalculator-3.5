Public Class Normal
    Dim a, b
    Dim op As String
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & “1”
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & “2”
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & “3”
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & “4”
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & “5”
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & “6”
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text & “7”
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & “8”
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text & “9”
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = TextBox1.Text & “0”
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a = CDbl(TextBox1.Text)
        op = “+”
        TextBox1.Text = “”
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        a = CDbl(TextBox1.Text)
        op = “*”
        TextBox1.Text = “”
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        a = CDbl(TextBox1.Text)
        op = “/”
        TextBox1.Text = “”
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        b = CDbl(TextBox1.Text)
        Select Case op
            Case “/”
                TextBox1.Text = a / b
            Case “*”
                TextBox1.Text = a * b
            Case “+”
                TextBox1.Text = a + b
            Case “-”
                TextBox1.Text = a - b

        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = “”

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)
        TextBox1.Text = a & ”%”
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        TextBox1.Text = "2.71"
    End Sub

    Private Sub ScOpen_Click(sender As Object, e As EventArgs)
        Scientific.Show()
        Me.Hide()
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        TextBox1.Text = “”
        Me.Hide()
        Scientific.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = "-"
    End Sub

    Private Sub Copy_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UnitOfMeasureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitOfMeasureToolStripMenuItem.Click
        Convertitor.Show()
        Me.Hide()
    End Sub

    Private Sub MoneyValueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoneyValueToolStripMenuItem.Click
        Money_Value.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GraphicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraphicsToolStripMenuItem.Click
        Graphicsa.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        a = CDbl(TextBox1.Text)
        op = “-”
        TextBox1.Text = “”
    End Sub
End Class
