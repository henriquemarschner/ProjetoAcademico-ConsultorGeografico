program Ponto;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}
  cthreads,
  {$ENDIF}
  Classes, SysUtils, CustApp, Unit1
  { you can add units after this };

type

  { PCoordenadas }

  PCoordenadas = class(TCustomApplication)
  protected
    procedure DoRun; override;
  public
    constructor Create(TheOwner: TComponent); override;
    destructor Destroy; override;
    procedure WriteHelp; virtual;
  end;

{ PCoordenadas }

procedure PCoordenadas.DoRun;
var
  ErrorMsg: String;
begin
  // quick check parameters
  ErrorMsg:=CheckOptions('h', 'help');
  if ErrorMsg<>'' then begin
    ShowException(Exception.Create(ErrorMsg));
    Terminate;
    Exit;
  end;

  // parse parameters
  if HasOption('h', 'help') then begin
    WriteHelp;
    Terminate;
    Exit;
  end;



  // stop program loop
  Terminate;
end;

constructor PCoordenadas.Create(TheOwner: TComponent);
begin
  inherited Create(TheOwner);
  StopOnException:=True;
end;

destructor PCoordenadas.Destroy;
begin
  inherited Destroy;
end;

procedure PCoordenadas.WriteHelp;
begin
  { add your help code here }
  writeln('Usage: ', ExeName, ' -h');
end;

var
  Application: PCoordenadas;
begin
  Application:=PCoordenadas.Create(nil);
  Application.Title:='PCoordenadas';
  Application.Run;
  Application.Free;
end.

