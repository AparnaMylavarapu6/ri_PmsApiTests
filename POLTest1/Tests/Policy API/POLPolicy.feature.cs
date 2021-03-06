﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace POLTest1.Tests.PolicyAPI
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("POLPolicy", SourceFile="Tests\\Policy API\\POLPolicy.feature", SourceLine=0)]
    public partial class POLPolicyFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "POLPolicy.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "POLPolicy", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Get POL Policy by entity type and entity id", new string[] {
                "needtorunfordev"}, SourceLine=4)]
        public virtual void GetPOLPolicyByEntityTypeAndEntityId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get POL Policy by entity type and entity id", new string[] {
                        "needtorunfordev"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table69 = new TechTalk.SpecFlow.Table(new string[] {
                        "entityid",
                        "entitytype"});
            table69.AddRow(new string[] {
                        "1234",
                        "Property"});
            table69.AddRow(new string[] {
                        "1234",
                        "Company"});
#line 6
 testRunner.Given("I have entered the entity type and the entity id", ((string)(null)), table69, "Given ");
#line 12
 testRunner.When("I send a Get request to fetch the POL policies", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("The POL policies should be fetched successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get POL policy by resident id and certificate number", new string[] {
                "needtorunfordev"}, SourceLine=16)]
        public virtual void GetPOLPolicyByResidentIdAndCertificateNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get POL policy by resident id and certificate number", new string[] {
                        "needtorunfordev"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table70 = new TechTalk.SpecFlow.Table(new string[] {
                        "certificatenumber",
                        "residentid"});
            table70.AddRow(new string[] {
                        "1234",
                        "12343"});
#line 19
testRunner.Given("I have entered the resident id and the certificate number of the pol policy", ((string)(null)), table70, "Given ");
#line 23
testRunner.When("I send a Get request with the certificate number and the residentid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
testRunner.Then("The policy, property, lease and ledger information tied up to the resident should" +
                    " be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get Policy Details by resident id and certificate number", new string[] {
                "needtorunfordev"}, SourceLine=28)]
        public virtual void GetPolicyDetailsByResidentIdAndCertificateNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Policy Details by resident id and certificate number", new string[] {
                        "needtorunfordev"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table71 = new TechTalk.SpecFlow.Table(new string[] {
                        "certificatenumber",
                        "residentid"});
            table71.AddRow(new string[] {
                        "1234",
                        "1234"});
#line 31
testRunner.Given("I have provided the resident id and certificate number for policy details", ((string)(null)), table71, "Given ");
#line 35
testRunner.When("I send a Get request to the get policy details method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
testRunner.Then("A successful response should be generated from the method with the resident id an" +
                    "d certificate number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get Policy Details by location id and certificate number", new string[] {
                "needtorunfordev"}, SourceLine=40)]
        public virtual void GetPolicyDetailsByLocationIdAndCertificateNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Policy Details by location id and certificate number", new string[] {
                        "needtorunfordev"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table72 = new TechTalk.SpecFlow.Table(new string[] {
                        "certificatenumber",
                        "locationid"});
            table72.AddRow(new string[] {
                        "1234",
                        "1234"});
#line 43
testRunner.Given("I have provided the location id and the certificate number fo policy details", ((string)(null)), table72, "Given ");
#line 47
testRunner.When("I send a Get request with the location id and certification number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
testRunner.Then("A successful response should be generated from the method with the location id an" +
                    "d certificate number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get the ledger monthly details by ledger info id", new string[] {
                "needtorunfordev"}, SourceLine=52)]
        public virtual void GetTheLedgerMonthlyDetailsByLedgerInfoId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the ledger monthly details by ledger info id", new string[] {
                        "needtorunfordev"});
#line 53
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table73 = new TechTalk.SpecFlow.Table(new string[] {
                        "ledgerinfoid"});
            table73.AddRow(new string[] {
                        "1234"});
#line 55
testRunner.Given("I have entered the ledger info id to fetch the ledger details", ((string)(null)), table73, "Given ");
#line 59
testRunner.When("I send a Get request to fetch the monthly ledger details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
testRunner.Then("A successful response should be generated with the monthly ledger details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get the ledger information by ledger info id", new string[] {
                "needtorunfordev"}, SourceLine=64)]
        public virtual void GetTheLedgerInformationByLedgerInfoId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the ledger information by ledger info id", new string[] {
                        "needtorunfordev"});
#line 65
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table74 = new TechTalk.SpecFlow.Table(new string[] {
                        "ledgerinfoid"});
            table74.AddRow(new string[] {
                        "1234"});
#line 66
testRunner.Given("I have provided the ledger info id to fetch the ledger information", ((string)(null)), table74, "Given ");
#line 70
testRunner.When("I send a Get request to fetch the ledger information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
testRunner.Then("A successful response should be generated with the ledger information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get Resident details by certificate number", new string[] {
                "needtorunfordev"}, SourceLine=75)]
        public virtual void GetResidentDetailsByCertificateNumber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Resident details by certificate number", new string[] {
                        "needtorunfordev"});
#line 76
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table75 = new TechTalk.SpecFlow.Table(new string[] {
                        "certificatenumber"});
            table75.AddRow(new string[] {
                        "1234"});
#line 78
testRunner.Given("I have entered the certificate number to fetch the resident details", ((string)(null)), table75, "Given ");
#line 82
testRunner.When("I send a Get request to fetch the resident details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
testRunner.Then("A successful response should be generated with the resident details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Get the product coverage details with the certificate number and location id", new string[] {
                "needtorunfordev"}, SourceLine=88)]
        public virtual void GetTheProductCoverageDetailsWithTheCertificateNumberAndLocationId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the product coverage details with the certificate number and location id", new string[] {
                        "needtorunfordev"});
#line 89
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table76 = new TechTalk.SpecFlow.Table(new string[] {
                        "certificatenumber",
                        "locationid"});
            table76.AddRow(new string[] {
                        "1234",
                        "1234"});
#line 91
testRunner.Given("I have entered the certificate number and location id to fetch the product covera" +
                    "ge details", ((string)(null)), table76, "Given ");
#line 95
testRunner.When("I send a Get request to fetch the product coverage details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 96
testRunner.Then("A successful response should be generated with the product coverage details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
