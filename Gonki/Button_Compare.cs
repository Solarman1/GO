using System;
using System.Windows.Forms;


namespace Gonki
{
    class Button_Compare : Button , IComparable
    {
        public int CompareTo(object obj)
        {
            Button_Compare temp = (Button_Compare)obj;
            if (this.Location.X > temp.Location.X)
                return -1;
            if (this.Location.X < temp.Location.X)
                return 1;
            return 0;
        }
    }
}
