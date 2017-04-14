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
        private Station[] _stations;

        public FormSMHISharpExample()
        {
            InitializeComponent();

            _smhi = new ApiClient();

            wizard.PageDisplayed(tpParameters, (prev) =>
            {
                if (!prev)
                {
                    pLoadParameters.Visible = true;
                    olvParameters.Visible = false;
                    _smhi.GetResources(res =>
                    {
                        olvParameters.SetObjects(res);
                        pLoadParameters.Visible = false;
                        olvParameters.Visible = true;
                    });
                }
            });

            wizard.NextFunction(tpParameters, () => olvParameters.SelectedIndex != -1);

            wizard.PageDisplayed(tpStations, (prev) =>
            {
                var resource = olvParameters.SelectedObject as Resource;
                if (resource == null) return;

                if (!prev)
                {
                    pLoadStations.Visible = true;
                    scStations.Visible = false;
                    _smhi.GetStations(resource.Key, stations => {
                        _stations = stations;
                        olvStations.SetObjects(stations);
                        pLoadStations.Visible = false;
                        scStations.Visible = true;
                    });
                }
            });

            wizard.NextFunction(tpStations, () => olvStations.SelectedIndex != -1);

            wizard.PageDisplayed(tpPeriods, (prev) =>
            {
                var resource = olvParameters.SelectedObject as Resource;
                var station = olvStations.SelectedObject as Station;

                if (station == null || resource == null) return;

                if (!prev)
                {
                    pLoadPeriods.Visible = true;
                    olvPeriods.Visible = false;
                    _smhi.GetPeriods(resource.Key, station.Key, periods =>
                    {
                        olvPeriods.SetObjects(periods);
                        pLoadPeriods.Visible = false;
                        olvPeriods.Visible = true;
                    });
                }
            });

            wizard.NextFunction(tpPeriods, () => olvPeriods.SelectedIndex != -1);

            wizard.PageDisplayed(tpData, (prev) =>
            {
                var resource = olvParameters.SelectedObject as Resource;
                var station = olvStations.SelectedObject as Station;
                var period = olvPeriods.SelectedObject as PeriodResult;

                if (station == null || resource == null || period == null) return;

                if (!prev)
                {
                    pLoadData.Visible = true;
                    chartData.Visible = false;
                    
                    _smhi.GetData(resource.Key, station.Key, period.Key, (dataPoints, exception) => {
                        if (exception == null)
                        {
                            chartData.Series[0].Points.Clear();
                            foreach (var dataPoint in dataPoints)
                                chartData.Series[0].Points.AddXY(dataPoint.Date.LocalDateTime, dataPoint.Value);
                            pLoadData.Visible = false;
                            chartData.Visible = true;
                            chartData.Update();
                        }
                        else
                        {
                            MessageBox.Show("Error getting data: " + exception.Message, "Error getting data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pLoadData.Visible = false;
                        }
                    });
                }
            });
        }

        private void StateControlChanged(object sender, EventArgs e)
        {
            wizard.UpdateState();
        }

        private void wizard_LastButtonClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void bFindNearest_Click(object sender, EventArgs e)
        {
            var oldThresh = TimeSpan.FromDays(7);

            double lng, lat;
            if(_stations != null && double.TryParse(tbLongitude.Text, out lng) && double.TryParse(tbLatitude.Text, out lat))
            {
                Station bestStation = null;
                double bestDelta = double.MaxValue;
                double delta = double.MaxValue;

                foreach(var station in _stations)
                {
                    if (bestStation == null || (
                        (delta = (Math.Abs(lng - station.Longitude)+ Math.Abs(lat - station.Latitude))) < bestDelta
                        && (!cbExcludeOld.Checked || DateTimeOffset.Now - station.Updated < oldThresh)))
                    {
                        bestStation = station;
                        bestDelta = delta;
                    }
                }

                olvStations.SelectedObject = bestStation;
                olvStations.SelectedItem.EnsureVisible();
            }
        }
    }
}