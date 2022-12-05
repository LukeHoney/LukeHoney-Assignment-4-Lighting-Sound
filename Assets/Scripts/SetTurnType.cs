using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurn; //refrence to the XR rig snap turn provider
    public ActionBasedContinuousTurnProvider continuousTurn; //refrence to the XR rig continus turn provider

    public void SetTypeFromIndex(int index) //method for selecting turning method
    {
        if(index == 0) //if 'continous turn' is selected
        {
            snapTurn.enabled = false; //turn off snap turn
            //Debug.Log("Snap turn is off");
            continuousTurn.enabled = true; //turn on continous turn
            //Debug.Log("Continuous turn is on");

        }
        else if(index == 1) //if 'Snapturn' is selected
        {
            snapTurn.enabled = true; //turn on snap turn
            //Debug.Log("Snap turn is on");
            continuousTurn.enabled = false; //turn off continous turn
            //Debug.Log("Continuous turn is off");
        }
    }


}
