﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ConfrariApp.Classes
{
    public class Clientes
    {
        public List<ModelClientes> SelectAll()
        {
            try
            {
                var clientes = ((App)Application.Current).conexao.Query<ModelClientes>("SELECT * FROM CadastroCliente");
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }

        }

        public int Login(string login, string senha)
        {
           
                string query = string.Format("SELECT COUNT(*) FROM CadastroCliente WHERE login = '{0}' AND senha = '{1}'", login, senha);
                var ResultadoSql = ((App)Application.Current).conexao.Query<ModelClientes>(query);

                if (ResultadoSql.Count == 1)
                {
                    return 1;
                }
 
                else
                {
                    return 2;
                }
            
 

        }

        public bool Inserir(string nome, string login, string data, string telefone, string senha)
        {
            try
            {
                var query = $"INSERT INTO CadastroCliente (nome, login, data, telefone, senha) VALUES ('{nome}', '{login}', '{data}', '{telefone}', '{senha}')";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }

        }

        public bool Update(int id, string nome, string login, string data, string telefone, string senha)
        {
            try
            {
                var query = $"UPDATE CadastroCliente SET nome = '{nome}', login = '{login}', data = '{data}', telefone = '{telefone}', senha = '{senha}' WHERE id = {id}";
                ((App)Application.Current).conexao.Execute(query);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao atualizar\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteAll()
        {
            try
            {
                var query = $"DELETE FROM CadastroClientes";
                ((App)Application.Current).conexao.Execute(query);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Houve um erro ao inserir\nDetalhes:" + ex.Message);
            }
        }

        public bool DeleteItem(int id, string nome, string login, string data, string telefone, string senha)
        {
            try
            {
                var query = $"DELETE FROM CadastroCliente WHERE id = {id}";
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
