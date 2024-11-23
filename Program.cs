
// organiza o programa
class Program
{
// static permite chamar o metodo sem precisar criar um objeto da classe , void indica que o metodo não retorna nenhuma valor , o main é nome padrão obrigatório para iniciar o programa
    static void Main()
    {
        Console.WriteLine("=== Silvio Santos e o Desafio do 'Pim' ===");
        Console.WriteLine("Os números de 1 a 40 serão exibidos. Múltiplos de 4 viram 'pim'!\n");
 
        // Chama a função para exibir a sequência
        ExibirSequencia(1, 40);
 
        Console.WriteLine("\n=== Fim do Desafio ===");
    }
 
    static void ExibirSequencia(int inicio, int fim)
    {
        for (int i = inicio; i <= fim; i++)
        {
            // Obtém o valor a ser exibido (número ou "pim")
            string valor = VerificarPim(i);
 
            // Define cor para destacar "pim"
            if (valor == "pim")
                Console.ForegroundColor = ConsoleColor.Magenta;
            else
                Console.ResetColor();
 
            // Exibe o valor com espaçamento
            Console.Write(valor.PadRight(4));
 
            // Quebra a linha após 4 itens
            if (i % 4 == 0)
                Console.WriteLine();
        }
 
        // Restaura a cor padrão
        Console.ResetColor();
    }
 
    static string VerificarPim(int numero)
    {
        // Retorna "pim" se for múltiplo de 4, caso contrário o número como string
        return (numero % 4 == 0) ? "pim" : numero.ToString();
    }
}