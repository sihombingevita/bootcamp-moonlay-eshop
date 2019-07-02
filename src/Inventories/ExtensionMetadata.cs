using Infrastructure;
using System.Collections.Generic;

namespace Inventories
{
    public class ExtensionMetadata : IExtensionMetadata
    {
        public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[] { };

        public IEnumerable<Script> Scripts => new Script[] { };

        public IEnumerable<MenuItem> MenuItems
        {
            get
            {
                return new MenuItem[]
                {
                    new MenuItem("/inventory", "Inventory", 200)
                };
            }
        }
    }
}