using ProjetoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if (!string.IsNullOrEmpty(loginDao.mensagem))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String nome, String email, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(nome,email,senha,confSenha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
            
    }
}
