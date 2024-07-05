using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RomanNumerals : MonoBehaviour
{
    [Header("this Script Was Made by pugls")]
    [Header("this Script is an example so sorry if its messy")]
    [Header("Discord.gg/pugls")]
    public int WhatUWantToDisplayInRomanNumerals;
    public TextMeshPro Text;
    public float TiemBeforeTextChange;

    void Start() // bassically when u play it converts it to the roman numeral and sets the text to it.
    {
        Text.text = ConvertToRoman(WhatUWantToDisplayInRomanNumerals);
    }

    string ConvertToRoman(int number) // btw none of this is gpt i have comments so i can teach u guys how it works lmao
    {
        if (number < 0) return string.Empty;
        if (number == 0) return "N";
        var sb = new System.Text.StringBuilder();
        var values = new[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        var numerals = new[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        for (int i = 0; i < 13; i++)
        {
            while (number >= values[i])
            {
                number -= values[i];
                sb.Append(numerals[i]);
            }
        }
        return sb.ToString();
    }
}
