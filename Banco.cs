using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace NFC2
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = C:\\Users\\João Paulo\\source\\repos\\NFC2\\NFC2\\banco\\bd_NFC.db");
            conexao.Open();            
            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();                
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
              
            }catch(Exception ex)
            {  
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Funçoes do FORM F_NovoUsuario

        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELDOUSUARIO) VALUES (@nome, @username, @senha, @status, @nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário cadastrado!");
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuário!");
            }
        }



        //Fim das funções do FORM F_NovoUsuario

        //Funções do F_GestaoUsuarios
        public static DataTable ObterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID Usuário', T_NOMEUSUARIO as 'Nome' FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Fim do F_GestaoUsuarios

        //novo jogador
        public static void NovoJogador(Jogador j)
        {
            if (existeJogador(j))
            {
                MessageBox.Show("Jogador já existe");
                return;
            }
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_jogador (NOME, IDADE, NACIONALIDADE, POSICAO) VALUES (@nome, @idade, @nacionalidade, @posicao)";
                cmd.Parameters.AddWithValue("@nome", j.nome);
                cmd.Parameters.AddWithValue("@idade", j.idade);
                cmd.Parameters.AddWithValue("@nacionalidade", j.nacionalidade);
                cmd.Parameters.AddWithValue("@posicao", j.posicao);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo jogador cadastrado!");
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo jogador!");
            }
        }

        //Obter jogadores
        public static DataTable ObterTodosJogadores()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_jogador";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Rotinas Gerais

        public static bool existeUsername(Usuario u)
        {
            bool res = false;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME = '" + u.username +"'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;

        }

        public static bool existeJogador(Jogador j)
        {
            bool res = false;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT NOME FROM tb_jogador WHERE NOME = '" + j.nome + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;

        }

    }
}
