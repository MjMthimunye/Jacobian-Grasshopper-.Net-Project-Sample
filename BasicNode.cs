using Grasshopper.Kernel;
using Rhino.Geometry;

namespace Jacobian.Grasshopper
{
    public class BasicNode : GH_Component
    {
        public BasicNode()
            : base("Basic Node", "BasicNode",
                "A basic Grasshopper node example",
                "Jacobian", "Examples")
        {
        }

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("Number", "N", "Input number", GH_ParamAccess.item);
            pManager.AddPointParameter("Point", "P", "Input point", GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddNumberParameter("Doubled", "2N", "Input number multiplied by 2", GH_ParamAccess.item);
            pManager.AddPointParameter("Moved Point", "MP", "Point moved by the input number", GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            double number = 0;
            Point3d point = Point3d.Origin;

            // Get input data
            if (!DA.GetData(0, ref number)) return;
            if (!DA.GetData(1, ref point)) return;

            double doubled = number * 2;
            Point3d movedPoint = new Point3d(point.X + number, point.Y + number, point.Z + number);

            // Set output data
            DA.SetData(0, doubled);
            DA.SetData(1, movedPoint);
        }

        protected override System.Drawing.Bitmap Icon => Resources.jacobian32;

        public override Guid ComponentGuid => new Guid("12345678-1234-1234-1234-123456789012");
    }
}
