using System.Threading;

namespace SeleniumTestsProject.PageObjectsOct21Tema28
{
    partial class GooglePage
    {
        public void AcceptTerms()
        {
            _driver.SwitchTo().Frame(ConsentIframe);
            AgreeButton.Click();
            _driver.SwitchTo().DefaultContent();
        }

        public void GoogleSearch(string searchText)
        {
            SearchFieldTextBox.SendKeys(searchText);
            Thread.Sleep(500);
            GoogleSearchButton.Click();
        }

        public void ClickFirstResultFromImages()
        {
            ImagesLink.Click();
            FirstImage.Click();
        }

        public void ReturnToImages()
        {
            BackToImagesIcon.Click();
        }

        public bool IsImagePanelDisplayed()
        {
            return ImagePanel.Displayed;
        }

    }
}