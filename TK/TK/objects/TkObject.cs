using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TK.objects
{
    public abstract class TkObject
	{
        public TkObject()
        { 
        }

        public abstract void Render();


	}


    public class TkObjectList : TkObject
    {
        public TkObjectList()
        { 
        }

        public void Add(TkObject obj)
        {
 
        }

        public override void Render()
        {
            throw new NotImplementedException();
        }
    }
}
