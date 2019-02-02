Public Class checkAuth
    Dim _username, _password As String
    Public Property username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property password As String
        Get
            Return _password

        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Function c_Auth() As Boolean
        Dim db As New DataClasses1DataContext
        Dim query = From test In db.db_Tests
                    Select test
        For Each _Data In query


            If _Data.username = _username And _Data.pass = _password Then
                Return True
            End If
        Next
        Return False

    End Function








End Class
