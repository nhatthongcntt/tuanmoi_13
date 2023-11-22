using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_2001215969_LeHoaiNam
{
    class PhuongTrinhBacHai
    {
        public int PC02_969_a, PC02_969_b, PC02_969_c;
        public PhuongTrinhBacHai(int a,int b,int c)
        {
            PC02_969_a = a;
            PC02_969_b = b;
            PC02_969_c = c;
        }
        public int delta()
        {
            return (PC02_969_b * PC02_969_b) - 4 * PC02_969_a * PC02_969_c;
        }
        public string KQ()
        {
            int Delta = delta();
            if (Delta < 0)
                return "Phương trình không có nghiệm thực.";
            else if(Delta == 0)
            {
                int x = -PC02_969_b / (2 * PC02_969_a);
                return "Phương trình có nghiệm kép x1 = x2 = " + x.ToString();
            }
            else
            {
                double x1 = (-PC02_969_b - Math.Sqrt(Delta)) / (2 * PC02_969_a);
                double x2 = (-PC02_969_b + Math.Sqrt(Delta)) / (2 * PC02_969_a);
                return "Phương trình có 2 nghiệm phân biệt x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
            }
        }
    }
}
