using System;
using System.Collections.Generic;
using System.Text;

public class Soundex
{
    public static string GenerateSoundex(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return string.Empty;
        }

        StringBuilder soundex = new StringBuilder();
        soundex.Append(char.ToUpper(name[0]));

        AppendSoundexCodes(name, soundex);

        CheckSoundexAppend(soundex);

        return soundex.ToString();
    }

    private static void AppendSoundexCodes(string name, StringBuilder soundex)
    {
        char prevCode = GetSoundexCode(name[0]);

        for (int i = 1; i < name.Length && soundex.Length < 4; i++)
        {
            char code = GetSoundexCode(name[i]);
            if (IsCodeValid(code, prevCode))
            {
                soundex.Append(code);
                prevCode = code;
            }
        }
    }


    private static bool IsCodeValid(char code, char prevCode)
    {
        return code != '0' && code != prevCode;
    }

    private static void CheckSoundexAppend(StringBuilder soundex)
    {
        while (soundex.Length < 4)
        {
            soundex.Append('0');
        }
    }

    private static readonly Dictionary<char, char> SoundexMap = new Dictionary<char, char>
    {
        {'B', '1'}, {'F', '1'}, {'P', '1'}, {'V', '1'},
        {'C', '2'}, {'G', '2'}, {'J', '2'}, {'K', '2'}, {'Q', '2'}, {'S', '2'}, {'X', '2'}, {'Z', '2'},
        {'D', '3'}, {'T', '3'},
        {'L', '4'},
        {'M', '5'}, {'N', '5'},
        {'R', '6'}
    };

    private static char GetSoundexCode(char c)
    {
        c = char.ToUpper(c);
        return SoundexMap.TryGetValue(c, out char code) ? code : '0';
    }
}
