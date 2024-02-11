using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsAppWeatherForecast.WindowsForm.Services;
using WindowsAppWeatherForecast.WindowsForm.Models;

namespace WindowsAppWeatherForecast.WindowsForm.Forms
{
    public partial class Splashscreen : Form
    {
        private StatusResponseEntry _serverStatusResponseEntry;
        private SynopticDataService _synopticDataService;
        private int _timerTick;
        private readonly string _messageServerNotWorks = Properties.Settings.Default.MessageServerNotWorks;
        private readonly string _serverStatusOk = Properties.Settings.Default.ServerStatusOk;


        public Splashscreen()
        {
            InitializeComponent();
            _synopticDataService = new SynopticDataService();
            StartTimer();
            SetLabels();
        }

        private void SetLabels()
        {
            this.titleLabel.Text = Properties.Settings.Default.AppTitle;
            this.serverStatusLabel.Text = Properties.Settings.Default.CheckingAccess;
            this.authorLabel.Text = Properties.Settings.Default.AuthorLabel;
        }

        private void CheckServerAvibility()
        {
            try
            {
                _serverStatusResponseEntry = _synopticDataService.CheckPublicServerAvibility();

                if (_serverStatusResponseEntry!= null)
                {
                    this.serverStatusLabel.Text = _serverStatusResponseEntry.StatusInformation;
                    if(_serverStatusResponseEntry.StatusCode == _serverStatusOk)
                    {
                        this.serverStatusLabel.ForeColor = Color.Green;
                    }
                    else
                    {
                        this.serverStatusLabel.ForeColor = Color.Red;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void StartTimer()
        {
            _timerTick = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timerTick += 1;

            if (_timerTick == 2)
            {
                CheckServerAvibility();
            }

            if (_timerTick >= 5)
            {
                if (_serverStatusResponseEntry != null && _serverStatusResponseEntry.StatusCode == _serverStatusOk)
                {
                    timer1.Stop();
                    Close();
                }

                if (_timerTick > 5)
                {
                    this.serverStatusLabel.Text = _messageServerNotWorks;
                    this.serverStatusLabel.ForeColor = Color.Red;
                }

                if (_timerTick >= 8 || _serverStatusResponseEntry != null && _serverStatusResponseEntry.StatusCode != _serverStatusOk)
                {
                    timer1.Stop();
                    Application.Exit();
                }
               
            }
           
        }

    }


}
