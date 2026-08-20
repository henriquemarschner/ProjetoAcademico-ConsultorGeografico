unit uInter;

interface
uses Classes,SysUtils;
  type Inter = class
    private
    protected
    public
      constructor CrieObj;
      destructor Destrua_se;
      procedure pecaX (var pX : real);
      procedure pecaY (var pY : real);
      procedure pecaX2 (var X2 : real);
      procedure pecaY2 (var Y2 : real);
      procedure resultado (pDist,pDistCentro,pDistCentro2 : real);
  end;

implementation
  constructor Inter.CrieObj;
  begin

  end;

  destructor Inter.Destrua_se;
  begin

  end;

  procedure Inter.pecaX(var pX: Real);
  begin
    writeln('Digite o valor de X do ponto um');
    readln(pX);
  end;

  procedure Inter.pecaY(var pY: Real);
  begin
    writeln('Digite o valor de Y do ponto um');
    readln(pY);
  end;

  procedure Inter.pecaX2(var X2 : Real);
  begin
    writeln('Digite o valor de X do ponto dois');
    readln(X2);
  end;

  procedure Inter.pecaY2(var Y2 : Real);
  begin
    writeln('Digite o valor de Y do ponto dois');
    readln(Y2);
  end;

  procedure Inter.resultado(pDist: Real; pDistCentro: Real; pDistCentro2: Real);
  begin
    writeln('A distancia entre os dois pontos é:', pDist:8:2);
    writeln('A distancia entre o ponto um e o centro é:', pDistCentro:8:2);
    writeln('A distancia entre o ponto dois e o centro é:', pDistCentro2:8:2);
    readln;
  end;

end.
