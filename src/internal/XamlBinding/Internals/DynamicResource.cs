using System.ComponentModel;

namespace Tizen.NUI.XamlBinding.Internals
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class DynamicResource
    {
        public DynamicResource(string key)
        {
            Key = key;
        }

        public string Key { get; private set; }
    }
}