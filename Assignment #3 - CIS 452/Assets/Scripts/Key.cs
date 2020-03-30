/*
 * Kevon Long
 * Key.cs
 * Assignment #3
 * The subject object that sends an update to the door observers
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Key : MonoBehaviour, ISubject
{

    private List<IObserver> observers;

    /*public bool unlocked
    {
        get { return _unlocked; }
        set
        {
            _unlocked = true;
            notifyObservers();
        }
    }
        private bool _unlocked;*/



    public Key()
    {
        observers = new List<IObserver>();
    }

    public void registerObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void removeObserver(IObserver o)
    {
        int i = observers.IndexOf(o);
        if (i >= 0)
        {
            observers.RemoveAt(i);
        }
    }

    public void notifyObservers()
    {
        Debug.Log("notifying observers");
        observers.ForEach(o =>
        {

            o.UpdateData(this);
        });
    }





    public void hasbeenUnlocked()
    {
        Debug.Log("has been unlocked");
        notifyObservers();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(observers);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
