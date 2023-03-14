using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class movementTest
{
    private PlayerMovement moveTest;

    [SetUp]
    public void Setup()
    {
        var gameObject = new GameObject();
        moveTest = gameObject.AddComponent<PlayerMovement>();
    }


    /*
    * Passed Test Case
    * **/
    [Test]
    public void LeftTest()
    {
        Vector3 expectedVector = new Vector3(-2, 2, 2);
        moveTest.moveLeft();
        Assert.AreEqual(expectedVector, moveTest.transform.localScale);

    }

    /*
     * Passed Test Case
     * **/
    [Test]
    public void RightTest()
    {
        Vector3 expectedVector = new Vector3(2, 2, 2);
        moveTest.moveRight();
        Assert.AreEqual(expectedVector, moveTest.transform.localScale);
    }

    /*
     * Failed Test Case
     * **/
    [Test]
    public void JumpTest()
    {

        bool expected = true;
        bool actual = false;
        Assert.AreEqual(expected, actual);

    }

  


}

