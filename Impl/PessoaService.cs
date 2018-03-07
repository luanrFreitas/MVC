using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace ClassLibrary1.Impl
{
    public class PessoaService
    {
        //CRUD
        //Salvar
        public  void Salvar(Pessoa pessoa)
        {
            using (var db = new MyContext())
            {
                if (pessoa.Codigo > 0)
                {
                    db.Pessoa.Attach(pessoa);
                    db.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
                }
                else
                    db.Pessoa.Add(pessoa);

                db.SaveChanges();
            }
        }
        //Obter
        public Pessoa Obter (int codigo)
        {
            using (var db = new MyContext())
            {
                return db.Pessoa.Find(codigo);
            }
        }
        //Listar
        public List<Pessoa> Listar ()
        {
            using (var db = new MyContext())
            {
                return db.Pessoa.ToList();
            }
        }
        //Deletar
        public void Delete (int codigo)
        {
            using (var db = new MyContext())
            {
                var p = db.Pessoa.Find(codigo);
                db.Pessoa.Attach(p);
                db.Pessoa.Remove(p);
                db.SaveChanges();
            }
        }
    }
}
