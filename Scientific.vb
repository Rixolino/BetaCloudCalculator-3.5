Public Class Scientific
    Dim memory As Double
    Dim operation As String
    Dim a, b
    Dim op As String
    Dim x
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
    Function Factorial(n As Integer) As Integer
        If n <= 1 Then
            Return 1
        End If
        Return Factorial(n - 1) * n
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Me.Close()
        Normal.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & “1”
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & “2”
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & “3”
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & “4”
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & “5”
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & “6”
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text & “7”
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & “8”
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox1.Text = TextBox1.Text & “9”
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TextBox1.Text = TextBox1.Text & “0”
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & “(”
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text & “)”
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        TextBox3.Text = Math.Sin(TextBox1.Text)
        TextBox2.Text = "sin"
        functions.Text = ""
        xEsp.Enabled = True
        Button29.Enabled = True
        ButtonAnsC.Show()
    End Sub
    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        TextBox3.Text = Math.Tan(TextBox1.Text)
        ButtonAnsC.Show()
        Label4.Hide()
        Label6.Hide()
        functions.Text = ""
        TextBox2.Text = "tan"
        xEsp.Enabled = True
        Button29.Enabled = True
    End Sub

    Private Sub GreekPi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GreekPi.Click
        TextBox1.Text = Math.PI
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = “”
        TextBox2.Text = “”
        TextBox3.Text = “”
        oplabel.Text = ""
        functions.Text = ""
        ERRProvider.Text = ""
        Label6.Hide()
        Label4.Hide()
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        ButtonAnsC.Hide()
        xEsp.Enabled = True
        Button29.Enabled = True
    End Sub
    Private Sub sqrtB_Click(sender As Object, e As EventArgs) Handles sqrtB.Click
        TextBox3.Text = Math.Sqrt(TextBox1.Text)
        TextBox2.Text = "sqrt"
        oplabel.Text = "√"
        xEsp.Enabled = True
        Button29.Enabled = True
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        functions.Text = ""
        ButtonAnsC.Show()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        TextBox3.Text = TextBox1.Text ^ (1 / 3)
        TextBox2.Text = "cbrt"
        functions.Text = ""
        oplabel.Text = "3√"
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        xEsp.Enabled = True
        Button29.Enabled = True
        ButtonAnsC.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) 
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

    Private Sub MoltButt_Click(sender As Object, e As EventArgs) Handles MoltButt.Click
        Label4.Hide()
        Label6.Hide()
        TextBox3.Text = TextBox1.Text * TextBox2.Text
        oplabel.Text = "*"
        functions.Text = ""
        ButtonAnsC.Show()
    End Sub

    Private Sub MinusButt_Click(sender As Object, e As EventArgs) Handles MinusButt.Click
        Label4.Hide()
        Label6.Hide()
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        TextBox3.Text = (a - b)
        oplabel.Text = "-"
        functions.Text = ""
        ButtonAnsC.Show()
    End Sub

    Private Sub DivButton_Click(sender As Object, e As EventArgs) Handles DivButton.Click
        Label4.Hide()
        Label6.Hide()
        TextBox3.Text = TextBox1.Text / TextBox2.Text
        oplabel.Text = "/"
        functions.Text = ""
        ButtonAnsC.Show()
    End Sub

    Private Sub ScientificActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificActualToolStripMenuItem.Click

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Label6.Show()
        Label4.Show()
        oplabel.Text = "x√"
        functions.Text = ""
        TextBox3.Text = TextBox1.Text ^ (1 / TextBox2.Text)
        ButtonAnsC.Hide()
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox2.Text = TextBox2.Text & “1”
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox2.Text = TextBox2.Text & “2”
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox2.Text = TextBox2.Text & “3”
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox2.Text = TextBox2.Text & “4”
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox2.Text = TextBox2.Text & “5”
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox2.Text = TextBox2.Text & “6”
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.Text = TextBox2.Text & “7”
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Text = TextBox2.Text & “8”
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text = TextBox2.Text & “9”
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text = TextBox2.Text & “0”
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub TenEsp_Click(sender As Object, e As EventArgs) Handles xEsp.Click
        Label4.Hide()
        Label6.Hide()
        TextBox3.Text = TextBox1.Text ^ TextBox2.Text
        oplabel.Text = "^"
        functions.Text = ""
        ButtonAnsC.Show()
    End Sub

    Private Sub SquarePot_Click(sender As Object, e As EventArgs) Handles SquarePot.Click
        TextBox3.Text = TextBox1.Text ^ 2
        TextBox2.Text = "2"
        oplabel.Text = "^"
        xEsp.Enabled = True
        Button29.Enabled = True
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        Label4.Hide()
        Label6.Hide()
        functions.Text = ""
        ButtonAnsC.Show()
    End Sub

    Private Sub CubButt_Click(sender As Object, e As EventArgs) Handles CubButt.Click
        TextBox3.Text = TextBox1.Text ^ 3
        oplabel.Text = "^"
        functions.Text = ""
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = True
        Button29.Enabled = True
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        TextBox2.Text = "3"
        ButtonAnsC.Show()
    End Sub

    Private Sub DEGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEGToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 180 / Math.PI
        functions.Show()
        functions.Text = "RAD => DEG"
        oplabel.Text = ""
        TextBox2.Text = "*180/π"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub NeperoButt_Click(sender As Object, e As EventArgs) Handles NeperoButt.Click
        TextBox1.Text = 2.71828182846
    End Sub
    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        TextBox3.Text = Math.Cos(TextBox1.Text)
        functions.Text = ""
        TextBox2.Text = "cos"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = True
        Button29.Enabled = True
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TextBox2.Text = "%"
        TextBox3.Text = (TextBox1.Text / 100)
        functions.Text = ""
        oplabel.Text = ""
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = True
        Button29.Enabled = True
    End Sub

    Private Sub Button32_Click_1(sender As Object, e As EventArgs) Handles Button32.Click
        TextBox1.Text = "-"
    End Sub

    Private Sub EspButton_Click(sender As Object, e As EventArgs) Handles EspButton.Click
        TextBox3.Text = Factorial(TextBox1.Text)
        TextBox2.Text = "fact"
        functions.Text = ""
        oplabel.Text = "!"
        Label4.Hide()
        Label6.Hide()
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        xEsp.Enabled = True
        Button29.Enabled = True
        ButtonAnsC.Show()
    End Sub

    Private Sub Button1000_Click(sender As Object, e As EventArgs) Handles Button1000.Click
        TextBox2.Text = TextBox2.Text & “-”
    End Sub

    Private Sub Del1_Click(sender As Object, e As EventArgs) Handles Del1.Click
        TextBox1.Text = ""
        Label4.Hide()
        Label6.Hide()
        oplabel.Text = ""
        ButtonAnsC.Hide()
    End Sub

    Private Sub Del2_Click(sender As Object, e As EventArgs) Handles Del2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        xEsp.Enabled = True
        Button29.Enabled = True
        functions.Text = ""
        Label4.Hide()
        Label6.Hide()
        oplabel.Text = ""
        ButtonAnsC.Hide()
    End Sub



    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        TextBox2.Text = 2.71828182846
    End Sub

    Private Sub GreekPi2_Click(sender As Object, e As EventArgs) Handles GreekPi2.Click
        TextBox2.Text = Math.PI
    End Sub


    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Label4.Hide()
        Label6.Hide()
        TextBox3.Text = Math.Log(TextBox1.Text)
        TextBox2.Text = "log"
        functions.Text = ""
        xEsp.Enabled = True
        Button29.Enabled = True
        ButtonAnsC.Show()
    End Sub

    Private Sub Ans_Click(sender As Object, e As EventArgs) Handles Ans.Click
        PlusButt.Enabled = True
        MinusButt.Enabled = True
        MoltButt.Enabled = True
        DivButton.Enabled = True
        xEsp.Enabled = True
        Button29.Enabled = True
        functions.Text = ""
        TextBox1.Text = TextBox3.Text
        TextBox2.Text = ""
        TextBox3.Text = ""
        oplabel.Text = ""
    End Sub

    Private Sub ButtonAnsC_Click(sender As Object, e As EventArgs) Handles ButtonAnsC.Click
        Answer.Show()
    End Sub

    Private Sub FormulasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulasToolStripMenuItem.Click
        Formulas.Show()
    End Sub

    Private Sub RADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RADToolStripMenuItem.Click
        Label4.Hide()
        Label6.Hide()
        TextBox3.Text = TextBox1.Text * Math.PI / 180
        functions.Show()
        TextBox2.Text = "*π/180"
        oplabel.Text = ""
        functions.Text = "DEG => RAD"
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub INVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INVToolStripMenuItem.Click
        Label4.Hide()
        Label6.Hide()
        TextBox3.Text = TextBox1.Text * 180 / 200
        functions.Show()
        TextBox2.Text = "*180/200"
        oplabel.Text = ""
        functions.Text = "GRAD => DEG"
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub GRADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GRADToolStripMenuItem.Click
        Label4.Hide()
        Label6.Hide()
        TextBox3.Text = TextBox1.Text * Math.PI / 200
        functions.Show()
        TextBox2.Text = "*π/200"
        oplabel.Text = ""
        functions.Text = "GRAD => RAD"
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub RADGRADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RADGRADToolStripMenuItem.Click
        Label4.Hide()
        Label6.Hide()
        TextBox3.Text = TextBox1.Text * 200 / Math.PI
        functions.Show()
        TextBox2.Text = "*200/π"
        oplabel.Text = ""
        functions.Text = "RAD => GRAD"
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DEGGRADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEGGRADToolStripMenuItem.Click
        Label4.Hide()
        Label6.Hide()
        TextBox3.Text = TextBox1.Text * 200 / 180
        functions.Show()
        TextBox2.Text = "*200/180"
        oplabel.Text = ""
        functions.Text = "DEG => GRAD"
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub FunctionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FunctionsToolStripMenuItem.Click

    End Sub

    Private Sub UnitOfMeasureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitOfMeasureToolStripMenuItem.Click
        Convertitor.Show()
        Me.Close()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox1.Text = TextBox1.Text & “,”
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        TextBox2.Text = TextBox2.Text & “,”
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub LinearEquationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinearEquationsToolStripMenuItem.Click

    End Sub

    Private Sub NormalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem1.Click
        Linearequations.Show()
        Me.Close()
    End Sub

    Private Sub AdvancedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvancedToolStripMenuItem.Click
        LinEquationTriple.Show()
        Me.Close()
    End Sub
    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConversionToolStripMenuItem.Click

    End Sub
    Private Sub KmHmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmHmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        functions.Show()
        functions.Text = "k => h"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub KmDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmDamToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 100
        TextBox2.Text = "*100"
        functions.Show()
        functions.Text = "k => da"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub KmMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmMToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 1000
        TextBox2.Text = "*1000"
        functions.Show()
        functions.Text = "k => u"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub KmDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmDmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 10000
        TextBox2.Text = "*10000"
        functions.Show()
        functions.Text = "k => d"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub KmCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmCmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 100000
        TextBox2.Text = "*100000"
        functions.Show()
        functions.Text = "k => c"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub KmMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KmMmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 1000000
        TextBox2.Text = "*1000000"
        functions.Show()
        functions.Text = "k => m"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmKmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        functions.Show()
        functions.Text = "h => k"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmDamToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        functions.Show()
        functions.Text = "h => k"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmMToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 100
        TextBox2.Text = "*100"
        functions.Show()
        functions.Text = "h => u"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmDmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 1000
        TextBox2.Text = "*1000"
        functions.Show()
        functions.Text = "h => d"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmCmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 10000
        TextBox2.Text = "*10000"
        functions.Show()
        functions.Text = "h => c"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub HmMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HmMmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 100000
        TextBox2.Text = "*100000"
        functions.Show()
        functions.Text = "h => m"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamKmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 100
        TextBox2.Text = "/100"
        functions.Show()
        functions.Text = "da => k"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamHmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamHmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        functions.Show()
        functions.Text = "da => h"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamMToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        functions.Show()
        functions.Text = "da => u"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamDmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 100
        TextBox2.Text = "*100"
        functions.Show()
        functions.Text = "da => d"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamCmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 1000
        TextBox2.Text = "*1000"
        functions.Show()
        functions.Text = "da => c"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DamMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DamMmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 10000
        TextBox2.Text = "*10000"
        functions.Show()
        functions.Text = "da => m"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MKmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MKmToolStripMenuItem1.Click
        TextBox3.Text = TextBox1.Text / 1000
        TextBox2.Text = "/1000"
        functions.Show()
        functions.Text = "u => k"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MHmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MHmToolStripMenuItem1.Click
        TextBox3.Text = TextBox1.Text / 100
        TextBox2.Text = "/100"
        functions.Show()
        functions.Text = "u => h"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MDamToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MDamToolStripMenuItem1.Click
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        functions.Show()
        functions.Text = "u => da"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MDmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        functions.Show()
        functions.Text = "u => d"
    End Sub

    Private Sub MCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MCmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 100
        TextBox2.Text = "*100"
        functions.Show()
        functions.Text = "u => c"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MMmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 1000
        TextBox2.Text = "*1000"
        functions.Show()
        functions.Text = "u => m"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmKmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 10000
        TextBox2.Text = "/10000"
        functions.Show()
        functions.Text = "d => k"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmHmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmHmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 1000
        TextBox2.Text = "/1000"
        functions.Show()
        functions.Text = "d => h"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmDamToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 100
        TextBox2.Text = "/100"
        functions.Show()
        functions.Text = "d => da"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmMToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        functions.Show()
        functions.Text = "d => u"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmCmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        functions.Show()
        functions.Text = "d => c"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub DmMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DmMmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 100
        TextBox2.Text = "*100"
        functions.Show()
        functions.Text = "d => m"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub CmKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CmKmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 100000
        TextBox2.Text = "/100000"
        functions.Show()
        functions.Text = "c => k"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub
    Private Sub CmDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CmDamToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 10000
        TextBox2.Text = "/10000"
        functions.Show()
        functions.Text = "c => h"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 1000
        TextBox2.Text = "/1000"
        functions.Show()
        functions.Text = "c => da"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub CmMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CmMToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 100
        TextBox2.Text = "/100"
        functions.Show()
        functions.Text = "c => u"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub CmDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CmDmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        functions.Show()
        functions.Text = "c => d"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub CmMmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CmMmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text * 10
        TextBox2.Text = "*10"
        functions.Show()
        functions.Text = "c => m"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmKmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MmKmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 1000000
        TextBox2.Text = "/1000000"
        functions.Show()
        functions.Text = "mm => km"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmCmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MmCmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 100000
        TextBox2.Text = "/100000"
        functions.Show()
        functions.Text = "mm => hm"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmDamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MmDamToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 10000
        TextBox2.Text = "/10000"
        functions.Show()
        functions.Text = "mm => dam"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmMToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MmMToolStripMenuItem1.Click
        TextBox3.Text = TextBox1.Text / 1000
        TextBox2.Text = "/1000"
        functions.Show()
        functions.Text = "mm => m"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmDmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MmDmToolStripMenuItem.Click
        TextBox3.Text = TextBox1.Text / 100
        TextBox2.Text = "/100"
        functions.Show()
        functions.Text = "mm => dm"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub MmCmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MmCmToolStripMenuItem1.Click
        TextBox3.Text = TextBox1.Text / 10
        TextBox2.Text = "/10"
        functions.Show()
        functions.Text = "mm => cm"
        Label4.Hide()
        Label6.Hide()
        xEsp.Enabled = False
        Button29.Enabled = False
        PlusButt.Enabled = False
        MinusButt.Enabled = False
        MoltButt.Enabled = False
        DivButton.Enabled = False
        ButtonAnsC.Show()
    End Sub

    Private Sub PlusButt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlusButt.Click
        Label4.Hide()
        Label6.Hide()
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        TextBox3.Text = (a + b)
        oplabel.Text = "+"
        functions.Text = ""
        ButtonAnsC.Show()
    End Sub
End Class