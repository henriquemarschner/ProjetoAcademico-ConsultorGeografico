unit uPrograma;

{$mode ObjFPC}{$H+}

interface

uses
  Classes, SysUtils, uPonto, uInterfaces;
  type
   Programa = class
    private
    protected
      oPonto  : Ponto;
      oPonto2 : Ponto;
      aInterfaces : Interfaces;
    public
      constructor CrieObj;
      destructor Destrua_se;
      procedure Execute_se;

  end;

implementation
  constructor Programa.CrieObj;
     begin
        oPonto  := ponto.CrieObj;
        oPonto2 := ponto.CrieObj;
        aInterfaces := Interfaces.CrieObj;
     end;
   destructor Programa.Destrua_se;
   begin
      oPonto.Destrua_se;
      oPonto2.Destrua_se;
      aInterfaces.Destrua_se;
   end;
   procedure Programa.Execute_se;
   var mpX, mpY, mX2, mY2, mDistancia, mDistCentro2 : real;
   begin
     aInterfaces.pecaX( mpX );
     aInterfaces.pecaY( mpY );
     oPonto.setPontos ( mpX, mpY );
     aInterfaces.pecaX2( mX2 );
     aInterfaces.pecaY2( mY2 );
     oPonto2.setPontos ( mX2, mY2 );
     oPonto.distancia(oPonto2, mDistancia, mDistCentro2);
     aInterfaces.resultado(mDistancia, mDistCentro2, oPonto.DistanciaCentro());
   end;
end.

