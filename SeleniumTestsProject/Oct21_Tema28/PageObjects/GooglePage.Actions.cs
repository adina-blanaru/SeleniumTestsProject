using System.Threading;

namespace SeleniumTestsProject.Oct21_Tema28.PageObjects
{
    partial class GooglePage
    {
        public void AcceptTerms()
        {
            _driver.SwitchTo().Frame(ConsentIframe);
            AgreeButton.Click();
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