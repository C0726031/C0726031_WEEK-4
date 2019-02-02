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
            c.travel();
            //new Test().fortest();//Anonymous Object Reference
            Console.ReadLine();

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
        public village currentvillage { get; private set; }

            public void run()
            {

                Mapple = new village();
                Toronto = new village();
                Ajax = new village();
                Ajax.villagename = "Ajax";
                Ajax.isAstrilde = true;
                Mapple.villagename = "Mapple";
                Mapple.nextvillage = Toronto;
                Toronto.nextvillage = Ajax;
                Toronto.villagename = "Toronto";
                Ajax.nextvillage = null;
        }
        public void travel()
            {
                 currentvillage = Toronto;

            while (true)


            {
                if (currentvillage.isAstrilde)
                {
                    Console.WriteLine(" Astrilde is in: " + currentvillage.villagename);
                    Console.ReadLine();
                }

                else

                    currentvillage = currentvillage.nextvillage;


            }

                }
            }
        }

    


   



