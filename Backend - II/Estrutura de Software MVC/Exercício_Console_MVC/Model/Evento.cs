using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício_Console_MVC.Model
{
    public class Evento
    {
                public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data { get; set; }

        private const string PATH = "Database/Eventos.csv";
        // "Database/Eventos.csv"
        // [0] - "Database"
        // [1] - "Eventos.csv"


        public Evento()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Evento> Ler()
        {
            // instância da lista de produtos
            List<Evento> eventos = new List<Evento>();
            // array de strings armazenando todas as linhas do csv
            string[] linhas = File.ReadAllLines(PATH);
            // leitura das linhas
            foreach (var item in linhas)
            {
                // separação de atributos de cada linha
                string[] atributos = item.Split(";");
                // instância de produto
                Evento e = new Evento();
                // atribuição de valores dentro do objeto
                e.Nome = (atributos[0]);
                e.Descricao = atributos[1];
                e.Data = DateTime.Parse(atributos[2]);

                // adicionar objeto dentro da lista
                eventos.Add(e);

            }
            // retorna a lista de produtos
            return eventos;
        }

        public string PrepararLinhaCSV(Evento e)
        {
            return $"{e.Nome};{e.Descricao};{e.Data}";
        }

        public void Inserir(Evento e)
        {
            string [] linhas = {PrepararLinhaCSV(e)};
            File.AppendAllLines(PATH, linhas);
        }
    }
}