using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_19
{
    internal class MyTextBox : TextBox
    {
        //точка перемещения
        private Point DownPoint;
        //нажата ли кнопка мыши
        public bool IsDragMode, point = true;

        

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            DownPoint = mevent.Location;
            IsDragMode = true;
            base.OnMouseDown(mevent);
        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            //если кнопка мыши нажата
            if (IsDragMode)
            {
                Point p = mevent.Location;
                //вычисляем разницу в координатах между положением курсора и "нулевой" точкой кнопки
                Point dp = new Point(p.X - DownPoint.X, p.Y - DownPoint.Y);
                Location = new Point(Location.X + dp.X, Location.Y + dp.Y);
            }
        }
    }
}