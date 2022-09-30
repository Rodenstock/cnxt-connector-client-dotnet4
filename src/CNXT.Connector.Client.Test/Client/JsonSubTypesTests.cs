/*
 * CNXT-API
 *
 * The CNXT-API is developed by Rodenstock GmbH to integrate data from measurement devices such as DNEye<sup>®</sup> Scanner, Rodenstock Fundus Scanner, and ImpressionIST<sup>®</sup> into 3rd party applications as well as into several applications of Rodenstock such as WinFit, Rodenstock Consulting etc. If you have any feedback then please feel free to contact us via email. Copyright © Rodenstock GmbH 2022
 *
 * The version of the OpenAPI document: 1.5.0
 * Contact: cnxt@rodenstock.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Collections.Generic;
using System.Linq;
using JsonSubTypes;
using Newtonsoft.Json;
using NUnit.Framework;

using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Model;
using CNXT.Connector.Client.Client;

namespace CNXT.Connector.Client.Test.Client
{
    public class JsonSubTypesTests
    {
        [Test]
        public void TestSimpleJsonSubTypesExample()
        {
            var animal =
                JsonConvert.DeserializeObject<IAnimal>("{\"Kind\":\"Dog\",\"Breed\":\"Jack Russell Terrier\"}");
            Assert.AreEqual("Jack Russell Terrier", (animal as Dog)?.Breed);
        }

        [Test]
        public void DeserializeObjectWithCustomMapping()
        {
            var animal =
                JsonConvert.DeserializeObject<Animal2>("{\"Sound\":\"Bark\",\"Breed\":\"Jack Russell Terrier\"}");
            Assert.AreEqual("Jack Russell Terrier", (animal as Dog2)?.Breed);
        }

        [Test]
        public void DeserializeObjectMappingByPropertyPresence()
        {
            string json =
                "[{\"Department\":\"Department1\",\"JobTitle\":\"JobTitle1\",\"FirstName\":\"FirstName1\",\"LastName\":\"LastName1\"}," +
                "{\"Department\":\"Department1\",\"JobTitle\":\"JobTitle1\",\"FirstName\":\"FirstName1\",\"LastName\":\"LastName1\"}," +
                "{\"Skill\":\"Painter\",\"FirstName\":\"FirstName1\",\"LastName\":\"LastName1\"}]";


            var persons = JsonConvert.DeserializeObject<ICollection<Person>>(json);
            Assert.AreEqual("Painter", (persons.Last() as Artist)?.Skill);
        }
    }

    [JsonConverter(typeof(JsonSubtypes), "Kind")]
    public interface IAnimal
    {
        string Kind { get; }
    }

    public class Dog : IAnimal
    {
        public Dog()
        {
            Kind = "Dog";
        }

        public string Kind { get; }
        public string Breed { get; set; }
    }

    class Cat : IAnimal
    {
        public Cat()
        {
            Kind = "Cat";
        }

        public string Kind { get; }
        bool Declawed { get; set; }
    }

    [JsonConverter(typeof(JsonSubtypes), "Sound")]
    [JsonSubtypes.KnownSubType(typeof(Dog2), "Bark")]
    [JsonSubtypes.KnownSubType(typeof(Cat2), "Meow")]
    public class Animal2
    {
        public virtual string Sound { get; }
        public string Color { get; set; }
    }

    public class Dog2 : Animal2
    {
        public Dog2()
        {
            Sound = "Bark";
        }

        public override string Sound { get; }
        public string Breed { get; set; }
    }

    public class Cat2 : Animal2
    {
        public Cat2()
        {
            Sound = "Meow";
        }

        public override string Sound { get; }
        public bool Declawed { get; set; }
    }

    [JsonConverter(typeof(JsonSubtypes))]
    [JsonSubtypes.KnownSubTypeWithProperty(typeof(Employee), "JobTitle")]
    [JsonSubtypes.KnownSubTypeWithProperty(typeof(Artist), "Skill")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Employee : Person
    {
        public string Department { get; set; }
        public string JobTitle { get; set; }
    }

    public class Artist : Person
    {
        public string Skill { get; set; }
    }
}
