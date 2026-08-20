unit Aprendendo_POO_Classe.Cliente;

interface
uses Aprendendo_POO_Classe.Pessoa;
  type TCliente = class(Tpessoa)
    CNPJ : string;
    RazaoSocial : string;
  end;
implementation

end.
