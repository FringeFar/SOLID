using System;

namespace Class.SOLID.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // Validar valor
        }

        public void SalvarBanco()
        {
            // Insert tabela Produto
        }

        public void EnviarEmail()
        {
            // Produto n鉶 tem e-mail, o que eu fa鏾 agora???
            throw new NotImplementedException("Esse metodo n鉶 serve pra nada");
        }
    }
}