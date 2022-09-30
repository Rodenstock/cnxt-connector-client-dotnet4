/*
 * CNXT-API
 *
 * The CNXT-API is developed by Rodenstock GmbH to integrate data from measurement devices such as DNEye<sup>®</sup> Scanner, Rodenstock Fundus Scanner, and ImpressionIST<sup>®</sup> into 3rd party applications as well as into several applications of Rodenstock such as WinFit, Rodenstock Consulting etc. If you have any feedback then please feel free to contact us via email. Copyright © Rodenstock GmbH 2022
 *
 * The version of the OpenAPI document: 1.5.0
 * Contact: cnxt@rodenstock.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Model;

namespace CNXT.Connector.Client.Test
{
    /// <summary>
    ///  Class for testing AssetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AssetsApiTests
    {
        private AssetsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AssetsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AssetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AssetsApi
            //Assert.IsInstanceOf(typeof(AssetsApi), instance);
        }

        
        /// <summary>
        /// Test GetDNEyeScannerAssets
        /// </summary>
        [Test]
        public void GetDNEyeScannerAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetDNEyeScannerAssets(id);
            //Assert.IsInstanceOf(typeof(DNEyeScannerAssetsResponse), response, "response is DNEyeScannerAssetsResponse");
        }
        
        /// <summary>
        /// Test GetImpressionISTAssets
        /// </summary>
        [Test]
        public void GetImpressionISTAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetImpressionISTAssets(id);
            //Assert.IsInstanceOf(typeof(ImpressionISTAssetsResponse), response, "response is ImpressionISTAssetsResponse");
        }
        
    }

}
