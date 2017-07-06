using System;
using TechTalk.SpecFlow;

namespace HerbSys
{
    [Binding]
    public class CadastraClienteSteps
    {
        [Given(@"Eu estou na tela de cadastro de cliente")]
        public void GivenEuEstouNaTelaDeCadastroDeCliente()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"eu informei '(.*)'")]
        public void GivenEuInformei(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"eu informei '(.*)'")]
        public void GivenEuInformei(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"eu informei ")]
        public void GivenEuInformei()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Eu finalizei o cadastro do cliente")]
        public void WhenEuFinalizeiOCadastroDoCliente()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o cadastro deve ser realizado com sucesso")]
        public void ThenOCadastroDeveSerRealizadoComSucesso()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"o cadastro deve ser bloquado")]
        public void ThenOCadastroDeveSerBloquado()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
