using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ConfrariApp.Classes
{
    public class Programacao
    {
        public List<ModelProgramacao> SelectAll()
        {
            try
            {
                var programacao = ((App)Application.Current).conexao.Query<ModelProgramacao>("SELECT * FROM CadastroProgramacao");
                return programacao;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }

        }

        public bool Inserir(string nomeprog, string data, string descricao)
        {
            try
            {
                var query = $"INSERT INTO CadastroProgramacao (nomeprog, data, descricao) VALUES ('{nomeprog}', '{data}', '{descricao}')";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }

        }

        public bool Update(int id, string nomeprog, string data, string descricao)
        {
            try
            {
                var query = $"UPDATE CadastroProgramacao SET nomeprog = '{nomeprog}', data = '{data}', descricao = '{descricao}' WHERE id = {id}";
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
                var query = $"DELETE FROM CadastroProgramacao";
                ((App)Application.Current).conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteItem(int id, string nomeprog, string data, string descricao)
        {
            try
            {
                var query = $"DELETE FROM CadastroProgramacao WHERE id = {id}";
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
