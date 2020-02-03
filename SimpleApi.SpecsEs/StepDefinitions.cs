using System;
using TechTalk.SpecFlow;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"que esta lloviendo")]
        public void DadoQueEstaLloviendo()
        {
            Console.WriteLine("que esta lloviendo");
        }

        [When(@"salgo a la calle")]
        public void CuandoSalgoALaCalle()
        {
            Console.WriteLine("salgo a la calle");
        }

        [Then(@"me mojo")]
        public void EntoncesMeMojo()
        {
            Console.WriteLine("me mojo");
        }
    }
}