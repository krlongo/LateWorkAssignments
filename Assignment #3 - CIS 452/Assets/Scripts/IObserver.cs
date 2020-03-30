/*
 * Kevon Long
 * IObserver.cs
 * Assignment #3
 * The observer interface that tells observers to update their data
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    void UpdateData(bool unlocked);
}
