using System.ComponentModel;

namespace StringEnumSample;

/// <summary>
/// 文字列の列挙型
/// </summary>
public readonly record struct StringEnumStruct
{
    /// <summary>
    /// 文字列の列挙型に設定する値
    /// </summary>
    private readonly string? _value;

    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Defaultを使用してください。")]
    public StringEnumStruct() : this(string.Empty) { }

    private StringEnumStruct(string value) => _value = value;

    /// <summary>
    /// 列挙型に設定されている値。
    /// <see langword="default"/>では<see cref="_value"/>がnullになってしまうため、空文字を返す。
    /// そのため、<see langword="default"/>と<see cref="Default"/>は同じ値となる。
    /// </summary>
    private string Value => _value ?? string.Empty;

    public static StringEnumStruct Default => new(string.Empty);

    public static StringEnumStruct Value1 => new("Value1");

    public static StringEnumStruct Value2 => new("Value2");

    public override string ToString() => Value;

    public bool Equals(string? str) => Value == str;

    public bool Equals(StringEnumStruct other) => Value == other.Value;

    public override int GetHashCode() => Value.GetHashCode();

    /// <summary>
    /// <see cref="StringEnumStruct"/>を<see cref="string"/>に暗黙的に変換する
    /// </summary>
    /// <param name="stringEnum"></param>
    public static implicit operator string(StringEnumStruct stringEnum) => stringEnum.Value;

    // 暗黙的な変換を定義したため実装不要
    // public static bool operator ==(StringEnumSample left, string right) => left._value == right;
    // public static bool operator !=(StringEnumSample left, string right) => !(left == right);
    // public static bool operator ==(string left, StringEnumSample right) => left == right._value;
    // public static bool operator !=(string left, StringEnumSample right) => !(left == right._value);
}
