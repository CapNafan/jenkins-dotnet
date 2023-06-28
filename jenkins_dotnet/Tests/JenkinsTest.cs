using Aquality.Selenium.Browsers;
using NUnit.Framework;

[TestFixture]
public class JenkinsTest 
{
     public Browser browser;

    [SetUp]
    public void SetUp() 
    {
        browser = AqualityServices.Browser;
        browser.Maximize();
        string startUrl = "https://userinyerface.com/";
        browser.GoTo(startUrl);
        browser.WaitForPageToLoad();
    }

    [Test]
    public static void Test1() 
    {
        Assert.True(true);
    }

    [TearDown]
    public void TearDown() 
    {
        browser.Quit();
    }
}