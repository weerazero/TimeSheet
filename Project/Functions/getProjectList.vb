Public Class getProjectList



    Public Function getdata() As IQueryable
        Dim db As New DataClassesDataContext


        Dim query = From ac In db.accounts
                    Join tm In db.timesheets On ac.id Equals tm.employee_id
                    Select tm



        Return query

    End Function


End Class
