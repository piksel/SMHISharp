using Piksel.SMHISharp.Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piksel.SMHISharp.Example
{
    public partial class FormSMHISharpExample : Form
    {
        ApiClient _smhi;

        public FormSMHISharpExample()
        {
            InitializeComponent();

            _smhi = new ApiClient();

            wizard.PageDisplayed(tpParameters, (prev) =>
            {
                if(!prev)
                    _smhi.GetResources(res => objectListView1.SetObjects(res));
            });

            wizard.NextFunction(tpParameters, () => objectListView1.SelectedIndex != -1);

            wizard.PageDisplayed(tpStations, (prev) =>
            {
                var resource = objectListView1.SelectedObject as Resource;
                if (resource == null) return;

                if (!prev)
                    _smhi.GetStations(resource.Key, stations => objectListView2.SetObjects(stations));
            });
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            wizard.UpdateState();
        }

        private void wizard_LastButtonClicked(object sender, EventArgs e)
        {
            Close();
        }
    }
}