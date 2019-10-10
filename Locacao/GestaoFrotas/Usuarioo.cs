using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlCliet;


namespace GestaoDeFrota
{
    public class Usuarioo
    {
        private int Id;
        private string login;
        private string senha;
        private bool bloqueado;

        public int id
        {
            get { return Id; }
            set { Id = value; }

        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public bool Bloqueado
        {
            get { return bloqueado; }
            set { bloqueado = value; }
        }

        public Usuarioo()
        {
            this.Id = 0;
            this.login = "";
            this.senha = "";
            this.bloqueado = true;

        }
        public bool Verificarlogin()
        {



            return Bloqueado;
        }

        

    }
    
    

    
        
    


    
}  
