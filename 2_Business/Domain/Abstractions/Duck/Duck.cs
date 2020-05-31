using Domains.Strategies.Fly;
using Domains.Strategies.Crud;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Abstractions.Duck
{
    public abstract class Duck
    {
        public string Name;

        private IFlyStrategy fly;
        private ICrudStrategy crud;

        public Duck() { }
        
        public Duck(IFlyStrategy fly) => this.fly = fly;
        public Duck(ICrudStrategy crud) => this.crud = crud;
        public void Setfly(IFlyStrategy fly) => this.fly = fly;
        public void SetCrud(ICrudStrategy crud) => this.crud = crud;
        
        public void Create(object o) => this.crud.Create(this);
        public void Update(object o) => this.crud.Update(this);
        public object GetById(int id) => this.crud.GetById(id);
        public IEnumerable<object> GetAll() => this.crud.GetAll();
        public void Delete(object o) => this.crud.Delete(o);

        public void Fly() => this.fly.Fly();
    }
}
