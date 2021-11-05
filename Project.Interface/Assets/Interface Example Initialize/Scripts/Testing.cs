using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    MyClass _myClass;

    void Start()
    {
        MyClass _myClass = new MyClass();
        MySecondClass _mySecondClass = new MySecondClass();

        TestMyInterface(_myClass);
        TestMyInterface(_mySecondClass);
    }

    void TestMyInterface(IMyFirstInterface myInterface)
    {
        myInterface.TestMyFunction();
    }

    void Update()
    {
        
    }
}

public class MyClass : IMyFirstInterface
{
    public void TestMyFunction()
    {
        Debug.Log("MyClass.TestFunction");
    }
}
public class MySecondClass : IMyFirstInterface
{
    public void TestMyFunction()
    {
        Debug.Log("MySecondClass.TestFunction");
    }
}

public interface IMyFirstInterface
{
    void TestMyFunction();
}

