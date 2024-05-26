using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace THKTLT_Lab8
{
    class Square: DrawingShape
    {
        public Square(int sideLength) : base(sideLength)
        {
            // Constructors được kế thừa từ DrawingShape 
        }
        public override void Draw(Canvas canvas)    
        {
            if (this.shape != null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Rectangle();
            }
            base.Draw(canvas);
        }

    }
}
