using System.Windows.Forms;

namespace PluginInterface
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        string Author { get; }
        string Version { get; }
        int TreeSubNumber { get; }
        bool IsSubTree { get; }
        UserControl MainInterface { get; }
        void Initialize();
        void Dispose();
    }
}
