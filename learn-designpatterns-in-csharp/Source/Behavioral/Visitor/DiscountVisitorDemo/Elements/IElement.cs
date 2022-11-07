using DiscountVisitorDemo.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountVisitorDemo.Elements
{

    /// <summary>
    /// Element
    /// </summary>
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

}
