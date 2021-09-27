using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

namespace CyberPoliceParcer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--headless","-incognito");
            ChromeDriverService chromeservice = ChromeDriverService.CreateDefaultService();
            chromeservice.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chromeservice, options);

            IWebElement GetArray(By locator)
            {
                List<IWebElement> elements = driver.FindElements(locator).ToList();
                if (elements.Count > 0) return elements[0];
                else return null;
            }

            string[] richMasBox1 = (string[])e.Argument;
            foreach (var word in richMasBox1)
            {
                Thread.Sleep(500);
                driver.Navigate().GoToUrl("https://rt.pornhub.com/model/" + word);
                //IWebElement element1 = GetArray(By.ClassName("geoBlocked"));
                IWebElement element1 = GetArray(By.XPath("//div[@class='geoBlocked']"));
                if (element1 != null)
                {
                     LimitedBox.BeginInvoke(new Action(() =>
                     { 
                         LimitedBox.Text += "https://rt.pornhub.com/model/" + word + System.Environment.NewLine;
                     }));
                }
                Thread.Sleep(500);
                IWebElement element2 = GetArray(By.ClassName("mainMenu"));
                IWebElement element3 = GetArray(By.Id("profileStream"));
                if (element2 != null || element3 != null ) 
                {
                    LimitedBox.BeginInvoke(new Action(() => {
                        UnlimitedBox.Text += "https://rt.pornhub.com/model/" + word + System.Environment.NewLine;
                    }));
                }
                Thread.Sleep(500);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
                Thread.Sleep(500);
            }
            driver.Quit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string[] richMasBox1 = ModelsBox.Text.Split(' ', ',', '\r', '\n');

            if (backgroundWorker1.IsBusy)
            {
                WarningLabel.Text = "Выполненяется, ожидайте...";
            }
            else
            {
                backgroundWorker1.RunWorkerAsync(richMasBox1);
            }
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

            LimitedBox.ScrollBars = ScrollBars.Vertical;
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            UnlimitedBox.ScrollBars = ScrollBars.Vertical;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            string lines1 = LimitedBox.Text;
            System.IO.File.WriteAllText(@"C:\Access limited.txt", lines1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string lines2 = UnlimitedBox.Text;
            System.IO.File.WriteAllText(@"C:\Access unlimited.txt", lines2);
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                WarningLabel.Text = "Остановлено";
            }
        }
    }
}
