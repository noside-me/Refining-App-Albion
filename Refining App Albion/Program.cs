using System;

namespace Refining_App_Albion
{
    class Program
    {
        static void Main(string[] args)
        {
            new InputManager().Intro();

            var t4Specs = new UserInput().SpecializationInput("T4");
            var t5Specs = new UserInput().SpecializationInput("T5");
            var t6Specs = new UserInput().SpecializationInput("T6");
            var t7Specs = new UserInput().SpecializationInput("T7");
            var t8Specs = new UserInput().SpecializationInput("T8");

            var refinedMaterialStringKey = new UserInput().RefinedMaterial(); //Key for SpecsCalculator

            var tierEnchantmentStringKey = new UserInput().TierEnchantment();

            var currentFocusPoints = new UserInput().CurrentFocusPoints();

            var refiningLocation = new UserInput().RefiningLocation();
           
            var rrr = new ResourceReturnRate().BonusRate(refiningLocation);
            
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
        
            var specsFCE = new FocusCostEfficiencyCalculator().SpecializationCalculator(specialization.Specs[refinedMaterialStringKey]);
            var totalFocusEffCost = new FocusCostEfficiencyCalculator().TotalFocusEffCalc(masteryFCE, specsFCE);
            var baseCost = new BaseCostDict()[tierEnchantmentStringKey];
            var focusCost = new FocusCostCalculator().FocusCostCalculate(baseCost, totalFocusEffCost);
            var ifuCalculate = new InstancedPerFocusCalculator().IFUCalculate(currentFocusPoints, focusCost);
            
            var estimateRawMaterial = new EstimateBuyUnitsRaw().RawMaterial(ifuCalculate, rrr);
            Console.WriteLine("Your target estimate of raw material is {0}", estimateRawMaterial); //change estimateRawMaterials background color or delete later

            var refinedMaterials = new EstimateBuyUnitsRefined().RefinedMaterial(refinedMaterialStringKey, estimateRawMaterial);
            Console.WriteLine("Low tier refined materials needed: {0}", refinedMaterials); //change refinedMaterials background color or delete later

            new UserInput().OptionEvent();
        }
    }
}
