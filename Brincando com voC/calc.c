#include <stdio.h>

// Funções para cada operação
float soma(float a, float b) {
    return a + b;
}

float subtrai(float a, float b) {
    return a - b;
}

float multiplica(float a, float b) {
    return a * b;
}

float divide(float a, float b) {
    if (b != 0)
        return a / b;
    else
        return 0; // Retorna 0 em caso de divisão por zero
}

int main() {
    int opcao;
    float num1, num2, resultado;

    printf("Calculadora Simples\n");
    printf("Escolha a operacao:\n");
    printf("1 - Adicao (+)\n");
    printf("2 - Subtracao (-)\n");
    printf("3 - Multiplicacao (*)\n");
    printf("4 - Divisao (/)\n");
    printf("Digite a opcao: ");
    scanf("%d", &opcao);

    printf("Digite o primeiro numero: ");
    scanf("%f", &num1);
    printf("Digite o segundo numero: ");
    scanf("%f", &num2);

    switch (opcao) {
        case 1:
            resultado = soma(num1, num2);
            printf("Resultado: %.2f\n", resultado);
            break;
        case 2:
            resultado = subtrai(num1, num2);
            printf("Resultado: %.2f\n", resultado);
            break;
        case 3:
            resultado = multiplica(num1, num2);
            printf("Resultado: %.2f\n", resultado);
            break;
        case 4:
            if (num2 != 0) {
                resultado = divide(num1, num2);
                printf("Resultado: %.2f\n", resultado);
            } else {
                printf("Erro: divisao por zero!\n");
            }
            break;
        default:
            printf("Opcao invalida!\n");
            break;
    }
    return 0;
}