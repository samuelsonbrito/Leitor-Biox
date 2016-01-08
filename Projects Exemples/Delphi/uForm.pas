unit uForm;

interface

uses
{  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls,  ComCtrls, ExtCtrls, Menus, AppEvnts,
  Mask, Buttons;
 }

  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ComCtrls, ExtCtrls, Menus, Buttons;


type
  TfrmForm = class(TForm)
    Label13: TLabel;
    Label14: TLabel;
    btnLerDLL: TButton;
    lblVersao: TLabel;
    btnLerDedo1: TButton;
    btnLerDedo2: TButton;
    btnCompararDigitais: TButton;
    Label15: TLabel;
    btnCancelarLeitura: TButton;
    Label1: TLabel;
    btnLerImagemWSQ: TButton;
    btnCancelarLeituraImagem: TButton;
    Label2: TLabel;
    procedure btnIdentificarClick(Sender: TObject);
    procedure btnLerDLLClick(Sender: TObject);
    procedure btnLerDedo1Click(Sender: TObject);
    procedure btnLerDedo2Click(Sender: TObject);
    procedure btnCancelarLeituraClick(Sender: TObject);
    procedure btnCompararDigitaisClick(Sender: TObject);
    procedure btnCancelarLeituraImagemClick(Sender: TObject);
    procedure btnLerImagemWSQClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

  type
    THREAD_Leitura1 = class(TThread)
  protected
    procedure Execute; override;
  end;

  type
    THREAD_Leitura2 = class(TThread)
  protected
    procedure Execute; override;
  end;

  type
    THREAD_LeituraWSQ = class(TThread)
  protected
    procedure Execute; override;
  end;


{ Retorno das Funções }
{
   0 -> COMANDO NAO EXECUTADO
   1 -> COMANDO EXECUTADO COM SUCESSO

  -1 -> LEITOR INCOMPATIVEL COM SDK
  -2 -> DIGITAIS NAO SAO IGUAIS

 -10 -> ERRO DESCONHECIDO
 -11 -> FALTA DE MEMORIA
 -12 -> ARGUMENTO INVALIDO
 -13 -> SDK JA EM USO
 -14 -> TEMPLATE INVALIDO
 -15 -> ERRO INTERNO
 -16 -> NAO HABILITADO PARA CAPTURAR DIGITAL
 -17 -> CANCELADO PELO USUARIO
 -18 -> LEITURA NAO POSSIVEL
 -20 -> TEMPLANTE INCONSISTENTE

 -21 -> ERRO DESCONHECIDO
 -22 -> SDK NAO FOI INICIADO
 -23 -> LEITOR NAO CONECTADO
 -24 -> ERRO NO LEITOR
 -25 -> FRAME DE DADOS VAZIO
 -26 -> ORIGEM FALSA (FAKE)
 -27 -> HARDWARE INCOMPATIVEL
 -28 -> FIRMWARE INCOMPATIVEL
 -29 -> FRAME ALTERADO
}


{ Cabeçalho das Funções }
function CIS_SDK_Biometrico_Iniciar: integer; stdcall; external 'CIS_SDK.dll';
function CIS_SDK_Biometrico_Finalizar: integer; stdcall; external 'CIS_SDK.dll';
function CIS_SDK_Biometrico_LerDigital(pTemplate: Pointer): integer; stdcall; external 'CIS_SDK.dll';
function CIS_SDK_Biometrico_CancelarLeitura: integer; stdcall; external 'CIS_SDK.dll';
function CIS_SDK_Biometrico_CompararDigital(pAmostra1, pAmostra2: Pointer): integer; stdcall; external 'CIS_SDK.dll';

function CIS_SDK_Versao: PAnsiChar; stdcall; external 'CIS_SDK.dll';
function CIS_SDK_Retorno(intRetorno: integer): PAnsiChar; stdcall; external 'CIS_SDK.dll';

function CIS_SDK_Biometrico_LerDigital_LerWSQ(var iRetorno, iSize: Integer): Pointer; stdcall; external 'CIS_SDK.dll';


var
  frmForm: TfrmForm;

implementation

{$R *.dfm}

procedure TfrmForm.btnCancelarLeituraClick(Sender: TObject);
begin
  CIS_SDK_Biometrico_CancelarLeitura;

  btnCancelarLeitura.Enabled := False;
end;

procedure TfrmForm.btnLerDedo1Click(Sender: TObject);
var
  thread: THREAD_Leitura1;
begin
  btnCancelarLeitura.Enabled := True;

  thread := THREAD_Leitura1.Create(False);
  thread.Resume;
end;

procedure TfrmForm.btnLerDedo2Click(Sender: TObject);
var
  thread: THREAD_Leitura2;
begin
  btnCancelarLeitura.Enabled := True;

  thread := THREAD_Leitura2.Create(False);
  thread.Resume;
end;

procedure TfrmForm.btnLerDLLClick(Sender: TObject);
var
  intResposta: integer;
  strP: PAnsiChar;
begin
  strP := CIS_SDK_Versao;
  lblVersao.Caption := 'CIS SDK v.' + strP;
end;

procedure TfrmForm.btnLerImagemWSQClick(Sender: TObject);
var
  thread: THREAD_LeituraWSQ;
