using System;

namespace Opdracht_3__Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle(1,1,1,1, "iets");

            Console.WriteLine(rectangle.a);
            Console.WriteLine("'Vierkant'");
        }
    }

    class Rectangle
    {
        private float width;
        private float height;
        private float x;
        private float y;
        public string a;

        public Rectangle(float width, float height, float x, float y, string a)
        {
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
            this.a = a;
        }
        public Rectangle(float x, float y, float size)
        {
            this.x = x;
            this.y = y;
            this.height = size;
            this.width = size;
        }
        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(float size)
        {
            this.height = size;
            this.width = size;
        }
        public void MoveTo(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public bool IsSquare(bool i)
        {
            if (height == width)
                i = true;
            if (height != width)
                i = false;
            return i;
        }
        public void Set(float size, float x, float y)
        {
            this.x = x;
            this.y = y;
            this.width = size;
            this.height = size;
        }
    }
}
