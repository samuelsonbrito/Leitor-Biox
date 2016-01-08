program CIS_SDK_Delphi;

uses
  Forms,
  uForm in 'uForm.pas' {frmForm};

{$R *.res}

begin
  Application.Initialize;
  Application.Title := 'CIS SDK';
  Application.CreateForm(TfrmForm, frmForm);
  Application.Run;
end.
