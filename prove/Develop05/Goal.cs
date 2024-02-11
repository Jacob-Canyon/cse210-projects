﻿namespace Develop05;

public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected string _points = "";
    protected string _checkbox = "[ ]";

    //public Goal(string name, string description, string points)
    //{
        //_shortName = name;
        //_description = description;
        //_points = points;
    //}

    public abstract void RecordEvent();

    public abstract void IsComplete();

    public virtual int GetPoints()
    {
        int addPoints = int.Parse(_points);
        return addPoints;

    }

    public virtual string GetDetailsString()
    {

        return $"{_checkbox} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}
