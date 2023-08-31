using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Tenis.Dall.model;

namespace Tenis.Dall.controlle
{
    public class CtrlJogador: DAO
    {


            public int inserir(Jogador jogador)
            {
                String sql = "INSERT INTO JOGADOR(NOME, NICK, SENHA) " +
                "VALUES (@NOME, @NICK, @SENHA) " +
                "SELECT SCOPE_IDENTITY()";

                cmd = new SqlCommand(sql, conectar());

                par = new SqlParameter("@NOME", jogador.nome);
                par.SqlDbType = System.Data.SqlDbType.VarChar;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@NICK", jogador.nick);
                par.SqlDbType = System.Data.SqlDbType.VarChar;
                cmd.Parameters.Add(par);

                par = new SqlParameter("@SENHA", jogador.senha);
                par.SqlDbType = System.Data.SqlDbType.VarChar;
                cmd.Parameters.Add(par);

                reader = cmd.ExecuteReader();

                reader.Read();
                String pk = reader.GetValue(0).ToString();
                return Int32.Parse(pk);
            }

        public int alterar(Jogador jogador)
        {
            string Sql = "UPDATE JOGADOR SET NOME = @NOME, NICK = @NICK" + "SENHA = @SENHA" + "WHERE COD = @COD";

            cmd = new SqlCommand(Sql, conectar());

            par = new SqlParameter("@COD", jogador.cod);
            par.SqlDbType = System.Data.SqlDbType.Int;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@NOME", jogador.nome);
            par.SqlDbType = System.Data.SqlDbType.VarChar;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@NICK", jogador.nick);
            par.SqlDbType = System.Data.SqlDbType.VarChar;
            cmd.Parameters.Add(par);

            par = new SqlParameter("@SENHA", jogador.senha);
            par.SqlDbType = System.Data.SqlDbType.VarChar;
            cmd.Parameters.Add(par);


            reader = cmd.ExecuteReader();
            reader.Read();
            String pk = reader.GetValue(0).ToString();
            return Int32.Parse(pk);
        }

        public void excluir(Jogador jogador)
        {
            String sql = "DELETE FROM JOGADOR " +
                "WHERE COD = @COD";

            cmd = new SqlCommand(sql, conectar());

            par = new SqlParameter("@COD", jogador.cod);
            par.SqlDbType = System.Data.SqlDbType.Int;
            cmd.Parameters.Add(par);

            cmd.ExecuteNonQuery();

        }

    }
}