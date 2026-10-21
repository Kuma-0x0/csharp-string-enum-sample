using StringEnumSample;

namespace StringEnumSampleTests;

public class StructEnumTests
{
    #region ToString

    [Test]
    public async Task ToString_OK_DefaultReturnsStringEmpty()
    {
        // Arrange
        StringEnumStruct strEnum = default;

        // Act
        var actual = strEnum.ToString();

        // Assert
        await Assert.That(actual).IsEqualTo(string.Empty);
    }

    [Test]
    public async Task ToString_OK_ReturnsStringValue()
    {
        // Arrange
        var strEnum = StringEnumStruct.Value1;

        // Act
        var actual = strEnum.ToString();

        // Assert
        await Assert.That(actual).IsEqualTo("Value1");
    }

    #endregion

    #region Equals

    [Test]
    public async Task Equals_OK_CompareDefaultToDefaultProperty()
    {
        // Arrange
        StringEnumStruct left = default;
        var right = StringEnumStruct.Default;

        // Act
        var actual = left.Equals(right);

        // Assert
        await Assert.That(actual).IsTrue();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }

    [Test]
    public async Task Equals_OK_CompareEnumToEnum()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = StringEnumStruct.Value1;

        // Act
        var actual = left.Equals(right);

        // Assert
        await Assert.That(actual).IsTrue();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }

    [Test]
    public async Task Equals_NG_CompareEnumToEnum()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = StringEnumStruct.Value2;

        // Act
        var actual = left.Equals(right);

        // Assert
        await Assert.That(actual).IsFalse();
    }

    [Test]
    public async Task Equals_OK_CompareEnumToString()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = "Value1";

        // Act
        var actual = left.Equals(right);

        // Assert
        await Assert.That(actual).IsTrue();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }

    [Test]
    public async Task Equals_NG_CompareEnumToString()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = "Value2";

        // Act
        var actual = left.Equals(right);

        // Assert
        await Assert.That(actual).IsFalse();
    }


    [Test]
    public async Task Equals_OK_CompareStringToEnum()
    {
        // Arrange
        var left = "Value1";
        var right = StringEnumStruct.Value1;

        // Act
        var actual = left.Equals(right, StringComparison.Ordinal);

        // Assert
        await Assert.That(actual).IsTrue();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }


    [Test]
    public async Task Equals_NG_CompareStringToEnum()
    {
        // Arrange
        var left = "Value2";
        var right = StringEnumStruct.Value1;

        // Act
        var actual = left.Equals(right, StringComparison.Ordinal);

        // Assert
        await Assert.That(actual).IsFalse();
    }

    [Test]
    public async Task Equals_NG_CompareEnumToStringAsObject()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        object right = "Value1";

        // Act
        var actual = left.Equals(right);

        // Assert
        await Assert.That(actual).IsFalse();
    }

    [Test]
    public async Task Equals_NG_CompareEnumToNull()
    {
        // Arrange
        var left = StringEnumStruct.Default;
        string? right = null;

        // Act
        var actual = left.Equals(right);

        // Assert
        await Assert.That(actual).IsFalse();
    }

    [Test]
    public async Task Equals_NG_CompareEnumToOther()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = 1;

        // Act
        var actual = left.Equals(right);

        // Assert
        await Assert.That(actual).IsFalse();
    }

    #endregion

    #region ==

    [Test]
    public async Task Operator_Equality_OK_CompareDefaultToDefaultProperty()
    {
        // Arrange
        StringEnumStruct left = default;
        var right = StringEnumStruct.Default;

        // Act
        var actual = left == right;

        // Assert
        await Assert.That(actual).IsTrue();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }

    [Test]
    public async Task Operator_Equality_OK_CompareEnumToEnum()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = StringEnumStruct.Value1;

        // Act
        var actual = left == right;

        // Assert
        await Assert.That(actual).IsTrue();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }

    [Test]
    public async Task Operator_Equality_NG_CompareEnumToEnum()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = StringEnumStruct.Value2;

        // Act
        var actual = left == right;

        // Assert
        await Assert.That(actual).IsFalse();
    }

    [Test]
    public async Task Operator_Equality_OK_CompareEnumToString()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = "Value1";

        // Act
        var actual = left == right;

        // Assert
        await Assert.That(actual).IsTrue();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }

    [Test]
    public async Task Operator_Equality_NG_CompareEnumToString()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = "Value2";

        // Act
        var actual = left == right;

        // Assert
        await Assert.That(actual).IsFalse();
    }

    [Test]
    public async Task Operator_Equality_OK_CompareStringToEnum()
    {
        // Arrange
        var left = "Value1";
        var right = StringEnumStruct.Value1;

        // Act
        var actual = left == right;

        // Assert
        await Assert.That(actual).IsTrue();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }

    [Test]
    public async Task Operator_Equality_NG_CompareStringToEnum()
    {
        // Arrange
        var left = "Value2";
        var right = StringEnumStruct.Value1;

        // Act
        var actual = left == right;

        // Assert
        await Assert.That(actual).IsFalse();
    }

    #endregion

    #region !=

    [Test]
    public async Task Operator_Inequality_OK_CompareEnumToEnum()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = StringEnumStruct.Value2;

        // Act
        var actual = left != right;

        // Assert
        await Assert.That(actual).IsTrue();
    }

    [Test]
    public async Task Operator_Inequality_NG_CompareEnumToEnum()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = StringEnumStruct.Value1;

        // Act
        var actual = left != right;

        // Assert
        await Assert.That(actual).IsFalse();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }

    [Test]
    public async Task Operator_Inequality_OK_CompareEnumToString()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = "Value2";

        // Act
        var actual = left != right;

        // Assert
        await Assert.That(actual).IsTrue();
    }

    [Test]
    public async Task Operator_Inequality_NG_CompareEnumToString()
    {
        // Arrange
        var left = StringEnumStruct.Value1;
        var right = "Value1";

        // Act
        var actual = left != right;

        // Assert
        await Assert.That(actual).IsFalse();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }

    [Test]
    public async Task Operator_Inequality_OK_CompareStringToEnum()
    {
        // Arrange
        var left = "Value2";
        var right = StringEnumStruct.Value1;

        // Act
        var actual = left != right;

        // Assert
        await Assert.That(actual).IsTrue();
    }

    [Test]
    public async Task Operator_Inequality_NG_CompareStringToEnum()
    {
        // Arrange
        var left = "Value1";
        var right = StringEnumStruct.Value1;

        // Act
        var actual = left != right;

        // Assert
        await Assert.That(actual).IsFalse();
        await Assert.That(left.GetHashCode()).IsEqualTo(right.GetHashCode());
    }

    #endregion

    #region implicit conversion

    [Test]
    public async Task Operator_ImplicitConversion_OK_DefaultConvertToStringEmpty()
    {
        // Arrange
        string left = default(StringEnumStruct);

        // Assert
        await Assert.That(left).IsEqualTo(string.Empty);
    }

    [Test]
    public async Task Operator_ImplicitConversion_OK_EnumConvertToString()
    {
        // Arrange
        string left = StringEnumStruct.Value1;


        // Assert
        await Assert.That(left).IsEqualTo("Value1");
    }

    #endregion

    #region Same Key

    [Test]
    public async Task Add_HashsetItem_NG_WhenDefaultKeyAlreadyExists()
    {
        // Arrange
        HashSet<StringEnumStruct> set = [default];

        // Act
        var actual = set.Add(StringEnumStruct.Default);

        // Assert
        await Assert.That(actual).IsFalse();
    }

    [Test]
    public async Task Add_DictionaryItem_NG_WhenDefaultKeyAlreadyExists()
    {
        // Arrange
        Dictionary<StringEnumStruct, string> dict = new()
        {
            [default] = string.Empty,
        };

        // Act
        var actual = dict.TryAdd(StringEnumStruct.Default, "new_value");

        // Assert
        await Assert.That(actual).IsFalse();
    }

    #endregion
}
