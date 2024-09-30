//import libraries
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ComputerizedOpponentMovement : MonoBehaviour
{
    //initialize variables
    public string ComputerState;
    public GameObject ComputerizedOpponent;
    public GameObject Basketball;
    public GameObject OpponentHoop;
    public float XPositionDifference;
    public float YPositionDifference;
    public float NeededDirectionalAngle;
    public float RatioForInverseTangentFunction;
    public float Distance;
    public string DistanceAsString;
    public string DistanceFromPlayerPrefs;
    public float PlayerPrefsDistance;
    public int NumberOfTimesInvoked;
    public Button ShootButtonForOpponent;

    //this function is called once per frame update
    //this function moves the computer character towards their hoop when on offense and towards the ball when on defense
    public void Update()
    {
        ComputerState = GetString("ComputerState");

        if (ComputerState == "Offense")
        {
            Vector3 HoopCurrentPosition = transform.position;
            HoopCurrentPosition.x = OpponentHoop.GetComponent<Transform>().position.x;
            HoopCurrentPosition.y = OpponentHoop.GetComponent<Transform>().position.y;

            Vector3 ComputerizedOpponentCurrentPosition = transform.position;
            ComputerizedOpponentCurrentPosition.x = ComputerizedOpponent.GetComponent<Transform>().position.y;
            ComputerizedOpponentCurrentPosition.y = ComputerizedOpponent.GetComponent<Transform>().position.x;

            YPositionDifference = ComputerizedOpponentCurrentPosition.x + (-1 * HoopCurrentPosition.y);
            XPositionDifference = HoopCurrentPosition.x - ComputerizedOpponentCurrentPosition.y;

            RatioForInverseTangentFunction = YPositionDifference / XPositionDifference;
            if (XPositionDifference < 0 && YPositionDifference < 0)
            {
                NeededDirectionalAngle = (Mathf.Rad2Deg*Mathf.Atan(RatioForInverseTangentFunction)) + 180;
            }
            else if (XPositionDifference > 0 && YPositionDifference < 0)
            {
                NeededDirectionalAngle = (Mathf.Rad2Deg*Mathf.Atan(RatioForInverseTangentFunction));
            }
            else if (XPositionDifference < 0 && YPositionDifference > 0)
            {
                NeededDirectionalAngle = (Mathf.Rad2Deg*Mathf.Atan(RatioForInverseTangentFunction)) + 180;
            }
            else if (XPositionDifference > 0 && YPositionDifference > 0)
            {
                NeededDirectionalAngle = (Mathf.Rad2Deg*Mathf.Atan(RatioForInverseTangentFunction));
            }

            ComputerizedOpponent.transform.rotation = Quaternion.Euler(NeededDirectionalAngle, 90, 270);

            Distance = Mathf.Sqrt((XPositionDifference * XPositionDifference) + (YPositionDifference * YPositionDifference));
            if (Distance > 7)
            {
                ComputerizedOpponent.transform.Translate(Vector3.forward * Time.deltaTime * 4, Space.Self);
            }
            else if (Distance <= 7)
            {
                DistanceAsString = Distance.ToString();
                SetString("Distance", DistanceAsString);
            }

            DistanceFromPlayerPrefs = GetString("Distance");
            try
            {
                PlayerPrefsDistance = (float)Convert.ToDecimal(DistanceFromPlayerPrefs, CultureInfo.GetCultureInfo("en-US"));
            }
            catch
            {
            }

            if (PlayerPrefsDistance <= 7 && PlayerPrefsDistance != 0)
            {
                NumberOfTimesInvoked = GetInt("InvokedTimes");
                if (NumberOfTimesInvoked == 0)
                {
                    ShootButtonForOpponent.onClick.Invoke();
                    PlayerPrefs.SetInt("InvokedTimes", 1);
                }
            }
        }

        else if (ComputerState == "Defense")
        {
            Vector3 BallCurrentPosition  = transform.position;
            BallCurrentPosition.x = Basketball.GetComponent<Transform>().position.x;
            BallCurrentPosition.y = Basketball.GetComponent<Transform>().position.y;

            Vector3 ComputerizedOpponentCurrentPosition = transform.position;
            ComputerizedOpponentCurrentPosition.x = ComputerizedOpponent.GetComponent<Transform>().position.x;
            ComputerizedOpponentCurrentPosition.y = ComputerizedOpponent.GetComponent<Transform>().position.y;

            XPositionDifference = BallCurrentPosition.x - ComputerizedOpponentCurrentPosition.x;
            YPositionDifference = ComputerizedOpponentCurrentPosition.y - BallCurrentPosition.y;

            RatioForInverseTangentFunction = YPositionDifference / XPositionDifference;
            if (XPositionDifference < 0 && YPositionDifference < 0)
            {
                NeededDirectionalAngle = (Mathf.Rad2Deg*Mathf.Atan(RatioForInverseTangentFunction)) + 180;
            }
            else if (XPositionDifference > 0 && YPositionDifference < 0)
            {
                NeededDirectionalAngle = (Mathf.Rad2Deg*Mathf.Atan(RatioForInverseTangentFunction));
            }
            else if (XPositionDifference < 0 && YPositionDifference > 0)
            {
                NeededDirectionalAngle = (Mathf.Rad2Deg*Mathf.Atan(RatioForInverseTangentFunction)) + 180;
            }
            else if (XPositionDifference > 0 && YPositionDifference > 0)
            {
                NeededDirectionalAngle = (Mathf.Rad2Deg*Mathf.Atan(RatioForInverseTangentFunction));
            }

            ComputerizedOpponent.transform.rotation = Quaternion.Euler(NeededDirectionalAngle, 90, 270);

            Distance = Mathf.Sqrt((XPositionDifference * XPositionDifference) + (YPositionDifference * YPositionDifference));
            if (Distance > 4)
            {
                ComputerizedOpponent.transform.Translate(Vector3.forward * Time.deltaTime * 4, Space.Self);
            }
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }
}