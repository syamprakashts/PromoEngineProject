using System.Collections.Generic;
namespace PromotionProj
{
    public class SKUUtilities
    {
        public static int EstimateTotalWithPromotionEngine(List<ActivePromo> curActivePromo,List<inputSKUs> paramInputSKUs)
        {
            int Total = 0;
            //for all input SKUs
            for (int i = 0; i < paramInputSKUs.Count; i++)
            {
                int j = 0;
                for (j = 0; j < curActivePromo.Count; j++)  // Check defined promotion for each SKUs
                {
                    //for type 2 promotions
                    if (paramInputSKUs[i].SKU == curActivePromo[j].SKU1 && curActivePromo[j].SKU2 != null)
                    {
                        int k = 0;
                        for (k = i + 1; k < paramInputSKUs.Count; k++)
                            if (curActivePromo[j].SKU2.SKUid == paramInputSKUs[k].SKU.SKUid)
                            { Total += curActivePromo[j].Price; paramInputSKUs.RemoveAt(k); }

                        //2nd SKU in type 2 promotion is not in InputSKUs
                        if (k == paramInputSKUs.Count) Total += curActivePromo[j].SKU1.UnitPrice; //  curSKUs[j].UnitPrice;
                        break;
                    }
                    //for type 1 promotions
                    else if (paramInputSKUs[i].SKU == curActivePromo[j].SKU1 && curActivePromo[j].SKU2 == null)
                    {
                        Total += (paramInputSKUs[i].Count / curActivePromo[j].Count) * curActivePromo[j].Price + (paramInputSKUs[i].Count % curActivePromo[j].Count) * paramInputSKUs[i].SKU.UnitPrice;
                        break;
                    }
                }
                //undefied promotions
                if (j == curActivePromo.Count)
                    Total += paramInputSKUs[i].Count * paramInputSKUs[i].SKU.UnitPrice;
            }
            return Total; //return promotion total
        }
    }

    //Define SKU ids and its unit prices
    public class SKUs
    {
        public SKUs(char skuid, int price) { SKUid = skuid; UnitPrice = price; }
        public char SKUid { get; set; }
        public int UnitPrice { get; set; }
    }

    //Define Active Promotions
    public class ActivePromo
    {
        public ActivePromo(int pType, SKUs sku1, SKUs sku2, int count, int price) 
        { PromoType = pType; SKU1 = sku1; SKU2 = sku2; Count = count; Price = price; }
        public int PromoType { get; set; } // 1 - SKU n items, 2 - 2 SKUs
        public SKUs SKU1 { get; set; }
        public SKUs SKU2 { get; set; }      // null for promotion type 1
        public int Count { get; set; }     //n numbers , 1 - for promotion type 2
        public int Price { get; set; }
    }

    //Define input SKUs
    public class inputSKUs
    {
        public inputSKUs(SKUs sku, int count) { SKU = sku; Count = count; }
        public SKUs SKU { get; set; }
        public int Count { get; set; }
    }

}
