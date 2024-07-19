
using System;

public class BaseClass
{
    public int PublicField = 1;
    private int PrivateField = 2;
    protected int ProtectedField = 3;
    internal int InternalField = 4;
    protected internal int ProtectedInternalField = 5;

    public void DisplayBaseFields()
    {
        Console.WriteLine($"BaseClass - PublicField: {PublicField}");
        Console.WriteLine($"BaseClass - PrivateField: {PrivateField}");
        Console.WriteLine($"BaseClass - ProtectedField: {ProtectedField}");
        Console.WriteLine($"BaseClass - InternalField: {InternalField}");
        Console.WriteLine($"BaseClass - ProtectedInternalField: {ProtectedInternalField}");
    }
}

public class DerivedClass : BaseClass
{
    public void DisplayDerivedFields()
    {
        Console.WriteLine($"DerivedClass - PublicField: {PublicField}");
        // Cannot access PrivateField from BaseClass
        // Console.WriteLine($"DerivedClass - PrivateField: {PrivateField}");
        Console.WriteLine($"DerivedClass - ProtectedField: {ProtectedField}");
        Console.WriteLine($"DerivedClass - InternalField: {InternalField}");
        Console.WriteLine($"DerivedClass - ProtectedInternalField: {ProtectedInternalField}");
    }
}

public class OtherClass
{
    public void DisplayOtherClassFields()
    {
        BaseClass baseObj = new BaseClass();
        Console.WriteLine($"OtherClass - PublicField: {baseObj.PublicField}");
        // Cannot access PrivateField from BaseClass
        // Console.WriteLine($"OtherClass - PrivateField: {baseObj.PrivateField}");
        // Cannot access ProtectedField from BaseClass
        // Console.WriteLine($"OtherClass - ProtectedField: {baseObj.ProtectedField}");
        Console.WriteLine($"OtherClass - InternalField: {baseObj.InternalField}");
        Console.WriteLine($"OtherClass - ProtectedInternalField: {baseObj.ProtectedInternalField}");
    }
}

public class AcessModifier
{
    public static void Main(string[] args)
    {
        BaseClass baseClass = new BaseClass();
        baseClass.DisplayBaseFields();

        DerivedClass derivedClass = new DerivedClass();
        derivedClass.DisplayDerivedFields();

        OtherClass otherClass = new OtherClass();
        otherClass.DisplayOtherClassFields();
    }
}
