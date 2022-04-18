using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books
{
    public partial class Books
    {
        public string PartalClass
        {
            get
            {
                return Author + " | " + Title;
            }

        }
        public string KolvoMagaz
        {
            get
            {
                if (KolvSkl > 0)
                {
                    if (KolvSkl > 4)
                    {
                        return "Количество на складе: Много";
                    }
                    else return Convert.ToString("Количество на складе: "+KolvSkl);
                }
                else return "Количество на складе: Нет";



            }
        }
    }
}

