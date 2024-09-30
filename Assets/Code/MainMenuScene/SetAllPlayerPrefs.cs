//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAllPlayerPrefs : MonoBehaviour
{
    //this function ensures all values in the playerprefs library are initialized properly
    public void SetPrefs()
    {
        if (PlayerPrefs.HasKey("Coins") == false)
        {
            SetInt("Coins", 8000);
        }
        if (PlayerPrefs.HasKey("PlayerScore") == false)
        {
            SetInt("PlayerScore", 0);
        }
        if (PlayerPrefs.HasKey("ComputerScore") == false)
        {
            SetInt("ComputerScore", 0);
        }
        if (PlayerPrefs.HasKey("TimeShootButtonHeldFor") == false)
        {
            SetFloat("TimeShootButtonHeldFor", 0f);
        }
        if (PlayerPrefs.HasKey("WariorsOwned") == false)
        {
            SetString("WariorsOwned", "False");
        }
        if (PlayerPrefs.HasKey("MavericsOwned") == false)
        {
            SetString("MavericsOwned", "False");
        }
        if (PlayerPrefs.HasKey("ClipersOwned") == false)
        {
            SetString("ClipersOwned", "False");
        }
        if (PlayerPrefs.HasKey("RockethsOwned") == false)
        {
            SetString("RockethsOwned", "False");
        }
        if (PlayerPrefs.HasKey("NugethsOwned") == false)
        {
            SetString("NugethsOwned", "False");
        }
        if (PlayerPrefs.HasKey("KelticsOwned") == false)
        {
            SetString("KelticsOwned", "False");
        }
        if (PlayerPrefs.HasKey("BulsOwned") == false)
        {
            SetString("BulsOwned", "False");
        }
        if (PlayerPrefs.HasKey("HeathOwned") == false)
        {
            SetString("HeathOwned", "False");
        }
        if (PlayerPrefs.HasKey("NethsOwned") == false)
        {
            SetString("NethsOwned", "False");
        }
        if (PlayerPrefs.HasKey("HornethsOwned") == false)
        {
            SetString("HornethsOwned", "False");
        }
        if (PlayerPrefs.HasKey("SelectedTeam") == false)
        {
            SetString("SelectedTeam", "");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForWariors") == false)
        {
            SetString("NotEnoughCoinsForWariors", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForMaverics") == false)
        {
            SetString("NotEnoughCoinsForMaverics", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForClipers") == false)
        {
            SetString("NotEnoughCoinsForClipers", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForRockeths") == false)
        {
            SetString("NotEnoughCoinsForRockeths", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForNugeths") == false)
        {
            SetString("NotEnoughCoinsForNugeths", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForKeltics") == false)
        {
            SetString("NotEnoughCoinsForKeltics", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForBuls") == false)
        {
            SetString("NotEnoughCoinsForBuls", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForHeath") == false)
        {
            SetString("NotEnoughCoinsForHeath", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForNeths") == false)
        {
            SetString("NotEnoughCoinsForNeths", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForHorneths") == false)
        {
            SetString("NotEnoughCoinsForHorneths", "False");
        }
        if (PlayerPrefs.HasKey("Block") == false)
        {
            SetString("Block", "");
        }
        if (PlayerPrefs.HasKey("Shoot") == false)
        {
            SetString("Shoot", "");
        }
        if (PlayerPrefs.HasKey("ComputerState") == false)
        {
            SetString("ComputerState", "");
        }
        if (PlayerPrefs.HasKey("PlayerState") == false)
        {
            SetString("PlayerState", "");
        }
        if (PlayerPrefs.HasKey("Distance") == false)
        {
            SetString("Distance", "");
        }
        if (PlayerPrefs.HasKey("OpponentShoot") == false)
        {
            SetString("OpponentShoot", "");
        }
        if (PlayerPrefs.HasKey("InvokedTimes") == false)
        {
            SetInt("InvokedTimes", 0);
        }
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetFloat(string Keyname, float Value)
    {
        PlayerPrefs.SetFloat(Keyname, Value);
    }
}
