using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efsoft.Core.Cache
{
    public interface ICache : ICache<string>
    {
        string Get(string key);
        void Set(string key, string value, int minutes, bool isAbsoluteExpiration, Action<string, string, string> onRemove);
        void Remove(string key);
        void Clear(string keyRegex);
    }

    public interface ICache<T>
    {
        T Get(string key);
        void Set(string key, T value, int minutes, bool isAbsoluteExpiration, Action<string, T, string> onRemove);
        void Remove(string key);
        void Clear(string keyRegex);
    }
}
