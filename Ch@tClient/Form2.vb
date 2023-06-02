Imports System.Threading
Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Public Class Form2
    Private output As NetworkStream ' stream for receiving data          
    Private writer As BinaryWriter ' facilitates writing to the stream   
    Private reader As BinaryReader ' facilitates reading from the stream  
    Private readThread As Thread ' Thread for processing incoming messages
    Private message As String = ""
    Private connected As Boolean = False
    Dim i As Integer = 8088
    Dim j As Integer = 0
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim client As TcpClient

        ' instantiate TcpClient for sending data to server
        Try

            ' Step 1: create TcpClient and connect to server
            client = New TcpClient()
            j = j + 1

            client.Connect("172.16.0.29", i)

            ' Step 2: get NetworkStream associated with TcpClient
            output = client.GetStream()

            connected = True
            ' create objects for writing and reading across stream
            writer = New BinaryWriter(output)
            reader = New BinaryReader(output)

            'DisplayMessage(vbCrLf & "Got I/O streams" & vbCrLf)


            MessageBox.Show("Port Found" & i)

            While True
                writer.Write("www.yahoo.com")
                'MessageBox.Show(Chr(CType(reader.ReadByte.ToString, System.Int32)))
                MessageBox.Show(reader.ReadString)
            End While

            ' Step 4: close connection
            writer.Close()
            reader.Close()
            output.Close()
            client.Close()

            Application.Exit()
        Catch ex As Exception
            If i < 80000 Then
                i = i + 1
                Form2_Load(Nothing, Nothing)
            Else
                'Thread.CurrentThread.Abort()
                System.Environment.Exit(System.Environment.ExitCode)
            End If


        End Try
    End Sub
End Class