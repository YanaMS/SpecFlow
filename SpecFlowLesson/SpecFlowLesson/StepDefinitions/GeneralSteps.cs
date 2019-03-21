﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowLesson
{
    [Binding]
    public class GeneralSteps
    {
        private readonly ScenarioContext _context;
        private readonly Calculator _calculator;

        public GeneralSteps(ScenarioContext context, Calculator calculator)
        {
            _context = context;
            _calculator = calculator;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            if (!_context.ContainsKey("numbers"))
            {
                _context["numbers"] = new List<int>();
            }
            var numbers = (List<int>)_context["numbers"];
            numbers.Add(number);
        }

        [When(@"I have entered (.*) into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(int number)
        {
            var numbers = (List<int>)_context["numbers"];

            if (_context.ContainsKey("result"))
            {
                var result = (int)_context["result"];
                numbers.Clear();
                numbers.Add(result);
            }

            numbers.Add(number);
        }



        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            var numbers = (List<int>)_context["numbers"];
            var result = _calculator.Add(numbers.First(), numbers.Last());
            _context["result"] = result;

        }
        [When(@"Press Multiply")]
        public void WhenPressMultiply()
        {
            var numbers = (List<int>)_context["numbers"];
            var result = _calculator.Multiply(numbers.First(), numbers.Last());
            _context["result"] = result;

        }



    }
}
