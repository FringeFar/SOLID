﻿using Class.SOLID.ISP.Solucao.Interfaces;

namespace Class.SOLID.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void EnviarEmail()
        {
            // Enviar e-mail para o cliente
        }
    }
}