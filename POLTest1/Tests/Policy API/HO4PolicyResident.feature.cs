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
    [TechTalk.SpecRun.FeatureAttribute("HO4PolicyResident", SourceFile="Tests\\Policy API\\HO4PolicyResident.feature", SourceLine=0)]
    public partial class HO4PolicyResidentFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HO4PolicyResident.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "HO4PolicyResident", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Fetch Resident and policy information by policyid", new string[] {
                "happypath"}, SourceLine=4)]
        public virtual void FetchResidentAndPolicyInformationByPolicyid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetch Resident and policy information by policyid", new string[] {
                        "happypath"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table65 = new TechTalk.SpecFlow.Table(new string[] {
                        "policyid"});
            table65.AddRow(new string[] {
                        "1234"});
#line 6
 testRunner.Given("I have entered the policy id to fetch the policy and resident information", ((string)(null)), table65, "Given ");
#line 11
 testRunner.When("I send a Get request to fetch the policy and resident information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("A successful response code should be generated with the policy and resident infor" +
                    "mation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Delete resident and policy information by policyid", new string[] {
                "happypath"}, SourceLine=14)]
        public virtual void DeleteResidentAndPolicyInformationByPolicyid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete resident and policy information by policyid", new string[] {
                        "happypath"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table66 = new TechTalk.SpecFlow.Table(new string[] {
                        "policyid"});
            table66.AddRow(new string[] {
                        "1234"});
#line 16
testRunner.Given("I have entered the policy id to delete the policy and resident information", ((string)(null)), table66, "Given ");
#line 21
 testRunner.When("I send a Delete request to delete the policy and resident information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("A successful response code should be generated with the delete operation being su" +
                    "ccessful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Fetch Resident and policy information by residentid", new string[] {
                "happypath"}, SourceLine=24)]
        public virtual void FetchResidentAndPolicyInformationByResidentid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fetch Resident and policy information by residentid", new string[] {
                        "happypath"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table67 = new TechTalk.SpecFlow.Table(new string[] {
                        "residentid"});
            table67.AddRow(new string[] {
                        "1234"});
#line 26
 testRunner.Given("I have entered the resident id to fetch the policy and resident information", ((string)(null)), table67, "Given ");
#line 31
 testRunner.When("I send a Get request to fetch the policy and resident information by residentid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.Then("A successful response code should be generated with the policy and resident infor" +
                    "mation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Delete resident and policy information by residentid", new string[] {
                "happypath"}, SourceLine=34)]
        public virtual void DeleteResidentAndPolicyInformationByResidentid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete resident and policy information by residentid", new string[] {
                        "happypath"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table68 = new TechTalk.SpecFlow.Table(new string[] {
                        "residentid"});
            table68.AddRow(new string[] {
                        "1234"});
#line 36
testRunner.Given("I have entered the residentid id to delete the policy and resident information", ((string)(null)), table68, "Given ");
#line 41
 testRunner.When("I send a Delete request to delete the policy and resident information by resident" +
                    "id", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("A successful response code should be generated with the delete operation being su" +
                    "ccessful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
