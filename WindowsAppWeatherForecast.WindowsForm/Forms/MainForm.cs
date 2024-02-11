using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WindowsAppWeatherForecast.WindowsForm.Models;
using WindowsAppWeatherForecast.WindowsForm.Services;

namespace WindowsAppWeatherForecast.WindowsForm
{
    public partial class MainForm : Form
    {
        private SynopticDataService _synopticDataService;
        private List<string> _townsNamesList;
        private List<SynopticDataEntry> _fullSynopticDataList;
        private SynopticDataEntry _townSynopticData;
        private List<TemperatureDataEntry> _townsList;
        private List<PressureDataEntry> _townsPressuresList;
        private List<HumidityDataEntry> _townsHumiditiesList;
        private List<System.Windows.Forms.Control> _townsNamesLabelList;
        private List<System.Windows.Forms.Control> _townsValuesLabelList;
        private List<string> _majorTownsNames;
        private readonly string _messageServerNotResponse = Properties.Settings.Default.MessageServerNotResponse;
        private readonly string _messageNotDataFound = Properties.Settings.Default.MessageNotDataFound;
        private readonly string _authorInfo = Properties.Settings.Default.AuthorInfo;
        private readonly string _happyFace = Properties.Settings.Default.HappyFace;
        private readonly string _sadFace = Properties.Settings.Default.SadFace;
        private readonly string _exitInfo = Properties.Settings.Default.ExitInfo;
        private readonly string _actualizationData = Properties.Settings.Default.ActualizationData;
        private readonly string _loadDate = Properties.Settings.Default.LoadDate;
        private readonly string _temperatureLoaded = Properties.Settings.Default.TemperatudeLoaded;
        private readonly string _pressureLoaded = Properties.Settings.Default.PressureLoaded;
        private readonly string _humidityLoaded = Properties.Settings.Default.HumidityLoaded;


        public MainForm()
        {
            InitializeComponent();
            _synopticDataService = new SynopticDataService();
            LoadNecessaryLists();
            Translate();
            SetadvancedFormatting();
            LoadTownNamesListToComboBox();
            LoadTownsList();
        }

        private void LoadNecessaryLists()
        {
            _majorTownsNames = new List<string>
            {
                "Białystok",
                "Gdańsk",
                "Gorzów",
                "Katowice",
                "Kraków",
                "Lublin",
                "Łódź",
                "Olsztyn",
                "Poznań",
                "Rzeszów",
                "Suwałki",
                "Szczecin",
                "Toruń",
                "Warszawa",
                "Wrocław",
                "Zakopane"
            };

            _townsNamesLabelList = new List<System.Windows.Forms.Control>
            {
                town0Name, town1Name, town2Name, town3Name, town4Name,
                town5Name, town6Name, town7Name, town8Name, town9Name,
                town10Name, town11Name, town12Name, town13Name, town14Name, town15Name
            };

            _townsValuesLabelList = new List<System.Windows.Forms.Control>
            {
                town0Value, town1Value, town2Value, town3Value, town4Value,
                town5Value, town6Value, town7Value, town8Value, town9Value,
                town10Value, town11Value, town12Value, town13Value, town14Value, town15Value
            };
        }

        private void Translate()
        {
            //title
            this.Text = Properties.Settings.Default.AppTitle;
            //menu
            this.actionToolStripMenuItem.Text = Properties.Settings.Default.ActionMenu;
            this.authorToolStripMenuItem.Text = Properties.Settings.Default.AuthorMenu;
            this.exitToolStripMenuItem.Text = Properties.Settings.Default.ExitMenu;
            //tabs
            this.tabPage1.Text = Properties.Settings.Default.FullInfoTab;
            this.tabPage2.Text = Properties.Settings.Default.TownInfoTab;
            this.tabPage3.Text = Properties.Settings.Default.PolandMapTab;
            //buttons
            this.button1.Text = Properties.Settings.Default.GetFullDataButton;
            this.button2.Text = Properties.Settings.Default.GetTemperaturesDataButton;
            this.button3.Text = Properties.Settings.Default.GetPressuresDataButton;
            this.button4.Text = Properties.Settings.Default.GetHumidityDataButton;
            //labels
            this.label1.Text = Properties.Settings.Default.ChooseTownLabel;
            this.label2.Text = Properties.Settings.Default.LoadDataLabel;
            this.label3.Text = "";

        }

        private void SetadvancedFormatting()
        {
            this.panel1.BackgroundImageLayout = ImageLayout.None;
        }

