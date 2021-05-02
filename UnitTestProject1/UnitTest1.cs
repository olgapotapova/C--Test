using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using OpenQA.Selenium.Interactions;
using System.Threading;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        FirefoxDriver driver;
        [TestMethod]
        public void TestMethodMain()
        {
            Debug.Listeners.Add(new TextWriterTraceListener("log.txt"));// Saving errors to a file.
            Debug.WriteLine("TestMethodMain");
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://prelive.aptimea.com/");
            if (driver.Title != "Page d'accueil | Prelive Aptimea")
            {
                Debug.WriteLine("Test1 Failed. Page not found.");
            }
            else
            {
                Debug.WriteLine("Test1 Passed :)");
            }
            System.Diagnostics.Trace.WriteLine("Page title is: " + driver.Title);
            TestMethod1();
            TestMethod2();
            TestMethod3();
            TestMethod4();
            TestMethod5();
            TestMethod6();
            TestMethod7();
            TestMethod8();
            TestMethod9();
            TestMethod10();
            TestMethod11();
            TestMethod12();
            TestMethod13();
            TestMethod14();
            TestMethod15();
            Debug.Flush();
            driver.Quit();
        }

        public void TestMethod1()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.XPath("//*[@class='hero__btn-left']"));
            element.SendKeys("´ `");//for navigate
            action.MoveToElement(element).Build().Perform();           
            Thread.Sleep(5000);
            element.Click();
            if (driver.Title != "Questionnaire | Prelive Aptimea")
            {
                Debug.WriteLine("Test2 Failed. Page not found. ");
            }
            else
            {
                Debug.WriteLine("Test2 Passed :)");
            }
        }
        public void TestMethod2()
        {
            driver.FindElement(By.XPath("//*[@id='edit-wizard-next']")).Click();
            Thread.Sleep(2000);
            string output = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Je suis est requis')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test3 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test3 Failed. Text 'Le champ Je suis est requis' was not found.");
            }
        }

        public void TestMethod3()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='je_suis']"));
            element.SendKeys("´ `");//for navigate
            Thread.Sleep(2000);
            action.MoveToElement(element).Click();
            Suivant();
            string output = driver.FindElement(By.XPath("//span[contains(text(),'Je suis enceinte')]")).Text;
                if (output.Length > 0)
            {
                Debug.WriteLine("Test4 Failed. Text 'Je suis enceinte' was found.");
            }
            else
            {
                Debug.WriteLine("Test4 Passed :)");
            }
        }

        public void TestMethod4()
        {
            Suivant();
            string output = driver.FindElement(By.XPath("//*[contains(text(), 'La date')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test5 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test5 Failed. Text 'La date' was not found.");
            }

        }

        public void TestMethod5()
        {
            IWebElement el = driver.FindElement(By.XPath("//option[contains(text(), 'Année')]"));
            Actions action = new Actions(driver);
            Thread.Sleep(2000);
            IWebElement element = driver.FindElement(By.XPath("//*[@value='1960']"));
            element.SendKeys("´ `");//for navigate
            Thread.Sleep(3000);
            action.MoveToElement(element).Click();
            Thread.Sleep(3000);            
            el.SendKeys("1960");
            Thread.Sleep(2000);
            Suivant();
            Thread.Sleep(2000);
            string output1 = driver.FindElement(By.XPath("//*[@value='1951']")).Text;
            string output2 = driver.FindElement(By.XPath("//*[@selected = 'selected']")).Text;
            if (output1 == output2)
            {
                IWebElement ele = driver.FindElement(By.XPath("//option[contains(text(), '1960')]"));
                ele.SendKeys("´ `");//for navigate
                Thread.Sleep(3000);
                action.MoveToElement(ele).Click();
                Thread.Sleep(3000);
                ele.SendKeys("1960");
                Suivant();
                Thread.Sleep(3000);
            }

                string output = driver.FindElement(By.XPath("//li[contains(text(), 'Le champ Je fais du sport chaque semaine est requis.')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test6 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test6 Failed. Text 'Le champ Je fais du sport chaque semaine est requis.' was not found.");
            }

        }

        public void TestMethod6()
        {
             Actions action = new Actions(driver);
             IWebElement element = driver.FindElement(By.XPath(".//input[@name='je_fais_du_sport_chaque_semaine' and @value='1']"));
             element.SendKeys("´ `");
             Thread.Sleep(3000);
             action.MoveToElement(element).Build().Perform();
             Thread.Sleep(3000);
             Suivant();
             string output = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Je suis est requis')]")).Text;
             if (output != null)
             {
                 Debug.WriteLine("Test7 Passed :) ");
             }
             else
             {
                 Debug.WriteLine("Test7 Failed. Text 'Le champ Je suis est requis' was not found.");
             }

        }
        public void TestMethod7()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='je_suis_2']"));
            element.SendKeys("´ `");//for navigate
            Thread.Sleep(1000);
            action.Click(element).Build().Perform();

            Suivant();
            Thread.Sleep(2000);
            string output = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Je pèse (en kg) est requis.')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test8 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test8 Failed.Text 'Le champ Je pèse (en kg) est requis.' was not found.");
            }

        }

        public void TestMethod8()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.CssSelector("textarea[name='mes_traitements_medicaux_sont']"));//kg
            element.SendKeys("Test");
            Suivant();

            string output = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Je pèse (en kg) est requis.')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test9 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test9 Failed. Text 'Le champ Je pèse (en kg) est requis.' was not found.");
            }

        }

        public void TestMethod9()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='user_weight']"));
            element.SendKeys("68");
            Suivant();

            string output = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Je mesure (en cm) est requis.')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test10 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test10 Failed. Text 'Le champ Je mesure (en cm) est requis.' was not found.");
            }


        }

        public void TestMethod10()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='user_height']"));
            element.SendKeys("165");
            Suivant();
            string output = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Je vis est requis.')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test11 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test11 Failed. Text 'Le champ Je vis est requis.' was not found.");
            }

        }

        public void TestMethod11()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='je_vis']"));
            element.SendKeys("´ `");//for navigate
            Thread.Sleep(3000);
            action.Click(element).Build().Perform();
            Suivant();
            string output = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Nombre d')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test12 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test12 Failed. Text 'Le champ Nombre d' was not found.");
            }

        }

        public void TestMethod12()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='j_ai_enfants_nombre_']"));
            element.SendKeys("3");
            Thread.Sleep(3000);
            Suivant();
            Thread.Sleep(5000);
              string output = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Mon objectif santé principal est requis.')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test13 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test13 Failed. Text 'Le champ Mon objectif santé principal est requis.' was not found.");
            }

        }

        public void TestMethod13() 
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='patient_goals']"));
            element.SendKeys("´ `");//for navigate
            Thread.Sleep(5000);
            action.MoveToElement(element).Click();
            Thread.Sleep(2000);
            Suivant();
            string output1 = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Prénom est requis.')]")).Text;
            if (output1 != null)
            {
                Debug.WriteLine("Test14 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test14 Failed. Text 'Le champ Prénom est requis.' was not found.");
            }

        }

        public void TestMethod14()  
                              
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='first_name']"));
            action.MoveToElement(element).Click();
            Thread.Sleep(2000);
            element.SendKeys("Kozel");

            Suivant();
            string output = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Nom de famille est requis.')]")).Text;

            if (output != null)
            {
                Debug.WriteLine("Test15 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test15 Failed. Text 'Le champ Nom de famille est requis.' was not found.");
            }
        }

        public void TestMethod15()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.CssSelector("input[name='last_name']"));
            action.MoveToElement(element).Click();
            Thread.Sleep(2000);
            element.SendKeys("Kozlov");
            Suivant();
            Thread.Sleep(10000);
            string output = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Votre email pour sauvegarder vos réponses est requis.')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test16.1 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test16.1 Failed  Text 'Le champ Votre email pour sauvegarder vos réponses est requis.' was not found.");
            }
            string output1 = driver.FindElement(By.XPath("//*[contains(text(), 'Le champ Mot de passe est requis.')]")).Text;
            if (output != null)
            {
                Debug.WriteLine("Test16.2 Passed :) ");
            }
            else
            {
                Debug.WriteLine("Test16.2 Failed. Text 'Le champ Mot de passe est requis.' was not found.");
            }
        }

        public void Suivant()
        {
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(By.XPath("//button[contains(text(), 'Suivant')]"));
            element.SendKeys("´ `");//for navigate
            Thread.Sleep(2000);
            action.MoveToElement(element).Click();
        }


        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}


