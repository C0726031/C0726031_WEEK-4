using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0726031
{
    class Program
    {
        static void Main(string[] args)

        {
            countryside c = new countryside();
            c.run();

        }


   }
    class LearningExperiment
    {
        public void run() {

            village Toronto;
            Toronto = new village();
            village a, b, c;
            Toronto.villagename = "Version A";
            a = Toronto;
            Toronto = new village();
            Toronto.villagename = "Version B";
            b = Toronto;
            Toronto = new village();
            Toronto.villagename = "Version C";
            c = Toronto;
            Console.WriteLine(a.villagename);
        }
    }
        class village

        {
            public bool isAstrilde;
            public village nextvillage;
            public village prevvillage;
            public String villagename;

        }
        class countryside
        {
            village Mapple;
            village Toronto;
            village Ajax;

            public void run()
            {

                Mapple = new village();
                Toronto = new village();
                Ajax = new village();
                Ajax.isAstrilde = true;
                Mapple.villagename = "Toronto";
                Mapple.nextvillage = Toronto;

            }
            public void travel()
            {
                village currentvillage = Toronto;
                while (currentvillage.isAstrilde) {
                    if (currentvillage.isAstrilde)
                        Console.WriteLine("You found Astrilde in " + currentvillage);
                    else
                        currentvillage = currentvillage.nextvillage;

                }
            }
        }
    }
}

   



