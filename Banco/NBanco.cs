using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class NBanco
    {
        private static List<Banco> bancos = new List<Banco>();
        public static void Inserir(Banco b)
        {
            Abrir();
            int id = 0;
            foreach (Banco obj in bancos)
                if (obj.Id > id) id = obj.Id;
            b.Id = id + 1;
            bancos.Add(b);
            Salvar();
        }
        public static List<Banco> Listar()
        {
            Abrir();
            return bancos;
        }
        public static void Excluir(Banco b)
        {
            Abrir();
            Bnaco x = null;
            foreach (Banco obj in bancos)
                if (obj.Id == b.Id) x = obj;
            if (x != null) bancos.Remove(x);
            Salvar();
        }
        public static void Atualizar(Banco b)
        {
            Abrir();
            foreach (Banco obj in bancos)
                if (obj.Id == b.Id)
                {
                    obj.Nome = b.Nome;
                }
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Banco>));
                f = new StreamReader("./bancos.xml");
                bancos = (List<Banco>)xml.Deserialize(f);
            }
            catch
            {
                bancos = new List<Banco>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Banco>));
            StreamWriter f = new StreamWriter("./bancos.xml", false);
            xml.Serialize(f, bancos);
            f.Close();
        }
    }
}
