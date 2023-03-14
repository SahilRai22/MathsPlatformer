using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class arithmeticTest
{
     /*
     * Failed Test Case
     * **/
    [Test]
    public void additionTest()
    {
        int expected = 5;
        int actual = 2 + 2;
        Assert.AreEqual(expected, actual);
    }

    /*
     * Failed Test Case
     * **/
    [Test]
    public void subtractionTest()
    {
        int expected = 2;
        int actual = 4 - 3; 
        Assert.AreEqual(expected, actual);
    }

    /*
     * Failed Test Case
     * **/
    [Test]
    public void multiplicationTest()
    {
        int expected = 10;
        int actual = 2 * 3; 
        Assert.AreEqual(expected, actual);
    }

    /*
     * Failed Test Case
     * **/
    [Test]
    public void divisionTest()
    {
        int expected = 2;
        int actual = 4/1; 
        Assert.AreEqual(expected, actual);
    }


}
