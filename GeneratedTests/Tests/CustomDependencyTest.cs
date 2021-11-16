using System;
using NUnit.Framework;
using ConsoleApp.Files;
using Moq;
using System.Collections.Generic;

[TestFixture]
class CustomDependencyTest
{
    private CustomDependency _customDependency;
    [SetUp]
    public void SetUp()
    {
        _customDependency = new CustomDependency();
    }

    [Test]
    public void CreateCustomEntity()
    {
        var name = default(string);
        var value = default(double);
        var actual = _customDependency.CreateCustomEntity(name, value);
        var expected = default(CustomEntity);
        Assert.That(actual, Is.EqualTo(expected));
        Assert.Fail("autogenerated");
    }

    [Test]
    public void DependencyString()
    {
        var list = default(List<string>);
        var actual = _customDependency.DependencyString(list);
        var expected = default(string);
        Assert.That(actual, Is.EqualTo(expected));
        Assert.Fail("autogenerated");
    }
}