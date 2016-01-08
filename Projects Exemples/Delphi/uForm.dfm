object frmForm: TfrmForm
  Left = 307
  Top = 65
  BorderIcons = [biSystemMenu]
  Caption = 'CIS_SDK - Exemplo Delphi'
  ClientHeight = 393
  ClientWidth = 497
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Label13: TLabel
    Left = 20
    Top = 24
    Width = 160
    Height = 13
    Caption = 'Teste de conex'#227'o com a DLL'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label14: TLabel
    Left = 20
    Top = 110
    Width = 130
    Height = 13
    Caption = 'Ler e comparar digitais'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object lblVersao: TLabel
    Left = 203
    Top = 56
    Width = 55
    Height = 13
    Caption = 'Vers'#227'o SDK'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label15: TLabel
    Left = 268
    Top = 349
    Width = 196
    Height = 13
    Caption = 'Pasta das digitais: C:\CIS_SDK\DIGITAIS'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object Label1: TLabel
    Left = 20
    Top = 286
    Width = 69
    Height = 13
    Caption = 'Ler imagens'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = [fsBold]
    ParentFont = False
  end
  object Label2: TLabel
    Left = 268
    Top = 368
    Width = 202
    Height = 13
    Caption = 'Pasta das imagens: C:\CIS_SDK\IMAGENS'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
  end
  object btnLerDLL: TButton
    Left = 20
    Top = 43
    Width = 160
    Height = 33
    Caption = 'Ler DLL (Vers'#227'o SDK)'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
    OnClick = btnLerDLLClick
  end
  object btnLerDedo1: TButton
    Left = 20
    Top = 131
    Width = 160
    Height = 42
    Caption = 'Ler Digital (Dedo 1)'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
    OnClick = btnLerDedo1Click
  end
  object btnLerDedo2: TButton
    Left = 20
    Top = 179
    Width = 160
    Height = 42
    Caption = 'Ler Digital (Dedo 2)'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 2
    OnClick = btnLerDedo2Click
  end
  object btnCompararDigitais: TButton
    Left = 203
    Top = 131
    Width = 160
    Height = 42
    Caption = 'Comparar Digitais'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 3
    OnClick = btnCompararDigitaisClick
  end
  object btnCancelarLeitura: TButton
    Left = 20
    Top = 227
    Width = 160
    Height = 26
    Caption = 'Cancelar leitura'
    Enabled = False
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 4
    OnClick = btnCancelarLeituraClick
  end
  object btnLerImagemWSQ: TButton
    Left = 20
    Top = 307
    Width = 160
    Height = 42
    Caption = 'Ler Imagem WSQ'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 5
    OnClick = btnLerImagemWSQClick
  end
  object btnCancelarLeituraImagem: TButton
    Left = 20
    Top = 355
    Width = 160
    Height = 26
    Caption = 'Cancelar leitura imagem'
    Enabled = False
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -11
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentFont = False
    TabOrder = 6
    OnClick = btnCancelarLeituraImagemClick
  end
end
