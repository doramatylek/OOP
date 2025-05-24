using OOP_laba_1.Model;
using OOP_laba_1.Services;
using System;
using System.Windows.Forms;

namespace OOP_laba_1.Controllers
{
    public class PluginController
    {
        private readonly DrawingSettings _settings;

        public PluginController(DrawingSettings settings)
        {
            _settings = settings;
        }

        public void LoadPlugin(string dllPath, ToolStripDropDownButton pluginButton)
        {
            try
            {
                PluginLoader.LoadAndRegisterPlugin(dllPath, pluginButton, shapeName =>
                {
                    _settings.CurrentShapeType = shapeName;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}