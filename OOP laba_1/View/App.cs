namespace OOP_laba_1
{
    using OOP_laba_1.Controllers;
    using OOP_laba_1.Model;
    using OOP_laba_1.Services;
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        #region Поля и конструктор

        private readonly DrawingController _drawingController;
        private readonly FileController _fileController;
        private readonly PluginController _pluginController;

        private ShapeList _shapeList = new ShapeList();
        private DrawingSettings _settings = new DrawingSettings();

        public MainForm()
        {
            InitializeComponent();

            var drawingService = new DrawingShapes(_shapeList, _settings);
            _drawingController = new DrawingController(drawingService);
            _fileController = new FileController();
            _pluginController = new PluginController(_settings);
        }

        #endregion

        #region Обработчики событий рисования

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (_settings.CurrentShapeType == null) return;

            _drawingController.StartDrawing(e.Location);
            pictureBox.Refresh();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _drawingController.CompleteDrawing();
            pictureBox.Refresh();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            _drawingController.UpdateDrawing(e.Location);
            pictureBox.Refresh();
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            _drawingController.FinalizeMultiClickShape();
            _drawingController.CompleteDrawing();
            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            _drawingController.Draw(e.Graphics);
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            _drawingController.FinalizeMultiClickShape();
            pictureBox.Refresh();
        }

        #endregion

        #region Работа с файлами

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _fileController.LoadShapes(_shapeList,openFileDialog.FileName);
                    pictureBox.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки: {ex.Message}");
                }
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _fileController.SaveShapes(_shapeList, saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                }
            }
        }

        #endregion

        #region Управление плагинами

        private void importPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "DLL files (*.dll)|*.dll|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _pluginController.LoadPlugin(openFileDialog.FileName, buttonPlugins);
                }
            }
        }

        #endregion

        #region Настройки рисования

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _settings.Color = colorDialog.Color;
            }
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _settings.FillColor = colorDialog.Color;
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            _shapeList.Undo();
            pictureBox.Refresh();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            _shapeList.Redo();
            pictureBox.Refresh();
        }

        #endregion

        #region Выбор инструментов

        private void buttonLine_Click(object sender, EventArgs e)
            => _settings.CurrentShapeType = "Line";

        private void buttonRectangle_Click(object sender, EventArgs e)
            => _settings.CurrentShapeType = "Rectangle";

        private void buttonEllipse_Click(object sender, EventArgs e)
            => _settings.CurrentShapeType = "Ellipse";

        private void buttonPolyline_Click(object sender, EventArgs e)
            => _settings.CurrentShapeType = "Polyline";

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _settings.Corners = 6;
            _settings.CurrentShapeType = "Polygon";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _settings.Corners = 3;
            _settings.CurrentShapeType = "Polygon";
        }

        private void pentagonButton_Click(object sender, EventArgs e)
        {
            _settings.Corners = 5;
            _settings.CurrentShapeType = "Polygon";
        }

        #endregion

        #region Настройки пера

        private void pxToolStripMenuItem_Click(object sender, EventArgs e)
            => _settings.PenWidth = 1;

        private void buttonWigth2_Click(object sender, EventArgs e)
            => _settings.PenWidth = 2;

        private void pxToolStripMenuItem2_Click(object sender, EventArgs e)
            => _settings.PenWidth = 4;

        private void buttonWigth6_Click(object sender, EventArgs e)
            => _settings.PenWidth = 6;

        #endregion
    }
}