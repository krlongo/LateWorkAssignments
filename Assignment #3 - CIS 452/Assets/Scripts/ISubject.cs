/*
 * Kevon Long
 * ISubject.cs
 * Assignment #3
 * The subject interface 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    void registerObserver(IObserver o);

    void removeObserver(IObserver o);

    void notifyObservers();

}
