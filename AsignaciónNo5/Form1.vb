Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim BoxGood As DialogResult


        If (PasswordTxt.Text = "3312") Then

            BoxGood = MessageBox.Show("Muy bien hecho eres todo/a un/a Hacker!", "Hacker!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If (BoxGood = DialogResult.OK) Then
                Me.Close()
            End If

        End If

        PasswordTxt.Text = ("")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PasswordTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTxt.KeyPress
        SoloNumeros(e)
    End Sub

    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

End Class
