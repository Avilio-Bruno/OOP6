using OOP_LAB_4.factory;
using OOP_LAB_4.figures;

namespace OOP_LAB_4
{
    
    public partial class Form1 : Form
    {
        List<Shape> shapes;
        List<Shape> selectedShapes;

        int CursorX, CursorY;
        int x1, y1, x2, y2;

        Color color;

        bool create;

        Graphics g;


        CONST_SHAPE selectedShape;

        salavatShapeFactory shapeFactory;

        public Form1()
        {

            shapes = new();
            selectedShapes = new();
            shapeFactory = new();


            InitializeComponent();
            panel1.MouseUp += Form1_MouseUp;
            panel1.MouseDown += Form1_MouseDown;


            color = Color.Black;
            pictureBox_color.Refresh();

            selectedShape = CONST_SHAPE.selectedCircle;


            CursorX = 0;
            CursorY = 0;
            x1 = 0; y1 = 0; x2 = 0; y2 = 0;


            g = panel1.CreateGraphics();
            DoubleBuffered = true;
        }
       

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            CursorX = e.X; CursorY = e.Y;
            create = true;
            for(int i = 0; i < shapes.Count; ++i)
            {
                if (shapes[i].inShape(CursorX, CursorY))
                {
                    create = false;
                    if (Form.ModifierKeys != Keys.Control)
                    {
                        for (int j = 0; j < shapes.Count; ++j)
                        {
                            if ( j != i )
                            {
                                if (selectedShapes.Contains(shapes[j]))
                                {
                                    selectedShapes.Remove(shapes[j]);
                                }
                                shapes[j] = shapeFactory.unselect(shapes[j]);
                            }
                        }
                    }

                    if (!selectedShapes.Contains(shapes[i]))
                    {
                        shapes[i] = shapeFactory.select(shapes[i]);
                        selectedShapes.Add(shapes[i]);
                        continue;
                    }
                }
            }
            if(create)
            {
                if (Form.ModifierKeys != Keys.Control)
                {
                    for (int j = 0; j < shapes.Count; ++j)
                    {
                        if (selectedShapes.Contains(shapes[j]))
                        {
                            selectedShapes.Remove(shapes[j]);
                        }
                        shapes[j] = shapeFactory.unselect(shapes[j]);
                    }
                }
                    x1 = CursorX; y1 = CursorY;
            }
            panel1.Invalidate();
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            CursorX = e.X; CursorY = e.Y;
            if(create)
            {
                x2 = CursorX; y2 = CursorY;
                Shape shape = shapeFactory.create(x1, y1, x2, y2, selectedShape);
                shape.color = color;
                shapes.Add(shape);
                selectedShapes.Add(shape);
                create = false;
            }

            panel1.Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                shapes.Clear();
                selectedShapes.Clear();
            }

            if (e.KeyCode == Keys.W)
            {
                for (int j = 0; j < selectedShapes.Count; ++j)
                {
                    selectedShapes[j].move(panel1.Size, 0, -10);
                }
            }
            if (e.KeyCode == Keys.A) 
            {
                if(Form.ModifierKeys == Keys.Control)
                {
                    for (int j = 0; j < selectedShapes.Count; ++j)
                    {
                        selectedShapes[j].resize(panel1.Size, -10);
                    }
                }
                else
                {
                    for (int j = 0; j < selectedShapes.Count; ++j)
                    {
                        selectedShapes[j].move(panel1.Size, -10, 0);
                    }
                }
            }
            if (e.KeyCode == Keys.S)
            {
                for (int j = 0; j < selectedShapes.Count; ++j)
                {
                    selectedShapes[j].move(panel1.Size, 0, 10);
                }
            }
            if (e.KeyCode == Keys.D)
            {
                if (Form.ModifierKeys == Keys.Control)
                {
                    for (int j = 0; j < selectedShapes.Count; ++j)
                    {
                        selectedShapes[j].resize(panel1.Size, 10);
                    }
                }
                else
                {
                    for (int j = 0; j < selectedShapes.Count; ++j)
                    {
                        selectedShapes[j].move(panel1.Size,10,0);
                    }

                }
            }

            panel1.Invalidate();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(SystemColors.Control);

            foreach (Shape c in shapes)
            {
                c.Draw(g);
            }
        }
        private void toolStripTextBoxCircle_Click(object sender, EventArgs e)
        {
            selectedShape = CONST_SHAPE.selectedCircle;
        }
        private void toolStripTextBoxRectangle_Click(object sender, EventArgs e)
        {
            selectedShape = CONST_SHAPE.selectedRectangle;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            foreach(Shape shape in shapes)
            {
                shape.resize(panel1.Size, 0);    
            }
            panel1.Invalidate();
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
            pictureBox_color.Refresh();
        }
        private void button_setColor_Click(object sender, EventArgs e)
        {
            foreach (Shape shape in selectedShapes)
            {
                shape.color = color;
            }
            panel1.Invalidate();
        }
        private void pictureBox_color_Paint(object sender, PaintEventArgs e)
        {
            pictureBox_color.BackColor = color;
        }
        private void toolStripTextBoxTriangle_Click(object sender, EventArgs e)
        {
            selectedShape = CONST_SHAPE.selectedTriangle;
        }

    }
   
}