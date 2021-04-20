using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Shapes.RUS.AreaShapes;

namespace Shapes
{
    public abstract class Shapes
    {
        public virtual double FigureArea()
        {
            return 0;
        }

        public virtual double Gradus()
        {
            return 0;
        }

        public virtual double Length()
        {
            return 0;
        }

        public virtual void Draw() { }

        public virtual void DrawENG() { }
    }

    
}
