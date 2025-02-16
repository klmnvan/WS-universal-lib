namespace WSUniversalLib
{
    public class Calculation
    {
        //пример: 3 тип, 1 тип, 15, 20, 45
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if(count < 0 || width < 0 || length < 0) return -1;
            float ratio = 1f; //коэффициент
            float percentOfMarriage = 0f;
            switch (productType)
            {
                case 1: ratio = 1.1f; break;
                case 2: ratio = 2.5f; break;
                case 3: ratio = 8.43f; break;
                default: return -1;
            }
            switch (materialType)
            {
                case 1: percentOfMarriage = 0.003f; break;
                case 2: percentOfMarriage = 0.0012f; break;
                default: return -1;
            }
            float S = (width * length); //площадь продукции
            float sWithRatio = S * ratio ; //площадь продукции, умноженная на к типа продукции
            float countQualityRes = sWithRatio * count; //количество качественного сырья
            int brak = (int)Math.Ceiling(countQualityRes + (countQualityRes * percentOfMarriage));
            return brak;
        }
    }
}
