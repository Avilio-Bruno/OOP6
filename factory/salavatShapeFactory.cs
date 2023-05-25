using OOP_LAB_4.figures;
namespace OOP_LAB_4.factory
{
    
    public class salavatShapeFactory
    {
        public Shape create(int x1, int y1, int x2, int y2, CONST_SHAPE type)
        {
            Shape shape;
            switch (type)
            {
                case CONST_SHAPE.selectedCircle:
                    shape = new selectedCircle(x1, y1, x2, y2); break;

                case CONST_SHAPE.selectedRectangle:
                    shape = new selectedRectangle(x1, y1, x2, y2); break;

                case CONST_SHAPE.selectedTriangle:
                    shape = new selectedTriangle(x1, y1, x2, y2);break;

                default:
                    shape = new selectedCircle(x1,y1, x2, y2);break;
            }
            return shape;
        }
        public Shape unselect(Shape shape)
        {
            switch (shape.name)
            {
                case CONST_SHAPE.selectedCircle:
                    return new CCircle((CCircle)shape);

                case CONST_SHAPE.selectedRectangle:
                    return new CRectangle((CRectangle)shape);

                case CONST_SHAPE.selectedTriangle:
                    return new CTriangle((CTriangle)shape);
            }

            return shape;
        }
        public Shape select(Shape shape)
        {
            switch (shape.name)
            {
                case CONST_SHAPE.Circle:
                    return new selectedCircle((CCircle)shape);
                    case CONST_SHAPE.Rectangle:
                    return new selectedRectangle((CRectangle)shape);
                    case CONST_SHAPE.Triangle:
                    return new selectedTriangle((CTriangle)shape);
            }
            return shape;
        }   
    }
}
