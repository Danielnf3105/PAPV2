Imports System.Data.SqlClient

Public Class Registar_form
    Public Sub Consulta_FirstRun()

        Call conectar()

        Dim sql As String = "Update firstrun SET estado = 1 "

        Dim sqlcom As New SqlCommand(sql, con)

        Dim dr As SqlDataReader = sqlcom.ExecuteReader

        Call Desconectar()

    End Sub



    Private Sub RegistarUtilizador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNome.Focus()
    End Sub





    Private Sub BttCriarUser_Click(sender As Object, e As EventArgs) Handles BttCriarUser.Click

        If TxtNome.Text = "" Or TxtUserName.Text = "" Or TxtPassword.Text = "" Or MaskText_telefone.Text = "" Or TextMorada.Text = "" Then

            MsgBox("Os campos são todos obrigatórios! ", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Erro")
            'BttCriarUser.Activecolor = (255; 209; 96)
        ElseIf TxtPassword.TextLength < 8 Then
            MessageBox.Show("O Username tem de ter pelo menos 8 carateres!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error)



        Else

            Call conectar()

            Dim sql As String = "insert into utilizador values ( '" & TxtNome.Text & "','" & TxtUserName.Text & "','" & TxtPassword.Text & "','" & MaskText_telefone.Text & "','" & TextMorada.Text & "')"



            Dim sqlcom As New SqlCommand(sql, con)

            Dim dr As SqlDataReader = sqlcom.ExecuteReader

            Call Desconectar()

            Consulta_FirstRun()

            MsgBox("Os seus dados foram registados com sucesso, " & TxtNome.Text & "", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Informação")

            Me.Hide()

            'Windows.Forms.ProgressBar.Timer1.Start()

            ProgressBar.Show()

        End If

    End Sub

    Private Sub BttSair_Click(sender As Object, e As EventArgs) Handles BttSair.Click
        Application.ExitThread()
    End Sub


End Class
