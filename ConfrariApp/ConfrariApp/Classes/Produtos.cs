using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ConfrariApp.Classes
{
    public class Produtos
    {
        public List<ModelProdutos> SelectAll()
        {
            try
            {
                var produtos = ((App)Application.Current).conexao.Query<ModelProdutos>("SELECT * FROM CadastroProduto");
                return produtos;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }

        }

        public bool Inserir(string nome, string descricao, string valor, string categoria)
        {
            try
            {
                var query = $"INSERT INTO CadastroProduto (nome, descricao, valor, categoria) VALUES ('{nome}', '{descricao}', '{valor}', '{categoria}')";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }

        }

        public bool Update(int id, string nome, string descricao, string valor, string categoria)
        {
            try
            {
                var query = $"UPDATE CadastroProdutos SET nome = '{nome}', descricao = '{descricao}', valor = '{valor}', categoria = '{categoria}' WHERE id = {id}";
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
                var query = $"DELETE FROM CadastroProdutos";
                ((App)Application.Current).conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteItem(int id, string nome, string descricao, string valor, string categoria)
        {
            try
            {
                var query = $"DELETE FROM CadastroProdutos WHERE id = {id}";
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
