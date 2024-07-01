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
      
        Assert.Equal("S530", Soundex.GenerateSoundex("Smith"));
    }

    [Fact]
    public void HandlesNameWithOnlyVowels()
    {
        Assert.Equal("A000", Soundex.GenerateSoundex("Aeia"));
    }

    [Fact]
    public void HandlesUpperAndLowerCaseLetters()
    {
        Assert.Equal("S530", Soundex.GenerateSoundex("sMiTh"));
    }

    [Fact]
    public void HandlesNamesWithDuplicateConsonants()
    {
        Assert.Equal( "T520", Soundex.GenerateSoundex("Tennessee"));
    }

    [Fact]
    public void HandlesNamesWithNonAlphabeticCharacters()
    {
        Assert.Equal("O540", Soundex.GenerateSoundex("ONeill"));
    }

    [Fact]
    public void HandlesLongNames()
    {
        Assert.Equal("W252", Soundex.GenerateSoundex("Washington"));
    }

    [Fact]
    public void HandlesNamesWithConsonantsMappingToSameSoundexCode()
    {
        Assert.Equal("J250", Soundex.GenerateSoundex("Jackson"));
    }
}
