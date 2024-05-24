using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace THKTLT_Lab8
{
    interface IDraw
    {
        void SetLocation(int xCoord, int yCoord);
        void Draw(Canvas canvas);
    }
}
