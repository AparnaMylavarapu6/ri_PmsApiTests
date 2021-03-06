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
namespace POLTest1.Tests.PaymentAPI
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Payment", SourceFile="Tests\\PaymentAPI\\Payment.feature", SourceLine=0)]
    public partial class PaymentFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Payment.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Payment", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("Post CustomerRegistration", new string[] {
                "mytag"}, SourceLine=3)]
        public virtual void PostCustomerRegistration()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post CustomerRegistration", new string[] {
                        "mytag"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                        "CarrierName",
                        "PolicyNumber",
                        "ResidentID",
                        "propertyID",
                        "firstName",
                        "lastName",
                        "email",
                        "phoneNumber"});
            table35.AddRow(new string[] {
                        "AMIG",
                        "0023262524",
                        "45678945",
                        "156",
                        "Register",
                        "Customer",
                        "registercustomer@test.com",
                        "585695532"});
#line 5
 testRunner.Given("I have a request to register a customer", ((string)(null)), table35, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                        "addressLine1",
                        "addressLine2",
                        "city",
                        "state",
                        "zipCode"});
            table36.AddRow(new string[] {
                        "1214 E Algonquin Rd",
                        "2C",
                        "Schaumburg",
                        "IL",
                        "60173"});
#line 9
 testRunner.And("I have provided the location details", ((string)(null)), table36, "And ");
#line 12
 testRunner.When("I have entered the customer details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("the customer should be registered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Post AccountRegistration", new string[] {
                "mytag"}, SourceLine=16)]
        public virtual void PostAccountRegistration()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post AccountRegistration", new string[] {
                        "mytag"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                        "carrierName",
                        "policyNumber",
                        "paymentMethod",
                        "customerNumber"});
            table37.AddRow(new string[] {
                        "AMIG",
                        "0023262524",
                        "CC",
                        "12345656"});
#line 18
 testRunner.Given("I have a request to register a account", ((string)(null)), table37, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                        "nameOnAccount",
                        "accountNumber",
                        "routingNumber",
                        "accountType",
                        "checkNumber"});
            table38.AddRow(new string[] {
                        "Test Name",
                        "123456789654",
                        "0021000021",
                        "savings",
                        "12564"});
#line 22
    testRunner.And("I have provided the accountinformation", ((string)(null)), table38, "And ");
#line hidden
            TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                        "addressLine1",
                        "addressLine2",
                        "city",
                        "state",
                        "zipCode"});
            table39.AddRow(new string[] {
                        "1214 E Algonquin Rd",
                        "2C",
                        "Schaumburg",
                        "IL",
                        "60173"});
#line 26
 testRunner.And("I aslo provide the Account Location Details", ((string)(null)), table39, "And ");
#line 30
 testRunner.When("I have entered the account details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("the account should be registered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Post ProcessPayment", new string[] {
                "mytag"}, SourceLine=34)]
        public virtual void PostProcessPayment()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post ProcessPayment", new string[] {
                        "mytag"});
#line 35
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                        "transactionAmount",
                        "transactionFee",
                        "propertyID",
                        "residentID",
                        "policyNumber",
                        "carrierName",
                        "customerReferenceID",
                        "accountReferenceID",
                        "checkNumber",
                        "isCreditCard",
                        "transType",
                        "cvv"});
            table40.AddRow(new string[] {
                        "235.25",
                        "3",
                        "156",
                        "123456858",
                        "0032125867",
                        "AMIG",
                        "3434343",
                        "3333",
                        "12343",
                        "true",
                        "1",
                        "123"});
#line 36
 testRunner.Given("I have tp process a payment", ((string)(null)), table40, "Given ");
#line 39
 testRunner.When("I have entered the payment details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("the payment should be successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Post ProcessPaymentSubmission", new string[] {
                "mytag"}, SourceLine=42)]
        public virtual void PostProcessPaymentSubmission()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post ProcessPaymentSubmission", new string[] {
                        "mytag"});
#line 43
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                        "CarrierName",
                        "PolicyNumber",
                        "paymentMethod",
                        "residentID",
                        "propertyID",
                        "firstName",
                        "lastName",
                        "email",
                        "phoneNumber",
                        "transactionAmount",
                        "transactionFee"});
            table41.AddRow(new string[] {
                        "AMIG",
                        "0023262524",
                        "CC",
                        "45678945",
                        "156",
                        "viswa",
                        "Customer",
                        "chj@test.com",
                        "585695532",
                        "235.25",
                        "3"});
#line 44
 testRunner.Given("I have to process a paymentSubmission", ((string)(null)), table41, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                        "addressLine1",
                        "addressLine2",
                        "city",
                        "state",
                        "zipCode"});
            table42.AddRow(new string[] {
                        "1214 E Algonquin Rd",
                        "2C",
                        "Schaumburg",
                        "IL",
                        "60173"});
#line 48
 testRunner.And("I have provided payment location address", ((string)(null)), table42, "And ");
#line hidden
            TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[] {
                        "nameOnCard",
                        "ccNumber",
                        "cvv",
                        "expirationMonth",
                        "expirationYear",
                        "cardType"});
            table43.AddRow(new string[] {
                        "Test CC",
                        "4111111111111111",
                        "584",
                        "08",
                        "2028",
                        "1"});
#line 52
 testRunner.And("I have provided creditcard information", ((string)(null)), table43, "And ");
#line hidden
            TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                        "nameOnAccount",
                        "accountNumber",
                        "routingNumber",
                        "accountType",
                        "checkNumber"});
            table44.AddRow(new string[] {
                        "Test Name",
                        "123456789654",
                        "0021000021",
                        "savings",
                        "23232"});
#line 55
 testRunner.And("i have also provided payment achInfo", ((string)(null)), table44, "And ");
#line 59
 testRunner.When("I have entered the ProcessPaymentSubmission details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("the paymentsubmission should be successfull", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
