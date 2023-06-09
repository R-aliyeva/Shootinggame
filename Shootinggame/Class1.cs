using Shootinggame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Shootinggame


{

    public class InsufficientBulletCountException : Exception
    {
       public InsufficientBulletCountException() : base("you can't shoot") 
        {
        
        }

    }
    public class InvalidBulletCountException : Exception

    {
        public InvalidBulletCountException() : base("Total bullet count can't be zero or less than zero") { }

    }
    public abstract class Gun
    {
        public int TotalBulletCount { get; set; }
        public int CurrentBulletCount { get; set; }
        public Gun(int totalbulletcount)
        {

            try
            {
                if (totalbulletcount <= 0) { throw new InvalidBulletCountException(); }
                TotalBulletCount = totalbulletcount;
            }
            catch (InvalidBulletCountException ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public virtual void Shoot()
        {
            CurrentBulletCount = TotalBulletCount;
            try
            {
                if (CurrentBulletCount == 0)
                { throw new InsufficientBulletCountException(); }
                CurrentBulletCount--;
                Console.WriteLine(this.ToString() + " gun is shooting...");
                Console.WriteLine(this.ToString() + " current bullet count is " + CurrentBulletCount);
            }
            catch (InsufficientBulletCountException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public virtual void Reload()

        {
            
            CurrentBulletCount=TotalBulletCount;

            Console.WriteLine(this.ToString() + " gun is reloading " + CurrentBulletCount);
        }

    }
    public interface IGun
    {
        public void Zoom();


    }
    public class M4 : Gun
    {
        public M4(int totalbulletcount) : base(totalbulletcount)
        {
        }
  

    }


}
public class AK47 : Gun
{


    public AK47(int totalbulletcount) : base(totalbulletcount)
    {

    }
    
  

}
public class P92 : Gun, IGun
{

    public P92(int totalbulletcount) : base(totalbulletcount)
    {


    }
   
    public void Zoom()
    {
        Console.WriteLine(this.ToString() + " is zooming");
    }
}
public class AWP : Gun, IGun
{
    public AWP(int totalbulletcount) : base(totalbulletcount) { }
   


    public void Zoom()
    {
        Console.WriteLine(this.ToString() + " is zooming");
    }
}



