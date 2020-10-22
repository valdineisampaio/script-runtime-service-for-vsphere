/* 
 * Script Runtime Service for vSphere
 *
 * # Script Runtime Service API    Script Runtime Service for vSphere (SRS) allows running PowerShell and PowerCLI scripts. SRS is a VC add-on that is deployed separately from VCSA. SRS can be accessed via REST API that allows you to create PowerShell instances and run PowerShell and PowerCLI scripts within. No Connect-VIServer is required to run PowerCLI against VC(s) SRS is registered to.    ## Authetication    SRS uses VC SSO as Identity and Authentication Server. Two types of authentication are supported. SIGN and Basic. SIGN authentication is purposed for Service-To-Service access to SRS resources. For convenience of the end-users SRS supports basic authentication passing username and password which are used to acquire SAML HoK token for SRS solution. When basic is used SRS exchanges the username and password for SAML HoK token from the SSO server. SRS uses the SAML token to Connect PowerCLI to VC services in further operations.   On successful authentication SRS returns API Key which is required to authorize further SRS API calls.
 *
 * OpenAPI spec version: 1.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ScriptExecution
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ScriptExecutionTests
    {
        // TODO uncomment below to declare an instance variable for ScriptExecution
        //private ScriptExecution instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ScriptExecution
            //instance = new ScriptExecution();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScriptExecution
        /// </summary>
        [Test]
        public void ScriptExecutionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ScriptExecution
            //Assert.IsInstanceOfType<ScriptExecution> (instance, "variable 'instance' is a ScriptExecution");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'RunspaceId'
        /// </summary>
        [Test]
        public void RunspaceIdTest()
        {
            // TODO unit test for the property 'RunspaceId'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Script'
        /// </summary>
        [Test]
        public void ScriptTest()
        {
            // TODO unit test for the property 'Script'
        }
        /// <summary>
        /// Test the property 'ScriptParameters'
        /// </summary>
        [Test]
        public void ScriptParametersTest()
        {
            // TODO unit test for the property 'ScriptParameters'
        }
        /// <summary>
        /// Test the property 'OutputObjectsFormat'
        /// </summary>
        [Test]
        public void OutputObjectsFormatTest()
        {
            // TODO unit test for the property 'OutputObjectsFormat'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'Reason'
        /// </summary>
        [Test]
        public void ReasonTest()
        {
            // TODO unit test for the property 'Reason'
        }
        /// <summary>
        /// Test the property 'StartTime'
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO unit test for the property 'StartTime'
        }
        /// <summary>
        /// Test the property 'EndTime'
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO unit test for the property 'EndTime'
        }

    }

}