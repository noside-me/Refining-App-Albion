using System;

namespace Refining_App_Albion
{
    class Program
    {
        static void Main(string[] args)
        {
            new AppIntro().Intro();

            var t4Specs = new UserInput().SpecializationInput("T4");
            var t5Specs = new UserInput().SpecializationInput("T5");
            var t6Specs = new UserInput().SpecializationInput("T6");
            var t7Specs = new UserInput().SpecializationInput("T7");
            var t8Specs = new UserInput().SpecializationInput("T8");

            var refinedMat = new UserInput().RefinedMaterial(); //Key for SpecsCalculator

            var tierEnchantment = new UserInput().TierEnchantment();

            var currentFocusPoints = new UserInput().CurrentFocusPoints();

            var refiningLocation = new UserInput().RefiningLocation();
           
            var rrr = new ResourceReturnRate().BonusRate(refiningLocation);
            Console.WriteLine("Resource return rate is {0}", rrr); //delete later

            var specialization = new SpecializationDict();
            specialization.Specs["T4"] = t4Specs;
            specialization.Specs["T5"] = t5Specs;
            specialization.Specs["T6"] = t6Specs;
            specialization.Specs["T7"] = t7Specs;
            specialization.Specs["T8"] = t8Specs;

            var masteryFCE = new FocusCostEfficiencyCalculator().MasteryCalculator(
                specialization.Specs["T4"],
                specialization.Specs["T5"],
                specialization.Specs["T6"],
                specialization.Specs["T7"],
                specialization.Specs["T8"]);
        
            var specsFCE = new FocusCostEfficiencyCalculator().SpecializationCalculator(specialization.Specs[refinedMat]);

            var totalFocusEffCost = new FocusCostEfficiencyCalculator().TotalFocusEffCalc(masteryFCE, specsFCE);
            Console.WriteLine("Total Focus Cost Efficiency: " + totalFocusEffCost); // delete later

            var baseCost = new BaseCostDict()[tierEnchantment];
            Console.WriteLine("Base cost: {0} of tier.X: {1}", baseCost, tierEnchantment); // delete later

            var focusCost = new FocusCostCalculator().FocusCostCalculate(baseCost, totalFocusEffCost);
            Console.WriteLine("Focus cost per unit: " + focusCost); //delete later

            var ifuCalculate = new InstancedPerFocusCalculator().IFUCalculate(currentFocusPoints, focusCost);
            Console.WriteLine("Instanced per focus used: " + ifuCalculate); //delete later

            var estimateRawMaterial = new EstimateBuyUnitsRaw().RawMaterial(ifuCalculate, rrr);
            Console.WriteLine("Your target estimate of raw material is {0}", estimateRawMaterial); //change estimateRawMaterials background color

            var refinedMaterials = new EstimateBuyUnitsRefined().RefinedMaterial(refinedMat, estimateRawMaterial);
            Console.WriteLine("Low tier refined materials needed: {0}", refinedMaterials); //change refinedMaterials background color

            /*new UserInput().Option();*/ //lastline of code.

            var textfile = new InputManager();
            textfile.Save(Convert.ToString(estimateRawMaterial),Convert.ToString(refinedMaterials));
        }
    }
}
