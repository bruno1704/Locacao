using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locacao.Repository
{
    public class Iteste: Itestando
    {
        public string AlgumacoisPorString(String Parametro)
        {
            var String = "testestesteste4652"; //execmplo


            return String;
        }

        public int AlgumacoisporInt(int Algo)
        {
            var I = Algo;

            return Algo;
        }

        public bool AlgumaCoisaporbool( bool parametro)
        {

            return true;

        }
        public decimal AlgumaCoisaporDEcimal(decimal Nome)
        {
            ///aqui tem fazer convert
            ///ex: var t = Convert.seudadodeconversaooutipo("2019/05/10 23:59:00")
            ///apenas convert para datetime, nos outros não qlqr coisa avisa
            var D = Convert.ToDecimal(Nome);//essa forma foi uma possibilidade pra ficar claro era um exemplo
            /// na vaviavel d tem que passar algum dado e retornar esse dado
            return Nome;
        }

        public DateTime retornaDateTime(string data)
        {

            //anota dps o que achar interessante aqui olha isso

            // "2019/05/10 23:59:00" isso é um string vamos lá
            //data seria igual vamos dizer "2019/05/10 23:59:00" sacou? mas nesse caso vai ser pra decimal também? lê as coisas airton
            data = "2019/05/10 23:59:00";//faça ai o convert igual como mandei aqui onde vou mostrar
            var suadata = Convert.ToDateTime(data); //o que vai passar ali?  //nao pq ta errado vc ta pondo como string 

            //pegou a strinf data e conerteu para suadata passa para datetime 

            //ñ tinha entendido?

            //o problema é que eu já tinha visto um exemplo de tipo de retorno, mas o dateTime, eu não sabia que ele era um retorno também por isso estava dificl

            //blz. vc ajustou o postit?

            //eu tentei tirar alguns mas nem colaram de volta rsr

            //cara cria outro tem postit ai, dificil heimm, senao ta colando faz outro 

            //sei lá precisa ser mais agil, 

            //

            //nao tem erro nao sei pq se atraoalhou
            return suadata;
            //aqui vai seu tipo de dado  meu retorno é datetime então esta claro, por algum]
            //motivo vc nao entendeu

            //se seu tipo de dado é datetime pq ta fazendo decimal? issso que eu perguntei naquela hora
            //nao faz sentido essa pergunta pow se vc quer datetime pq ta passando decimal? eu expliqiei ali em cima

            //Convert.seudadodeconversaooutipo le aqui o que seria meu dado? cara anota denovo sobre tipo de dado


            //nao sei o que acontece que vc se atraalha em coisa boba vc fez os outros era a mesma logica

            //vc tem de me dizer a sua dificuldade

            //deveria dizer aqui  Convert.seudadodeconversaooutipo("2019/05/10 23:59:00") nao entendi 

            // é hipotetico se isso foi sua duvida

            // vc tentende que o tipo do retorno tem de ser o return 

            //??espera ai, o tipo de retorno tem que ser o retorno, mas ali no return vc colocou o nome da var que é suadata

            //foda-se (é força da espressao nao to chateado) o nome poww

            //anota ai , o var ele vai assumir o tipo do dado foda-se o nome
        }

        public double Retornadouble(string algumacoisa)
        {
            algumacoisa = "2010/10";
            var suavariavel = Convert.ToDouble(algumacoisa);

            //quando der erro começa a ler //gente aqui fuii
            return suavariavel; //muito facil tem de receber outro dado assim fica muito facil
        }





    }
}
