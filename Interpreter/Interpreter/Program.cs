using Interpreter.entities;

Numero n1 = new Numero(2);
Numero n2 = new Numero(3);
Numero n3 = new Numero(1);

Soma s1 = new Soma(n1, n2);
s1.interpretar();
Subtracao s2 = new Subtracao(s1.result, n3);

Console.WriteLine(s2.interpretar());