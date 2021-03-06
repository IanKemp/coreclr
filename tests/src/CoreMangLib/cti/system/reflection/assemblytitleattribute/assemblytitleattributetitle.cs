using System;
using System.Reflection;
/// <summary>
/// AssemblyTitleAttribute.Title
/// </summary>
public class AssemblyTitleAttributeTitle
{
    private int c_MIN_STR_LENGTH = 8;
    private int c_MAX_STR_LENGTH = 256;
    public static int Main()
    {
        AssemblyTitleAttributeTitle assemTitleAttrTitle = new AssemblyTitleAttributeTitle();
        TestLibrary.TestFramework.BeginTestCase("AssemblyTitleAttributeTitle");
        if (assemTitleAttrTitle.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        return retVal;
    }
    #region PositiveTest
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1:Return the Title info from initialized AssemblyTitleAttribute 1");
        try
        {
            string title = TestLibrary.Generator.GetString(-55, false, c_MIN_STR_LENGTH, c_MAX_STR_LENGTH);
            AssemblyTitleAttribute assemTitleAttr = new AssemblyTitleAttribute(title);
            if (assemTitleAttr.Title != title)
            {
                TestLibrary.TestFramework.LogError("001", "the ExpectResult is not the ActualResult");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpect exception:" + e);
            retVal = false;
        }
        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2:Return the Title info from initialized AssemblyTitleAttribute 2");
        try
        {
            string title = null;
            AssemblyTitleAttribute assemTitleAttr = new AssemblyTitleAttribute(title);
            if (assemTitleAttr.Title != null)
            {
                TestLibrary.TestFramework.LogError("003", "the ExpectResult is not the ActualResult");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpect exception:" + e);
            retVal = false;
        }
        return retVal;
    }
    public bool PosTest3()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest3:Return the Title info from initialized AssemblyTitleAttribute 3");
        try
        {
            string title = string.Empty;
            AssemblyTitleAttribute assemTitleAttr = new AssemblyTitleAttribute(title);
            if (assemTitleAttr.Title != "")
            {
                TestLibrary.TestFramework.LogError("005", "the ExpectResult is not the ActualResult");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "Unexpect exception:" + e);
            retVal = false;
        }
        return retVal;
    }
    #endregion
}
