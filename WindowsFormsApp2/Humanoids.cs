using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public abstract class Humanoids
    {
        public abstract void socialize();
    }

    interface ICodeCSharp
    {
        void writeCode();
    }

    interface ISnore
    {
        void snore();
    }
    interface ICanEat
    {
        void Eat();
    }
    interface ISpeakFrench
    {
        void SpeakFrench();
        void Sing();
    }
    interface ICanDance
    {
        void Dance();
    }
}
