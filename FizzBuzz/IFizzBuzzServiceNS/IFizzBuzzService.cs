using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFizzBuzzServiceNS
{
    public class IFizzBuzzService
    {
        public IFizzBuzzService()
        {

        }

        public bool DivisibleBy(int count, int divider)
        {
            return (count % divider) == 0 ? true : false;

            //if(count % divider == 0)
            //    return true;
            //else
            //    return false;
        }
    }
}
