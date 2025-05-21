namespace OOP_laba_1
{
    using System;
    using System.Drawing;
    using System.Reflection;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private string currentShapeType = null;
        private Shape shape;
        private Color color;
        private Color fillColor;
        private int corners;
        private float penWidth;
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;
        private ShapeList shapeList;

        public MainForm()
        {
            InitializeComponent();
            shapeList = new ShapeList();
            color = Color.Black;
            fillColor = Color.White;
            penWidth = 1;
            corners = 3;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShapeType == null)
                return;
            isDrawing = true;
            startPoint = e.Location;
            endPoint = e.Location;

            if (shape == null)
            {
                shape = ShapeFactory.CreateShape(
                    currentShapeType,
                    color,
                    penWidth,
                    fillColor,
                    corners);

                if (shape is Polyline polyline)
                {
                    polyline.addPoint(e.Location);
                }
            }
 
            else if (shape is Polyline existingPolyline)
            {
                existingPolyline.addPoint(e.Location);
            }

            pictureBox.Refresh();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing || shape == null)
                return;

            endPoint = e.Location;
         
            if (!(shape is Polyline))
            {
               
                if (Math.Abs(startPoint.X - endPoint.X) > 2 || Math.Abs(startPoint.Y - endPoint.Y) > 2)
                {
                    shape.startPoint = startPoint;
                    shape.endPoint = endPoint;
                    shapeList?.addShape(shape);
                }

                shape = null;
                isDrawing = false;
            }
            pictureBox.Refresh();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing || shape == null)
                return;

            endPoint = e.Location;

            if (!(shape is Polyline))
            {
                shape.endPoint = endPoint;
            }

            pictureBox.Refresh();
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (!isDrawing || shape == null)
                return;
            if (shape is Polyline polyline)
            {
                polyline.addPoint(endPoint);
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            shapeList.drawAll(e.Graphics);

            if (shape != null)
            {
                shape.startPoint = startPoint;
                shape.endPoint = endPoint;
                shape.draw(e.Graphics);
            }

        }
       
        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (shape is Polyline polyline)
            {
                polyline.addPoint(endPoint);
                shapeList.addShape(shape);
                shape = null;
                isDrawing = false;
                pictureBox.Refresh();
            }

        }
       
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.Title = "Open a JSON File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    shapeList.deserialize(openFileDialog.FileName);
                    pictureBox.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
                }
            }

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.Title = "Save a JSON File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    shapeList.serialize(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
                }
            }
        }

        private void LoadPlugins(string dllPath)
        {
            try
            {
                var assembly = Assembly.LoadFrom(dllPath);
                var pluginShapes = assembly.GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(Shape)) && !t.IsAbstract);

                foreach (var shapeType in pluginShapes)
                {
                    string shapeName = shapeType.Name;
                    ShapeFactory.RegisterShape(shapeName, shapeType);

                    var menuItem = new ToolStripMenuItem(shapeName);
                    menuItem.Click += (s, e) => currentShapeType = shapeName;
                    buttonPlugins.DropDownItems.Add(menuItem);
                }
            }
            catch (BadImageFormatException)
            {
                MessageBox.Show("Это не валидная DLL с плагинами",
                               "Ошибка загрузки",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить плагин: {ex.Message}",
                               "Ошибка",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
       
        private void importPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "DLL files (*.dll)|*.dll|All files (*.*)|*.*";
                openFileDialog.Title = "Выберите файл плагина";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadPlugins(openFileDialog.FileName);
                }
            }
        }
       
        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                fillColor = colorDialog.Color;
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            shapeList.undo();
            pictureBox.Refresh();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            shapeList.redo();
            pictureBox.Refresh();
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            currentShapeType = "Line";
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            currentShapeType = "Rectangle";
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            currentShapeType = "Ellipse";
        }

        private void pxToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            penWidth = 4;
        }

        private void pxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            penWidth = 1;
        }

        private void buttonWigth2_Click(object sender, EventArgs e)
        {
            penWidth = 2;
        }

        private void buttonWigth6_Click(object sender, EventArgs e)
        {
            penWidth = 6;
        }

        private void buttonPolyline_Click(object sender, EventArgs e)
        {
            currentShapeType = "Polyline";

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            corners = 6;
            currentShapeType = "Polygon";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            corners = 3;
            currentShapeType = "Polygon";
        }
    
        private void pentagonButton_Click(object sender, EventArgs e)
        {
            corners = 5;
            currentShapeType = "Polygon";
        }

    }
}