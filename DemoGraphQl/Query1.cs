using System.Net;

namespace DemoGraphQl
{
    
    public partial class Query1
    {

        public Flavours GetFlavours()
        {

            return new Flavours
            {
                Style1 = "vanilla",
                Style2 = "choco",

                Icecream = new Icecream
                {
                    Ic1 = "cone",
                    Ic2 = "flat"
                },

                Toppings = new Toppings
                {
                    tp1 = 1,
                    tp2 = 2
                }

            };


        }


    }
}
