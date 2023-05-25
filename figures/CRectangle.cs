namespace OOP_LAB_4.figures
{
    public class CRectangle : Shape
    {

        public CRectangle(int x1, int y1, int x2, int y2)
        {
            shapeSize = new Size();
            p0 = new Point();
            name = CONST_SHAPE.Rectangle;
            Size new_size = new Size();
            Point new_p0 = new Point();

            if (x1 > x2)
            {
                new_p0.X = x2;
                new_size.Width = x1 - x2;
            }
            else
            {
                new_p0.X = x1;
                new_size.Width = x2 - x1;
            }
            if (y1 > y2)
            {
                new_p0.Y = y2;
                new_size.Height = y1 - y2;
            }
            else
            {
                new_p0.Y = y1;
                new_size.Height = y2 - y1;
            }

            shapeSize = new_size;
            p0= new_p0;
        }
        public CRectangle(CRectangle shape)
        {
            shapeSize = new Size();
            p0 = new Point();

            shapeSize = shape.shapeSize;
            p0= shape.p0;
            name = CONST_SHAPE.Rectangle;
            color= shape.color;
        }


        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(color);

            Rectangle rect = new Rectangle(p0, shapeSize);

            g.DrawRectangle(pen, rect);
            g.FillRectangle(brush, rect);
        }
        public override bool inShape(int x, int y)
        {
            if((x >= p0.X) && ( y >= p0.Y))
                if((x <= p0.X + shapeSize.Width ) && (y <= p0.Y + shapeSize.Height))
                    return true;
            return false;
        }
    }
    public class selectedRectangle : CRectangle {
        public selectedRectangle(int x1, int y1, int x2, int y2) : base(x1, y1, x2, y2)
        {
            name = CONST_SHAPE.selectedRectangle;
        }
        public selectedRectangle(CRectangle shape) : base(shape)
        {
            name = CONST_SHAPE.selectedRectangle;
        }
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Rectangle rect = new Rectangle(p0, shapeSize);
            Pen pen = new Pen(Color.Red);
            g.DrawRectangle(pen, rect);
        }
    }
}
