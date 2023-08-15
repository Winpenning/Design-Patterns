# Builder

******************padrão de projeto:****************** Criacional.

---

<aside>
💡 Abordagem que visa resolver o problema da criação de objetos complexos, proporcionando uma estrutura mais organizada e flexível.

</aside>

O padrão Builder separa o processo de construção de um objeto da sua representação, permitindo  a criação de objetos em etapas.

Em essência, o padrão Builder fornece uma maneira de criar objetos passo a passo, onde cada passo é representado por um método específico. Isso significa que você pode controlar a ordem em que os passos de construção são executados e, ao final, obter um objeto completamente construído e configurado.

Vantagens:

- Flexibilidade: Diferentes configurações de objetos a partir dos mesmos passos de construção;
- Legibilidade: Cada parte do objeto tem sua própria classe builder, deixando o código mais legível;
- Manutenção: Adicionar novos tipos de objetos ou partes se torna mais fácil, pois você pode criar novos construtores concretos ou alterar os existentes sem afetar o código que usa o padrão Builder.
- Re-usabilidade: Os passos de construção definidos pelo Builder podem ser reutilizados em diferentes contextos, evitando duplicação de código e melhorando a eficiência no desenvolvimento.
- Encapsulamento: A construção do objeto é encapsulada nas classes Builder.