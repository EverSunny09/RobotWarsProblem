using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWarsProblem.Services.Interfaces
{
    public interface IPosition
    {
        void StartMoving(List<int> maxPoints, string moves);
    }
}
