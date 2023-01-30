using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Banco
{
    static class NConta
    {
        private static List<Conta> contas = new List<Conta>();
        public static void Inserir(Conta co)
        {
            Abrir();
            int id = 0;
            foreach (Conta obj in contas)
                if (obj.Id > id) id = obj.Id;
            co.Id = id + 1;
            contas.Add(co);
            Salvar();
        }
        public static List<Conta> Listar()
        {
            Abrir();
            return contas;
        }
        public static void Atualizar(Conta co)
        {
            Abrir();
            foreach (Conta obj in contas)
                if (obj.Id == co.Id)
                {
                    obj.IdCliente = c.IdCliente;
                    obj.Numero = c.Numero;
                }
            Salvar();
        }
        public static void Excluir(Conta co)
        {
            Abrir();
            Conta x = null;
            foreach (Conta obj in contas)
                if (obj.Id == co.Id) x = obj;
            if (x != null) contas.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Conta>));
                f = new StreamReader("./contas.xml");
                contas = (List<Conta>)xml.Deserialize(f);
            }
            catch
            {
                contas = new List<Conta>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Conta>));
            StreamWriter f = new StreamWriter("./contas.xml", false);
            xml.Serialize(f, contas);
            f.Close();
        }
    }
}
