Public Class Form1
    Private Sub btnMostraValores_Click(sender As Object, e As EventArgs) Handles btnMostraValores.Click

        Dim intIdade As Integer = 42
        Dim dblAltura As Double = 1.65
        Dim strNome As String = "guizaodozap"
        Dim bolHasChild As Boolean = True


        MsgBox(intIdade)
        MsgBox(dblAltura)
        MsgBox(strNome)
        MsgBox(bolHasChild)

    End Sub

    Private Sub btnMostraMat_Click(sender As Object, e As EventArgs) Handles btnMostraMat.Click

        Dim intNumber As Integer

        'soma
        intNumber = 20
        intNumber = intNumber + 5

        MessageBox.Show("the number with plus five is: " & intNumber.ToString, "Soma")

        'subtração
        intNumber = 20
        intNumber = intNumber - 5

        MessageBox.Show("the number with less five is: " & intNumber.ToString, "subtracao")

        'multiplicação
        intNumber = 20
        intNumber = intNumber * 5

        MessageBox.Show("the number with 5 times is: " & intNumber.ToString, "multiplicacao")

        'divisao
        intNumber = 20
        intNumber = intNumber / 5

        MessageBox.Show("the number divided to 5 is: " & intNumber.ToString, "divisao")

        'resto de divisao
        intNumber = 20
        intNumber = intNumber Mod 5

        MessageBox.Show("the mod of 20 for 5: " & intNumber.ToString, "mod")

    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click

        Dim dblNumber As Double

        'mult
        dblNumber = 25.23

        dblNumber *= 5.6

        MessageBox.Show("Im testing the double type: " & dblNumber.ToString("#.##"), "double type")

        'div
        dblNumber = 15

        dblNumber /= 6

        MessageBox.Show("Im testing the double type: " & dblNumber.ToString("#.##"), "double type")
    End Sub

    Private Sub btnIF_Click(sender As Object, e As EventArgs) Handles btnIF.Click

        'CDbl is a way to convert data to double
        Dim intNumber As Integer = CDbl(txtNumber.Text)

        If intNumber = 27 Then

            MessageBox.Show($"the number is equals: {intNumber}", "if else")

        ElseIf intNumber = 2 Then

            MessageBox.Show($"the number {intNumber} is diferent of 27")

        Else
            MessageBox.Show($"the number {intNumber} is diferent of both")
        End If


    End Sub

    Private Sub btnVerifyName_Click(sender As Object, e As EventArgs) Handles btnVerifyName.Click

        Dim StrName As String = txtName.Text

        'If StrName = "guizaodozap" Then

        '    MessageBox.Show($"you're the super {StrName} bruhh")

        'ElseIf StrName = "gabriel" Then

        '    MessageBox.Show($"you're only the {StrName} cof cof")

        'Else

        '    MessageBox.Show("you're nothing bruh, get out of here")

        'End If

        ' <> -> means diferent like !=

        If StrName <> "guizaodozap" Then

            MessageBox.Show("you're nothing")

        ElseIf StrName = "guizaodozap" Then

            MessageBox.Show($"you're so handsome {StrName}")

        Else
            MessageBox.Show("type anything right")

        End If

    End Sub

    Private Sub btnVerifyHeight_Click(sender As Object, e As EventArgs) Handles btnVerifyHeight.Click
        'dado em metros

        'using try catch
        Dim dblHeight As Double

        Try
            dblHeight = CDbl(txtHeight.Text)
        Catch
            Exit Sub
        End Try


        If dblHeight > 0 And dblHeight <= 1 Then

            MessageBox.Show("You're a dwarf !!", "Dwarf")

        ElseIf dblHeight > 1 And dblHeight <= 1.5 Then

            MessageBox.Show("You're almost a dwarf !!", "almost Dwarf")

        ElseIf dblHeight > 1.5 And dblHeight <= 2 Then

            MessageBox.Show("You're a normal person!!", "normal person")

        Else
            MessageBox.Show("type right values", "warning")
        End If

    End Sub

    Private Sub btnLoopFor_Click(sender As Object, e As EventArgs) Handles btnLoopFor.Click

        Dim intConta As Integer

        'calling an another routine
        LimparLista()

        'puting data in the list
        For intConta = 1 To 10
            lstDados.Items.Add($" 9 x {intConta.ToString} = {9 * intConta}")
        Next

    End Sub

    Private Sub LimparLista()
        'cleaning the list
        lstDados.Items.Clear()

        lstDadosWhile.Items.Clear()

    End Sub

    Private Sub btnLoopWhile_Click(sender As Object, e As EventArgs) Handles btnLoopWhile.Click
        Dim intCount As Integer = 0

        'calling another subroutine
        LimparLista()

        Do While intCount < 11

            lstDadosWhile.Items.Add($"5 x {intCount.ToString} = {5 * intCount}")

            intCount += 1
        Loop

    End Sub
End Class
