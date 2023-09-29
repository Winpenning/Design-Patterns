Documento doc = new Documento();
Cuidador cuidador = new Cuidador();

doc.escreverTexto("The Hobbit", "texto..............");
cuidador.adicionarMemento(doc.salvar());
Console.WriteLine("Texto atual\n" + doc.getTexto());

doc.escreverTexto("texto 2", "texto2..............");
cuidador.adicionarMemento(doc.salvar());



DocumentoMemento estadoanterior = cuidador.getUltimoMemento();
doc.restaurar(estadoanterior);

Console.WriteLine("Texto anterior\n" + doc.getTexto());

