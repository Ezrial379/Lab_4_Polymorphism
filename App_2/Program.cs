using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_2
{
    internal class Pupils
    {

        static void Main(string[] args)
        {

            ClassRoom classRoom = new ClassRoom();

            ExcelentPupil excelentPupil = new ExcelentPupil();
            GoodPupil goodPupil = new GoodPupil();
            StandartPupil standartPupil = new StandartPupil();
            BadPupil badPupil = new BadPupil();

            classRoom.Entrie(excelentPupil);
            classRoom.Entrie(goodPupil);
            classRoom.Entrie(standartPupil);
            classRoom.Entrie(badPupil);

        }


        class ClassRoom
        {

            public void Entrie(Pupil pupil)
            {

                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();

            }

        }

        abstract class Pupil
        {

            public abstract void Study();

            public abstract void Read();

            public abstract void Write();

            public abstract void Relax();

        }


        class ExcelentPupil : Pupil
        {

            public override void Study()
            {
                Console.WriteLine("\nThe pupil studies perfectly");
            }

            public override void Read()
            {
                Console.WriteLine("The pupil reads perfectly");
            }

            public override void Write()
            {
                Console.WriteLine("The pupil writes perfectly");
            }

            public override void Relax()
            {
                Console.WriteLine("The pupil relaxes well\n");
            }

        }

        class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine("\nThe pupil studies well");
            }

            public override void Read()
            {
                Console.WriteLine("The pupil reads well");
            }

            public override void Write()
            {
                Console.WriteLine("The pupil writes well");
            }

            public override void Relax()
            {
                Console.WriteLine("The pupil doesn`t relax much\n");
            }

        }

        class StandartPupil : Pupil
        {

            public override void Study()
            {
                Console.WriteLine("\nThe pupil studies normally");
            }

            public override void Read()
            {
                Console.WriteLine("The pupil reads well");
            }

            public override void Write()
            {
                Console.WriteLine("The pupil writes normally");
            }

            public override void Relax()
            {
                Console.WriteLine("The pupil relaxes a lot\n");
            }


        }


        class BadPupil : Pupil
        {

            public override void Study()
            {
                Console.WriteLine("\nThe pupil studies bad");
            }

            public override void Read()
            {
                Console.WriteLine("The pupil reads bad");
            }

            public override void Write()
            {
                Console.WriteLine("The pupil writes bad");
            }

            public override void Relax()
            {
                Console.WriteLine("Mode: chilling all the time\n");
            }


        }


    }


}
