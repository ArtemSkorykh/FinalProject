using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using static FinalProject.Weather;

namespace FinalProjectClient
{
    public partial class Form1 : Form
    {
        List<DateTime> time;
        List<double> temp;
        List<int> humidity;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text != "")
            {
                time = new List<DateTime>();
                temp = new List<double>();
                humidity = new List<int>();

                string lat = textBox2.Text;
                string lon = textBox1.Text;
                string APIkey = "ef5ebfda74903c4b21316165b1c7b5de";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync($@"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lon}&exclude=current,minutely,daily,alerts&appid={APIkey}&units=metric&lang=ua%22");
                    string body = await responseMessage.Content.ReadAsStringAsync();

                    Root data = JsonConvert.DeserializeObject<Root>(body);

                    data.hourly.Select(d => new { Time = new DateTime(1970, 1, 1).AddSeconds(d.dt), Temp = d.temp, humidity = d.humidity });
                    foreach (var item in data.hourly)
                        humidity.Add(item.humidity);
                    foreach(var item in data.hourly)
                        temp.Add(item.temp);
                    foreach(var item in data.hourly)
                        time.Add(new DateTime(1970,1,1).AddSeconds(item.dt));

                    List<string> shortDateString = time.ConvertAll(p => p.ToLongDateString() + p.ToShortDateString());
                    cartesianChart1.Series = new LiveCharts.SeriesCollection
                    {
                        new LineSeries
                        {
                            Title = "Temperature",
                            Values = new ChartValues<double>(temp)
                        }
                    };
                    cartesianChart1.AxisX.Clear();
                    cartesianChart1.AxisX.Add(new Axis
                    {
                        Title = "Time",
                        Labels = shortDateString
                    });
                    cartesianChart1.AxisY.Clear();
                    cartesianChart1.AxisY.Add(new Axis
                    {
                        Title = "Temperature",
                        LabelFormatter = val => $"{val} C"
                    });


                    cartesianChart2.Series = new LiveCharts.SeriesCollection
                    {
                        new LineSeries
                        {
                            Title = "Humidity",
                            Values = new ChartValues<int>(humidity)
                        }
                    };
                    cartesianChart2.AxisX.Clear();
                    cartesianChart2.AxisX.Add(new Axis
                    {
                        Title = "Time",
                        Labels = shortDateString
                    });
                    cartesianChart2.AxisY.Clear();
                    cartesianChart2.AxisY.Add(new Axis
                    {
                        Title = "Humidity",
                        LabelFormatter = val => $"{val} %"
                    });

                }
            }
        }
    }
}