        private void LoadTownNamesListToComboBox()
        {
            try
            {
                _townsNamesList = _synopticDataService.GetTownsList();
                var stringBuilder = new StringBuilder();
                if (_townsNamesList != null)
                {
                    foreach (var item in _townsNamesList)
                    {
                        comboBox1.Items.Add(item);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void LoadFullSynopticDataList()
        {
            try
            {
                _fullSynopticDataList = _synopticDataService.GetListOfSynopticDataForAllTowns();
                var stringBuilder = new StringBuilder();
                if (_fullSynopticDataList != null)
                {
                    var sysdate = DateTime.Now;
                    stringBuilder.AppendLine($"{_actualizationData}: {sysdate}");
                    stringBuilder.AppendLine(null);

                    foreach (var item in _fullSynopticDataList)
                    {
                        stringBuilder.Append(item);
                    }

                    textBox1.Text = stringBuilder.ToString();
                }
                else
                {
                    MessageBox.Show(_messageServerNotResponse);
                    textBox1.Text = _messageNotDataFound;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LoadOneTownSynopticData()
        {
            try
            {
                var choosenValue = comboBox1.SelectedItem.ToString();
                _townSynopticData = _synopticDataService.GetSynopticDataForOneTown(choosenValue);

                if (_townSynopticData != null)
                {
                    this.textBox2.Text = _townSynopticData.ToStringShort();
                }
                else
                {
                    MessageBox.Show(_messageServerNotResponse);
                    textBox2.Text = _messageNotDataFound;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LoadTownsList()
        {
            try
            {
                _townsList = _synopticDataService.GetListOfTemperatureDataForTowns(_majorTownsNames);

                if (_townsList != null)
                {
                    if (_townsList.Count == _townsNamesLabelList.Count && _townsList.Count == _townsValuesLabelList.Count)
                    {
                        for (int i = 0; i < _townsList.Count; i++)
                        {
                            _townsNamesLabelList[i].Text = _townsList[i].Nazwa;
                        }
                    }
                }
                else
                {
                    SetLabelsOnMapWhenServerNotWorks();
                    MessageBox.Show(_messageServerNotResponse);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void LoadTownsTemperaturesList()
        {

            try
            {
                _townsList = _synopticDataService.GetListOfTemperatureDataForTowns(_majorTownsNames);

                if (_townsList != null)
                {
                    if(_townsList.Count == _townsNamesLabelList.Count && _townsList.Count==_townsValuesLabelList.Count)
                    {
                        for (int i = 0; i < _townsList.Count; i++)
                        {
                            _townsNamesLabelList[i].Text = _townsList[i].Nazwa;
                            _townsValuesLabelList[i].Text = _townsList[i].Temperatura;
                        }
                    }

                    this.label3.Text = $"{_temperatureLoaded}\n{_loadDate}: {DateTime.Now}";
                }
                else
                {
                    SetLabelsOnMapWhenServerNotWorks();
                    MessageBox.Show(_messageServerNotResponse);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void LoadTownsPressuresList()
        {
            try
            {
                _townsPressuresList = _synopticDataService.GetListOfPressureDataForTowns(_majorTownsNames);

                if (_townsPressuresList != null)
                {
                    if (_townsPressuresList.Count == _townsNamesLabelList.Count && _townsPressuresList.Count == _townsValuesLabelList.Count)
                    {
                        for (int i = 0; i < _townsPressuresList.Count; i++)
                        {
                            _townsNamesLabelList[i].Text = _townsPressuresList[i].Nazwa;
                            _townsValuesLabelList[i].Text = _townsPressuresList[i].Cisnienie;
                        }
                    }

                    this.label3.Text = $"{_pressureLoaded}\n{_loadDate}: {DateTime.Now}";
                }
                else
                {
                    SetLabelsOnMapWhenServerNotWorks();
                    MessageBox.Show(_messageServerNotResponse);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void LoadTownsHumiditiesList()
        {
            try
            {
                _townsHumiditiesList = _synopticDataService.GetListOfHumidityDataForTowns(_majorTownsNames);

                if (_townsHumiditiesList != null)
                {
                    if (_townsHumiditiesList.Count == _townsNamesLabelList.Count && _townsHumiditiesList.Count == _townsValuesLabelList.Count)
                    {
                        for (int i = 0; i < _townsHumiditiesList.Count; i++)
                        {
                            _townsNamesLabelList[i].Text = _townsHumiditiesList[i].Nazwa;
                            _townsValuesLabelList[i].Text = _townsHumiditiesList[i].Wilgotnosc;
                        }
                    }

                    this.label3.Text = $"{_humidityLoaded}\n{_loadDate}: {DateTime.Now}";
                }
                else
                {
                    SetLabelsOnMapWhenServerNotWorks();
                    MessageBox.Show(_messageServerNotResponse);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFullSynopticDataList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadTownsTemperaturesList();
            button2.BackColor = SystemColors.ControlLight;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadTownsPressuresList();
            button2.BackColor = Color.White;
            button3.BackColor = SystemColors.ControlLight;
            button4.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadTownsHumiditiesList();
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = SystemColors.ControlLight;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadOneTownSynopticData();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var decision = MessageBox.Show(
                _authorInfo,
                authorToolStripMenuItem.Text,
                 MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (decision == DialogResult.Yes)
            {
                MessageBox.Show(_happyFace);
            }
            else
            {
                MessageBox.Show(_sadFace);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var decision = MessageBox.Show(
                _exitInfo,
                this.Text,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            switch (decision)
            {
                case DialogResult.No: e.Cancel = true; break;
                case DialogResult.Yes: break;
                default: e.Cancel = true; break;
            }
        }

        private void SetLabelsOnMapWhenServerNotWorks()
        {
            if (_townsNamesLabelList.Count == _townsValuesLabelList.Count)
            {
                for (int i = 0; i < _townsNamesLabelList.Count; i++)
                {
                    _townsValuesLabelList[i].Text = "???";
                }
            }
        }



    }
}
