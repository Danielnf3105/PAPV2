Imports System.Data.SqlClient
Public Class ProgressBar
    Private Sub ProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
        '    ProgressBar1.Value += 2
        'End If
        'If ProgressBar1.Value = ProgressBar1.Maximum Then
        '    Login.Show()
        '    Me.Hide()
        'End If
        If ProgressBar1.Value = 100 Then

            Call conectar()

            Dim sql As String = "SELECT * FROM firstrun"
            Dim sqlcom As New SqlCommand(sql, con)
            Dim dr As SqlDataReader = sqlcom.ExecuteReader
            dr.Read()


            If Trim(dr.Item(0)) = 1 Then
                Me.Hide()
                Login.Show()
                Timer1.Stop()
                ProgressBar1.Value = 50

            ElseIf Trim(dr.Item(0)) = 0 Then
                Timer1.Stop()
                ProgressBar1.Value = 50
                Me.Hide()
                Registar_form.Show()



            End If
        End If

        Call Desconectar()
        '  Catch
        '  MsgBox("Não pode ser  alterado, esta ser ultilizado", MsgBoxStyle.OkOnly)
        '  End Try
        ProgressBar1.Increment(1)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

End Class