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
        Dim db As New DataClassesDataContext

        Dim query = From test In db.accounts
                    Select test
        For Each _Data In query


            If _Data.id = _username And _Data.password = _password Then
                Return True
            End If
        Next
        Return False

    End Function








End Class
