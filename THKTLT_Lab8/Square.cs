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
    class Square: IDraw, IColor
    {
        private int sideLength; //Cạnh của hình
        private int locX = 0, locY = 0; //Tạo độ cần vẽ
        private Rectangle rect = null; //Dùng để tạo hình chữ nhật

        public Square(int sideLength)
        {
            this.sideLength = sideLength;
        }

        void IDraw.Draw(Canvas canvas)
        {
            if (this.rect != null)
            {
                canvas.Children.Remove(this.rect);//Xóa đối tượng
            }
            else
            {
                this.rect = new Rectangle(); //Tạo một đối tượng mới
            }
            this.rect.Height = this.sideLength; //Điều chỉnh chiều cao
            this.rect.Width = this.sideLength; //Điều chỉnh chiều rộng
            Canvas.SetTop(this.rect, this.locY); //Set vị trí cạnh trên của đoi tượng
            Canvas.SetLeft(this.rect, this.locX);//Set vị trí cạnh trái của đối tượng
            canvas.Children.Add(this.rect); //Thêm vào Canvas

        }

        void IColor.SetColor(Color color)
        {
            if (this.rect != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.rect.Fill = brush;

            }
        }
        void IDraw.SetLocation(int xCoord, int yCoord)
        {
            this.locX = xCoord;
            this.locY = yCoord;
        }
    }
}
