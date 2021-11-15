using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseCrawler
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
            SetupProgressBar();

            // _task = task;
        }

        // TODO: Use void return type instead of dynamic.
        // private readonly Func<Task<dynamic>> _task;

        private readonly int _expectFakeProgressFinishDurationInSeconds = 2;

        private readonly int _expectProgressBarMaxValue = 100;
        private readonly int _expectProgressBarMinValue = 0;
        private readonly int _expectProgressBarStep = 1;

        private void SetupProgressBar()
        {
            ProgressBar.Maximum = _expectProgressBarMaxValue;
            ProgressBar.Minimum = _expectProgressBarMinValue;
            ProgressBar.Step = _expectProgressBarStep;
        }

        private async void StartProgress(int milliSeconds)
        {
            // await Task.Run(() => null);
            if (!ProgressTimer.Enabled)
            {
                ProgressBar.Value = _expectProgressBarMinValue;
                ProgressTimer.Interval = milliSeconds / 100;
                ProgressTimer.Enabled = true;
            }
        }

        private async void ProgressForm_Load(object sender, EventArgs e)
        {
            StartProgress(_expectFakeProgressFinishDurationInSeconds * 1000);
            // await _task?.Invoke();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value < _expectProgressBarMaxValue)
            {
                ProgressBar.Value += _expectProgressBarStep;
                ProgressBar.Refresh();
            }
            else
            {
                ProgressTimer.Enabled = false;
                Close();
            }
        }
    }
}