begin
  btnCancelarLeituraImagem.Enabled := True;

  thread := THREAD_LeituraWSQ.Create(False);
  thread.Resume;
end;

procedure TfrmForm.btnCancelarLeituraImagemClick(Sender: TObject);
begin
  CIS_SDK_Biometrico_CancelarLeitura;

  btnCancelarLeituraImagem.Enabled := False;
end;

procedure TfrmForm.btnCompararDigitaisClick(Sender: TObject);
var
  intResposta: integer;
  bAmostra1, bAmostra2: Array [0..668] of Byte;
  MS: TMemoryStream;
  strDiretorio: string;
begin
  intResposta := CIS_SDK_Biometrico_Iniciar;
    if (intResposta <> 1) then
      begin
        ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
        Exit;
      end;

  strDiretorio := 'C:\CIS_SDK\DIGITAIS\';

  MS := TMemoryStream.Create;
  MS.LoadFromFile(strDiretorio + 'Template1.tpl');
  MS.Position := 0;
  MS.Read(bAmostra1, MS.Size);
  MS.Free;

  MS := TMemoryStream.Create;
  MS.LoadFromFile(strDiretorio + 'Template2.tpl');
  MS.Position := 0;
  MS.Read(bAmostra2, MS.Size);
  MS.Free;

  intResposta := CIS_SDK_Biometrico_CompararDigital(@bAmostra1, @bAmostra2);
    if (intResposta = 1) then
      ShowMessage('As digitais são IGUAIS !')
    else if (intResposta = -2) then
      ShowMessage('As digitais são DIFERENTES !')
    else
      ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));

  intResposta := CIS_SDK_Biometrico_Finalizar;
    if (intResposta <> 1) then
      ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
end;

procedure TfrmForm.btnIdentificarClick(Sender: TObject);
begin
end;

{ THREAD_Leitura }

procedure THREAD_Leitura1.Execute;
var
  intResposta: integer;
  bAmostra: Array [0..668] of Byte;
  MS: TMemoryStream;
  strDiretorio: string;
begin
  inherited;

  intResposta := CIS_SDK_Biometrico_Iniciar;
    if (intResposta <> 1) then
      begin
        ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
        Exit;
      end;

  intResposta := CIS_SDK_Biometrico_LerDigital(@bAmostra);
    if (intResposta <> 1) then
      begin
        CIS_SDK_Biometrico_Finalizar;

        ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
        Exit;
      end
    else
      begin
        strDiretorio := 'C:\CIS_SDK\DIGITAIS\';
        ForceDirectories(strDiretorio);

        DeleteFile(strDiretorio + 'Template1.tpl');

        MS := TMemoryStream.Create;
        MS.Write(bAmostra, 669);
        MS.Position := 0;
        MS.SaveToFile(strDiretorio + 'Template1.tpl');
        MS.Free;

        ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
      end;

  intResposta := CIS_SDK_Biometrico_Finalizar;
    if (intResposta <> 1) then
      ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
end;



procedure THREAD_Leitura2.Execute;
var
  intResposta: integer;
  bAmostra: Array [0..668] of Byte;
  MS: TMemoryStream;
  strDiretorio: string;
begin
  inherited;

  intResposta := CIS_SDK_Biometrico_Iniciar;
    if (intResposta <> 1) then
      begin
        ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
        Exit;
      end;

  intResposta := CIS_SDK_Biometrico_LerDigital(@bAmostra);
    if (intResposta <> 1) then
      begin
        CIS_SDK_Biometrico_Finalizar;

        ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
        Exit;
      end
    else
      begin
        strDiretorio := 'C:\CIS_SDK\DIGITAIS\';
        ForceDirectories(strDiretorio);

        DeleteFile(strDiretorio + 'Template2.tpl');

        MS := TMemoryStream.Create;
        MS.Write(bAmostra, 669);
        MS.Position := 0;
        MS.SaveToFile(strDiretorio + 'Template2.tpl');
        MS.Free;

        ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
      end;

  intResposta := CIS_SDK_Biometrico_Finalizar;
    if (intResposta <> 1) then
      ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
end;


procedure THREAD_LeituraWSQ.Execute;
var
  intResposta: integer;
  pImagem: Pointer;
  intSize: integer;
  MS: TMemoryStream;
  strDiretorio: string;
begin
  inherited;

  intResposta := CIS_SDK_Biometrico_Iniciar;
    if (intResposta <> 1) then
      begin
        ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
        Exit;
      end;

  pImagem := CIS_SDK_Biometrico_LerDigital_LerWSQ(intResposta, intSize);
    if (intResposta <> 1) then
      begin
        CIS_SDK_Biometrico_Finalizar;

        ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
        Exit;
      end
    else
      begin
        strDiretorio := 'C:\CIS_SDK\IMAGENS\';
        ForceDirectories(strDiretorio);

        DeleteFile(strDiretorio + 'Imagem.wsq');

        MS := TMemoryStream.Create;
        MS.Write(PByte(pImagem)^, intSize);
        MS.Position := 0;
        MS.SaveToFile(strDiretorio + 'Imagem.wsq');
        MS.Free;

        ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
      end;

  intResposta := CIS_SDK_Biometrico_Finalizar;
    if (intResposta <> 1) then
      ShowMessage('Retorno: ' + IntToStr(intResposta) + #13#10 + CIS_SDK_Retorno(intResposta));
end;


end.
