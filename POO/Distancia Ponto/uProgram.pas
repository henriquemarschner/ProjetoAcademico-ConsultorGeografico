unit uProgram;

interface
uses
  SysUtils, Classes, uPonto, uInter;
  type
    Programa = Class
      private
      protected
        oPonto : Ponto;
        oPonto2 : Ponto;
        aInter : Inter;
      public
        constructor CrieObj;
        destructor  Destrua_se;
        procedure Execute;
    End;


implementation
  constructor Programa.CrieObj;
  begin
    oPonto := Ponto.CrieObj;
    oPonto2 := Ponto.CrieObj;
    aInter := Inter.CrieObj;
  end;

  destructor Programa.Destrua_se;
  begin
    oPonto.Destrua_se;
    oPonto2.Destrua_se;
    aInter.Destrua_se;
  end;

  procedure Programa.Execute;
  var mpX, mpY, mX2, mY2, mDist, mDistCentro2 : real;
  begin
     aInter.pecaX( mpX );
     aInter.pecaY( mpY );
     oPonto.setPontos ( mpX, mpY );
     aInter.pecaX2( mX2 );
     aInter.pecaY2( mY2 );
     oPonto2.setPontos ( mX2, mY2 );
     oPonto.dist(oPonto2, mDist, mDistCentro2);
     aInter.resultado(mDist, mDistCentro2, oPonto.DistCentro());
   end;

end.
