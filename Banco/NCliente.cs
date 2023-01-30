using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Banco
{
    static class NCliente
    {
        private static List<Cliente> clientes = new List<Cliente>();
        public static void Inserir(Cliente c)
        {
            Abrir();
            int id = 0;
            foreach (Cliente obj in clientes)
                if (obj.Id > id) id = obj.Id;
            c.Id = id + 1;
            clientes.Add(c);
            Salvar();
        }
        public static List<Cliente> Listar()
        {
            Abrir();
            return clientes;
        }
        public static void Atualizar(Cliente c)
        {
            Abrir();
            foreach (Cliente obj in clientes)
                if (obj.Id == c.Id)
                {
                    obj.Nome = c.Nome;
                    obj.Email = c.Email;
                    obj.Cpf = c.Cpf;
                }
            Salvar();
        }
        public static void Excluir(Cliente c)
        {
            Abrir();
            Cliente x = null;
            foreach (Cliente obj in clientes)
                if (obj.Id == c.Id) x = obj;
            if (x != null) clientes.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Cliente>));
                f = new StreamReader("./clientes.xml");
                clientes = (List<Cliente>)xml.Deserialize(f);
            }
            catch
            {
                clientes = new List<Cliente>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Cliente>));
            StreamWriter f = new StreamWriter("./clientes.xml", false);
            xml.Serialize(f, clientes);
            f.Close();

        }
    }
}
