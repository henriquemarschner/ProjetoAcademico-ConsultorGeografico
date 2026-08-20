program Aprendendo_POO;

{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils,
  Aprendendo_POO_Classe.Pessoa in 'Aprendendo_POO_Classe.Pessoa.pas',
  Aprendendo_POO_Classe.Cliente in 'Aprendendo_POO_Classe.Cliente.pas',
  Aprendendo_POO_Classe.Usuario in 'Aprendendo_POO_Classe.Usuario.pas',
  Aprendendo_POO_Classe.Administrador in 'Aprendendo_POO_Classe.Administrador.pas';

var
  Pessoa : TPessoa;
begin
  try
    { TODO -oUser -cConsole Main : Insert code here }
    Pessoa := TPessoa.Create;
    writeln('Digite o nome da pessoa: ');
    readln(Pessoa.Nome);
    writeln('O nome da pessoa é ' + Pessoa.Nome);
    readln;
  except
    on E: Exception do
      Writeln(E.ClassName, ': ', E.Message);
  end;
end.
