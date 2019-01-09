using System.Drawing.Drawing2D;
using System.Drawing;

namespace Svg
{
    /// <summary>
    /// Represents an element that is using a GraphicsPath as rendering base.
    /// </summary>
    public abstract class SvgPathBasedElement : SvgVisualElement
    {
        public override RectangleF Bounds
        {
            get
            {
                var path = this.Path(null);
                if (Transforms != null && Transforms.Count > 0)
                {
                    path = (GraphicsPath)path.Clone();
                    path.Transform(Transforms.GetMatrix());
                }
                return path.GetBounds();
            }
        }
    }
}
