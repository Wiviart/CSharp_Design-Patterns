using System;
using System.Collections.Generic;

// Observer interface
public abstract class Observer
{
    public abstract void Update(Subject theChangedSubject);
}

// Subject interface
public abstract class Subject
{
    private List<Observer> _observers = new List<Observer>();

    public void Attach(Observer o)
    {
        _observers.Add(o);
    }

    public void Detach(Observer o)
    {
        _observers.Remove(o);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
}

// Concrete subject: ClockTimer
public class ClockTimer : Subject
{
    private int _hour;
    private int _minute;
    private int _second;

    public int GetHour() => _hour;
    public int GetMinute() => _minute;
    public int GetSecond() => _second;

    public void Tick()
    {
        _second++;
        if (_second % 60 == 0)
        {
            _minute++;
            if (_minute % 60 == 0)
            {
                _hour++;
                _minute = 0;
            }
            _second = 0;
        }

        Notify();
    }
}

// Concrete observer: DigitalClock
public class DigitalClock : Observer
{
    private ClockTimer _subject;

    public DigitalClock(ClockTimer subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }

    public override void Update(Subject theChangedSubject)
    {
        if (theChangedSubject == _subject)
        {
            Draw();
        }
    }

    public void Draw()
    {
        // Get the new values from the subject
        int hour = _subject.GetHour();
        int minute = _subject.GetMinute();
        int second = _subject.GetSecond();
        // etc.

        // Draw the digital clock
        Console.WriteLine($"Digital Clock: {hour}:{minute}:{second}");
    }
}

// Concrete observer: AnalogClock
public class AnalogClock : Observer
{
    private ClockTimer _subject;

    public AnalogClock(ClockTimer subject)
    {
        _subject = subject;
        _subject.Attach(this);
    }

    public override void Update(Subject theChangedSubject)
    {
        if (theChangedSubject == _subject)
        {
            Draw();
        }
    }

    public void Draw()
    {
        int hour = _subject.GetHour();
        int minute = _subject.GetMinute();
        int second = _subject.GetSecond();
        // Draw the analog clock
        Console.WriteLine($"Analog Clock: {hour}:{minute}:{second}");
    }
}

// Program to demonstrate the Observer pattern
class Program
{
    static void Main()
    {
        ClockTimer timer = new ClockTimer();
        AnalogClock analogClock = new AnalogClock(timer);
        DigitalClock digitalClock = new DigitalClock(timer);

        while (true)
        {
            timer.Tick();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
