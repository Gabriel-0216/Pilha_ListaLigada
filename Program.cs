namespace Pilha
{
    public class Program
    {
        public static void Main()
        {
            var pilha = new Pilha();
            Console.WriteLine($"Pilha está vazia? {pilha.IsEmpty()}");

            Console.WriteLine("Adicionando elemento");
            pilha.Push(new Elemento(1));
            Console.WriteLine($"Topo da pilha: {pilha.RetornarTopo()?.Valor}");

            Console.WriteLine("adicionando novo elemento");

            pilha.Push(new Elemento(2));
            Console.WriteLine($"Topo da pilha: {pilha.RetornarTopo()?.Valor}");

            Console.WriteLine("removendo elemento");
            pilha.Pop();

            Console.WriteLine($"Topo da pilha: {pilha.RetornarTopo()?.Valor}");

            Console.WriteLine("removendo elemento");
            pilha.Pop();
            Console.WriteLine($"Topo da pilha: {pilha.RetornarTopo()?.Valor}");
                        Console.WriteLine($"Pilha está vazia? {pilha.IsEmpty()}");



        }
    }
    public class Pilha
    {
        public Elemento? TopoPilha { get; set; }

        public bool IsEmpty()
        {
            return TopoPilha is null;
        }
        public void Push(Elemento novo)
        {
            novo.Anterior = TopoPilha;
            TopoPilha = novo;
        }
        public void Pop()
        {
            if (TopoPilha is null) return;
            TopoPilha = TopoPilha.Anterior;
        }
        public Elemento? RetornarTopo() => TopoPilha;
    }

    public class Elemento
    {
        public Elemento(int valor)
        {
            Valor = valor;
        }
        public int Valor { get; set; }
        public Elemento? Anterior { get; set; } = null;
    }
}