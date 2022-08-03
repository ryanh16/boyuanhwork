using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int Health;
    [SerializeField]
    private int MaxHealth;
    [SerializeField]
    private int Level;
    [SerializeField]
    private int EXP;

    private static Player Instance;
}
