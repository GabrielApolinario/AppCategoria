using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace AppRoute66.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }

        public string Titulo { get; set; }

        public string Categoria { get; set; }

        public string Conteudo { get; set; }

        public DateTime Data { get; set; }
        
        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia
                {
                    NoticiaId=1,
                    Categoria="Esportes",
                    Titulo="O time da escola ganha dos catados",
                    Conteudo="O time da escola vence de 10x2 de time montado com os alunos sem time",
                    Data=new DateTime(22/03/2019)
                },
                new Noticia
                {
                    NoticiaId=2,
                    Categoria="Esportes",
                    Titulo="Ônibus da seleção masculina preso em blitz",
                    Conteudo="O ônibus da seleção foi parado pela blitz por alguns motivos: Sem volante. Sem lateral." +
                    "Grandes problemas na frente. E ainda transportando todo tipo de droga, menos crack.",
                    Data=new DateTime(15/02/2019)
                },
                new Noticia
                {
                    NoticiaId=3,
                    Categoria="Escola",
                    Titulo="Custo da escola",
                    Conteudo="Pai vai reclamar do boleto de pagamento da escola de joãozinho",
                    Data=new DateTime(02/03/2019)
                },
                new Noticia
                {
                    NoticiaId=4,
                    Categoria="Escola",
                    Titulo="Diario de um nerd",
                    Conteudo="Querido diario estou tão feliz",
                    Data=new DateTime(22/02/2019)
                }
            };
            return retorno;
        }        
    }
}