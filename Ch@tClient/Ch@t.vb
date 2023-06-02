
' Fig. 23.1: FrmChatServer.vb
' Set up a server that will receive a connection from a client, send a
' string to the client, chat with the client and close the connection.
Imports System.Threading
Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports Microsoft.Win32

Public Class Ch_t
    Private output As NetworkStream ' stream for receiving data          
    Private writer As BinaryWriter ' facilitates writing to the stream   
    Private reader As BinaryReader ' facilitates reading from the stream  
    Private readThread As Thread ' Thread for processing incoming messages
    Private message As String = ""
    Private connected As Boolean = False

   

    

    ' initialize thread for reading
    Private Sub Ch_t_Load(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.txtNick.Text = My.Settings.NickName
        Me.UltraToolbarsManager1.Ribbon.ApplicationMenu.ToolAreaLeft.Tools("File Transfer").InstanceProps.Visible = Infragistics.Win.DefaultableBoolean.False
        btnIP_Click(Nothing, Nothing)
        'Registry.LocalMachine.OpenSubKey("Software", RegistryKeyPermissionCheck.ReadWriteSubTree).OpenSubKey("Customer", RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("TLimit", CStr(CInt(Registry.LocalMachine.OpenSubKey("Software", RegistryKeyPermissionCheck.ReadWriteSubTree).OpenSubKey("Customer", RegistryKeyPermissionCheck.ReadWriteSubTree).GetValue("TLimit")) - 1))
    End Sub ' FrmChatClient_Load

    ' close all threads associated with this application
    Private Sub Ch_t_FormClosing(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.FormClosingEventArgs) _
    Handles MyBase.FormClosing

        NotifyIcon1.Dispose()
        System.Environment.Exit(System.Environment.ExitCode)

    End Sub ' FrmChatClient_FormClosing

    ' Delegate that allows method  DisplayMessage to be called
    ' in the thread that creates and  maintains the GUI
    Private Delegate Sub DisplayDelegate(ByVal message As String)
    Private Delegate Sub abcDelegate(ByVal abc As Integer)
    ' method DisplayMessage sets txtDisplay's Text property
    ' in a thread-safe manner
    Private Sub abc(ByVal abc As Integer)
        Me.txtDisplay.Select(abc, 0)
        Me.txtDisplay.ScrollToCaret()
    End Sub
    Private Sub DisplayMessage(ByVal message As String)
        ' if modifying txtDisplay is not thread safe
        If txtDisplay.InvokeRequired Then
            ' use inherited method Invoke to execute DisplayMessage 
            ' via a Delegate                                        
            Invoke(New DisplayDelegate(AddressOf DisplayMessage), _
            New Object() {message})

            Invoke(New abcDelegate(AddressOf abc), txtDisplay.Text.Length)


            ' OK to modify txtDisplay in current thread
        Else
            txtDisplay.Text &= message
            Me.txtDisplay.Select(Me.txtDisplay.Text.Length, 0)
            Me.txtDisplay.ScrollToCaret()
            Me.Activate()
        End If
        If Not Me.Visible Then
            Me.NotifyIcon1.ShowBalloonTip(3, "Ch@t", message, ToolTipIcon.Info)

        End If '

    End Sub ' DisplayMessage

    Private Delegate Sub timerDelegate()
    Private Sub timerEnable()

        Timer1.Enabled = True
    End Sub



    ' Delegate that allows method  DisableInput to be  called
    ' in the thread that creates and  maintains the GUI
    Private Delegate Sub DisableInputDelegate(ByVal value As Boolean)

    ' method DisableInput sets txtInput's ReadOnly property
    ' in  a thread-safe manner
    Private Sub DisableInput(ByVal value As Boolean)
        ' if modifying txtInput is not thread safe
        If txtInput.InvokeRequired Then
            ' use inherited method Invoke to execute DisableInput     
            ' via a Delegate                                          
            Invoke(New DisableInputDelegate(AddressOf DisableInput), _
            New Object() {value})

            ' OK to modify txtInput in current thread
        Else
            txtInput.ReadOnly = value
        End If

        toolConnect.Enabled = value
        If value = True Then
            Me.UltraToolbarsManager1.Ribbon.ApplicationMenu.ToolAreaLeft.Tools("File Transfer").InstanceProps.Visible = Infragistics.Win.DefaultableBoolean.False
        Else
            Me.UltraToolbarsManager1.Ribbon.ApplicationMenu.ToolAreaLeft.Tools("File Transfer").InstanceProps.Visible = Infragistics.Win.DefaultableBoolean.True
        End If

    End Sub ' DisableInput

    ' sends text the user typed to server
    Private Sub txtInput_KeyDown(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.KeyEventArgs) _
            Handles txtInput.KeyDown

        Try
            If e.KeyCode = Keys.Enter And txtInput.ReadOnly = False Then
                writer.Write(My.Settings.NickName & ">>> " & txtInput.Text)
                'txtDisplay.Text &= vbCrLf & My.Settings.NickName & ">>> " & txtInput.Text
                txtInput.Clear()
                Me.txtDisplay.Select(Me.txtDisplay.Text.Length, 0)
                Me.txtDisplay.ScrollToCaret()
            End If
        Catch ex As SocketException
            txtDisplay.Text &= vbCrLf & "Error writing object"
            'Finally
            '    Me.txtDisplay.Select(Me.txtDisplay.Text.Length - 1, 0)
            '    Me.txtDisplay.ScrollToCaret()
        End Try
    End Sub ' txtInput_KeyDown

    ' connect to server and display server-generated text
    Public Sub RunClient()
        Dim client As TcpClient
        'Me.toolConnect.Enabled = False
        ' instantiate TcpClient for sending data to server
        Try
            DisplayMessage(vbCrLf & "Attempting connection" & vbCrLf)
            Timer1.Enabled = False


            ' Step 1: create TcpClient and connect to server
            client = New TcpClient()
            client.Connect(My.Settings.ServerIP, 50000)

            ' Step 2: get NetworkStream associated with TcpClient
            output = client.GetStream()

            connected = True
            Timer1.Interval = 5000

            ' create objects for writing and reading across stream
            writer = New BinaryWriter(output)
            reader = New BinaryReader(output)

            'DisplayMessage(vbCrLf & "Got I/O streams" & vbCrLf)


            DisableInput(False) ' enable txtInput

            ' loop until server signals termination
            Do
                ' Step 3: processing phase
                Try
                    ' read message from server      
                    message = reader.ReadString()
                    If message = "File Transfer Permission" Then
                        Dim fileThread As Thread
                        fileThread = New Thread(New ThreadStart(AddressOf filercv))
                        fileThread.Start()

                    Else
                        DisplayMessage(vbCrLf & message)
                    End If
                Catch ex As Exception
                    ' handle exception if error in reading server data
                    DisplayMessage(vbCrLf & "Connection Failed" & vbCrLf)
                    Invoke(New timerDelegate(AddressOf timerEnable))
                    Me.toolConnect.Enabled = True
                    Ch_t_Load(Nothing, Nothing)
                    Me.toolConnect.Enabled = True
                    Thread.CurrentThread.Abort()
                    'System.Environment.Exit(System.Environment.ExitCode)
                End Try
            Loop While message.Substring(message.Length - 9) <> "TERMINATE"

            ' Step 4: close connection
            writer.Close()
            reader.Close()
            output.Close()
            client.Close()

            Application.Exit()
        Catch ex As Exception
            ' handle exception if error in establishing connection
            'MessageBox.Show(ex.ToString(), "Connection Error", _
            'MessageBoxButtons.OK, MessageBoxIcon.Error)
            DisplayMessage("Connection Failed" & vbCrLf)
            Invoke(New timerDelegate(AddressOf timerEnable))
            Me.toolConnect.Enabled = True
            'Ch_t_Load(Nothing, Nothing)
            DisableInput(True)
            Thread.CurrentThread.Abort()

            'System.Environment.Exit(System.Environment.ExitCode)
        End Try
    End Sub ' RunClient
    
    Private Sub filesend()

        writer.Write("File Transfer Permission")


        Dim client1 As TcpClient

        ' instantiate TcpClient for sending data to server


        Dim output1 As NetworkStream
        ' Step 1: create TcpClient and connect to server

        client1 = New TcpClient()
        client1.Connect(My.Settings.ServerIP, 50001)

        ' Step 2: get NetworkStream associated with TcpClient
        output1 = client1.GetStream()


        Dim writer1 As BinaryWriter
        Dim reader1 As BinaryReader

        ' create objects for writing and reading across stream
        writer1 = New BinaryWriter(output1)
        reader1 = New BinaryReader(output1)


        Try

            'txtDisplay.Text &= vbCrLf & "File Transfer Permission"
            DisplayMessage(vbCrLf & "File Transfer Permission")
            writer1.Write(ip.ToString)

            'If reader.ReadString() = "Permission Granted" Then
            If reader1.ReadBoolean = True Then
                'txtDisplay.Text &= vbCrLf & "Permission Granted by Reciever"
                DisplayMessage(vbCrLf & "Permission Granted by Reciever")

                Dim fileBytes As Byte()
                'fileBytes = File.ReadAllBytes(OpenFileDialog1.FileName)
                fileBytes = File.ReadAllBytes(fileTransfer)
                writer1.Write(fileBytes.Length)

                writer1.Write(fileTransfer.Substring(fileTransfer.LastIndexOf("\") + 1))

                writer1.Write(fileBytes)


                writer1.Write(True)
                'txtDisplay.Text &= vbCrLf & "File Transferred"
                DisplayMessage(vbCrLf & "File Transferred")
            Else
                'txtDisplay.Text &= vbCrLf & "Denied"
                DisplayMessage(vbCrLf & "Denied")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            client1.Close()
            ip = Nothing
            fileTransfer = Nothing
            Thread.CurrentThread.Abort()

        End Try

    End Sub
    Private Sub filercv()


        Dim client1 As TcpClient

        ' instantiate TcpClient for sending data to server


        Dim output1 As NetworkStream
        ' Step 1: create TcpClient and connect to server
        Try
            client1 = New TcpClient()
            client1.Connect(My.Settings.ServerIP, 50002)

            ' Step 2: get NetworkStream associated with TcpClient
            output1 = client1.GetStream()


            Dim writer1 As BinaryWriter
            Dim reader1 As BinaryReader

            ' create objects for writing and reading across stream
            writer1 = New BinaryWriter(output1)
            reader1 = New BinaryReader(output1)



            DisplayMessage(vbCrLf & "File Recieving Permission")
            Dim res As DialogResult = MessageBox.Show("Do you want to recieve a file from the sender", "Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                writer1.Write(True)
                DisplayMessage(vbCrLf & "Permission Granted to Sender")



                Dim length = reader1.ReadInt32()
                Dim filename = reader1.ReadString()
                Dim buf As Byte() = reader1.ReadBytes(length)

                Dim f As New FileStream(My.Settings.RcvdFile & filename, FileMode.Create)
                Using f
                    f.Write(buf, 0, length)
                End Using

                If reader1.ReadBoolean() = True Then
                    MessageBox.Show("File Recieved successfully", "Thanks")
                    DisplayMessage(vbCrLf & "File Recieved")
                End If
            Else
                writer1.Write(False)
                DisplayMessage(vbCrLf & "Permission Denied")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            client1.Close()
            Thread.CurrentThread.Abort()
        End Try

    End Sub

    Private Sub btnIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        connected = False
        readThread = New Thread(New ThreadStart(AddressOf RunClient))
        readThread.Start()

        'Me.txtIP.Enabled = False
        'Me.btnIP.Enabled = False
        'Me.txtInput.Enabled = True
        'Me.itemFT.Enabled = True

    End Sub


    'Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'OpenFileDialog1.ShowDialog()
    'End Sub

    'Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    Dim fileThread As Thread
    '    fileThread = New Thread(New ThreadStart(AddressOf filesend))
    '    fileThread.Start()

    'End Sub



    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Hide()
        Me.itmShowHide.Text = "Show Ch@t"
    End Sub

    Private Sub ShowChtToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmShowHide.Click, ToolStripButton1.Click
        If (Me.itmShowHide.Text = "Show Ch@t") Then
            Show()
            Me.WindowState = FormWindowState.Normal
            Me.itmShowHide.Text = "Hide Ch@t"
        Else
            Hide()
            Me.WindowState = FormWindowState.Minimized
            Me.itmShowHide.Text = "Show Ch@t"
        End If

    End Sub
    

  
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Ch_t_FormClosing(Nothing, Nothing)
        Close()
    End Sub
    Public ip As IPAddress
    Public fileTransfer As String
    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        If e.Tool.Key = "File Transfer" Then
            Dim ft As fileTrns = New fileTrns
            ft.ShowDialog()
            If Not IsNothing(ip) And Not IsNothing(fileTransfer) And fileTransfer <> "" Then

                Dim fileThread As Thread
                fileThread = New Thread(New ThreadStart(AddressOf filesend))
                fileThread.Start()
            End If
            'ToolStripButton1_Click(Nothing, Nothing)
        ElseIf e.Tool.Key = "Hide" Then
            btnHide_Click(Nothing, Nothing)
        ElseIf e.Tool.Key = "Close" Then
            ExitToolStripMenuItem_Click(Nothing, Nothing)
        ElseIf e.Tool.Key = "Settings" Then
            Dim f As New Settings
            f.ShowDialog()
        End If
    End Sub


    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolConnect.Click

        Timer1.Enabled = True
        btnIP_Click(Nothing, Nothing)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
        Me.Show()
        Me.itmShowHide.Text = "Hide Ch@t"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = Timer1.Interval * 3
        btnIP_Click(Nothing, Nothing)


    End Sub


End Class