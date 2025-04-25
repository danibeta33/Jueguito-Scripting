using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;

public class reiniciarLogros : MonoBehaviour
{
    public void reiniciarLogro()
    {

        MMAchievementManager.ResetAchievements("AchievementList");
    }

}
