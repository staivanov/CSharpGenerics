using Playground.Domain.Services;
using System.Text.Json;

namespace Playground.Data.Entities
{
    public static class EntityExtensions
    {
        public static T Copy<T>(this T itemToCopy) where T : IEntity
        {   //One of the easiest way to make deep copy.
            string jsonObj = JsonSerializer.Serialize(itemToCopy);
            T? deserializeObj = JsonSerializer.Deserialize<T>(jsonObj);

            return deserializeObj;
        }
    }
}
