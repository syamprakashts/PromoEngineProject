using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace PromotionProj
{
    public partial class MainWindow : Form
    {
        public List<SKUs> DefinedSKUs = new List<SKUs>(); //List of all SKUs
        public List<ActivePromo> curActivePromo = new List<ActivePromo>(); //Active Promotions

        public List<inputSKUs> curInputSKUsA = new List<inputSKUs>(); //scenarioA input SKUs
        public List<inputSKUs> curInputSKUsB = new List<inputSKUs>(); //scenarioB input SKUs
        public List<inputSKUs> curInputSKUsC = new List<inputSKUs>(); //scenarioC input SKUs
        public MainWindow()
        {
            InitializeComponent();

            //initialise SKU values
            DefinedSKUs.Add(new SKUs('A', 50));
            DefinedSKUs.Add(new SKUs('B', 30));
            DefinedSKUs.Add(new SKUs('C', 20));
            DefinedSKUs.Add(new SKUs('D', 15));

            //initialise active promotions
            curActivePromo.Add(new ActivePromo(1, DefinedSKUs[0], null, 3, 130));
            curActivePromo.Add(new ActivePromo(1, DefinedSKUs[1], null, 2, 45));
            curActivePromo.Add(new ActivePromo(2, DefinedSKUs[2], DefinedSKUs[3], 1, 30));

            //Scenario A
            curInputSKUsA.Add(new inputSKUs(DefinedSKUs[0], 1));
            curInputSKUsA.Add(new inputSKUs(DefinedSKUs[1], 1));
            curInputSKUsA.Add(new inputSKUs(DefinedSKUs[2], 1));

            //Scenario B
            curInputSKUsB.Add(new inputSKUs(DefinedSKUs[0], 5));
            curInputSKUsB.Add(new inputSKUs(DefinedSKUs[1], 5));
            curInputSKUsB.Add(new inputSKUs(DefinedSKUs[2], 1));

            //Scenario C
            curInputSKUsC.Add(new inputSKUs(DefinedSKUs[0], 3));
            curInputSKUsC.Add(new inputSKUs(DefinedSKUs[1], 5));
            curInputSKUsC.Add(new inputSKUs(DefinedSKUs[2], 1));
            curInputSKUsC.Add(new inputSKUs(DefinedSKUs[3], 1));

            //Show scenarios A,B,C in Screen
            object[] items = curInputSKUsA.Select(i =>(object)(i.SKU.SKUid + " - " + i.Count)).ToArray();
            lstScenarioA.Items.AddRange(items);
            items = curInputSKUsB.Select(i => (object)(i.SKU.SKUid + " - " + i.Count)).ToArray();
            lstScenarioB.Items.AddRange(items);
            items = curInputSKUsC.Select(i => (object)(i.SKU.SKUid + " - " + i.Count)).ToArray();
            lstScenarioC.Items.AddRange(items);

            //Calling Promition Engine to calculate the total for each senarios.
            txtScenarioA.Text = SKUUtilities.EstimateTotalWithPromotionEngine(curActivePromo,curInputSKUsA).ToString();
            txtScenarioB.Text = SKUUtilities.EstimateTotalWithPromotionEngine(curActivePromo,curInputSKUsB).ToString();
            txtScenarioC.Text = SKUUtilities.EstimateTotalWithPromotionEngine(curActivePromo,curInputSKUsC).ToString();
        }
    }
}
