unit uInterfaces;

{$mode ObjFPC}{$H+}

interface

uses
  Classes, SysUtils;
   type interfaces = class
     private
     protected
     public

       constructor CrieObj;
       destructor Destrua_se;

       procedure pecaX (var pX : real);
       procedure pecaY (var pY : real);

       procedure pecaX2 (var X2 : real);
       procedure pecaY2 (var Y2 : real);

       procedure resultado (pDistancia, pDistCentro2, pDistanciaCentro : real);

   end;

implementation
   constructor interfaces.CrieObj;
   begin
   end;

   destructor interfaces.destrua_se;
   begin
   end;

   procedure interfaces.pecaX(var pX : real);
   begin
     write('Digite o Valor de X do ponto um: ');
     readln( pX );
   end;

   procedure interfaces.pecaY(var pY : real);
   begin
     write('Digite o Valor de Y do ponto um: ');
     readln( pY );
   end;

   procedure interfaces.pecaX2(var X2 : real);
   begin
     write('Digite o Valor de X do ponto dois: ');
     readln( X2 );
   end;

   procedure interfaces.pecaY2(var Y2 : real);
   begin
     write('Digite o Valor de Y do ponto dois: ');
     readln( Y2 );
   end;

   procedure interfaces.resultado (pDistancia, pDistCentro2, pDistanciaCentro : real);
   begin
      writeln('A distancia entre ponto um e o ponto dois é: ', pDistancia:8:2);
      writeln('A distancia entre o ponto um e o centro é: ', pDistanciaCentro:8:2);
      writeln('A distancia entre o ponto dois e o centro é: ', pDistCentro2:8:2);
      readln;
   end;
end.

