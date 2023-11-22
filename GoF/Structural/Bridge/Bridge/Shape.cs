using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal abstract class Shape
    {
        protected IRenderer renderer;
        protected Shape(IRenderer renderer)
        {
            this.renderer = renderer ?? throw new ArgumentNullException(nameof(renderer));
        }
        public abstract void Draw();
        public abstract void Resize(float factor);
    }
}
