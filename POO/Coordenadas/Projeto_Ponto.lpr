program Projeto_Ponto;

{$mode objfpc}{$H+}

uses
  {$IFDEF UNIX}
  cthreads,
  {$ENDIF}
  Classes, SysUtils, CustApp, uPonto, uInterfaces, uPrograma
  { you can add units after this };


var
  oPrograma : Programa;
begin
  oPrograma := Programa.CrieObj;
  oPrograma.Execute_se;
  oPrograma.Destrua_se;
end.
