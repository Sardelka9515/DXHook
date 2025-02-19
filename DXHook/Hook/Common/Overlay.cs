﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXHook.Hook.Common
{
    [Serializable]
    public class Overlay: IOverlay
    {
        List<IOverlayElement> _elements = new List<IOverlayElement>();
        public virtual List<IOverlayElement> Elements
        {
            get { return _elements; }
            set { _elements = value; }
        }

        public virtual bool Hidden
        {
            get;
            set;
        }

        public virtual void Frame()
        {
            foreach (var element in Elements)
            {
                element.Frame();
            }
        }

        public virtual object Clone()
        {
            return MemberwiseClone();
        }
    }
}
