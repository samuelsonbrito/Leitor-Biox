Imports System.Runtime.InteropServices
Imports System.Threading


Public Class frmPrincipal

    Private Declare Function CIS_SDK_Versao Lib "CIS_SDK.dll" () As IntPtr
    Private Declare Function CIS_SDK_Biometrico_Iniciar Lib "CIS_SDK.dll" () As Integer
    Private Declare Function CIS_SDK_Biometrico_LerDigital_RetornoPonteiro Lib "CIS_SDK.dll" (ByRef iRetorno As Integer) As IntPtr
    Private Declare Function CIS_SDK_Biometrico_CompararDigital Lib "CIS_SDK.dll" (ByVal bAmostra1() As Byte, ByVal bAmostra2() As Byte) As Integer
    Private Declare Function CIS_SDK_Biometrico_Finalizar Lib "CIS_SDK.dll" () As Integer
    Private Declare Function CIS_SDK_Biometrico_CancelarLeitura Lib "CIS_SDK.dll" () As Integer
    Private Declare Function CIS_SDK_Biometrico_LerDigital_LerWSQ Lib "CIS_SDK.dll" (ByRef iRetorno As Integer, ByRef iSize As Integer) As IntPtr

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ptr As IntPtr = Marshal.AllocHGlobal(20)
        ptr = CIS_SDK_Versao
        lblVersao.Text = "CIS SDK - v." + Marshal.PtrToStringAnsi(ptr)
    End Sub

    Private ThLeitura1, ThLeitura2, ThLeituraWSQ As Thread

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim iRetorno = CIS_SDK_Biometrico_Iniciar()
        If (iRetorno <> 1) Then
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Iniciar: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If

        btnCancelarLeitura.Enabled = True

        ThLeitura1 = New Thread(AddressOf Me.Leitura1)
        ThLeitura1.Start()
    End Sub


    Public Sub Leitura1()
        Dim iRetorno As Integer
        Dim ptr As IntPtr = Marshal.AllocHGlobal(669)
        ptr = CIS_SDK_Biometrico_LerDigital_RetornoPonteiro(iRetorno)
        If (iRetorno <> 1) Then
            CIS_SDK_Biometrico_Finalizar()
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Leitura: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If

        Dim Buffer(669) As Byte
        Call Marshal.Copy(ptr, Buffer, 0, 669)

        If My.Computer.FileSystem.FileExists("C:\CIS_SDK\DIGITAIS\Template1.tpl") Then
            My.Computer.FileSystem.DeleteFile("C:\CIS_SDK\DIGITAIS\Template1.tpl")
        End If

        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream("C:\CIS_SDK\DIGITAIS\Template1.tpl", System.IO.FileMode.Create)
        fs.Write(Buffer, 0, 669)
        fs.Close()

        iRetorno = CIS_SDK_Biometrico_Finalizar()
        If (iRetorno <> 1) Then
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Finalizar: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If

        MsgBox("Template gerado !", MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
    End Sub


    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim iRetorno = CIS_SDK_Biometrico_Iniciar()
        If (iRetorno <> 1) Then
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Iniciar: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If

        btnCancelarLeitura.Enabled = True

        ThLeitura2 = New Thread(AddressOf Me.Leitura2)
        ThLeitura2.Start()
    End Sub


    Public Sub Leitura2()
        Dim iRetorno As Integer
        Dim ptr As IntPtr = Marshal.AllocHGlobal(669)
        ptr = CIS_SDK_Biometrico_LerDigital_RetornoPonteiro(iRetorno)
        If (iRetorno <> 1) Then
            CIS_SDK_Biometrico_Finalizar()
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Leitura: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If

        Dim Buffer(669) As Byte
        Call Marshal.Copy(ptr, Buffer, 0, 669)

        If My.Computer.FileSystem.FileExists("C:\CIS_SDK\DIGITAIS\Template2.tpl") Then
            My.Computer.FileSystem.DeleteFile("C:\CIS_SDK\DIGITAIS\Template2.tpl")
        End If

        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream("C:\CIS_SDK\DIGITAIS\Template2.tpl", System.IO.FileMode.Create)
        fs.Write(Buffer, 0, 669)
        fs.Close()

        iRetorno = CIS_SDK_Biometrico_Finalizar()
        If (iRetorno <> 1) Then
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Finalizar: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If

        MsgBox("Template gerado !", MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
    End Sub



    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim iRetorno = CIS_SDK_Biometrico_Iniciar()
        If (iRetorno <> 1) Then
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Iniciar: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If

        Dim bAmostra1(669) As Byte
        Dim bAmostra2(669) As Byte

        bAmostra1 = My.Computer.FileSystem.ReadAllBytes("C:/CIS_SDK/DIGITAIS/Template1.tpl")
        bAmostra2 = My.Computer.FileSystem.ReadAllBytes("C:/CIS_SDK/DIGITAIS/Template2.tpl")

        iRetorno = CIS_SDK_Biometrico_CompararDigital(bAmostra1, bAmostra2)
        If (iRetorno = 1) Then
            MsgBox("As digitais são IGUAIS", MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
        ElseIf (iRetorno = -2) Then
            MsgBox("As digitais são DIFERENTES", MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
        Else
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro na comparação: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
        End If

        iRetorno = CIS_SDK_Biometrico_Finalizar()
        If (iRetorno <> 1) Then
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Finalizar: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If
    End Sub


    Private Sub btnCancelarLeitura_Click(sender As Object, e As EventArgs) Handles btnCancelarLeitura.Click
        btnCancelarLeitura.Enabled = False

        CIS_SDK_Biometrico_CancelarLeitura()
    End Sub



    Private Sub btnLeituraImagemWSQ_Click(sender As Object, e As EventArgs) Handles btnLeituraImagemWSQ.Click
        Dim iRetorno = CIS_SDK_Biometrico_Iniciar()
        If (iRetorno <> 1) Then
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Iniciar: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If

        btnCancelarLeituraImagem.Enabled = True

        ThLeituraWSQ = New Thread(AddressOf Me.LeituraWSQ)
        ThLeituraWSQ.Start()
    End Sub


    Public Sub LeituraWSQ()
        Dim iRetorno As Integer
        Dim iSize As Integer
        Dim ptr As IntPtr
        ptr = CIS_SDK_Biometrico_LerDigital_LerWSQ(iRetorno, iSize)
        If (iRetorno <> 1) Then
            CIS_SDK_Biometrico_Finalizar()
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Leitura WSQ: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If

        Dim Buffer(iSize) As Byte
        Call Marshal.Copy(ptr, Buffer, 0, iSize)

        If My.Computer.FileSystem.FileExists("C:\CIS_SDK\IMAGENS\Imagem.wsq") Then
            My.Computer.FileSystem.DeleteFile("C:\CIS_SDK\IMAGENS\Imagem.wsq")
        End If

        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream("C:\CIS_SDK\IMAGENS\Imagem.wsq", System.IO.FileMode.Create)
        fs.Write(Buffer, 0, iSize)
        fs.Close()

        iRetorno = CIS_SDK_Biometrico_Finalizar()
        If (iRetorno <> 1) Then
            Dim strMensagem = CStr(iRetorno)
            MsgBox("Erro Finalizar: " + strMensagem, MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
            Return
        End If

        MsgBox("Imagem gerada !", MsgBoxStyle.DefaultButton2, "Resposta CIS SDK")
    End Sub


    Private Sub btnCancelarLeituraImagem_Click(sender As Object, e As EventArgs) Handles btnCancelarLeituraImagem.Click
        btnCancelarLeituraImagem.Enabled = False

        CIS_SDK_Biometrico_CancelarLeitura()
    End Sub
End Class
