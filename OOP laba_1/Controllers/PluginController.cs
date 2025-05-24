using OOP_laba_1.Services;
using System.Windows.Forms;

namespace OOP_laba_1.Controllers
{
    public class PluginController
    {
        private readonly ToolStripDropDownButton _pluginsButton;

        public PluginController(ToolStripDropDownButton pluginsButton)
        {
            _pluginsButton = pluginsButton;
        }

        public string LoadPlugin(string dllPath)
        {
            try
            {
                return PluginLoader.LoadPlugin(_pluginsButton, dllPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в контроллере плагинов: {ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return null;
            }
        }
    }
}