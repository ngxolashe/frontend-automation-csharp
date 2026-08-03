using Core.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Core.Factories;

public static class WebDriverFactory
{
    public static IWebDriver Create(TestSettings settings)
    {
        if (!string.Equals(settings.Browser, "chrome", StringComparison.OrdinalIgnoreCase))
        {
            throw new NotSupportedException($"Browser '{settings.Browser}' is not supported yet.");
        }

        new DriverManager().SetUpDriver(new ChromeConfig());

        var options = new ChromeOptions();
        options.AddArgument($"--window-size={settings.ViewportWidth},{settings.ViewportHeight}");

        var driver = new ChromeDriver(options);
        driver.Manage().Window.Size = new System.Drawing.Size(
            settings.ViewportWidth,
            settings.ViewportHeight
        );

        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        return driver;
    }
}
