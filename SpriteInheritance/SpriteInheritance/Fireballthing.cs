using System.Drawing;

namespace Eindopdracht
{
    class Fireballthing : Sprite
    {

        public Fireballthing(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(175, 199, 16, 16);
        }
    }
}