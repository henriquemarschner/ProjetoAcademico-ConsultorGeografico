#include <stdio.h>
#include <locale.h>

int main() {
    setlocale(LC_ALL, "Portuguese");
    float vlDolar,vlYuan,vlGuarani;
    float cotDolar=5.40,cotYuan=1.15,cotGuarani=1300,cambio;
    int escolha=0;
    printf("Escolha a moeda para conversao:\n");
    printf("1. Dolar (USD)\n");
    printf("2. Yuan (CNY)\n");
    printf("3. Guarani (PYG)\n");
    printf("Digite o numero correspondente a moeda (1, 2 ou 3): ");
    scanf("%d", &escolha);
    if (escolha < 1 || escolha > 3) {
        printf("Invalida. Encerrando o programa.\n");
        return 0;
    }
    if (escolha == 1) {
        printf("Digite o valor em dolares a ser convertido em reais:\n");
        scanf("%f", &vlDolar);
        cambio=vlDolar*cotDolar;
        printf("O valor convertido em reais:R$ %.2f\n", cambio);
    } else if (escolha == 2) {
        printf("Digite o valor em yuan a ser convertido em reais:\n");
        scanf("%f", &vlYuan);
        cambio=vlYuan/cotYuan;
        printf ("O valor convertido em reais:R$ %.2f\n", cambio);
    } else if (escolha == 3) {
        printf("Digite o valor em guarani a ser convertido em reais:(para virar milhao)\n");
        scanf("%f", &vlGuarani);
        vlGuarani=vlGuarani*1000000;
        cambio=vlGuarani/cotGuarani;
        printf("O valor convertido em reais:R$ %.2f\n", cambio);
    }
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