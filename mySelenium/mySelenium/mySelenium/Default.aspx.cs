using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Requires reference to WebDriver.Support.dll
using OpenQA.Selenium.Support.UI;


namespace mySelenium
{
    public partial class Default : System.Web.UI.Page
    {
 
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Create a new instance of the Chrome driver.             
            IWebDriver driver = new ChromeDriver();             
            //Open Chrome and navigate to http://www.PaulFrymire.com             
            driver.Navigate().GoToUrl("https://es-int-dh.austin.hp.com/ui-obligation-1.1/main/ObligationViewer.jsp#tabs-quickSearch");            
            //After page has completed loading, close Chrome 
            IWebElement element = driver.FindElement(By.Id("footerDiv"));
            IList <IWebElement> element2 = element.FindElements(By.TagName("TABLE"));

            foreach (IWebElement ele in element2)
            {
                 IList<IWebElement> element3 = ele.FindElements(By.TagName("TBODY"));

                 foreach (IWebElement L in element3)
                 {
                     if (L.TagName == "TBDOY")
                     {
                         //L.Text = "";
                     }

                 }

            }


           


           

            

            driver.Quit(); 
           
        }
    }
}