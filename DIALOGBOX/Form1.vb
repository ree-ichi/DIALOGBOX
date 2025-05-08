Public Class Form1
    Private Sub BtnCek_Click(sender As Object, e As EventArgs) Handles BtnCek.Click
        Dim inputText As String = TextBox1.Text
        Dim nilai As Integer

        If Not Integer.TryParse(inputText, nilai) Then
            MessageBox.Show("Input tidak valid! Harap masukkan angka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Clear()
            TextBox1.Focus()
        ElseIf nilai < 0 OrElse nilai > 100000 Then
            MessageBox.Show("Angka di luar jangkauan! Masukkan angka antara 0 hingga 100000.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Clear()
            TextBox1.Focus()
        Else
            MessageBox.Show("Input valid. Program akan keluar.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Application.Exit()
    End Sub
End Class
