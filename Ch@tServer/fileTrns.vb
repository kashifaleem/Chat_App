Imports System.Net
Public Class fileTrns

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.txtFile.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            FrmChatServer.ip = IPAddress.Parse(Me.txtIP.Text)
            FrmChatServer.filename = Me.txtFile.Text
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class