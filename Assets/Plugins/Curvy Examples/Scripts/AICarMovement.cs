using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FluffyUnderware.Curvy.Examples;
using FluffyUnderware.Curvy.Controllers;
public class AICarMovement : MonoBehaviour
{
    public SplineController sp_Controller;
   // public float car_Speed;
   // public CarNum car_Num;
    public int car_Id;
    public void SpeedExceed(float speed)
    {
        sp_Controller.Speed = sp_Controller.Speed+ speed;
    }
}
//public enum CarNum { car1, car2, car3, car4 };