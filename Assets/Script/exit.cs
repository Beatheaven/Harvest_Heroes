using UnityEngine;
using System.Collections;

// Quits the player when the user hits escape

public class Exit : MonoBehaviour
{
   public void closegame()
    {
      Application.Quit();
    }
}