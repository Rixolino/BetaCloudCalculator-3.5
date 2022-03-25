Public Class Graphicsa
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Dim HighestNumber As Double = 1.33
    Dim LowestNumber As Double = 0.99
    Dim GraphClientArea As Single = 400
    Dim HalfClientArea As Single = GraphClientArea / 2
    Dim X As Integer
    Dim Cur
    Dim G
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


    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

        Dim clientArea As Single = PictureBox1.Height

        Dim Max As Single = 1207.43

        Dim g As Graphics = e.Graphics

        Dim LastPoint As New Point(0, 0)

        Dim prices As New List(Of Double)
        prices.Add(1207.43)
        prices.Add(1107.2)
        prices.Add(1203.33)
        prices.Add(807.12)
        prices.Add(607.21)
        prices.Add(907.53)
        prices.Add(607.61)
        prices.Add(1000.43)

        For i = 0 To prices.Count - 1
            Cur = prices(i)

            Dim col = i * 100
            Dim y As Single = (clientArea - (clientArea * (Cur / Max)))


            g.FillRectangle(Brushes.Black, New Rectangle(col, y, 10, 10))
            g.DrawString(Cur.ToString, Me.Font, Brushes.Black, New Point(col + 12, y))

            g.DrawLine(Pens.Blue, LastPoint, New Point(col, y))

            LastPoint = New Point(col, y) ' cur vector becomes prev vector for next iteration

        Next

        For X = 1 To 50 ' roll X for 500px total
            Dim r As New Random
            Dim CurX As Single = X * 10 ' 10px blocks horiz
            Dim CurrentNumber As Double = 1.02 + r.Next(-0.1, 0.1) ' make up a random number in range

            Dim Spread As Double = HighestNumber - LowestNumber
            Dim SpreadPercentage As Double = (LowestNumber / HighestNumber)

            Dim Y As Double = (HalfClientArea * SpreadPercentage) - (SpreadPercentage * CurrentNumber)

            g.FillEllipse(Brushes.White, New Rectangle(X, Y, 2, 2))

        Next
    End Sub


    Private Sub Graphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Normal.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Scientific.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        FunctionConverter.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Linearequations.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        LinEquationTriple.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        Formulas.Show()
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        About.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As PaintEventArgs) Handles Button1.Click

        Dim g As Graphics = e.Graphics

        Dim LastPoint As New Point(0, 0)

        Dim prices As New List(Of Double)

        prices.Add(i1.Text)
        prices.Add(i2.Text)
        prices.Add(i3.Text)
        prices.Add(i4.Text)
        prices.Add(i5.Text)
        prices.Add(i6.Text)
        prices.Add(i7.Text)
        prices.Add(i8.Text)
    End Sub
End Class