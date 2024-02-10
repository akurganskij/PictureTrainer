﻿using System.ComponentModel.DataAnnotations.Schema;

public class Image
{
    public int Id { get; set; }
    public string Description { get; set; }


    public int ProblemId { get; set; }
}


public class Tasks
{
    public int Id { get; set; }

    public double x1 { get; set; }
    public double y1 { get; set; }
    public double x2 { get; set; }
    public double y2 { get; set; }

    public string question { get; set; }

    public int ImageId { get; set; }
}

public class Problems
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }
    public string Topic { get; set; }
    public string Grade { get; set; }
    public string Complexity { get; set; }

    public bool EnableTimer { get; set; }
    public int TimerDuration { get; set; }

    public bool Randomise { get; set; }

    public bool LimitAttempts { get; set; }
    public int MaxAttempts { get; set; }

    public int ImageId { get; set; }

}

public class DataProbl
{
    public Problems problems { get; set; }
    public Image image { get; set; }
    public List<Tasks>? tasks { get; set; }
}