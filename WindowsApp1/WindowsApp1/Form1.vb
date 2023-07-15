Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 5 Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text.Length = 5 Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Length = 5 Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text.Length = 5 Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text.Length = 5 Then
            Button1.Enabled = True
            Button1.Focus()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = ("AF2GH") Then
            If TextBox3.Text = ("4F3V6") Then
                If TextBox2.Text = ("KLT65") Then
                    If TextBox5.Text = ("VG5TG") Then
                        If TextBox4.Text = ("7JHUK") Then
                            MessageBox.Show("Correct key, congrats!")
                        Else
                            MessageBox.Show("Incorrect key entered, try again!")
                        End If
                    Else
                        MessageBox.Show("Incorrect key entered, try again!")
                    End If
                Else
                    MessageBox.Show("Incorrect key entered, try again!")
                End If
            Else
                MessageBox.Show("Incorrect key entered, try again!")
            End If

        Else
            MessageBox.Show("Incorrect key entered, try again!")
        End If
    End Sub
End Class
