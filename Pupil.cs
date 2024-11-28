// See https://aka.ms/new-console-template for more information
using System;
public class Pupil
    {
    public virtual void Study()
        { 
        Console.WriteLine("Учится");
        }
    public virtual void Read() 
        {
        Console.WriteLine("Читает");
        }
    public virtual void Write() 
        { 
        Console.WriteLine("Пишет.");
        }
    public virtual void Relax() 
        { 
        Console.WriteLine("Отдыхает.");
        }
    }

public class ExcelentPupil : Pupil
    {
    public override void Study() 
        {
        Console.WriteLine ("Обучение: отлично");
        }
    public override void Read() 
        { 
        Console.WriteLine ("Чтение: быстро"); 
        }
    public override void Write() 
        { 
        Console.WriteLine ("Письмо: разборчиво"); 
        }
    public override void Relax() 
        { 
        Console.WriteLine ("Отдых: мало"); 
        }
    }

public class GoodPupil : Pupil
    {
    public override void Study() 
        {
        Console.WriteLine("Обучение: нормально"); 
        }
    public override void Read() 
        {    
        Console.WriteLine("Чтение: со средей скоростью"); 
        } 
    public override void Write() 
        { 
        Console.WriteLine("Письмо: не очень разборчиво");
        }
    public override void Relax() 
        { 
        Console.WriteLine("Отдых: немного");
        }
    }

public class BadPupil : Pupil
    {
    public override void Study() 
        {
        Console.WriteLine("Обучение: плохо");
        }
    public override void Read() 
        { 
        Console.WriteLine("Чтение: медленно");
        }
    public override void Write() 
        { 
        Console.WriteLine("Письмо: неразборчво");
        }
    public override void Relax() 
        { 
        Console.WriteLine("Отдых: много");
        }
    }   
public class ClassRoom
    {
    private Pupil[] pupils;
    public ClassRoom(params Pupil[] pupils)
        {
        if (pupils.Length < 1 || pupils.Length > 4)
            throw new ArgumentException("Error of students");
        this.pupils = pupils;
        }
    public void PrintSkill()
        {
        foreach (var pupil in pupils)
            {
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
            Console.WriteLine();
            }
        }
    }
class Program
    {
    static void Main(string[] args)
        {
        Pupil pupil1 = new ExcelentPupil();
        Pupil pupil2 = new GoodPupil();
      
        ClassRoom classRoom = new ClassRoom(pupil1, pupil2);
        classRoom.PrintSkill();
        }
    }

