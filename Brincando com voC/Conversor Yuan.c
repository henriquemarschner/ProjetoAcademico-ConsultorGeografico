#include <stdio.h>
float soma(float a, float b) {
    return a + b;
}
float divide(float a, float b) {
    if (b != 0)
        return a / b;
    else
        return 0;
}
int main() {
    float num1, num2, resultado;
    printf("Calculo para converter yuan para real\n");
    printf("Digite dois numeros:");
    scanf("%f %f", &num1,&num2);
    resultado = soma(num1, num2);
    printf("Convertendo o valor %.2f yuan para real\n",resultado);
    if (resultado != 0) {
        resultado = resultado / 1.15;
        printf("Valor convertido em: %.2f reais\n", resultado); 
    }
    else
        printf("Erro: divisao por zero!\n");
    
    printf("Quer continuar? (1-Sim / 2-Nao):\n");
    int continuar;
    scanf("%d", &continuar);
    if (continuar == 1)
        main();
    else {
        printf("Encerrando o programa.\n");
        return 0;
    }
    if (continuar < 1 || continuar > 2){
        printf("Invalida. Encerrando o programa.\n");
        return 0;
    }
}