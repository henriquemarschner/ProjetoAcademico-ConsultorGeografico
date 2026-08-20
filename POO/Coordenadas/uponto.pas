unit uPonto;

{$mode ObjFPC}{$H+} //compilador

interface
   uses
      Classes, SysUtils;   //bibliotecas
   type Ponto = class
   private
   protected
      X : real;    //eles não são acessados diretamente fora da classe, só pelos métodos
      Y : real;
   public
      constructor CrieObj;
      destructor destrua_se;

      procedure setPontos( pX, pY : real);
      procedure distancia( Ponto2 : Ponto; var dist, distCentro2 : real );
      function distanciaCentro : real;
      function getX : real; //irão apenas ler os valoresde x e y e não "mexer com eles"
      function getY : real;
end;

implementation
   constructor Ponto.CrieObj;
   begin
     X := 0; //seta os valores
     Y := 0;
   end;

   destructor Ponto.destrua_se;
   begin
   end;

   procedure Ponto.setPontos( pX, pY : real);
   begin
     X  := pX; //10
     Y  := pY;    // pega o valor e joga dentro de x e y
   end;

   function Ponto.getX : real;
   begin
        result := X;    //pega o valor que esta dentro do x e y e mostra
   end;

   function Ponto.getY : real;
   begin
        result := Y;
   end;

   function Ponto.distanciaCentro : real;
   begin
        result := sqrt(Sqr(X) + Sqr(Y));
   end;

   procedure Ponto.distancia( Ponto2 : Ponto; var dist, distCentro2 : real );
   var
     X2, Y2 : real;
   begin
        X2 := Ponto2.getX;
        Y2 := Ponto2.getY;
        dist := Sqrt( Sqr(X - X2) + Sqr(Y - Y2) );
        distCentro2 := sqrt(Sqr(X2) + Sqr(Y2));
   end;
end.

