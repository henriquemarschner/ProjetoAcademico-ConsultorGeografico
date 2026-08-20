unit Form_Principal;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TFormPrincipal = class(TForm)
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FormPrincipal: TFormPrincipal;

implementation

{$R *.dfm}

uses Classes_Ex;

procedure TFormPrincipal.Button1Click(Sender: TObject);
var
  LExemplo : TExemplo;
  LSub : TSubExemplo;
begin
  LExemplo := TExemplo.Create;
  LExemplo.Setpublicada('');
  LExemplo.GetPrivado;
  LSub.GetProtegidoEx;
end;

end.
