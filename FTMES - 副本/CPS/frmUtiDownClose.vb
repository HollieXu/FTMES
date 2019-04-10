Public Class frmUtiDownClose
    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub
End Class