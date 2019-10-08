using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ConfrariApp.Classes
{
    public class Reservas
    {
        public List<ModelReservas> SelectAll()
        {
            try
            {
                var reservas = ((App)Application.Current).conexao.Query<ModelReservas>("SELECT * FROM CadastroReservas");
                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }

        }

        public bool Inserir(string nomeCliente, string qtdpessoas , string data, string observacao)
        {
            try
            {
                var query = $"INSERT INTO CadastroReservas (nomeCliente, qtdpessoas, data, observacao) VALUES ('{nomeCliente}', '{qtdpessoas}', '{data}', '{observacao}')";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }

        }

        public bool Update(int id, string nomeCliente, string qtdpessoas, string data, string observacao)
        {
            try
            {
                var query = $"UPDATE CadastroReservas SET nomeCliente = '{nomeCliente}', qtdpessoas = '{qtdpessoas}', data = '{data}', observacao = '{observacao}' WHERE id = {id}";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteAll()
        {
            try
            {
                var query = $"DELETE FROM CadastroReservas";
                ((App)Application.Current).conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteItem(int id, string nomeCliente, string qtdpessoas, string data, string observacao)
        {
            try
            {
                var query = $"DELETE FROM CadastroReserva WHERE id = {id}";
                ((App)Application.Current).conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }
    }
}
