public class Cuidador
{
    public List<DocumentoMemento> estadosAnteriores = new List<DocumentoMemento>();
    public void adicionarMemento(DocumentoMemento memento)
    {
        estadosAnteriores.Add(memento);
    }
    public DocumentoMemento getUltimoMemento()
    {
        if (estadosAnteriores.Count == 0)
        {
            return null;
        }
        return estadosAnteriores[estadosAnteriores.Count - 1];
    }
}
