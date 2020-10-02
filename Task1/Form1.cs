using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Task1
{
	public partial class Form1 : Form
	{

		enum Months
		{
			January = 1,
			February = 2,
			March = 3,
			April = 4,
			May = 5,
			June = 6,
			Jule = 7,
			August = 8,
			September = 9,
			Octeber = 10,
			November = 11,
			December = 12,
		}

		List<Operations> uc01, uc02, uc03, uc04, uc_all;
		UCstatus uCstatus;
		List<Operations> avg_uc01, avg_uc02, avg_uc03, avg_uc04;
		double uc1Prof = 0, uc2Prof = 0, uc3Prof = 0, uc4Prof= 0, totalProf = 0;
		public Form1()
		{
			InitializeComponent();
			uc01 = new List<Operations>();
			uc02 = new List<Operations>();
			uc03 = new List<Operations>();
			uc04 = new List<Operations>();
			uc_all = new List<Operations>();
			avg_uc01 = new List<Operations>();
			avg_uc02 = new List<Operations>();
			avg_uc03 = new List<Operations>();
			avg_uc04 = new List<Operations>();

			uCstatus = new UCstatus();

			yearBox.Items.Add(2019);
			yearBox.SelectedItem = 2019;
			monBox.DataSource = Enum.GetValues(typeof(Months));
			chart1.ChartAreas.FindByName("ChartArea1").AxisX.Interval = 1;
			chart1.ChartAreas.FindByName("ChartArea1").AxisY.Interval = 1000;
			monBox.SelectedItem = 1;
		}
		private void button2_Click(object sender, EventArgs e)
		{
			var month = (int)monBox.SelectedItem;
			var year = (int)yearBox.SelectedItem;

			var list = uc02.Where(t => t.DateTime.Date.Month.Equals(month) && t.DateTime.Year == year).ToList();

			DrawDataPerDay(list);
			uCstatus = UCstatus.UC_02;
			ucName.Text = uCstatus.ToString();
		}



		private void button3_Click(object sender, EventArgs e)
		{
			var month = (int)monBox.SelectedItem;
			var year = (int)yearBox.SelectedItem;

			var list = uc03.Where(t => t.DateTime.Date.Month.Equals(month) && t.DateTime.Year == year).ToList();

			DrawDataPerDay(list);
			uCstatus = UCstatus.UC_03;
			ucName.Text = uCstatus.ToString();

		}

		private void button4_Click(object sender, EventArgs e)
		{
			var month = (int)monBox.SelectedItem;
			var year = (int)yearBox.SelectedItem;

			var list = uc04.Where(t => t.DateTime.Date.Month.Equals(month) && t.DateTime.Year == year).ToList();

			DrawDataPerDay(list);
			uCstatus = UCstatus.UC_04;
			ucName.Text = uCstatus.ToString();

		}


		private void button1_Click(object sender, EventArgs e)
		{
			var month = (int)monBox.SelectedItem;
			var year = (int)yearBox.SelectedItem;

			var list = uc01.Where(t => t.DateTime.Date.Month.Equals(month) && t.DateTime.Year == year).ToList();

			DrawDataPerDay(list);
			uCstatus = UCstatus.UC_01;
			ucName.Text = uCstatus.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var month = (int)monBox.SelectedItem;
			var year = (int)yearBox.SelectedItem;

			var list = uc_all.Where(t => t.DateTime.Date.Month.Equals(month) && t.DateTime.Year == year).ToList();

			DrawDataPerDay(list);
			uCstatus = UCstatus.UC_All;
			ucName.Text = uCstatus.ToString();
		}

		private void button6_Click_1(object sender, EventArgs e)
		{
			switch (uCstatus)
			{
				case UCstatus.UC_01:
					DrawDataPerDay(CalcAVG_Day(uc01, (int)monBox.SelectedItem));
					break;
				case UCstatus.UC_02:
					DrawDataPerDay(CalcAVG_Day(uc02, (int)monBox.SelectedItem));
					break;
				case UCstatus.UC_03:
					DrawDataPerDay(CalcAVG_Day(uc03, (int)monBox.SelectedItem));
					break;
				case UCstatus.UC_04:
					DrawDataPerDay(CalcAVG_Day(uc04, (int)monBox.SelectedItem));
					break;
				case UCstatus.UC_All:
					DrawDataPerDay(CalcAVG_Day(uc_all, (int)monBox.SelectedItem));
					break;
				default:
					break;
			}

		}
		private List<Operations> CalcAVG_Day(List<Operations> operations, int month)
		{
			List<Operations> result = new List<Operations>();
			List<Operations> list = new List<Operations>();
			//var month = (int)monBox.SelectedItem;
			var year = (int)yearBox.SelectedItem;
			list = operations.Where(t => t.DateTime.Date.Month.Equals(month) && t.DateTime.Year == year).ToList();

			for (int i = 0; i < 24; i++)
			{
				var temp = list.Where(t => t.DateTime.Hour == i
								&& t.Count < getMax() && t.Count > getMin()).ToList();
				double sum = 0;
				temp.ForEach(t => sum += t.Count);
				//result.Add(new Operations(list[i].DateTime, sum / temp.Count()));
				list[i].Count = sum / temp.Count;
				result.Add(list[i]);
			}

			return result;
		}

		private List<Operations> CalcAVG_Mon(List<Operations> days)
		{
			List<Operations> result = new List<Operations>();
			List<Operations> list = new List<Operations>();
			var year = (int)yearBox.SelectedItem;
			list = days.Where(t => t.DateTime.Year == year).ToList();

			for (int i = 0; i < 24; i++)
			{
				var temp = list.Where(t => t.DateTime.Hour == i).ToList();
				double sum = 0;
				temp.ForEach(t => sum += t.Count);
				//result.Add(new Operations(list[i].DateTime, sum / temp.Count()));
				list[i].Count = sum / temp.Count;
				result.Add(list[i]);
			}

			return result;
		}

		private void DrawDataPerDay(List<Operations> list)
		{
			chart1.Series.Clear();

			for (int i = 0; i < list.Count(); i += 24)
			{
				var temp = chart1.Series.Add(i / 24 + 1 + " Day");
				temp.ChartType = SeriesChartType.Spline;
				temp.YValuesPerPoint = 32;
				temp.BackGradientStyle = GradientStyle.DiagonalLeft;
				if (i == 0)
					temp.Color = Color.BlueViolet;
				
				var day = list.GetRange(i, 24);
				double[] points = new double[day.Count];

				for (int j = 0; j < day.Count; j++)
				{
					points[j] = day[j].Count;
				}

				if (!(points.Max() < getMax() && points.Min() > getMin())) 
				{
					if (!checkBox1.Checked)
					{
						temp.Color = Color.Red;
						temp.Points.DataBindY(points);
					}
				}
				else
					temp.Points.DataBindY(points);
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			var days = new List<Operations>();
			for (int i = 0; i < 12; i++)
			{
				switch (uCstatus)
				{
					case UCstatus.UC_01:
						days.AddRange(CalcAVG_Day(uc01, i + 1));
						if (i == 11)
							avg_uc01 = CalcAVG_Mon(days);
							break;
					case UCstatus.UC_02:
						days.AddRange(CalcAVG_Day(uc02, i + 1));
						if (i == 11)
							avg_uc02 = CalcAVG_Mon(days);
						break;
					case UCstatus.UC_03:
						days.AddRange(CalcAVG_Day(uc03, i + 1));
						if (i == 11)
							avg_uc03 = CalcAVG_Mon(days);
						break;
					case UCstatus.UC_04:
						days.AddRange(CalcAVG_Day(uc04, i + 1));
						if (i == 11)
							avg_uc04 = CalcAVG_Mon(days);
						break;
					case UCstatus.UC_All:
						days.AddRange(CalcAVG_Day(uc_all, i + 1));
						break;
					default:
						break;
				}
			}
			DrawDataPerDay(CalcAVG_Mon(days));
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			chart1.ChartAreas.FindByName("ChartArea1").AxisY.Interval = (double)numericUpDown1.Value;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			chart1.Series.Clear();
		//	var days = new List<Operations>();
		//	for (int i = 0; i < 12; i++)
		//	{
		//		days.AddRange(CalcAVG_Day(uc_all, i + 1));
		//	}
		//
		//	days = new List<Operations>();
		//	for (int i = 0; i < 12; i++)
		//	{
		//		days.AddRange(CalcAVG_Day(uc01, i + 1));
		//	}
		//	avg_uc01 = CalcAVG_Mon(days);			
			DrawOp(avg_uc01, 1);

			//days = new List<Operations>();
			//for (int i = 0; i < 12; i++)
			//{
			//	days.AddRange(CalcAVG_Day(uc02, i + 1));
			//}
			//avg_uc02 = CalcAVG_Mon(days);
			DrawOp(avg_uc02, 2);

			//days = new List<Operations>();
			//for (int i = 0; i < 12; i++)
			//{
			//	days.AddRange(CalcAVG_Day(uc03, i + 1));
			//}
			//avg_uc03 = CalcAVG_Mon(days);
			DrawOp(avg_uc03, 3);

			//days = new List<Operations>();
			//for (int i = 0; i < 12; i++)
			//{
			//	days.AddRange(CalcAVG_Day(uc04, i + 1));
			//}
			//avg_uc04 = CalcAVG_Mon(days);
			DrawOp(avg_uc04, 4);

		}
		private void DrawOp(List<Operations> day, int num)
		{
			var temp = chart1.Series.Add(num + " Operation");
			temp.ChartType = SeriesChartType.Spline;
			temp.YValuesPerPoint = 32;

			var points = new double[day.Count];
			for (int j = 0; j < day.Count; j++)
			{
				//if (j >= numericUpDownFrom.Value && j <= numericUpDownTo.Value)
				points[j] = day[j].Count;
			}
			temp.Points.DataBindY(points);
			for (int i = 0; i < temp.Points.Count; i++)
			{
				if (i < (double)numericUpDownFrom.Value || i > (double)numericUpDownTo.Value)
					temp.Points[i].Color = Color.Transparent;
			}

		}

		private void button10_Click(object sender, EventArgs e)
		{
			AVGDaytoCSV();
		}

		//private void DrawOp(List<Operations> day, int num)
		//{
		//	var temp = chart1.Series.Add(num + " Operation");
		//	temp.ChartType = SeriesChartType.Spline;
		//	temp.YValuesPerPoint = 32;
		//	List<Operations> op = getOp(day, num);

		//	var points = new double[op.Count];
		//	for (int j = 0; j < op.Count; j++)
		//	{
		//		//if (j >= numericUpDownFrom.Value && j <= numericUpDownTo.Value)
		//		points[j] = op[j].Count;
		//	}
		//	temp.Points.DataBindY(points);
		//	var tt = temp.Points.Where(t => t.XValue >= (double)numericUpDownFrom.Value && t.XValue <= (double)numericUpDownTo.Value).Sum(t=>t.YValues[0]);
		//	for (int i = 0; i < temp.Points.Count; i++)
		//	{
		//		if (i < (double)numericUpDownFrom.Value || i > (double)numericUpDownTo.Value)
		//			temp.Points[i].Color = Color.Transparent;
		//	}

		//}
		private List<Operations> getOp(List<Operations> ops, int num)
		{
			var reuslt = new List<Operations>();
			for (int i = 0; i < 24; i++)
			{
					switch (num)
					{
						case 1:
							reuslt.Add(ops[i].Op1);
							break;
						case 2:
							reuslt.Add(ops[i].Op2);
							break;
						case 3:
							reuslt.Add(ops[i].Op3);
							break;
						case 4:
							reuslt.Add(ops[i].Op4);
							break;
						default:
							break;
					}
			}
		
			return reuslt;
		}
		private void button9_Click(object sender, EventArgs e)
		{
			var temp = avg_uc01.Where(t => t.DateTime.Hour > numericUpDownFrom.Value
									&& t.DateTime.Hour < numericUpDownTo.Value);
			double sum = 0;
			double totalSum = 0;
			foreach (var item in temp)
			{
				sum += item.Count;
			}
			var sum1 = sum;
			var int1 = sum1 / temp.Count();
			totalSum += sum;
			temp = avg_uc02.Where(t => t.DateTime.Hour > numericUpDownFrom.Value
						&& t.DateTime.Hour < numericUpDownTo.Value);
			sum = 0;
			foreach (var item in temp)
			{
				sum += item.Count;
			}
			var sum2 = sum;
			var int2 = sum1 / temp.Count();
			totalSum += sum;

			temp = avg_uc03.Where(t => t.DateTime.Hour > numericUpDownFrom.Value
			&& t.DateTime.Hour < numericUpDownTo.Value);
			sum = 0;

			foreach (var item in temp)
			{
				sum += item.Count;
			}
			var sum3 = sum;
			var int3 = sum3 / temp.Count();
			totalSum += sum;

			temp = avg_uc04.Where(t => t.DateTime.Hour > numericUpDownFrom.Value
			&& t.DateTime.Hour < numericUpDownTo.Value);
			sum = 0;

			foreach (var item in temp)
			{
				sum += item.Count;
			}
			var sum4 = sum;
			var int4 = sum4 / temp.Count();
			totalSum += sum;


			uc1Prof = int1 = avg_uc01.Where(t => t.DateTime.Hour > numericUpDownFrom.Value
									&& t.DateTime.Hour < numericUpDownTo.Value).Max().Count;
			uc2Prof = int2 = avg_uc02.Where(t => t.DateTime.Hour > numericUpDownFrom.Value
									&& t.DateTime.Hour < numericUpDownTo.Value).Max().Count;
			uc3Prof = int3 = avg_uc03.Where(t => t.DateTime.Hour > numericUpDownFrom.Value
									&& t.DateTime.Hour < numericUpDownTo.Value).Max().Count;
			uc4Prof = int4 = avg_uc04.Where(t => t.DateTime.Hour > numericUpDownFrom.Value
									&& t.DateTime.Hour < numericUpDownTo.Value).Max().Count;

			totalProf = uc1Prof + uc2Prof + uc3Prof + uc4Prof;

			avg01.Text = ((int)int1).ToString();
			avg02.Text = ((int)int2).ToString();
			avg03.Text = ((int)int3).ToString();
			avg04.Text = ((int)int4).ToString();

			//per01.Text = (Math.Round((sum1 / totalSum * 100), 2)).ToString();
			//per02.Text = (Math.Round((sum2 / totalSum * 100), 2)).ToString();
			//per03.Text = (Math.Round((sum3 / totalSum * 100), 2)).ToString();
			//per04.Text = (Math.Round((sum4 / totalSum * 100), 2)).ToString();
			per01.Text = (Math.Round((int1 / (int1+int2+int3+int4) * 100), 2)).ToString();
			per02.Text = (Math.Round((int2 / (int1+int2+int3+int4) * 100), 2)).ToString();
			per03.Text = (Math.Round((int3 / (int1+int2+int3+int4) * 100), 2)).ToString();
			per04.Text = (Math.Round((int4 / (int1+int2+int3+int4) * 100), 2)).ToString();

			double prof = 0;
			prof += double.Parse(per01.Text);
			profProc01.Text = prof.ToString();
			prof += double.Parse(per02.Text);
			profProc02.Text = prof.ToString();
			prof += double.Parse(per03.Text);
			profProc03.Text = prof.ToString();
			prof += double.Parse(per04.Text);
			profProc04.Text = prof.ToString();


			groupBox1.Visible = true;

		}

		private void AVGDaytoCSV()
		{
			//before your loop
			var csv = new StringBuilder();
			var header = "Hour;";
			for (int i = 0; i < 24; i++)
			{
				if (i >= numericUpDownFrom.Value && i <= numericUpDownTo.Value)
					header += i+";";
			}
			csv.Append(header+"\n");
			//in your loop
			
			for (int i = 1; i <= 6; i++)
			{
				var temp = "";
				
				for (int j = 0; j < 24; j++)
				{
					if (j == 0&&i<5)
						temp += String.Format("UC_0{0} Int;",i);
					else if(j==0&& i == 5)
						temp += "Total;";
					else if (j == 0 && i == 6)
						temp += "Profile Compare;";
					if (j >= numericUpDownFrom.Value && j <= numericUpDownTo.Value)
					{
						switch (i)
						{
							case 1:
								temp += avg_uc01[j].Count + ";";
								break;
							case 2:
								temp += avg_uc02[j].Count + ";";
								break;
							case 3:
								temp += avg_uc03[j].Count + ";";
								break;
							case 4:
								temp += avg_uc04[j].Count + ";";
								break;
							case 5:
								temp += avg_uc01[j].Count + avg_uc02[j].Count + avg_uc03[j].Count
									+ avg_uc04[j].Count + ";";
								break;
							case 6:
								temp += Math.Round((avg_uc01[j].Count + avg_uc02[j].Count + avg_uc03[j].Count
									+ avg_uc04[j].Count) / totalProf * 100, 2) + "%;";
								break;
							default:
								break;
						}
					}
				}
				csv.Append(temp+"\n");
			}

			//after your loop
			File.WriteAllText(Directory.GetCurrentDirectory()+"prof.csv", csv.ToString());
		}

		private void DrawDataPerMon(List<Operations> list)
		{
			chart1.Series.Clear();

			for (int i = 0; i < list.Count(); i += 24)
			{
				var temp = chart1.Series.Add(i / 24 + 1 + " Day");
				temp.ChartType = SeriesChartType.Spline;
				temp.YValuesPerPoint = 32;
				temp.BackGradientStyle = GradientStyle.DiagonalLeft;
				if (i == 0)
					temp.Color = Color.Red;

				var day = list.GetRange(i, 24);
				double[] points = new double[day.Count];

				for (int j = 0; j < day.Count; j++)
				{
					points[j] = day[j].Count;
				}
				if (points.Max() < getMax() && points.Min() > getMin())
					temp.Points.DataBindY(points);
			}
		}



		private void Form1_Load(object sender, EventArgs e)
		{
			using (TextFieldParser parser = new TextFieldParser("usage_data.csv"))
			{
				parser.TextFieldType = FieldType.Delimited;
				parser.SetDelimiters(";");
				parser.ReadFields();
				Operations op1, op2, op3, op4;
				groupBox1.Visible = false;
				while (!parser.EndOfData)
				{					
					string[] fields = parser.ReadFields();
					DateTime time = DateTime.Parse(fields[0]);
					op1 = new Operations(time, Double.Parse(fields[1]), UCstatus.UC_01);
					op2 = new Operations(time, Double.Parse(fields[2]), UCstatus.UC_02);
					op3 = new Operations(time, Double.Parse(fields[3]), UCstatus.UC_03);
					op4 = new Operations(time, Double.Parse(fields[4]), UCstatus.UC_04);
					uc01.Add(op1);
					uc02.Add(op2);
					uc03.Add(op3);
					uc04.Add(op4);

					uc_all.Add(new Operations(time, op1,op2,op3,op4,UCstatus.UC_All));
				}
			}
		}

		private double getMax()
		{
			return Double.Parse(delUpper.Text);
		}
		private double getMin()
		{
			return Double.Parse(delBelow.Text);
		}
	}
}
