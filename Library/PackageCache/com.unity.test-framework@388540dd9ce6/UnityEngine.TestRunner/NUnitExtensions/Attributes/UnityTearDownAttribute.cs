using System;
using NUnit.Framework;

namespace UnityEngine.TestTools
{
    /// <summary>
    /// The <see cref="UnitySetUpAttribute"/> and `UnityTearDown` attributes are identical to the standard `SetUp` and `TearDown` attributes, with the exception that they allow for <see cref="IEditModeTestYieldInstruction"/>. The `UnitySetUp` and `UnityTearDown` attributes expect a return type of [IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8).
    /// </summary>
    /// <example>
    /// <code>
    ///public class SetUpTearDownExample
    /// {
    ///     [UnitySetUp]
    ///     public IEnumerator SetUp()
    ///     {
    ///         yield return new EnterPlayMode();
    ///     }
    ///
    ///     [Test]
    ///     public void MyTest()
    ///     {
    ///         Debug.Log("This runs inside playmode");
    ///     }
    ///
    ///     [UnityTearDown]
    ///     public IEnumerator TearDown()
    ///     {
    ///         yield return new ExitPlayMode();
    ///     }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Method)]
    public class UnityTearDownAttribute : NUnitAttribute
    {
    }
}
