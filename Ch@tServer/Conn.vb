Public Class Conn
    Private conip As String
    Public isconnected As Boolean = False


    Public Property IP() As String
        Get
            Return conip
        End Get
        Set(ByVal value As String)
            conip = value
        End Set
    End Property


End Class
