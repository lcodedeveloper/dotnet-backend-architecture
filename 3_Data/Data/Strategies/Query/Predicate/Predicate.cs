using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorys.Strategies.Query.Predicate
{
    class Predicate : IPredicate
    {
        private string query;
        private Dictionary<string, object> parameters = new Dictionary<string, object>();

        public string Query { get => this.query; set => this.query = value; }
        public Dictionary<string, object> Parameters { get => this.parameters; set => this.parameters = value; }
    }
}
