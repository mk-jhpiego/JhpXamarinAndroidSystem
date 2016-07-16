using System.Collections.Generic;
using System.Linq;
using JhpDataSystem.model;
using JhpDataSystem.store;

namespace JhpDataSystem
{
    public class ClientLookupProvider<T> where T : class, ILocalDbEntity, new()
    {
        string _kindName;
        public ClientLookupProvider(string kindName)
        {
            _kindName = kindName;
        }

        public List<T> Get()
        {
            var all = new LocalDB3().DB
                .Table<T>()
                .ToList<T>()
                .OrderByDescending(t => t.CoreActivityDate)
                .ToList();
            all.ForEach(t => { t.build(); });
            return all;
        }
        public int Update(List<T> clients)
        {
            var all = new LocalDB3().DB
                .UpdateAll(clients);
            return all;
        }

        public int GetCount()
        {
            var all = new LocalDB3().DB
                .ExecuteScalar<int>("select count(*) from " + _kindName);
            return all;
        }
    }

}