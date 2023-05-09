using System.Runtime.CompilerServices;

namespace DemoGraphQl
{
    public static class Query1Extensions
    {
        public static List<Icecream> MyIcecream(this Query1 myQuery1)
        {
            var best = new List<Icecream>
             {
                  new Icecream{Ic1="babana", Ic2="chocolate"},
                  new Icecream{Ic1="babana2", Ic2="chocolate2"}
             };


            return best;
        }
    }
}
