unit Aprendendo_POO_Classe.Usuario;

interface
uses Aprendendo_POO_Classe.Pessoa;
  type TUsuario = class(Tpessoa)
    NomeAcesso : string;
    Senha : string;
  end;
implementation

end.
