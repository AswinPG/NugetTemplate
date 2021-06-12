using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.Feature1
{
    public interface IImageResizer
    {
        byte[] ResizeHeight(float toHeight, byte[] Image);
        byte[] ResizeWidth(float toWidth, byte[] Image);
        byte[] Resize(float toHeight, float toWidth, byte[] Image);
    }
}
