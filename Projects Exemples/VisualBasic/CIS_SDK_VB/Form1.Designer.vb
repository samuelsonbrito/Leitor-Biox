<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblVersao = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnCancelarLeitura = New System.Windows.Forms.Button()
        Me.btnLeituraImagemWSQ = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancelarLeituraImagem = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVersao
        '
        Me.lblVersao.AutoSize = True
        Me.lblVersao.Location = New System.Drawing.Point(201, 50)
        Me.lblVersao.Name = "lblVersao"
        Me.lblVersao.Size = New System.Drawing.Size(65, 13)
        Me.lblVersao.TabIndex = 15
        Me.lblVersao.Text = "Versão SDK"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(286, 347)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(206, 13)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Pasta das digitais: C:\CIS_SDK\DIGITAIS"
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(213, 133)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(171, 41)
        Me.button4.TabIndex = 13
        Me.button4.Text = "Comparar as digitais"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(13, 180)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(171, 41)
        Me.button3.TabIndex = 12
        Me.button3.Text = "Ler digital - Dedo 2"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(13, 133)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(171, 41)
        Me.button2.TabIndex = 11
        Me.button2.Text = "Ler digital - Dedo 1"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(10, 107)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(153, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Ler e comparar as digitais"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(13, 41)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(171, 30)
        Me.button1.TabIndex = 9
        Me.button1.Text = "Ler DLL (Versão SDK)"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(10, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(174, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Teste de conexão com a DLL"
        '
        'btnCancelarLeitura
        '
        Me.btnCancelarLeitura.Enabled = False
        Me.btnCancelarLeitura.Location = New System.Drawing.Point(13, 227)
        Me.btnCancelarLeitura.Name = "btnCancelarLeitura"
        Me.btnCancelarLeitura.Size = New System.Drawing.Size(171, 23)
        Me.btnCancelarLeitura.TabIndex = 16
        Me.btnCancelarLeitura.Text = "Cancelar Leitura"
        Me.btnCancelarLeitura.UseVisualStyleBackColor = True
        '
        'btnLeituraImagemWSQ
        '
        Me.btnLeituraImagemWSQ.Location = New System.Drawing.Point(13, 302)
        Me.btnLeituraImagemWSQ.Name = "btnLeituraImagemWSQ"
        Me.btnLeituraImagemWSQ.Size = New System.Drawing.Size(171, 41)
        Me.btnLeituraImagemWSQ.TabIndex = 18
        Me.btnLeituraImagemWSQ.Text = "Ler Imagem WSQ"
        Me.btnLeituraImagemWSQ.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Ler imagens"
        '
        'btnCancelarLeituraImagem
        '
        Me.btnCancelarLeituraImagem.Enabled = False
        Me.btnCancelarLeituraImagem.Location = New System.Drawing.Point(13, 349)
        Me.btnCancelarLeituraImagem.Name = "btnCancelarLeituraImagem"
        Me.btnCancelarLeituraImagem.Size = New System.Drawing.Size(171, 23)
        Me.btnCancelarLeituraImagem.TabIndex = 19
        Me.btnCancelarLeituraImagem.Text = "Cancelar leitura imagem"
        Me.btnCancelarLeituraImagem.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Pasta das imagens: C:\CIS_SDK\IMAGENS"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 397)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancelarLeituraImagem)
        Me.Controls.Add(Me.btnLeituraImagemWSQ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancelarLeitura)
        Me.Controls.Add(Me.lblVersao)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CIS SDK VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblVersao As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents button4 As System.Windows.Forms.Button
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnCancelarLeitura As System.Windows.Forms.Button
    Private WithEvents btnLeituraImagemWSQ As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents btnCancelarLeituraImagem As System.Windows.Forms.Button
    Private WithEvents Label5 As System.Windows.Forms.Label

End Class
