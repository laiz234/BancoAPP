using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Banco
{
    public class NBanco
    {
        private static List<AgenciaBancaria> bancos = new List<AgenciaBancaria>();
        public static void Inserir(AgenciaBancaria b)
        {
            Abrir();
            int id = 0;
            foreach (AgenciaBancaria obj in bancos)
                if (obj.Id > id) id = obj.Id;
            b.Id = id + 1;
            bancos.Add(b);
            Salvar();
        }
        public static List<AgenciaBancaria> Listar()
        {
            Abrir();
            return bancos;
        }
        public static void Excluir(AgenciaBancaria b)
        {
            Abrir();
            AgenciaBancaria x = null;
            foreach (AgenciaBancaria obj in bancos)
                if (obj.Id == b.Id) x = obj;
            if (x != null) bancos.Remove(x);
            Salvar();
        }
        public static void Atualizar(AgenciaBancaria b)
        {
            Abrir();
            foreach (AgenciaBancaria obj in bancos)
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
                XmlSerializer xml = new XmlSerializer(typeof(List<AgenciaBancaria>));
                f = new StreamReader("./bancos.xml");
                bancos = (List<AgenciaBancaria>)xml.Deserialize(f);
            }
            catch
            {
                bancos = new List<AgenciaBancaria>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<AgenciaBancaria>));
            StreamWriter f = new StreamWriter("./bancos.xml", false);
            xml.Serialize(f, bancos);
            f.Close();
        }

    }
}
