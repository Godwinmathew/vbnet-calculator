Public Class Form1
    Dim value As Double = 0
    Dim operation As String = ""
    Dim operation_pressed As Boolean = False
    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged

    End Sub

    Private Sub Button_7_Click(sender As Object, e As EventArgs) Handles Button_7.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "7"
        Else
            txtDisplay.Text &= "7"
        End If

    End Sub

    Private Sub Button_8_Click(sender As Object, e As EventArgs) Handles Button_8.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "8"
        Else
            txtDisplay.Text &= "8"
        End If

    End Sub

    Private Sub Button_9_Click(sender As Object, e As EventArgs) Handles Button_9.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "9"
        Else
            txtDisplay.Text &= "9"
        End If
    End Sub

    Private Sub Button_4_Click(sender As Object, e As EventArgs) Handles Button_4.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "4"
        Else
            txtDisplay.Text &= "4"
        End If
    End Sub

    Private Sub Button_5_Click(sender As Object, e As EventArgs) Handles Button_5.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "5"
        Else
            txtDisplay.Text &= "5"
        End If
    End Sub

    Private Sub Button_6_Click(sender As Object, e As EventArgs) Handles Button_6.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "6"
        Else
            txtDisplay.Text &= "6"
        End If
    End Sub

    Private Sub Button_1_Click(sender As Object, e As EventArgs) Handles Button_1.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "1"
        Else
            txtDisplay.Text &= "1"
        End If
    End Sub

    Private Sub Button_2_Click(sender As Object, e As EventArgs) Handles Button_2.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "2"
        Else
            txtDisplay.Text &= "2"
        End If
    End Sub

    Private Sub Button_3_Click(sender As Object, e As EventArgs) Handles Button_3.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "3"
        Else
            txtDisplay.Text &= "3"
        End If
    End Sub

    Private Sub Button_0_Click(sender As Object, e As EventArgs) Handles Button_0.Click
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = "0"
        Else
            txtDisplay.Text &= "0"
        End If
    End Sub

    Private Sub Buttonadd_Click(sender As Object, e As EventArgs) Handles Buttonadd.Click
        operation = "+"
        value = Val(txtDisplay.Text)
        operation_pressed = True
        txtDisplay.Text = "0"
    End Sub

    Private Sub Buttonsub_Click(sender As Object, e As EventArgs) Handles Buttonsub.Click
        operation = "-"
        value = Val(txtDisplay.Text)
        operation_pressed = True
        txtDisplay.Text = "0"
    End Sub

    Private Sub Buttonmulti_Click(sender As Object, e As EventArgs) Handles Buttonmulti.Click
        operation = "*"
        value = Val(txtDisplay.Text)
        operation_pressed = True
        txtDisplay.Text = "0"
    End Sub

    Private Sub Buttondiv_Click(sender As Object, e As EventArgs) Handles Buttondiv.Click
        operation = "/"
        value = Val(txtDisplay.Text)
        operation_pressed = True
        txtDisplay.Text = "0"
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        Dim second As Double
        second = Val(txtDisplay.Text)

        If operation = "+" Then
            txtDisplay.Text = value + second
        ElseIf operation = "-" Then
            txtDisplay.Text = value - second
        ElseIf operation = "*" Then
            txtDisplay.Text = value * second
        ElseIf operation = "/" Then
            txtDisplay.Text = value / second
        End If
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        txtDisplay.Text = "0"
        value = 0
    End Sub

    Private Sub Buttondot_Click(sender As Object, e As EventArgs) Handles Buttondot.Click
        If Not txtDisplay.Text.Contains(".") Then
            txtDisplay.Text &= "."
        End If
    End Sub
End Class
