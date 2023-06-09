namespace Shootinggame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AK47 gun1 = new AK47(30);
            M4 gun2 = new M4(30);
            P92 gun3 = new P92(60);
            AWP gun4 = new AWP(10);
            //Console.WriteLine(gun1.TotalBulletCount);
            Console.WriteLine("        AK47     ");
            gun1.Shoot();
             gun1.Reload();
            Console.WriteLine("       M4     ");
            gun2.Shoot();
            gun2.Reload();
            Console.WriteLine("       P92     ");
            gun3.Shoot();
            gun3.Reload();
           gun3.Zoom();
            Console.WriteLine("       AWP     ");
            gun4.Shoot();
           gun4.Reload();
           gun4.Zoom();
            Console.ReadKey();




        }
    }
}