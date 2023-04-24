using AprLoader.Models;

namespace AprLoader
{
    public static class CommonMapper
    {
        public static int GetRoiId(string s)
        {
            int i = -1;
            switch (s)
            {
                case "Органы грудной клетки":
                    i = 0;
                    break;
                case "Шея":
                    i = 3;
                    break;
                case "Брюшная полость":
                    i = 4;
                    break;
                case "Верхние конечности":
                    i = 7;
                    break;
                case "Нижние конечности":
                    i = 10;
                    break;
                case "Таз":
                    i = 11;
                    break;
                case "Череп":
                    i = 12;
                    break;
            }
            return i;
        }
        public static int GetAprType(ShootingParamSet shootingParamSet)
        {
            if (shootingParamSet.IsGraphy == true) return 1;
            if (shootingParamSet.IsSerialGraphy == true) return 2;
            if (shootingParamSet.IsScopy == true) return 4;
            if (shootingParamSet.IsHdScopy == true) return 8;
            if (shootingParamSet.IsTomoSynt == true) return 16;
            else return 1;
        }
    }
}
