namespace OOP_LAB_4.figures
{
    public abstract class Shape
    {
        public CONST_SHAPE name { get; set; }
        public Size shapeSize { get; set; } // size of box where will be shape
        public Point p0 { get; set; } // topleft point
        public Color color { get; set; }


        public abstract void Draw(Graphics g);

        public void resize(Size imageSize, int delta)
        {
            Size newSize = new(shapeSize.Width + delta, shapeSize.Height + delta);

            if (newSize.Width < 10)
            {
                newSize.Width = 10;
            }
            if(newSize.Width + p0.X > imageSize.Width)
            {
                newSize.Width = imageSize.Width - p0.X;
            }
            if(newSize.Height < 10)
            {
                newSize.Height = 10;
            }
            if (newSize.Height + p0.Y > imageSize.Height)
            {
                newSize.Height = imageSize.Height - p0.Y;
            }
            shapeSize = newSize;
            move(imageSize, 0, 0);
        }

        public void move(Size imageSize, int dx, int dy)
        {
            Point new_p0 = new Point(p0.X + dx, p0.Y + dy);

            if( new_p0.X + shapeSize.Width > imageSize.Width)
            {
                new_p0.X = imageSize.Width - shapeSize.Width;
            }
            if(new_p0.X < 0)
            {
                new_p0.X = 0;
            }
            if(new_p0.Y + shapeSize.Height > imageSize.Height)
            {
                new_p0.Y = imageSize.Height - shapeSize.Height;
            }
            if(new_p0.Y < 0)
            {
                new_p0.Y = 0;
            }
            p0 = new_p0;
        }

        public abstract bool inShape(int x, int y);
    }
    public class Help_vector
    {
        public int dx, dy;
        public Help_vector(Point a, Point b)
        {
            this.dx = a.X - b.X;
            this.dy = a.Y - b.Y;
        }
        public static int operator *(Help_vector a, Help_vector b)
        {
            return a.dx * b.dy - a.dy * b.dx;
        }
    }
}
