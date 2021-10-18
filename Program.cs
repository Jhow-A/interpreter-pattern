using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var expressoes = new List<IAbstractExpression>();
            var context = new Context(DateTime.Now);

            Console.WriteLine($"Data atual: {context.Data}\n");
            Console.WriteLine("Escolha expressão: MM-DD-YYYY    YYYY-MM-DD    DD-MM-YYYY ");
            context.Expressao = Console.ReadLine().ToUpper();

            string[] formato = context.Expressao.Split('-');
            foreach (var item in formato)
            {
                if (item.Equals("DD"))
                    expressoes.Add(new ExpressaoDia());

                else if (item.Equals("MM"))
                    expressoes.Add(new ExpressaoMes());

                else if (item.Equals("YYYY"))
                    expressoes.Add(new ExpressaoAno());
            }

            expressoes.Add(new Separador());
            foreach (var expressao in expressoes)
                expressao.Avaliar(context);

            Console.WriteLine($"\nExpressão escolhida: {context.Expressao}");
        }
    }
}
