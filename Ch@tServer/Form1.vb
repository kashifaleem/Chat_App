' Fig. 23.1: FrmChatServer.vb
' Set up a server that will receive a connection from a client, send a
' string to the client, chat with the client and close the connection.
Imports System.Threading
Imports System.Net
Imports System.Net.Sockets
Imports System.IO

Public Class FrmChatServer

    Private readThread As Thread  ' Thread for processing incoming messages
    Private connection(10) As Socket ' Socket for accepting a connection      
    Private socketStream(10) As NetworkStream ' network data stream           
    Private writer(10) As BinaryWriter ' facilitates writing to the stream    
    Private reader(10) As BinaryReader ' facilitates reading from the stream  
    Private c(10) As Conn

    'Private maxPort As Integer = 50004
    'Private i As Integer = 0
    ' initialize thread for reading
    Private Sub FrmChatServer_Load(ByVal sender As System.Object, _
       ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.txtNick.Text = My.Settings.NickName
        btnIP_Click(Nothing, Nothing)
    End Sub ' FrmChatServer_Load

    ' close all threads associated with this application
    Private Sub FrmChatServer_FormClosing(ByVal sender As System.Object, _
       ByVal e As System.Windows.Forms.FormClosingEventArgs) _
       Handles MyBase.FormClosing
        NotifyIcon1.Dispose()

        System.Environment.Exit(System.Environment.ExitCode)

    End Sub ' FrmChatServer_FormClosing

    ' Delegate that allows method DisplayMessage to be called
    ' in the thread that creates and maintains the GUI
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
        End If
        If Not Me.Visible Then
            Me.NotifyIcon1.ShowBalloonTip(3, "Ch@t Server", message, ToolTipIcon.Info)
            Beep()
        End If '

    End Sub ' DisplayMessage

    ' Delegate that allows method DisableInput to be called
    ' in the thread that creates and maintains the GUI
    Private Delegate Sub DisableInputDelegate(ByVal value As Boolean)

    ' method DisableInput sets txtInput's ReadOnly property
    ' in a thread-safe manner
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

        If value = True Then
            Me.UltraToolbarsManager1.Ribbon.ApplicationMenu.ToolAreaLeft.Tools("File Transfer").InstanceProps.Visible = Infragistics.Win.DefaultableBoolean.False
        Else
            Me.UltraToolbarsManager1.Ribbon.ApplicationMenu.ToolAreaLeft.Tools("File Transfer").InstanceProps.Visible = Infragistics.Win.DefaultableBoolean.True
        End If

    End Sub ' DisableInput

    ' send the text typed at the server to the client
    Private Sub txtInput_KeyDown(ByVal sender As System.Object, _
       ByVal e As System.Windows.Forms.KeyEventArgs) _
       Handles txtInput.KeyDown
        ' send the text to the client
        Try
            If e.KeyCode = Keys.Enter And txtInput.ReadOnly = False Then

                Dim sent As Integer = 0
                Dim j As Integer = 0

                While sent < counter And j < 11
                    If Not IsNothing(connection(j)) Then


                        If connection(j).Connected Then
                            writer(j).Write(My.Settings.NickName & ">>> " & txtInput.Text)
                        End If
                    End If
                    j += 1
                End While

                txtDisplay.Text &= vbCrLf & My.Settings.NickName & ">>> " & txtInput.Text

                Me.txtDisplay.Select(Me.txtDisplay.Text.Length, 0)
                Me.txtDisplay.ScrollToCaret()
                ' if the user at the server signaled termination
                ' sever the connection to the client
                If txtInput.Text = "TERMINATE" Then
                    connection(0).Close()

                End If
                txtInput.Clear() ' clear the userí-s input
            End If
        Catch ex As SocketException
            txtDisplay.Text &= vbCrLf & "Error writing object"

            'Finally
            '    Me.txtDisplay.Select(Me.txtDisplay.Text.Length - 1, 0)
            '    Me.txtDisplay.ScrollToCaret()
        End Try
    End Sub ' txtInput_KeyDown

    ' allows a client to connect; displays text the client sends
    Public listener As TcpListener
    Public counter As Integer = 0
    Public Sub RunServer()
        'Dim listener As TcpListener

        Dim tarray(10) As Thread

        ' wait for a client connection and display the text
        ' that the client sends
        Try
            ' Step 1: create TcpListener                         
            Dim local As IPAddress = IPAddress.Parse(My.Settings.ServerIP)
            listener = New TcpListener(local, 50000)

            ' Step 2: TcpListener waits for connection request
            listener.Start()

            DisplayMessage("Waiting for connection" & vbCrLf)
            ' Step 3: establish connection upon client request
            While True

                If listener.Pending Then

                    For l As Integer = 0 To c.Length - 1
                        If IsNothing(c(l)) Then
                            t = l
                            Exit For
                        End If
                        If c(l).isconnected = False Then
                            t = l
                            Exit For
                        End If

                    Next
                    If t = -1 Then
                        MessageBox.Show("Too Many Connections", "Error")
                        Continue While
                    End If
                    connection(t) = listener.AcceptSocket()
                    tarray(t) = New Thread(New ThreadStart(AddressOf mesgs))
                    tarray(t).Start()
                    counter += 1
               
                End If
                Thread.Sleep(1000)
            End While
        Catch se As SocketException
            MessageBox.Show("Server not initialized. Check your network", "Error")
            System.Environment.Exit(System.Environment.ExitCode)

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            System.Environment.Exit(System.Environment.ExitCode)
        End Try
    End Sub ' RunServer
    Dim t As Integer = -1
    Public numthread As Integer = 0
    Public Sub mesgs()
        ' accept an incoming connection     
        Dim tid As Integer = t
        numthread += 1
        'connection(tid) = listener.AcceptSocket()
        'Invoke(btnIP_Click(, ), New Object() {Nothing, Nothing})
        'btnIP_Click(Nothing, Nothing)
        ' create NetworkStream object associated with socket
        'If IsNothing(connection(tid)) Then
        'connection(tid) = listener.AcceptSocket()
        c(tid) = New Conn
        c(tid).IP = connection(tid).RemoteEndPoint.ToString.Substring(0, connection(tid).RemoteEndPoint.ToString.IndexOf(":"))
        c(tid).isconnected = True
        'End If
        socketStream(tid) = New NetworkStream(connection(tid))

        ' create objects for transferring data across stream
        writer(tid) = New BinaryWriter(socketStream(tid))
        reader(tid) = New BinaryReader(socketStream(tid))

        DisplayMessage( _
            "Connection received." & c(tid).IP.ToString & vbCrLf)


        ' inform client that connection was successfull
        writer(tid).Write(My.Settings.NickName & ">>> Connection successful")

        Dim online As String = "Online Connections :" & vbCrLf & My.Settings.ServerIP

        For i As Integer = 0 To c.Length - 1
            If Not IsNothing(c(i)) Then
                If c(i).isconnected Then
                    online = online + vbCrLf & c(i).IP
                End If
            End If
        Next
        writer(tid).Write(online)

        sendMsg(c(tid).IP.ToString & " joined!")
        DisableInput(False) ' enable txtInput
        Dim theReply As String = ""

        ' Step 4: read string data sent from client
        Do
            Try
                ' read the string sent to the server
                theReply = reader(tid).ReadString()
                If theReply = "File Transfer Permission" Then
                    If recieving = True Then
                        writer(tid).Write(vbCrLf & "Server Busy! Try Later")
                    Else
                        Dim fileThread As Thread
                        fileThread = New Thread(New ThreadStart(AddressOf filercv))
                        fileThread.Start()
                    End If
                    
                Else
                    sendMsg(theReply)
                    DisplayMessage(vbCrLf & theReply)
                End If

            Catch ex As Exception
                ' handle exception if error reading data
                Exit Do
            End Try

        Loop While connection(tid).Connected


        DisplayMessage(vbCrLf & c(tid).IP & " terminated connection" & vbCrLf)

        ' Step 5: close connection
        writer(tid).Close()
        reader(tid).Close()
        socketStream(tid).Close()
        connection(tid).Close()
        c(tid).isconnected = False

        sendMsg(c(tid).IP & " terminated connection")

        counter -= 1
        numthread -= 1
        If counter = 0 Then
            DisableInput(True) ' disable txtInput
        End If


        Thread.CurrentThread.Abort()
    End Sub
    Public Sub sendMsg(ByVal msg As String)
        For j As Integer = 0 To c.Length - 1
            If Not IsNothing(connection(j)) Then
                If connection(j).Connected Then
                    writer(j).Write(msg)
                End If
            End If
        Next
    End Sub
    Private Sub btnIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'maxPort = maxPort + 1
       
        Me.txtInput.Enabled = True
        'Me.itemFT.Enabled = True

        readThread = New Thread(New ThreadStart(AddressOf RunServer))
        readThread.Start()
        ' i = i + 1

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Hide()
        Me.itmShowHide.Text = "Show Ch@t Server"
    End Sub

    Private Sub itmShowHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itmShowHide.Click
        If (Me.itmShowHide.Text = "Show Ch@t Server") Then
            Show()
            Me.itmShowHide.Text = "Hide Ch@t Server"
        Else
            Hide()
            Me.itmShowHide.Text = "Show Ch@t Server"
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        FrmChatServer_FormClosing(Nothing, Nothing)
        Close()
    End Sub

    'Private Sub itemFT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'OpenFileDialog1.ShowDialog()
    'End Sub

    'Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

    '    Dim fileThread As Thread
    '    fileThread = New Thread(New ThreadStart(AddressOf filesend))
    '    fileThread.Start()

    '    'readThread = New Thread(New ThreadStart(AddressOf RunServer))
    '    'readThread.Start()

    'End Sub

    Private Sub filesend()
        sending = True
        Dim ind As Integer = -1
        Dim writer1 As BinaryWriter
        Dim reader1 As BinaryReader
        Dim socketStream1 As NetworkStream
        Dim listener1 As TcpListener
        Dim counter1 As Integer = 1
        Dim connection1 As Socket

        Dim exist As Boolean = False
        For k As Integer = 0 To c.Length - 1
            If Not IsNothing(c(k)) Then
                If c(k).IP.ToString = ip.ToString Then
                    ind = k
                    exist = True
                    Exit For
                End If
            End If
        Next

        If ind = -1 Then
            sending = False
            DisplayMessage(vbCrLf & ip.ToString & " not found!")
            Thread.CurrentThread.Abort()
        End If

        writer(ind).Write("File Transfer Permission")
        Dim local As IPAddress = IPAddress.Parse(My.Settings.ServerIP)
        listener1 = New TcpListener(local, 50002)
        listener1.Start()



        ' wait for a client connection and display the text
        ' that the client sends

        ' Step 1: create TcpListener                         



        ' Step 2: TcpListener waits for connection request


        ' Step 3: establish connection upon client request

        ' accept an incoming connection     
        connection1 = listener1.AcceptSocket()

        ' create NetworkStream object associated with socket
        socketStream1 = New NetworkStream(connection1)

        ' create objects for transferring data across stream
        writer1 = New BinaryWriter(socketStream1)
        reader1 = New BinaryReader(socketStream1)


        Try

            'txtDisplay.Text &= vbCrLf & "File Transfer Permission"
            DisplayMessage(vbCrLf & "File Transfer Permission")

            'If reader.ReadString() = "Permission Granted" Then
            If reader1.ReadBoolean = True Then
                'txtDisplay.Text &= vbCrLf & "Permission Granted by Reciever"
                DisplayMessage(vbCrLf & "Permission Granted by Reciever")

                Dim fileBytes As Byte()
                fileBytes = File.ReadAllBytes(Path.Combine(My.Settings.RcvdFile, filename))
                writer1.Write(fileBytes.Length)

                'writer1.Write(OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1))
                If filename.LastIndexOf("\") = -1 Then
                    writer1.Write(filename)
                Else
                    writer1.Write(filename.Substring(filename.LastIndexOf("\") + 1))
                End If


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
            sending = False
            listener1.Stop()
            Thread.CurrentThread.Abort()
        End Try
    End Sub

    Public ip As IPAddress
    Public filename As String
    Public recieving As Boolean = False
    Public sending As Boolean = False

    Private Sub filercv()
        recieving = True
        Dim writer1 As BinaryWriter
        Dim reader1 As BinaryReader
        Dim socketStream1 As NetworkStream
        Dim listener1 As TcpListener
        Dim counter1 As Integer = 1
        Dim connection1 As Socket
        Try
            ' wait for a client connection and display the text
            ' that the client sends

            ' Step 1: create TcpListener


            Dim local As IPAddress = IPAddress.Parse(My.Settings.ServerIP)
            listener1 = New TcpListener(local, 50001)

            ' Step 2: TcpListener waits for connection request
            listener1.Start()

            ' Step 3: establish connection upon client request

            ' accept an incoming connection     
            connection1 = listener1.AcceptSocket()

            ' create NetworkStream object associated with socket
            socketStream1 = New NetworkStream(connection1)

            ' create objects for transferring data across stream
            writer1 = New BinaryWriter(socketStream1)
            reader1 = New BinaryReader(socketStream1)

            DisplayMessage(vbCrLf & "File Recieving Permission")
            ip = IPAddress.Parse(reader1.ReadString())
            Dim res As DialogResult = Windows.Forms.DialogResult.No
            Dim exist As Boolean = False
            Dim m As Integer = 0
            If ip.ToString = My.Settings.ServerIP Then
                res = MessageBox.Show("Do you want to recieve a file from the sender", "Permission", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If res = Windows.Forms.DialogResult.Yes Then

                    writer1.Write(True)
                    DisplayMessage(vbCrLf & "Permission Granted to Sender")

                Else

                    writer1.Write(False)
                    DisplayMessage(vbCrLf & "Permission Denied")
                End If
            Else


                For m = 0 To c.Length - 1
                    If Not IsNothing(c(m)) Then
                        If c(m).IP.ToString = ip.ToString And connection(m).Connected Then
                            exist = True
                            Exit For
                        End If
                    End If
                Next
                If exist = False Then
                    writer1.Write(False)
                    DisplayMessage(vbCrLf & "Permission Denied")
                End If
            End If

            If res = Windows.Forms.DialogResult.Yes Or exist = True Then
                Dim length = reader1.ReadInt32()
                filename = reader1.ReadString()
                Dim buf As Byte() = reader1.ReadBytes(length)

                Dim f As New FileStream(My.Settings.RcvdFile & filename, FileMode.Create)

                Using f
                    f.Write(buf, 0, length)
                End Using

                If reader1.ReadBoolean() = True Then
                    DisplayMessage(vbCrLf & "File: " & filename & " recieved from " & connection1.RemoteEndPoint.ToString.Substring(0, connection1.RemoteEndPoint.ToString.IndexOf(":")))
                End If
            End If
            If exist = True Then

                While (sending)
                End While

                writer(m).Write("File: " & filename & " Sender IP: " & connection1.RemoteEndPoint.ToString.Substring(0, connection1.RemoteEndPoint.ToString.IndexOf(":")))

                Dim fileThread As Thread
                fileThread = New Thread(New ThreadStart(AddressOf filesend))
                fileThread.Start()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            recieving = False
            listener1.Stop()
            Thread.CurrentThread.Abort()
        End Try

        
    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        If e.Tool.Key = "File Transfer" Then
            Dim ft As fileTrns = New fileTrns
            ft.ShowDialog()
            If Not IsNothing(ip) And Not IsNothing(filename) And filename <> "" Then

                While (sending)
                End While

                Dim fileThread As Thread
                fileThread = New Thread(New ThreadStart(AddressOf filesend))
                fileThread.Start()
            End If
        ElseIf e.Tool.Key = "Hide" Then
            btnHide_Click(Nothing, Nothing)
        ElseIf e.Tool.Key = "Close" Then
            ExitToolStripMenuItem_Click(Nothing, Nothing)
        ElseIf e.Tool.Key = "Settings" Then
            Dim f As New Settings
            f.ShowDialog()
        End If
    End Sub

   
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
        Me.Show()
    End Sub

    
End Class ' FrmChatServer_Load




