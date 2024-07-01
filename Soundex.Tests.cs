using Xunit;

public class SoundexTests
{
    [Fact]
    public void HandlesEmptyString()
    {
        Assert.Equal(string.Empty, Soundex.GenerateSoundex(""));
    }

    [Fact]
    public void HandlesSingleCharacter()
    {
        Assert.Equal("A000", Soundex.GenerateSoundex("A"));
    }
    [Fact]
    public void HandlesMultipleCharacter()
    {
        string input = "Smith";
        string expected = "S530";
        Assert.Equal(expected ,Soundex.GenerateSoundex(input));
    }
    
    [Fact]
    public void  HandlesNameWithOnlyVowels()
    { 
        string inputstring = "Aeia";
        string expectedvalue = "A000";
        Assert.Equal(expectedvalue ,Soundex.GenerateSoundex(inputstring));
    }
}
