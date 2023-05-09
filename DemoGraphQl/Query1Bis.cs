using System.Net;

namespace DemoGraphQl
{
    
    public partial class Query1
    {

        public List<Icecream> MyIcecream()
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
