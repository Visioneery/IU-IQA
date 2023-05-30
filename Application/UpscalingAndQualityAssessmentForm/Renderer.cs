using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UpscalingAndQualityAssessmentForm
{
    public class Renderer : ToolStripProfessionalRenderer
    {

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderMenuItemBackground(e);
            e.Item.BackColor = Color.Black;
        }
    }
}
