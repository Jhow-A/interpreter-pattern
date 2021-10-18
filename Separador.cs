namespace InterpreterPattern
{
    public class Separador : IAbstractExpression
    {
        public void Avaliar(Context context)
        {
            var expressao = context.Expressao;
            context.Expressao = expressao.Replace(" ", "-");
        }
    }
}
