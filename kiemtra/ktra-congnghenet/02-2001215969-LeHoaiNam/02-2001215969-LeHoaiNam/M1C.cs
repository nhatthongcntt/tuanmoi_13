using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_2001215969_LeHoaiNam
{
    class M1C
    {
        int[] arr;
        public M1C(int[] mang)
        {
            arr = mang;
        }
        public string showMang()
        {
            string s = "";
            for (int i = 0; i < n(); i++)
                s += arr[i].ToString() + ' ';
            return s;
        }
        public string SXTang()
        {
            string sx = "";
            Array.Sort(arr);
            for(int i = 0;i < n();i++)
            {
                sx += arr[i].ToString() + ' ';
            }
            return sx;
        }
        public string SXGiam()
        {
            string sx = "";
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0; i < n(); i++)
            {
                sx += arr[i].ToString() + ' ';
            }
            return sx;
        }
        public bool timGiaTri(int x)
        {
            for (int i = 0; i < n(); i++)
                if (arr[i] == x)
                    return true;
            return false;
        }
        public int timViTri(int i)
        {
            
            return arr[i];
                
        }
        public int n()
        {
            return arr.Length;
        }
        public int TongMang()
        {
            int sum = 0;
            for (int i = 0; i < n(); i++)
                sum += arr[i];
            return sum;
        }
        public int TongChan()
        {
            int sum = 0;
            for (int i = 0; i < n(); i++)
                if(arr[i] % 2 ==0 )
                    sum += arr[i];
            return sum;
        }
    }
}
