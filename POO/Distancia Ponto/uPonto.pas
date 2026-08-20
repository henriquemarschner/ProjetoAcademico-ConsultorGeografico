unit uPonto;

interface
uses
 Classes,SysUtils;
type Ponto = class
  private
  protected
    x : real;
    y : real;
  public
    constructor CrieObj;
    destructor Destrua_se;
    procedure setPontos (pX, pY : real);
    procedure Dist(Ponto2 : Ponto; var dist,distCentro2 : real);
    function getX : real;
    function getY : real;
    function distCentro : real;
end;

implementation
  constructor Ponto.CrieObj;
  begin
    X := 0;
    Y := 0;
  end;

  destructor Ponto.Destrua_se;
  begin

  end;

  procedure Ponto.setPontos(pX: Real; pY: Real);
  begin
     pX := x;
     pY := y;
  end;

  function Ponto.getX: Real;
  begin
    X := result;
  end;

  function Ponto.getY: Real;
  begin
    Y := result;
  end;

  function Ponto.distCentro: Real;
  begin
    result := sqrt(sqr(X) + sqr(Y));
  end;

  procedure Ponto.Dist(Ponto2: Ponto; var dist: Real; var distCentro2: Real);
  var x2,y2:real;
  begin
    X2 := Ponto2.getX;
    Y2 := Ponto2.getY;
    dist := sqrt(sqr(x-x2) + sqr(y-y2));
    distCentro2 := sqrt(sqr(x2) + sqr(y2))
  end;
end.
