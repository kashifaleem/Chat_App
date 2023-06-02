Public Class Settings

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Me.FolderBrowserDialog1.ShowDialog()
        Me.txtFolder.Text = Me.FolderBrowserDialog1.SelectedPath

    End Sub


    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFolder.Text = My.Settings.RcvdFile
        txtNick.Text = My.Settings.NickName
        Me.txtIP.Text = My.Settings.ServerIP
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not IsNothing(Me.FolderBrowserDialog1.SelectedPath) And Not Me.FolderBrowserDialog1.SelectedPath = "" Then
            My.Settings.RcvdFile = Me.FolderBrowserDialog1.SelectedPath & "\"
        End If
        If Not IsNothing(Me.txtNick.Text) And Not Me.txtNick.Text = "" Then
            My.Settings.NickName = Me.txtNick.Text
        End If

        If Not IsNothing(Me.txtIP.Text) And Not Me.txtIP.Text = "" Then
            My.Settings.ServerIP = Me.txtIP.Text
        End If
        My.Settings.Save()
        Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class