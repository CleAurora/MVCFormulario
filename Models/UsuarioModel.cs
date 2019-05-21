using System;

namespace ex2WebMVC.Models
{
    public class UsuarioModel
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        public DateTime DataNascimento {get; set;}

        public UsuarioModel(string nome, string email, string senha, DateTime dataNascimento){//isso é um construtor - deve ter o mesmo nome da classe e seus parâmetros. Quando eu instanciar, já quero atribuir os valores aos atributos acima, logo as linhas abaixo:
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }//eu posso ter quantos construtores eu quiser nessa classe, mas com parâmetros distintos - tipo outro só com nome e e-mail

        public UsuarioModel(int id, string nome, string email, string senha, DateTime dataNascimento){
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }
    }
}