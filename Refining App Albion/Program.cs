using System;

namespace Refining_App_Albion
{
    class Program
    {
        static void Main(string[] args)
        {
            new AppIntro().Intro();

            var t4Input = new UserInput().TierInput();
            var t4Specs = new UserInput().SpecializationInput();

            var t5Input = new UserInput().TierInput();
            var t5Specs = new UserInput().SpecializationInput();

            var t6Input = new UserInput().TierInput();
            var t6Specs = new UserInput().SpecializationInput();

            var t7Input = new UserInput().TierInput();
            var t7Specs = new UserInput().SpecializationInput();

            var t8Input = new UserInput().TierInput();
            var t8Specs = new UserInput().SpecializationInput();

            var refinedMat = new UserInput().RefinedMaterial(); //Key for SpecsCalculator

            var tierEnchantment = new UserInput().TierEnchantment();

            var currentFocusPoints = new UserInput().CurrentFocusPoints();

            var refiningLocation = new UserInput().RefiningLocation();
           
            var rrr = new ResourceReturnRate().BonusRate(refiningLocation);
            Console.WriteLine("Resource return rate is {0}", rrr); //delete later

            var specialization = new SpecializationDict();
            specialization.Specs.Add(t4Input, t4Specs);
            specialization.Specs.Add(t5Input, t5Specs);
            specialization.Specs.Add(t6Input, t6Specs);
            specialization.Specs.Add(t7Input, t7Specs);
            specialization.Specs.Add(t8Input, t8Specs);

            var masteryFCE = new FocusCostEfficiencyCalculator().MasteryCalculator(
                specialization.Specs[t4Input],
                specialization.Specs[t5Input],
                specialization.Specs[t6Input],
                specialization.Specs[t7Input],
                specialization.Specs[t8Input]);
        
            var specsFCE = new FocusCostEfficiencyCalculator().SpecializationCalculator(specialization.Specs[refinedMat]);

            var totalFocusEffCost = new FocusCostEfficiencyCalculator().TotalFocusEffCalc(masteryFCE, specsFCE);
            Console.WriteLine("Total Focus Cost Efficiency: " + totalFocusEffCost); // delete later

            var baseCost = new BaseCost()[tierEnchantment];
            Console.WriteLine("Base cost: {0} of tier.X: {1}", baseCost, tierEnchantment); // delete later

            var focusCost = new FocusCostCalculator().FocusCostCalculate(baseCost, totalFocusEffCost);
            Console.WriteLine("Focus cost per unit: " + focusCost); //delete later

            var ifuCalculate = new InstancedPerFocusCalculator().IFUCalculate(currentFocusPoints, focusCost);
            Console.WriteLine("Instanced per focus used: " + ifuCalculate); //delete later

            var estimateRawMaterial = new EstimateBuyUnitsRaw().RawMaterial(ifuCalculate, rrr);
            Console.WriteLine("Your target estimate of raw material is {0}", estimateRawMaterial); //change estimateRawMaterials background color

            var refinedMaterials = new EstimateBuyUnitsRefined().RefinedMaterial(refinedMat, estimateRawMaterial);
            Console.WriteLine("Low tier refined materials needed: {0}", refinedMaterials); //change refinedMaterials background color

            new UserInput().Option(); //lastline of code.

            var textfile = new InputManager();
            textfile.Save(Convert.ToString(estimateRawMaterial),Convert.ToString(refinedMaterials));
        }
    }
}
