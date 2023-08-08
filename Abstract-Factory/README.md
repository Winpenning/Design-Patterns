# Abstract Factory

categoria do padrão: ************************************padrões de criação************************************

---

<aside>
💡 Fornece uma ************interface************ para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas.

</aside>

O padrão Abstract Factory é útil quando você precisa criar famílias de objetos que compartilham características comuns, mas têm variações específicas. Isso é especialmente útil em cenários em que você deseja criar objetos de diferentes tipos, mas esses tipos de objetos precisam ser usados juntos de alguma forma.

![problem-pt-br.png](Abstract%20Factory%207a320bc4e6c54c228c87005d7f91e09b/problem-pt-br.png)

---

## Vantagens

1. ************Separação das responsabilidades:************ O padrão Abstract Factory permite separar a criação de objetos complexos em uma hierarquia de fábricas abstratas, isolando as classes que criam objetos das classes que os utilizam. Isso promove uma estrutura mais modular e de fácil manutenção.
2. ******************************Flexibilidade:****************************** Como você trabalha com interfaces e classes abstratas, é mais fácil introduzir novas famílias de objetos sem afetar o código cliente existente. Isso torna o sistema mais flexível e adaptável a mudanças.
3. ****************Consistência:**************** Os objetos são criados em conformidade com uma família específica, o que ajuda a manter a consistência no design do sistema.
4. **************************Isolamento do código:************************** Detalhes de criação de objetos são encapsulados em suas fábricas concretas.
5. ********************Facilita os testes unitários:******************** É mais fácil criar testes unitários e substituir implementações concretas por mock objects durante os testes.
6. ******************Promove boas práticas de design:****************** Incentiva o uso de programação orientada a interfaces e a dependência de abstrações em vez de implementações concretas, alinhando-se assim com princípios sólidos de design de software.
7. ************************************************************************Adequado para hierarquias complexas:************************************************************************ É vantajoso quando as famílias de objetos têm hierarquias complexas e interdependências.
