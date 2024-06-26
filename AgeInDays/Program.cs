namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int anos, meses, dias, valor, resto;

            Console.WriteLine("Insira o valor aqui: ");
            valor = int.Parse(Console.ReadLine());

            anos = valor / 365;
            resto = valor % 365;

            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " anos (s)");
            Console.WriteLine(meses + " mes (es)");
            Console.WriteLine(dias + " dia (s)");
        }
    }
}