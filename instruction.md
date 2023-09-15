# Teste de Performance 3
## Exercício #4
Implemente um programa no qual o usuário controle um sistema de empréstimo para uma biblioteca, onde as opções de empréstimo são: livro, jornal ou revista. Ao fim, o programa deve exibir o resultado final para cada tipo de publicação.

### Requisitos:

1. Data da devolução de um livro: Até 5 dias corridos, a contar da data atual;
2. Data da devolução de um jornal: Até 7 dias corridos, a contar da data atual;
3. Data da devolução de uma revista: Até 15 dias corridos, a contar da data atual;
4. Exiba o tipo, nome e a data de devolução da publicação.

### Requisitos técnicos:

1. Decida tecnicamente entre uma classe abstrata ou uma interface, que represente uma publicação. Defina na classe ou na interface um método que calcule a data de devolução;
2. Implemente classes derivadas para representar livro, jornal e revista, herdando ou implementando o item 1 (classe abstrata ou interface);
3. Instancie no programa principal a criação de um livro, de um jornal e de uma revista (informe nomes fictícios para cada publicação);
4. Utilize a classe Console apenas no programa principal;