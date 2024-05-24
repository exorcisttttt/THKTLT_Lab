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
    class Circle: IDraw, IColor
    {
        private int diameter;
        private int locX = 0, locY = 0;
        private Ellipse circle = null;
        public Circle(int diameter)
        {
            this.diameter = diameter;
        }
        void IDraw.SetLocation(int xCoord, int yCoord)
        {
            this.locX = xCoord;
            this.locY = yCoord;
        }
        void IDraw.Draw(Canvas canvas)
        {
            if (this.circle != null)
            {
                canvas.Children.Remove(this.circle);//Xóa đối tượng
            }
            else
            {
                this.circle = new Ellipse(); //Tạo một đối tượng mới
            }
            this.circle.Height = this.diameter; //Điều chỉnh chiều cao
            this.circle.Width = this.diameter; //Điều chỉnh chiều rộng
            Canvas.SetTop(this.circle, this.locY); //Set vị trí cạnh trên của đoi tượng
            Canvas.SetLeft(this.circle, this.locX);//Set vị trí cạnh trái của đối tượng
            canvas.Children.Add(this.circle); //Thêm vào Canvas

        }
        void IColor.SetColor(Color color)
        {
            if (this.circle != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.circle.Fill = brush;

            }
        }
    }
}
