# TestProductKeyForm
This is a form with a product key checker in VB.NET

![image](https://github.com/poalchTRUNK/TestProductKeyForm/assets/110284837/05e01465-5a8f-4493-b1fd-e70fb5086d8f)


# How does this work?
It's very simple. Let me explain.

1. When you type the product key, and the TextBox reaches five characters, it switches focus to the second TextBox, and so on, until we get to the last Textbox, and after you type it in, it switches focus to the Button
 
![image](https://github.com/poalchTRUNK/TestProductKeyForm/assets/110284837/92637341-e016-4f63-b621-b924d208f2d4)

2. When you press the button, it goes to a cycle of If commands, that checks every cell for the correct key. If some cell is incorrect, there is an Else statement that shows a MsgBox, that the key is incorrect.

![image](https://github.com/poalchTRUNK/TestProductKeyForm/assets/110284837/34726ea6-7270-432b-a23b-5fc8fbfd026f)

3. When it successfully checks all cells and everything is correct, it shows a MsgBox, that it is all correct.

![image](https://github.com/poalchTRUNK/TestProductKeyForm/assets/110284837/f1edeb4c-4920-4e85-a994-b6bc49f37a03)

4. code for 1 and 2

![image](https://github.com/poalchTRUNK/TestProductKeyForm/assets/110284837/cce2cb5d-897c-4b24-b55b-80c540f33553)
  
That's all!



# If you're too lazy to open the code, here's a copy of Form1.vb, the main code
```
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
```

yeah, i know, the textbox numbering is not in the correct order :-|

