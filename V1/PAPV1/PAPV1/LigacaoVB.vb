Imports System.Data.SqlClient
Imports System.Security
Module LigacaoVB
    Public con As New SqlConnection
    Public comando As New SqlCommand

    Public Function conectar()
        con.Close()
        con.ConnectionString = "Data Source=LAPTOP-GE8FJ9UP\SQLEXPRESS;Initial Catalog=Jff;Integrated Security=True"
        con.Open()
        comando.Connection = con
        Return True
    End Function

    Public Function Desconectar()
        con.Close()
        Return True
    End Function
End Module
