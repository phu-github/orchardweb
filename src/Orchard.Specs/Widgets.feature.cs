// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Widgets")]
    public partial class WidgetsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Widgets.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Widgets", "  In order to add and manage widgets on my site\r\n  As an author\r\n  I want to crea" +
                    "te and edit widgets and layers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can edit a default layer")]
        public virtual void ICanEditADefaultLayer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can edit a default layer", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
    testRunner.When("I go to \"Admin/Widgets\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
    testRunner.Then("I should see \"<h1[^>]*>Widgets[^>]*>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
    testRunner.When("I follow \"Edit\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
    testRunner.Then("I should see \"<input[^>]*name=\"LayerPart.Name\"[^>]*value=\"Default\"[^>]*>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "LayerPart.Description",
                        "This is the default layer."});
#line 12
    testRunner.When("I fill in", ((string)(null)), table1, "When ");
#line 15
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
    testRunner.Then("I should see \"Your Layer has been saved\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
    testRunner.When("I follow \"Edit\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
    testRunner.Then("I should see \"<textarea[^>]*>\\s*This is the default layer.\\s*</textarea>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can add a new layer and that layer is active when I\'m redirected to the widget " +
            "management page")]
        public virtual void ICanAddANewLayerAndThatLayerIsActiveWhenIMRedirectedToTheWidgetManagementPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can add a new layer and that layer is active when I\'m redirected to the widget " +
                    "management page", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
    testRunner.When("I go to \"Admin/Widgets\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
        testRunner.And("I follow \"Add a new layer...\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
    testRunner.Then("I should see \"<h1[^>]*>Add Layer</h1>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "LayerPart.Name",
                        "For awesome stuff"});
            table2.AddRow(new string[] {
                        "LayerPart.LayerRule",
                        "url \"~/awesome*\""});
#line 26
    testRunner.When("I fill in", ((string)(null)), table2, "When ");
#line 30
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
    testRunner.Then("I should see \"Your Layer has been created.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
        testRunner.And("I should see \"<option[^>]+selected=\"selected\"[^>]+value=\"\\d+\">For awesome stuff</" +
                    "option>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can delete a layer")]
        public virtual void ICanDeleteALayer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can delete a layer", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 36
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
    testRunner.When("I go to \"Admin/Widgets\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
    testRunner.Then("I should see \"<option[^>]*>Default</option>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
    testRunner.When("I follow \"Edit\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
    testRunner.Then("I should see \"<input[^>]*name=\"LayerPart.Name\"[^>]*value=\"Default\"[^>]*>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
    testRunner.When("I hit \"Delete\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
    testRunner.Then("I should see \"Layer was successfully deleted\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
        testRunner.And("I should not see \"<option[^>]*>Default</option>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can add a widget to a specific zone in a specific layer")]
        public virtual void ICanAddAWidgetToASpecificZoneInASpecificLayer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can add a widget to a specific zone in a specific layer", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 47
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
    testRunner.When("I go to \"Admin/Widgets\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "layerId",
                        "Disabled"});
#line 49
        testRunner.And("I fill in", ((string)(null)), table3, "And ");
#line 52
        testRunner.And("I hit \"Show\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
    testRunner.Then("I should see \"<option[^>]*selected[^>]*>Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
    testRunner.When("I follow \"Add\" where href has \"zone=Header\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
    testRunner.Then("I should see \"<h1[^>]*>Choose A Widget</h1>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
    testRunner.When("I follow \"<h2>Html Widget</h2>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
    testRunner.Then("I should see \"<h1[^>]*>Add Widget</h1>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "WidgetPart.Title",
                        "Flashy HTML Widget"});
            table4.AddRow(new string[] {
                        "Body.Text",
                        "<p><blink>hi</blink></p>"});
#line 58
    testRunner.When("I fill in", ((string)(null)), table4, "When ");
#line 62
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
    testRunner.Then("I should see \"Your Html Widget has been added.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
        testRunner.And("I should see \"<option[^>]*selected[^>]*>Disabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
        testRunner.And("I should see \"<li[^>]*class=\"[^\"]*widgets-this-layer[^\"]*\"[^>]*>\\s*<form[^>]*>\\s*" +
                    "<h3[^>]*>\\s*<a[^>]*>Flashy HTML Widget</a>\\s*</h3>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
