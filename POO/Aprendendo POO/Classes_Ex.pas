unit Classes_Ex;

interface
  type
    TExemplo = class
    private
      {visivel para a classe e classes amigas (que estejam na mesma unit)}
      FPrivado : string;
    protected
      {visivel para a classe,classes amigas e herdeiros}
      FProtegido : string;
    public
      {visivel para a qualquer um que referencie a classe}
      FPublico : string;
      Fpublicada: string;
      procedure Setpublicada(const Value: string);
      function GetPrivado : string;
    published
      {visivel e publicado no object inspector}
      property publicada : string read Fpublicada write Setpublicada;
    end;

    TSubExemplo = class(TExemplo)
      public
        function GetProtegidoEx : string;
    end;

implementation

{ TExemplo }
function TExemplo.GetPrivado: string;
begin
  Result := FPrivado;
end;

procedure TExemplo.Setpublicada(const Value: string);
begin
  Fpublicada := Value;
end;

{ TSubExemplo }

function TSubExemplo.GetProtegidoEx: string;
begin
  Result := FProtegido;
end;

end.
