using System.Collections.Generic;

namespace SmsSender.Data.DbServices
{
    public interface IDbQueries<T>
    {
        IList<T> RetrieveItems(string key);
    }
}
