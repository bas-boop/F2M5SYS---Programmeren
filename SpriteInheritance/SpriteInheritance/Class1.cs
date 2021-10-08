using System.Drawing;

namespace Eindopdracht
{
    class Class1 : Sprite
    {

        public Class1(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(80, 199, 16, 16);
        }
    }
}