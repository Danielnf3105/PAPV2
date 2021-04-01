Imports System.Data.SqlClient



Public Class Login

    Private Sub BttLogin_Click(sender As Object, e As EventArgs) Handles BttLogin.Click
        If TxtUserName.Text = "" Or TxtPassword.Text = "" Then
            MessageBox.Show("Por favor preencha todos os campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If TxtUserName.TextLength < 5 Then
            MessageBox.Show("O Username tem de ter pelo menos 5 carateres!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If TxtPassword.TextLength < 8 Then
            MessageBox.Show("O Username tem de ter pelo menos 8 carateres!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try

            Call conectar()
            Dim sql As String = "SELECT * FROM utilizador WHERE username='" & TxtUserName.Text & "' AND pass = '" & TxtPassword.Text & "'"
            Dim sqlcom As New SqlCommand(sql, con)
            Dim dr As SqlDataReader = sqlcom.ExecuteReader()

            dr.Read()

            If Trim(dr.Item(2)) = TxtUserName.Text And Trim(dr.Item(3)) = TxtPassword.Text Then
                MsgBox("Bem-vindo " & dr.Item(1) & "!")
                TxtUserName.ResetText()
                TxtPassword.ResetText()
                pagina_princial.Show()

                Me.Hide()
            Else
                If TxtUserName.Text = "" Or TxtPassword.Text = "" Then
                    MessageBox.Show("Por favor preencha os campos corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtPassword.Text = ""
                    TxtUserName.Text = ""
                    TxtUserName.Focus()
                Else
                    MessageBox.Show("User ou Password não correspondem.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    TxtPassword.Text = ""
                    TxtUserName.Text = ""
                    TxtUserName.Focus()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Utilizador inexistente ou falha ao ligar à Base de dados...", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUserName.ResetText()
            TxtPassword.ResetText()
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PainelDeFundo.Show()
    End Sub

    Private Sub BttSair_Click(sender As Object, e As EventArgs) Handles BttSair.Click
        Application.Exit()
    End Sub

End Class