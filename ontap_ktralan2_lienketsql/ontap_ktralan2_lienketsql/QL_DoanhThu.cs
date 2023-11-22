using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap_ktralan2_lienketsql
{
    internal class QL_DoanhThu
    {
        private string _tencaulacbo;
        private string _tennuoc;
        private int _soluongve;
        private double _giave;
        public QL_DoanhThu()
        {

        }
        public QL_DoanhThu(string tencaulacbo, string tennuoc, int soluongve, double giave)
        {
            _tencaulacbo = tencaulacbo;
            _tennuoc = tennuoc;
            _soluongve = soluongve;
            _giave = giave;
        }

        public string Tencaulacbo { get => _tencaulacbo; set => _tencaulacbo = value; }
        public string Tennuoc { get => _tennuoc; set => _tennuoc = value; }
        public int Soluongve { get => _soluongve; set => _soluongve = value; }
        public double Giave { get => _giave; set => _giave = value; }
        public double DoanhThu()
        {
            return _soluongve* _giave;
        }
    }
}
