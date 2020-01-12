using System;
using TechTalk.SpecFlow;

namespace SpecflowTests...
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [When(@"I click on language to click on edit button for already added language")]
        public void WhenIClickOnLanguageToClickOnEditButtonForAlreadyAddedLanguage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on language tab and then click on delete button for already added language")]
        public void WhenIClickOnLanguageTabAndThenClickOnDeleteButtonForAlreadyAddedLanguage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the changes for language made should be displayed successfully")]
        public void ThenTheChangesForLanguageMadeShouldBeDisplayedSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"language should be deleted successufully")]
        public void ThenLanguageShouldBeDeletedSuccessufully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
